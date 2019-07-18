using System;
using System.Windows.Forms;

namespace SWAG_s_chatting
{
    public partial class Makeform : MetroFramework.Forms.MetroForm
    {
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
    }
}
