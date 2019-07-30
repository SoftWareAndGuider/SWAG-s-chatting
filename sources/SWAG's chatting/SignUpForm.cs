using System;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace SWAG_s_chatting
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            string url = System.IO.File.ReadAllText("URL.txt");
            LoginForm loginForm = new LoginForm();
            string download = client.DownloadString(url);
            JObject ids = JObject.Parse(download);
            try
            {
                string test = ids["Users"][ID.Text].ToString();
                MessageBox.Show("이 ID는 중복됩니다", "중복");
            }
            catch
            {
                if (!(string.IsNullOrEmpty(ID.Text) && string.IsNullOrEmpty(PW.Text) && string.IsNullOrEmpty(CPW.Text) && string.IsNullOrEmpty(NM.Text) && string.IsNullOrEmpty(SW.Text)))
                {
                    if (PW.Text == CPW.Text)
                    {
                        string password = loginForm.gotohash(PW.Text);
                        JArray jArray = new JArray();
                        jArray.Add(password);
                        jArray.Add(NM.Text);
                        jArray.Add(loginForm.gotohash(SW.Text));
                        JObject newid = new JObject();
                        newid.Add("chatting", "");
                        newid.Add("Login", jArray);
                        JObject Users = JObject.Parse(ids["Users"].ToString());
                        Users.Add(ID.Text, newid);
                        ids["Users"] = Users;
                        string upload = ids.ToString();
                        client.Headers.Add("Content-Type", "application/json");
                        client.UploadString(url, "Put", upload);
                        MessageBox.Show("ID생성이 완료되었습니다", "완료");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("비밀번호를 다시 확인해 주세요");
                    }
                }
                else
                {
                    MessageBox.Show("입력하지 않은 부분이 있는지 확인해 주세요");
                }
            }
        }
    }
}
