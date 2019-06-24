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
        string url = "https://api.myjson.com/bins/sbmn9";
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
            var enc = new SHA1CryptoServiceProvider();
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
                    Mainform mainform = new Mainform();
                    mainform.Show();
                    Hide();
                }
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
    }
}
