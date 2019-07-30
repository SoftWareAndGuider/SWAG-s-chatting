using System;
using System.Net;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace SWAG_s_chatting
{
    public partial class EditForm : MetroFramework.Forms.MetroForm
    {
        public static string id;
        public EditForm()
        {
            InitializeComponent();
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            string url = File.ReadAllText("URL.txt");
            string download = client.DownloadString(url);
            JObject all = JObject.Parse(download);
            JArray users = all["Users"][id]["Login"] as JArray;
            if (loginForm.gotohash(PPW.Text) != users[0].ToString())
            {
                MessageBox.Show("현재 비밀번호를 다시 입력해 주세요");
            }
            else
            {
                if (!string.IsNullOrEmpty(PW.Text))
                {
                    if (PW.Text != CPW.Text)
                    {
                        MessageBox.Show("새 비밀번호를 다시 확인해 주십시오");
                        goto fail;
                    }
                    else
                    {
                        users[0] = loginForm.gotohash(PW.Text);
                    }
                }
                if (!string.IsNullOrEmpty(NM.Text))
                {
                    users[1] = NM.Text;
                }
                if (!string.IsNullOrEmpty(SW.Text))
                {
                    users[2] = SW.Text;
                }
                all["Users"][id]["Login"] = users;
                client.Headers.Add("Content-Type", "application/json");
                client.UploadString(url,"PUT",all.ToString());
                MessageBox.Show("수정이 완료되었습니다","완료");
                Close();
            fail:;
            }
        }
    }
}
