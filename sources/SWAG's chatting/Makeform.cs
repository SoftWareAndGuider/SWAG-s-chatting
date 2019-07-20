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
        private JObject people = new JObject();
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
            people = JObject.Parse(jObject["Users"].ToString());
            bool i = true;
            JArray array = new JArray();
            try
            {
                array = JArray.Parse(jObject["Users"][id]["chatting"].ToString());
            }
            catch { }
            foreach (var room in rooms)
            {
                foreach (var check in array)
                {
                    if (room.Key == check.ToString())
                    {
                        i = false;
                    }
                }
                if (i && !(bool)room.Value[2])
                {
                    InsertChattingRooms.Items.Add(room.Key);
                }
            }
            foreach (var person in people)
            {
                MakeInvite.Items.Add(person.Key);
                MakeInvite.Items.Remove(id);
            }
        }

        private void InsertSearchword_TextChanged(object sender, EventArgs e)
        {
            InsertChattingRooms.Items.Clear();
            foreach (var room in rooms)
            {
                if (room.Key == InsertSearchword.Text && (bool)rooms[InsertSearchword.Text][2])
                {
                    InsertChattingRooms.Items.Add(room.Key);
                }
                else if (room.Key.Contains(InsertSearchword.Text))
                {
                    if (!(bool)room.Value[2])
                    {
                        InsertChattingRooms.Items.Add(room.Key);
                    }
                }
            }
        }

        private void InsertRefresh_Click(object sender, EventArgs e)
        {
            client.Encoding = Encoding.UTF8;
            download = client.DownloadString(url);
            jObject = JObject.Parse(download);
            rooms = JObject.Parse(jObject["Chattings"].ToString());
            people = JObject.Parse(jObject["Users"].ToString());
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
                if (i && !(bool)room.Value[2])
                {
                    InsertChattingRooms.Items.Add(room.Key);
                }
            }
            foreach (var person in people)
            {
                MakeInvite.Items.Add(person.Key);
                MakeInvite.Items.Remove(id);
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

        private void MakeShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (MakeShowPassword.Checked)
            {
                MakePassword.PasswordChar = '\0';
            }
            else
            {
                MakePassword.PasswordChar = '*';
            }
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(MakeName.Text) && String.IsNullOrEmpty(MakePassword.Text))
            {
                MessageBox.Show("채팅방의 이름과 비밀번호를 입력해 주세요");
            }
            else
            {
                try
                {
                    JArray newroom = new JArray();
                    newroom.Add($"{MakeName.Text}채널에 오신것을 환영합니다!\r\n\r\n");
                    newroom.Add(LoginForm.gotohash(MakePassword.Text));
                    newroom.Add(MakeHide.Checked);
                    rooms.Add(MakeName.Text, newroom);
                    jObject["Chattings"] = rooms;
                    foreach (var invite in MakeInvite.CheckedItems)
                    {
                        JArray jArray = new JArray();
                        try
                        {
                            jArray = JArray.Parse(people[invite.ToString()]["chatting"].ToString());
                        }
                        catch { }
                        jArray.Add(MakeName.Text);
                        jObject["Users"][invite.ToString()]["chatting"] = jArray;
                    }
                    JArray me = new JArray();
                    try
                    {
                        me = JArray.Parse(people[id]["chatting"].ToString());
                    }
                    catch { }
                    me.Add(MakeName.Text);
                    jObject["Users"][id]["chatting"] = me;
                    client.Headers.Add("Content-Type", "application/json");
                    client.UploadString(url, "PUT", jObject.ToString());
                    MessageBox.Show("채팅방 생성이 완료되었습니다");
                    Close();
                }
                catch
                {
                    MessageBox.Show("이미 동일한 이름의 채팅방이 있습니다");
                }
            }
        }
    }
}
