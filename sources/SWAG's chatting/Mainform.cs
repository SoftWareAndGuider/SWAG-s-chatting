using System;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace SWAG_s_chatting
{
    public partial class Mainform : MetroFramework.Forms.MetroForm
    {
        string url = System.IO.File.ReadAllText("URL.txt");
        WebClient client = new WebClient();
        public Mainform()
        {
            InitializeComponent();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            string download = client.DownloadString(url);
            JObject ids = JObject.Parse(download);
            foreach(var id in ids)
            {
                Users.Items.Add(id.Key);
            }
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
    }
}
