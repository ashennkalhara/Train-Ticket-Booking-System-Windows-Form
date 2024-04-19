using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;


namespace Train_Ticket_Booking_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegisterHere_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Username and password are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string url = "https://localhost:7125/api/User/Login";
            var loginInfo = new LoginInfo
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text
            };

            using (var client = new HttpClient())
            {
                var content = new StringContent(loginInfo.ToString(), Encoding.UTF8, "application/json");

                var response = client.PostAsync(url, content).Result;

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("User Login successful.");
                    this.Hide();
                    Form3 homepage = new Form3();
                    homepage.ShowDialog();

                }
                else if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Failed to log in. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
    public class LoginInfo
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return $"{{\"userName\":\"{Username}\",\"password\":\"{Password}\"}}";
        }
    }
}
