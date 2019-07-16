using System;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace SWAG_s_chatting
{
    public partial class LoginForm : Form
    {
        string url = System.IO.File.ReadAllText("URL.txt");
        public static string id;
        public LoginForm()
        {
            InitializeComponent();
        }
        private void Login_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(InsertID.Text) || String.IsNullOrEmpty(InsertPW.Text)))
            {
                task();
            }
        }
        private string gotohash(string password)
        {
            byte[] bytearray = Encoding.UTF8.GetBytes(password);
            var enc = new SHA256CryptoServiceProvider();
            var hash = enc.ComputeHash(bytearray);
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                strBuilder.Append(hash[i].ToString("x2"));
            }
            return strBuilder.ToString();
        }
        private void task()
        {
            string ID = InsertID.Text;
            string PW = gotohash(InsertPW.Text);
            WebClient client = new WebClient();
            string download = client.DownloadString(url);
            JObject ids = JObject.Parse(download);
            try
            {
                if (ids[ID][0].ToString() != PW)
                {
                    MessageBox.Show("Please try again", "Error");
                }
                else
                {
                    LoginForm.id = InsertID.Text;
                    Hide();
                }
                Mainform mainform = new Mainform();
                mainform.Show();
            }
            catch
            {
                MessageBox.Show("You don't have your ID.", "Please sign up");
            }
        }

        private void InsertPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!(String.IsNullOrEmpty(InsertID.Text) || String.IsNullOrEmpty(InsertPW.Text)))
                {
                    task();
                }
            }
        }

        private void InsertID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!(String.IsNullOrEmpty(InsertID.Text) || String.IsNullOrEmpty(InsertPW.Text)))
                {
                    task();
                }
            }
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(InsertID.Text) || String.IsNullOrEmpty(InsertPW.Text)))
            {
                WebClient client = new WebClient();
                string download = client.DownloadString(url);
                JObject ids = JObject.Parse(download);
                try
                {
                    string test = ids[InsertID.Text][0].ToString();
                    MessageBox.Show("This ID is overlap","Overlap");
                }
                catch
                {
                    string password = gotohash(InsertPW.Text);
                    JArray jArray = new JArray();
                    jArray.Add(password);
                    jArray.Add(false);
                    ids.Add(InsertID.Text, jArray);
                    string upload = ids.ToString();
                    client.Headers.Add("Content-Type", "application/json");
                    client.UploadString(url,"Put",upload);
                    MessageBox.Show("Your ID is made", "Complete");
                    task();
                }
            }
            else
            {
                MessageBox.Show("Please Insert your ID or Password","Null");
            }
        }
    }
}
