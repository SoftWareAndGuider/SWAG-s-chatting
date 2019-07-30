using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace SWAG_s_chatting
{
    public partial class ResetPasswordForm : Form
    {
        public ResetPasswordForm()
        {
            InitializeComponent();
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            string url = File.ReadAllText("URL.txt");
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            string download = client.DownloadString(url);
            JObject all = JObject.Parse(download);
            JArray user = all["Users"][ID.Text]["Login"] as JArray;
            if (user[2].ToString() != loginForm.gotohash(SW.Text))
            {
                MessageBox.Show("비밀단어를 확인해 주세요", "실패");
            }
            else
            {
                Random random = new Random();
                string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890`-=~!@#$%^&*()_+[]{}";
                string newpassword = "";
                for (int i = 0; i <= random.Next(5, 15); i++)
                {
                    int a = random.Next(0, text.Length);
                    newpassword += text[a];
                }
                if (DialogResult.Yes == MessageBox.Show($"비밀번호 초기화가 완료되었습니다\n새로운 비밀번호는 {newpassword}입니다\n새로운 비밀번호를 클립보드에 복사하시겠습니까?", "완료",buttons:MessageBoxButtons.YesNo))
                {
                    Clipboard.SetText(newpassword); 
                }
                user[0] = loginForm.gotohash(newpassword);
                all["Users"][ID.Text]["Login"] = user;
                client.Headers.Add("Content-Type", "application/json");
                client.UploadString(url, "PUT", all.ToString());
            }
        }
    }
}
