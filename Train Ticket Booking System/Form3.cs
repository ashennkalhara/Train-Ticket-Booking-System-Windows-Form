using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net;

namespace Train_Ticket_Booking_System
{
    public partial class Form3 : Form
    {
        private readonly HttpClient _httpClient;

        public Form3()
        {
            InitializeComponent();
            dgvTrainData.CellClick += dgvTrainData_CellClick;
            _httpClient = new HttpClient(); // Initialize _httpClient
        }

        private async void dgvTrainData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvTrainData.Rows[e.RowIndex];
                DialogResult result = MessageBox.Show("Confirm booking?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string nicNumber = Prompt.ShowDialog("Enter NIC number:", "NIC Number");
                    int seatCapacity = 0;
                    if (!int.TryParse(Prompt.ShowDialog("Enter seat capacity:", "Seat Capacity"), out seatCapacity))
                    {
                        MessageBox.Show("Invalid seat capacity. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (seatCapacity > 5)
                    {
                        MessageBox.Show("You can book 5 seats only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    TrainApi selectedTrain = (TrainApi)selectedRow.DataBoundItem;
                    selectedTrain.Capacity -= seatCapacity;
                    dgvTrainData.Refresh();

                    // Save booking data
                    BookingCreateDTO bookingCreateDTO = new BookingCreateDTO
                    {
                        TrainId = selectedTrain.TrainId,
                        NIC = nicNumber,
                        SeatCapacity = seatCapacity,
                        StartStation = selectedTrain.StartStation,
                        DestinationStation = selectedTrain.DestinationStation,
                        DepartureTime = selectedTrain.DepartureTime,
                        ArrivalTime = selectedTrain.ArrivalTime,
                        Date = selectedTrain.Date
                    };

                    await SaveBookingAsync(bookingCreateDTO);
                }
            }
        }
        private async Task SaveBookingAsync(BookingCreateDTO bookingCreateDTO)
        {
            var json = JsonConvert.SerializeObject(bookingCreateDTO);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _httpClient.PostAsync("https://localhost:7125/api/Booking", content);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Booking Confirmed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to confirm booking.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static class Prompt
        {
            public static string ShowDialog(string text, string caption)
            {
                Form prompt = new Form()
                {
                    Width = 300,
                    Height = 200,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    Text = caption,
                    StartPosition = FormStartPosition.CenterScreen
                };
                Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
                TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 200 };
                Button confirmation = new Button() { Text = "Ok", Left = 150, Width = 100, Top = 70, DialogResult = DialogResult.OK };
                confirmation.Click += (sender, e) => { prompt.Close(); };
                prompt.Controls.Add(textBox);
                prompt.Controls.Add(confirmation);
                prompt.Controls.Add(textLabel);
                prompt.AcceptButton = confirmation;

                return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
            }
        }

        public async Task LoadUser()
        {
            string url = "https://localhost:7125/api/Train";
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                using (var response = await client.GetAsync(url))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        dgvTrainData.DataSource = null;
                        dgvTrainData.DataSource = JsonConvert.DeserializeObject<List<TrainApi>>(json);
                        dgvTrainData.Columns["TrainId"].Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Failed to retrieve train data. Status code: " + response.StatusCode);
                    }
                }
            }
        }

        private void btnGetAllTrains_Click(object sender, EventArgs e)
        {
            LoadUser();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string selectedDate = dtpDate.Value.ToString("yyyy.MM.dd");
            string startStation = txtStart.Text;
            string endStation = txtEnd.Text;

            List<TrainApi> trains = await FindTrainsAsync(selectedDate, startStation, endStation);
            if (trains != null)
            {
                dgvTrainData.DataSource = trains;
            }
        }

        public async Task<List<TrainApi>> FindTrainsAsync(string date, string startStation, string destinationStation)
        {
            try
            {
                Console.WriteLine("Entering FindTrainsAsync method");

                var searchDTO = new SearchDTO
                {
                    Date = date,
                    StartStation = startStation,
                    DestinationStation = destinationStation
                };
                Console.WriteLine("Search Criteria:");
                Console.WriteLine($"Date: {date}");
                Console.WriteLine($"Start Station: {startStation}");
                Console.WriteLine($"Destination Station: {destinationStation}");


                Console.WriteLine("Search DTO created");

                string json = JsonConvert.SerializeObject(searchDTO);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Post,
                    RequestUri = new Uri("https://localhost:7125/api/Train/Search"),
                    Content = content
                };

                Console.WriteLine("Sending HTTP request");

                using (var response = await _httpClient.SendAsync(request))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string trainJson = await response.Content.ReadAsStringAsync();
                        Console.WriteLine("Train data received successfully");
                        var trains = JsonConvert.DeserializeObject<List<TrainApi>>(trainJson);
                        Console.WriteLine($"Received {trains.Count} train(s)");
                        return trains;
                    }
                    else if (response.StatusCode == HttpStatusCode.NotFound)
                    {
                        Console.WriteLine("No Matching Train.");
                        return null;
                    }
                    else
                    {
                        Console.WriteLine($"Failed to retrieve train data. Status code: {response.StatusCode}");
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in FindTrainsAsync: {ex.Message}");
                throw; // Rethrow the exception to propagate it further if necessary
            }
        }

    }

    public class TrainApi
    {
        public int TrainId { get; set; }
        public string Name { get; set; }
        public string StartStation { get; set; }
        public string DestinationStation { get; set; }
        public int Capacity { get; set; }
        public string DepartureTime { get; set; }
        public string ArrivalTime { get; set; }
        public string Date { get; set; }
    }

    public class SearchDTO
    {
        public string Date { get; set; }
        public string StartStation { get; set; }
        public string DestinationStation { get; set; }
    }

    public class BookingCreateDTO
    {
        public int TrainId { get; set; }
        public string NIC { get; set; }
        public string StartStation { get; set; }
        public string DestinationStation { get; set; }
        public int SeatCapacity { get; set; }
        public string DepartureTime { get; set; }
        public string ArrivalTime { get; set; }
        public string Date { get; set; }
    }
}
