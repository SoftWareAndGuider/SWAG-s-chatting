using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace SWAG_s_chatting
{
    public partial class Makeform : MetroFramework.Forms.MetroForm
    {
        LoginForm LoginForm = new LoginForm();
        private string url = File.ReadAllText("URL.txt");
        WebClient client = new WebClient();
        private string download;
        private JObject jObject = new JObject();
        private JObject rooms = new JObject();
        public static string id;

        public Makeform()
        {
            InitializeComponent();
        }

        private void Make_CheckedChanged(object sender, EventArgs e)
        {
            if (Make.Checked)
            {
                MakePanel.Show();
                InsertPanel.Hide();
            }
            else
            {
                MakePanel.Hide();
                InsertPanel.Show();
            }
        }

        private void Makeform_Load(object sender, EventArgs e)
        {
            client.Encoding = Encoding.UTF8;
            download = client.DownloadString(url);
            jObject = JObject.Parse(download);
            rooms = JObject.Parse(jObject["Chattings"].ToString());
            bool i = true;
            JArray array = JArray.Parse(jObject["Users"][id]["chatting"].ToString());
            foreach (var room in rooms)
            {
                foreach (var check in array)
                {
                    if (room.Key == check.ToString())
                    {
                        i = false;
                    }
                }
                if (i)
                {
                    InsertChattingRooms.Items.Add(room.Key);
                }
            }
        }

        private void InsertSearchword_TextChanged(object sender, EventArgs e)
        {
            InsertChattingRooms.Items.Clear();
            foreach (var room in rooms)
            {
                if (room.Key.Contains(InsertSearchword.Text))
                {
                    InsertChattingRooms.Items.Add(room.Key);
                }
            }
        }

        private void InsertRefresh_Click(object sender, EventArgs e)
        {
            client.Encoding = Encoding.UTF8;
            download = client.DownloadString(url);
            jObject = JObject.Parse(download);
            rooms = JObject.Parse(jObject["Chattings"].ToString());
            InsertChattingRooms.Items.Clear();
            foreach (var room in rooms)
            {
                InsertChattingRooms.Items.Add(room.Key);
            }
        }

        private void InsertShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (InsertShowPassword.Checked)
            {
                InsertPassword.PasswordChar = '\0';
            }
            else
            {
                InsertPassword.PasswordChar = '*';
            }
        }

        private void InsertInsert_Click(object sender, EventArgs e)
        {
            string password = LoginForm.gotohash(InsertPassword.Text);
            string select = InsertChattingRooms.SelectedItem.ToString();
            if (password == rooms[select][1].ToString())
            {
                JArray jArray = new JArray();
                try { jArray = JArray.Parse(jObject["Users"][id]["chatting"].ToString()); }
                catch { }
                jArray.Add(InsertChattingRooms.SelectedItem.ToString());
                jObject["Users"][id]["chatting"] = jArray;
                client.Headers.Add("Content-Type", "application/json");
                client.UploadString(url,"PUT",jObject.ToString());
                MessageBox.Show("성공");
                Close();
            }
            else
            {
                MessageBox.Show("비밀번호를 확인해 주세요");
                InsertPassword.Text = "";
            }
        }
    }
}
