using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWAG_s_chatting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        { 
            byte[] byteArray = Encoding.UTF8.GetBytes(textBox1.Text);
            MemoryStream stream = new MemoryStream(byteArray);
            var sha1 = new SHA1CryptoServiceProvider();
            var sha1data = sha1.ComputeHash(byteArray);
            string a = Encoding.Default.GetString(sha1data);
            textBox2.Text = a;
        }
    }
}
