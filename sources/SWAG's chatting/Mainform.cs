using System;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace SWAG_s_chatting
{
    public partial class Mainform : MetroFramework.Forms.MetroForm
    {
        string[] url = System.IO.File.ReadAllLines("URL.txt");
        string id;
        WebClient client = new WebClient();
        public Mainform()
        {
            InitializeComponent();
        }
        private void Mainform_Load(object sender, EventArgs e)
        {
            string download = client.DownloadString(url[0]);
            JObject ids = JObject.Parse(download);
            foreach(var id in ids)
            {
                Users.Items.Add(id.Key);
            }
            this.id = LoginForm.id;
        }

        private void Mainform_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Go_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(InsertURL.Text);
        }

        private void Next_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            string download = client.DownloadString(url[0]);
            JObject ids = JObject.Parse(download);
            ids.Remove(id);
            client.Headers.Add("Content-Type", "Application/json");
            client.UploadString(url[0], "PUT", ids.ToString());
            MessageBox.Show("Your ID was removed","Complete");
            Application.Exit();
        }
    }
}
