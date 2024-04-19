using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Web.Script.Serialization;


namespace Train_Ticket_Booking_System
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string url = "https://localhost:7125/api/User";
            HttpClient client = new HttpClient();
            Users users = new Users();

            users.UserName = txtEnterUsername.Text;
            users.Password = txtEnterPassword.Text;
            users.NIC = txtEnterNIC.Text;

            string data = (new JavaScriptSerializer()).Serialize(users);
            var content = new StringContent(data, UnicodeEncoding.UTF8, "application/json");

            var res = client.PostAsync(url, content).Result;
            if (res.IsSuccessStatusCode)
            {
                MessageBox.Show("User Registered Successfully");
                this.Hide();
                Form3 homepage = new Form3();
                homepage.ShowDialog();
            }
            else
            {
                MessageBox.Show("Fail to Register");
            }
        }



        public class Users
        {
            public string UserName { get; set; }
            public string Password { get; set; }
            public string NIC { get; set; }

        }

    }
}
