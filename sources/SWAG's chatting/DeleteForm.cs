using System;
using System.IO;
using System.Net;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace SWAG_s_chatting
{
    public partial class DeleteForm : MetroFramework.Forms.MetroForm
    {
        string url = File.ReadAllText("URL.txt");
        WebClient client = new WebClient();
        string download;
        public static string id;
        JObject json;

        public DeleteForm()
        {
            InitializeComponent();
        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {
            client.Encoding = Encoding.UTF8;
            download = client.DownloadString(url);
            json = JObject.Parse(download);
            foreach (var item in json["Users"][id]["chatting"])
            {
                List.Items.Add(item.ToString());
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            string name = List.SelectedItem.ToString();
            int i = 0;
            JObject users = JObject.Parse(json["Users"].ToString());
            foreach (var user in users)
            {
                JArray rooms = new JArray();
                try
                {
                    rooms = JArray.Parse(user.Value["chatting"].ToString());
                }
                catch
                {
                    continue;
                }
                for (int c = 0; rooms.Count > c; c++)
                {
                    if (user.ToString() == name)
                    {
                        i++;
                    }
                }
            }
            JObject chattings = JObject.FromObject(json["Chattings"]);
            JArray idchatting = json["Users"][id]["chatting"] as JArray;
            if (i <= 1)
            {
                if (DialogResult.Yes == MessageBox.Show("이 채팅방을 나가게 되면 이 채팅방은 비게 되어 채팅방이 삭제됩니다. 나가시겠습니까?", "비는 채팅방", MessageBoxButtons.YesNo))
                {
                    chattings.Remove(name);
                    json["Chattings"] = chattings;
                    JArray remove = new JArray();
                    foreach (var chatting in idchatting)
                    {
                        remove.Add(chatting.ToString());
                    }
                    idchatting.Clear();
                    for (int count = 0; remove.Count > count; count++)
                    {
                        if (remove[count].ToString() != name)
                        {
                            idchatting.Add(remove[count].ToString());
                        }
                    }
                    json["Users"][id]["chatting"] = idchatting;
                }
            }
            else
            {
                JArray remove = new JArray();
                foreach (var chatting in idchatting)
                {
                    remove.Add(chatting.ToString());
                }
                idchatting.Clear();
                for (int count = 0; remove.Count > count; count++)
                {
                    if (remove[count].ToString() != name)
                    {
                        idchatting.Add(remove[count].ToString());
                    }
                }
                json["Users"][id]["chatting"] = idchatting;
            }
            client.Headers.Add("Content-Type", "application/json");
            client.UploadString(url, "PUT", json.ToString());
            MessageBox.Show("채팅방 나가기가 완료되었습니다", "성공");
            Close();
        }
    }
}
