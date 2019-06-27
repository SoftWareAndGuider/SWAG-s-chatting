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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Send = new MetroFramework.Controls.MetroButton();
            this.InsertChat = new MetroFramework.Controls.MetroTextBox();
            this.Chats = new MetroFramework.Controls.MetroTextBox();
            this.Users = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Refresh = new MetroFramework.Controls.MetroButton();
            this.Go = new MetroFramework.Controls.MetroButton();
            this.Next = new MetroFramework.Controls.MetroButton();
            this.Back = new MetroFramework.Controls.MetroButton();
            this.InsertURL = new MetroFramework.Controls.MetroTextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabPage1);
            this.metroTabControl1.Controls.Add(this.tabPage2);
            this.metroTabControl1.Controls.Add(this.tabPage3);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(21, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 2;
            this.metroTabControl1.Size = new System.Drawing.Size(1144, 591);
            this.metroTabControl1.TabIndex = 9;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Send);
            this.tabPage1.Controls.Add(this.InsertChat);
            this.tabPage1.Controls.Add(this.Chats);
            this.tabPage1.Controls.Add(this.Users);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1136, 549);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Chatting";
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
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Refresh);
            this.tabPage2.Controls.Add(this.Go);
            this.tabPage2.Controls.Add(this.Next);
            this.tabPage2.Controls.Add(this.Back);
            this.tabPage2.Controls.Add(this.InsertURL);
            this.tabPage2.Controls.Add(this.webBrowser1);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1136, 549);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Browser";
            // 
            // Refresh
            // 
            this.Refresh.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Refresh.Location = new System.Drawing.Point(153, 22);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(65, 25);
            this.Refresh.TabIndex = 11;
            this.Refresh.Text = "↻";
            this.Refresh.UseSelectable = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Go
            // 
            this.Go.AllowDrop = true;
            this.Go.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Go.Location = new System.Drawing.Point(1013, 19);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(102, 27);
            this.Go.TabIndex = 10;
            this.Go.Text = "Go";
            this.Go.UseSelectable = true;
            this.Go.Click += new System.EventHandler(this.Go_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(86, 22);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(60, 25);
            this.Next.TabIndex = 9;
            this.Next.Text = "▶";
            this.Next.UseSelectable = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(17, 21);
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
            this.InsertURL.CustomButton.Location = new System.Drawing.Point(761, 1);
            this.InsertURL.CustomButton.Name = "";
            this.InsertURL.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.InsertURL.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.InsertURL.CustomButton.TabIndex = 1;
            this.InsertURL.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.InsertURL.CustomButton.UseSelectable = true;
            this.InsertURL.CustomButton.Visible = false;
            this.InsertURL.Lines = new string[] {
        "google.com"};
            this.InsertURL.Location = new System.Drawing.Point(224, 22);
            this.InsertURL.MaxLength = 32767;
            this.InsertURL.Name = "InsertURL";
            this.InsertURL.PasswordChar = '\0';
            this.InsertURL.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.InsertURL.SelectedText = "";
            this.InsertURL.SelectionLength = 0;
            this.InsertURL.SelectionStart = 0;
            this.InsertURL.ShortcutsEnabled = true;
            this.InsertURL.Size = new System.Drawing.Size(783, 23);
            this.InsertURL.TabIndex = 7;
            this.InsertURL.Text = "google.com";
            this.InsertURL.UseSelectable = true;
            this.InsertURL.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.InsertURL.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(17, 51);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1098, 479);
            this.webBrowser1.TabIndex = 6;
            this.webBrowser1.Url = new System.Uri("https://www.google.com", System.UriKind.Absolute);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.metroButton1);
            this.tabPage3.Location = new System.Drawing.Point(4, 38);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1136, 549);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Setting";
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.Location = new System.Drawing.Point(3, 395);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(1130, 151);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "회원탈퇴";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.MetroButton1_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 669);
            this.Controls.Add(this.metroTabControl1);
            this.Font = new System.Drawing.Font("굴림", 9F);
            this.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.Name = "Mainform";
            this.Padding = new System.Windows.Forms.Padding(21, 60, 21, 18);
            this.Text = "Mainform";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mainform_FormClosing);
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private MetroFramework.Controls.MetroButton Send;
        private MetroFramework.Controls.MetroTextBox InsertChat;
        private MetroFramework.Controls.MetroTextBox Chats;
        private System.Windows.Forms.ListBox Users;
        private MetroFramework.Controls.MetroButton Go;
        private MetroFramework.Controls.MetroButton Next;
        private MetroFramework.Controls.MetroButton Back;
        private MetroFramework.Controls.MetroTextBox InsertURL;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton Refresh;
    }
}