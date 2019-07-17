using System;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using CefSharp;
using CefSharp.WinForms;

namespace SWAG_s_chatting
{
    public partial class Mainform : MetroFramework.Forms.MetroForm
    {
        public static string id;
        string[] url = System.IO.File.ReadAllLines("URL.txt");
        WebClient client = new WebClient();
        public Mainform()
        {
            InitializeComponent();
            startchromium();
        }
        private void startchromium()
        {
            Cef.Initialize(new CefSettings());
            Browser = new ChromiumWebBrowser("www.google.com");
            this.panel1.Controls.Add(Browser);
            Browser.Dock = DockStyle.Fill;
            Browser.AddressChanged += Browser_ChangeURL;
        }
        private void Mainform_Load(object sender, EventArgs e)
        {
            string download = client.DownloadString(url[0]);
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
            Browser.Load($"www.google.com/search?q={InsertURL.Text}");
        }

        private void Next_Click(object sender, EventArgs e)
        {
            
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Browser.Back();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            Browser.Refresh();
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            string download = client.DownloadString(url[0]);
            JObject ids = JObject.Parse(download);
            ids.Remove(id);
            client.Headers.Add("Content-Type", "Application/json");
            client.UploadString(url[0], "PUT", ids.ToString());
            MessageBox.Show("Your ID is removed","Complete");
            Application.Exit();
        }

        private void Users_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = Users.SelectedItem.ToString();
            Chats.Text = name;
        }

        private void Browser_ChangeURL(object sender, AddressChangedEventArgs e)
        {
            InsertURL.Text = e.Address;
        }
    }
}
