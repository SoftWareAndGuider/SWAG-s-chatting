namespace SWAG_s_chatting
{
    partial class Mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.Chatting = new System.Windows.Forms.TabPage();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.Send = new MetroFramework.Controls.MetroButton();
            this.InsertChat = new MetroFramework.Controls.MetroTextBox();
            this.Chats = new MetroFramework.Controls.MetroTextBox();
            this.Users = new System.Windows.Forms.ListBox();
            this.Internet = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Reload = new MetroFramework.Controls.MetroButton();
            this.Go = new MetroFramework.Controls.MetroButton();
            this.Next = new MetroFramework.Controls.MetroButton();
            this.Back = new MetroFramework.Controls.MetroButton();
            this.InsertURL = new MetroFramework.Controls.MetroTextBox();
            this.Setting = new System.Windows.Forms.TabPage();
            this.회원탈퇴 = new MetroFramework.Controls.MetroButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroTabControl1.SuspendLayout();
            this.Chatting.SuspendLayout();
            this.Internet.SuspendLayout();
            this.Setting.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.metroTabControl1.Controls.Add(this.Chatting);
            this.metroTabControl1.Controls.Add(this.Internet);
            this.metroTabControl1.Controls.Add(this.Setting);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(21, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1156, 591);
            this.metroTabControl1.TabIndex = 9;
            this.metroTabControl1.UseSelectable = true;
            // 
            // Chatting
            // 
            this.Chatting.Controls.Add(this.metroButton1);
            this.Chatting.Controls.Add(this.Send);
            this.Chatting.Controls.Add(this.InsertChat);
            this.Chatting.Controls.Add(this.Chats);
            this.Chatting.Controls.Add(this.Users);
            this.Chatting.Location = new System.Drawing.Point(4, 41);
            this.Chatting.Name = "Chatting";
            this.Chatting.Size = new System.Drawing.Size(1148, 546);
            this.Chatting.TabIndex = 0;
            this.Chatting.Text = "채팅";
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.Location = new System.Drawing.Point(3, 13);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(38, 40);
            this.metroButton1.TabIndex = 13;
            this.metroButton1.Text = "+";
            this.metroButton1.UseSelectable = true;
            // 
            // Send
            // 
            this.Send.AutoSize = true;
            this.Send.Location = new System.Drawing.Point(1000, 500);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(110, 23);
            this.Send.TabIndex = 12;
            this.Send.Text = "Send";
            this.Send.UseSelectable = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // InsertChat
            // 
            // 
            // 
            // 
            this.InsertChat.CustomButton.Image = null;
            this.InsertChat.CustomButton.Location = new System.Drawing.Point(764, 1);
            this.InsertChat.CustomButton.Name = "";
            this.InsertChat.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.InsertChat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.InsertChat.CustomButton.TabIndex = 1;
            this.InsertChat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.InsertChat.CustomButton.UseSelectable = true;
            this.InsertChat.CustomButton.Visible = false;
            this.InsertChat.Lines = new string[0];
            this.InsertChat.Location = new System.Drawing.Point(208, 500);
            this.InsertChat.MaxLength = 32767;
            this.InsertChat.Name = "InsertChat";
            this.InsertChat.PasswordChar = '\0';
            this.InsertChat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.InsertChat.SelectedText = "";
            this.InsertChat.SelectionLength = 0;
            this.InsertChat.SelectionStart = 0;
            this.InsertChat.ShortcutsEnabled = true;
            this.InsertChat.Size = new System.Drawing.Size(786, 23);
            this.InsertChat.TabIndex = 11;
            this.InsertChat.UseSelectable = true;
            this.InsertChat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.InsertChat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Chats
            // 
            // 
            // 
            // 
            this.Chats.CustomButton.Image = null;
            this.Chats.CustomButton.Location = new System.Drawing.Point(439, 2);
            this.Chats.CustomButton.Name = "";
            this.Chats.CustomButton.Size = new System.Drawing.Size(467, 467);
            this.Chats.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Chats.CustomButton.TabIndex = 1;
            this.Chats.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Chats.CustomButton.UseSelectable = true;
            this.Chats.CustomButton.Visible = false;
            this.Chats.Lines = new string[0];
            this.Chats.Location = new System.Drawing.Point(208, 13);
            this.Chats.MaxLength = 32767;
            this.Chats.Multiline = true;
            this.Chats.Name = "Chats";
            this.Chats.PasswordChar = '\0';
            this.Chats.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Chats.SelectedText = "";
            this.Chats.SelectionLength = 0;
            this.Chats.SelectionStart = 0;
            this.Chats.ShortcutsEnabled = true;
            this.Chats.Size = new System.Drawing.Size(909, 472);
            this.Chats.TabIndex = 10;
            this.Chats.UseSelectable = true;
            this.Chats.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Chats.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Users
            // 
            this.Users.FormattingEnabled = true;
            this.Users.ItemHeight = 12;
            this.Users.Location = new System.Drawing.Point(47, 13);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(126, 520);
            this.Users.TabIndex = 9;
            this.Users.SelectedIndexChanged += new System.EventHandler(this.Users_SelectedIndexChanged);
            // 
            // Internet
            // 
            this.Internet.Controls.Add(this.panel1);
            this.Internet.Controls.Add(this.Reload);
            this.Internet.Controls.Add(this.Go);
            this.Internet.Controls.Add(this.Next);
            this.Internet.Controls.Add(this.Back);
            this.Internet.Controls.Add(this.InsertURL);
            this.Internet.Location = new System.Drawing.Point(4, 41);
            this.Internet.Name = "Internet";
            this.Internet.Size = new System.Drawing.Size(1148, 546);
            this.Internet.TabIndex = 1;
            this.Internet.Text = "인터넷 브라우저";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Location = new System.Drawing.Point(17, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1116, 490);
            this.panel1.TabIndex = 12;
            // 
            // Reload
            // 
            this.Reload.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Reload.Location = new System.Drawing.Point(153, 20);
            this.Reload.Name = "Reload";
            this.Reload.Size = new System.Drawing.Size(65, 25);
            this.Reload.TabIndex = 11;
            this.Reload.Text = "↻";
            this.Reload.UseSelectable = true;
            this.Reload.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Go
            // 
            this.Go.AllowDrop = true;
            this.Go.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Go.Location = new System.Drawing.Point(1032, 20);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(101, 27);
            this.Go.TabIndex = 10;
            this.Go.Text = "이동";
            this.Go.UseSelectable = true;
            this.Go.Click += new System.EventHandler(this.Go_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(86, 20);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(60, 25);
            this.Next.TabIndex = 9;
            this.Next.Text = "▶";
            this.Next.UseSelectable = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(17, 20);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(60, 25);
            this.Back.TabIndex = 8;
            this.Back.Text = "◀";
            this.Back.UseSelectable = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // InsertURL
            // 
            // 
            // 
            // 
            this.InsertURL.CustomButton.Image = null;
            this.InsertURL.CustomButton.Location = new System.Drawing.Point(776, 1);
            this.InsertURL.CustomButton.Name = "";
            this.InsertURL.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.InsertURL.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.InsertURL.CustomButton.TabIndex = 1;
            this.InsertURL.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.InsertURL.CustomButton.UseSelectable = true;
            this.InsertURL.CustomButton.Visible = false;
            this.InsertURL.Lines = new string[] {
        "google.com"};
            this.InsertURL.Location = new System.Drawing.Point(224, 20);
            this.InsertURL.MaxLength = 32767;
            this.InsertURL.Name = "InsertURL";
            this.InsertURL.PasswordChar = '\0';
            this.InsertURL.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.InsertURL.SelectedText = "";
            this.InsertURL.SelectionLength = 0;
            this.InsertURL.SelectionStart = 0;
            this.InsertURL.ShortcutsEnabled = true;
            this.InsertURL.Size = new System.Drawing.Size(802, 27);
            this.InsertURL.TabIndex = 7;
            this.InsertURL.Text = "google.com";
            this.InsertURL.UseSelectable = true;
            this.InsertURL.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.InsertURL.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Setting
            // 
            this.Setting.Controls.Add(this.회원탈퇴);
            this.Setting.Location = new System.Drawing.Point(4, 41);
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(1148, 546);
            this.Setting.TabIndex = 2;
            this.Setting.Text = "설정";
            // 
            // 회원탈퇴
            // 
            this.회원탈퇴.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.회원탈퇴.Location = new System.Drawing.Point(3, 395);
            this.회원탈퇴.Name = "회원탈퇴";
            this.회원탈퇴.Size = new System.Drawing.Size(1130, 151);
            this.회원탈퇴.TabIndex = 0;
            this.회원탈퇴.Text = "회원탈퇴";
            this.회원탈퇴.UseSelectable = true;
            this.회원탈퇴.Click += new System.EventHandler(this.MetroButton1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1198, 669);
            this.Controls.Add(this.metroTabControl1);
            this.Font = new System.Drawing.Font("굴림", 9F);
            this.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.Name = "Mainform";
            this.Padding = new System.Windows.Forms.Padding(21, 60, 21, 18);
            this.Text = "채팅창";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mainform_FormClosing);
            this.metroTabControl1.ResumeLayout(false);
            this.Chatting.ResumeLayout(false);
            this.Chatting.PerformLayout();
            this.Internet.ResumeLayout(false);
            this.Internet.PerformLayout();
            this.Setting.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage Chatting;
        private System.Windows.Forms.TabPage Internet;
        private System.Windows.Forms.TabPage Setting;
        private MetroFramework.Controls.MetroButton Send;
        private MetroFramework.Controls.MetroTextBox InsertChat;
        private MetroFramework.Controls.MetroTextBox Chats;
        private System.Windows.Forms.ListBox Users;
        private MetroFramework.Controls.MetroButton Go;
        private MetroFramework.Controls.MetroButton Next;
        private MetroFramework.Controls.MetroButton Back;
        private MetroFramework.Controls.MetroTextBox InsertURL;
        private MetroFramework.Controls.MetroButton 회원탈퇴;
        private MetroFramework.Controls.MetroButton Reload;
        private CefSharp.WinForms.ChromiumWebBrowser Browser;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.Timer timer1;
    }
}