﻿using System;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using CefSharp;
using CefSharp.WinForms;
using CefSharp.Example.Handlers;
using System.IO;

namespace SWAG_s_chatting
{
    public partial class Mainform : MetroFramework.Forms.MetroForm
    {
        public static string id;
        string nickname;
        private string url = File.ReadAllText("URL.txt");
        private static WebClient client = new WebClient();
        private static JObject ids = new JObject();
        private static string checkstring;
        private static JObject checkchatting = new JObject();
        private static JObject chattings = new JObject();
        LoginForm Login = new LoginForm();
        Makeform Make = new Makeform();
        private string download;
        bool stop = false;

        public Mainform()
        {
            InitializeComponent();
            startchromium();
            loading();
            Thread thread = new Thread(new ThreadStart(loop));
            thread.Start();
        }
        private void startchromium()
        {
            Cef.Initialize(new CefSettings());
            Browser = new ChromiumWebBrowser("www.google.com");
            this.panel1.Controls.Add(Browser);
            Browser.Dock = DockStyle.Fill;
            Browser.AddressChanged += Browser_ChangeURL;
            Browser.LoadError += Searching;
            Browser.DownloadHandler = new DownloadHandler();
        }

        private void Mainform_FormClosing(object sender, FormClosingEventArgs e)
        {
            stop = true;
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
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            JObject Users = JObject.FromObject(ids["Users"]);
            Users.Remove(id);
            ids["Users"] = Users;
            client.Headers.Add("Content-Type", "Application/json");
            client.UploadString(url, "PUT", ids.ToString());
            MessageBox.Show("당신의 ID가 삭제되었습니다","완료");
            Application.Exit();
        }

        private void Browser_ChangeURL(object sender, AddressChangedEventArgs e)
        {
            InsertURL.Text = e.Address;
        }

        private void loop()
        {
            WebClient client = new WebClient();
            for(;!stop;)
            {
                Thread.Sleep(100);
                client.Encoding = Encoding.UTF8;
                download = client.DownloadString(url);
                //이전 값과 현재 값이 다를 때만 실행
                if (download != checkstring)
                {
                    checkstring = download;
                    try
                    {
                        ids = JObject.Parse(download);
                        int i = 0;
                        foreach (var id in ids["Users"][id]["chatting"])
                        {
                            if (!Users.Items.Contains(id))
                            {
                                Users.Items.Add(id);
                            }
                            try
                            {
                                chattings.Add(id.ToString(), ids["Chattings"][id.ToString()][0]);
                            }
                            catch
                            {
                                chattings[id.ToString()] = ids["Chattings"][id.ToString()][0];
                            }
                            i++;
                        }
                        if (i == 0)
                        {
                            Users.Items.Clear();
                            chattings = new JObject();
                        }
                        if (chattings != checkchatting)
                        {
                            notifyIcon1.BalloonTipTitle = id;
                            if (!(NoInter.Checked || FormSelected.Checked))
                            {
                                notifyIcon1.ShowBalloonTip(500);
                            }
                            try
                            {
                                ChattingBox.Text = chattings[Users.SelectedItem.ToString()].ToString();
                            }
                            catch { }
                            //아래처럼 구문을 짠 이유는 checkchatting = chattings;를 했을 때 checkchatting값을 만지지 않는 구문에서도 chattings와 같아지기 때문임 (난 오른쪽 접시에 과자를 뒀는데 왼쪽 접시에도 과자가 놓인 기분)
                            string a = chattings.ToString();
                            checkchatting = JObject.Parse(a);
                        }
                    }
                    catch
                    {
                        Users.Items.Clear();
                    }
                }
            }
        }

        private void Send_Click(object sender, EventArgs e)
        {
            SendMessage();
        }
        private void SendMessage()
        {
            if (!string.IsNullOrEmpty(InsertChat.Text))
            {
                try
                {
                    string text = InsertChat.Text;
                    InsertChat.Clear();
                    chattings[Users.SelectedItem.ToString()] = $"{ChattingBox.Text}{nickname} {DateTime.Now.Year}년 {DateTime.Now.Month}월 {DateTime.Now.Day}일 {DateTime.Now.Hour}:{DateTime.Now.Minute}\r\n{text}\r\n\r\n";
                    ChattingBox.Text = chattings[Users.SelectedItem.ToString()].ToString();
                    ids["Chattings"][Users.SelectedItem.ToString()][0] = chattings[Users.SelectedItem.ToString()].ToString();
                    client.Encoding = Encoding.UTF8;
                    client.Headers.Add("Content-Type", "application/json");
                    client.UploadString(url, "PUT", ids.ToString());
                }
                catch(DivideByZeroException)
                {
                    MessageBox.Show("메세지를 보낼 사람을 선택해 주세요");
                }
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

        private void ChattingBox_TextChanged(object sender, EventArgs e)
        {
            //자동 스크롤
            ChattingBox.SelectionStart = ChattingBox.TextLength;
            ChattingBox.ScrollToCaret();
            //최적화 (채팅방 하나당 최대 350줄)
            string[] length = ChattingBox.Text.Split('\n');
            int a = length.Length;
            if (a > 350)
            {
                string print = "";
                for (int b = a - 341; b < a - 1; b++)
                {
                    print += length[b] + "\r\n";
                }
                ChattingBox.Text = print;
            }
        }
        private void loading()
        {
            client.Encoding = Encoding.UTF8;
            Text = id;
            try
            {
                client.Encoding = Encoding.UTF8;
                download = client.DownloadString(url);
                ids = JObject.Parse(download);
                foreach (var id in ids["Users"][id]["chatting"])
                {
                    if (!Users.Items.Contains(id))
                    {
                        Users.Items.Add(id);
                    }
                    chattings.Add(id.ToString(), ids["Chattings"][id.ToString()][0].ToString());
                    string a = chattings.ToString();
                    checkchatting = JObject.Parse(a);
                }
                nickname = ids["Users"][id]["Login"][1].ToString();
            }
            catch
            {
            }
        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void Mainform_Leave(object sender, EventArgs e)
        {
            FormSelected.Checked = false;
        }

        private void Mainform_Activated(object sender, EventArgs e)
        {
            FormSelected.Checked = true;
        }

        private void Users_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                ChattingBox.Text = chattings[Users.SelectedItem.ToString()].ToString();
            }
            catch { }
        }

        private void OpenRemoveForm_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm();
            deleteForm.Show();
        }

        private void MetroButton1_Click_2(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm();
            editForm.Show();
        }
    }
}
