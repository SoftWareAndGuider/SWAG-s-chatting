using System;
using System.Net;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using CefSharp;
using CefSharp.WinForms;

namespace SWAG_s_chatting
{
    public partial class Mainform : MetroFramework.Forms.MetroForm
    {
        public static string id;
        private string url = System.IO.File.ReadAllText("URL.txt");
        private static WebClient client = new WebClient();
        private static JObject ids = new JObject();
        private static JObject chats = new JObject();
        private static Hashtable chattings = new Hashtable();
        LoginForm Login = new LoginForm();
        Makeform Make = new Makeform();

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
            Browser.LoadError += Searching;
        }

        private void Mainform_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Go_Click(object sender, EventArgs e)
        {
            Browser.Load(InsertURL.Text);
        }

        private void Searching(object sender, LoadErrorEventArgs e)
        {
            Browser.Load($"www.google.com/search?q={InsertURL.Text}");
        }

        private void Next_Click(object sender, EventArgs e)
        {
            Browser.Forward();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Browser.Back();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            Browser.Load(InsertURL.Text);
            Browser.Back();
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            ids.Remove(id);
            client.Headers.Add("Content-Type", "Application/json");
            client.UploadString(url, "PUT", ids.ToString());
            MessageBox.Show("당신의 ID가 삭제되었습니다","완료");
            Application.Exit();
        }

        private void Users_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = Users.SelectedItem.ToString();
            Chats.Text = chattings[Users.SelectedItem.ToString()].ToString();
        }

        private void Browser_ChangeURL(object sender, AddressChangedEventArgs e)
        {
            InsertURL.Text = e.Address;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                client.Encoding = Encoding.UTF8;
                string download = client.DownloadString(url);
                ids = JObject.Parse(download);
                chats = JObject.Parse(ids["Chattings"].ToString());
                foreach (var id in ids["Users"][id]["chatting"])
                {
                    if (!Users.Items.Contains(id))
                    {
                        Users.Items.Add(id);
                    }
                }
                foreach (var item in Users.Items)
                {
                    try
                    {
                        chattings.Add(item.ToString(), chats[item.ToString()][0].ToString());
                    }
                    catch
                    {
                        chattings[item.ToString()] = chats[item.ToString()][0].ToString();
                    }
                }
                try
                {
                    string name = Users.SelectedItem.ToString();
                    Chats.Text = chattings[Users.SelectedItem.ToString()].ToString();
                }
                catch { }
            }
            catch
            {
                Users.Items.Clear();
            }
        }

        private void Send_Click(object sender, EventArgs e)
        {
            SendMessage();
        }
        private void SendMessage()
        {
            try
            {
                string send = $"{Chats.Text}{id} {DateTime.Now.Year}년 {DateTime.Now.Month}월 {DateTime.Now.Day}일 {DateTime.Now.Hour}:{DateTime.Now.Minute}\r\n{InsertChat.Text}\r\n\r\n";
                chats[Users.SelectedItem.ToString()][0] = send;
                ids["Chattings"] = chats;
                client.Encoding = Encoding.UTF8;
                client.Headers.Add("Content-Type", "application/json");
                client.UploadString(url, "PUT", ids.ToString());
                InsertChat.Text = "";
            }
            catch
            {
                MessageBox.Show("메세지를 보낼 사람을 선택해 주세요");
            }
        }

        private void MetroButton1_Click_1(object sender, EventArgs e)
        {
            Makeform makeform = new Makeform();
            makeform.Show();
        }

        private void InsertChat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendMessage();
            }
        }

        private void InsertURL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Browser.Load(InsertURL.Text);
            }
        }
    }
}
