using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWAG_s_chatting
{
    public partial class Mainform : MetroFramework.Forms.MetroForm
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {

        }

        private void Mainform_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Go_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(InsertURL.Text);
        }

        private void Next_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }
    }
}
