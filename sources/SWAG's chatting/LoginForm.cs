using System;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace SWAG_s_chatting
{
    public partial class LoginForm : Form
    {
        WebClient client = new WebClient();
        string url = System.IO.File.ReadAllText("URL.txt");
        public static string id;
        public LoginForm()
        {
            InitializeComponent();
            client.Encoding = Encoding.UTF8;
        }
        private void Login_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(InsertID.Text) || String.IsNullOrEmpty(InsertPW.Text)))
            {
                task();
            }
        }
        public string gotohash(string password)
        {
            byte[] bytearray = Encoding.UTF8.GetBytes(password);
            var enc = new SHA256CryptoServiceProvider();
            var hash = enc.ComputeHash(bytearray);
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                strBuilder.Append(hash[i].ToString("x2"));
            }
            return strBuilder.ToString();
        }
        private void task()
        {
            string ID = InsertID.Text;
            string PW = gotohash(InsertPW.Text);
            string download = client.DownloadString(url);
            JObject ids = JObject.Parse(download);
            try
            {
                if (ids["Users"][ID]["Login"][0].ToString() != PW)
                {
                    MessageBox.Show("비밀번호를 다시 입력해 주세요", "비밀번호 오류");
                }
                else
                {
                    Mainform.id = ID;
                    Makeform.id = ID;
                    DeleteForm.id = ID;
                    Hide();
                    Mainform mainform = new Mainform();
                    mainform.Show();
                }
            }
            catch
            {
                MessageBox.Show("ID를 만들고 재시도 해주세요", "ID가 없습니다");
            }
        }

        private void InsertPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!(String.IsNullOrEmpty(InsertID.Text) || String.IsNullOrEmpty(InsertPW.Text)))
                {
                    task();
                }
            }
        }

        private void InsertID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!(String.IsNullOrEmpty(InsertID.Text) || String.IsNullOrEmpty(InsertPW.Text)))
                {
                    task();
                }
            }
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
        }
    }
}
