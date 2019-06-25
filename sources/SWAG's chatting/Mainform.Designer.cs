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
            this.Users = new System.Windows.Forms.ListBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.InsertURL = new MetroFramework.Controls.MetroTextBox();
            this.Back = new MetroFramework.Controls.MetroButton();
            this.Next = new MetroFramework.Controls.MetroButton();
            this.Go = new MetroFramework.Controls.MetroButton();
            this.Chats = new MetroFramework.Controls.MetroTextBox();
            this.InsertChat = new MetroFramework.Controls.MetroTextBox();
            this.Send = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // Users
            // 
            this.Users.FormattingEnabled = true;
            this.Users.ItemHeight = 12;
            this.Users.Location = new System.Drawing.Point(24, 63);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(126, 292);
            this.Users.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(24, 399);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(766, 249);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.Url = new System.Uri("https://www.google.com", System.UriKind.Absolute);
            // 
            // InsertURL
            // 
            // 
            // 
            // 
            this.InsertURL.CustomButton.Image = null;
            this.InsertURL.CustomButton.Location = new System.Drawing.Point(367, 1);
            this.InsertURL.CustomButton.Name = "";
            this.InsertURL.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.InsertURL.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.InsertURL.CustomButton.TabIndex = 1;
            this.InsertURL.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.InsertURL.CustomButton.UseSelectable = true;
            this.InsertURL.CustomButton.Visible = false;
            this.InsertURL.Lines = new string[] {
        "google.com"};
            this.InsertURL.Location = new System.Drawing.Point(104, 370);
            this.InsertURL.MaxLength = 32767;
            this.InsertURL.Name = "InsertURL";
            this.InsertURL.PasswordChar = '\0';
            this.InsertURL.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.InsertURL.SelectedText = "";
            this.InsertURL.SelectionLength = 0;
            this.InsertURL.SelectionStart = 0;
            this.InsertURL.ShortcutsEnabled = true;
            this.InsertURL.Size = new System.Drawing.Size(389, 23);
            this.InsertURL.TabIndex = 2;
            this.InsertURL.Text = "google.com";
            this.InsertURL.UseSelectable = true;
            this.InsertURL.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.InsertURL.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(24, 370);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(34, 23);
            this.Back.TabIndex = 3;
            this.Back.Text = "←";
            this.Back.UseSelectable = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(64, 370);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(34, 23);
            this.Next.TabIndex = 4;
            this.Next.Text = "→";
            this.Next.UseSelectable = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Go
            // 
            this.Go.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Go.Location = new System.Drawing.Point(499, 370);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(112, 23);
            this.Go.TabIndex = 5;
            this.Go.Text = "Go";
            this.Go.UseSelectable = true;
            this.Go.Click += new System.EventHandler(this.Go_Click);
            // 
            // Chats
            // 
            // 
            // 
            // 
            this.Chats.CustomButton.Image = null;
            this.Chats.CustomButton.Location = new System.Drawing.Point(349, 1);
            this.Chats.CustomButton.Name = "";
            this.Chats.CustomButton.Size = new System.Drawing.Size(255, 255);
            this.Chats.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Chats.CustomButton.TabIndex = 1;
            this.Chats.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Chats.CustomButton.UseSelectable = true;
            this.Chats.CustomButton.Visible = false;
            this.Chats.Lines = new string[0];
            this.Chats.Location = new System.Drawing.Point(185, 63);
            this.Chats.MaxLength = 32767;
            this.Chats.Multiline = true;
            this.Chats.Name = "Chats";
            this.Chats.PasswordChar = '\0';
            this.Chats.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Chats.SelectedText = "";
            this.Chats.SelectionLength = 0;
            this.Chats.SelectionStart = 0;
            this.Chats.ShortcutsEnabled = true;
            this.Chats.Size = new System.Drawing.Size(605, 257);
            this.Chats.TabIndex = 6;
            this.Chats.UseSelectable = true;
            this.Chats.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Chats.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // InsertChat
            // 
            // 
            // 
            // 
            this.InsertChat.CustomButton.Image = null;
            this.InsertChat.CustomButton.Location = new System.Drawing.Point(467, 1);
            this.InsertChat.CustomButton.Name = "";
            this.InsertChat.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.InsertChat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.InsertChat.CustomButton.TabIndex = 1;
            this.InsertChat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.InsertChat.CustomButton.UseSelectable = true;
            this.InsertChat.CustomButton.Visible = false;
            this.InsertChat.Lines = new string[0];
            this.InsertChat.Location = new System.Drawing.Point(185, 332);
            this.InsertChat.MaxLength = 32767;
            this.InsertChat.Name = "InsertChat";
            this.InsertChat.PasswordChar = '\0';
            this.InsertChat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.InsertChat.SelectedText = "";
            this.InsertChat.SelectionLength = 0;
            this.InsertChat.SelectionStart = 0;
            this.InsertChat.ShortcutsEnabled = true;
            this.InsertChat.Size = new System.Drawing.Size(489, 23);
            this.InsertChat.TabIndex = 7;
            this.InsertChat.UseSelectable = true;
            this.InsertChat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.InsertChat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(680, 332);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(110, 23);
            this.Send.TabIndex = 8;
            this.Send.Text = "Send";
            this.Send.UseSelectable = true;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 669);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.InsertChat);
            this.Controls.Add(this.Chats);
            this.Controls.Add(this.Go);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.InsertURL);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.Users);
            this.Font = new System.Drawing.Font("굴림", 9F);
            this.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.Name = "Mainform";
            this.Padding = new System.Windows.Forms.Padding(21, 60, 21, 18);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mainform_FormClosing);
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Users;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private MetroFramework.Controls.MetroTextBox InsertURL;
        private MetroFramework.Controls.MetroButton Back;
        private MetroFramework.Controls.MetroButton Next;
        private MetroFramework.Controls.MetroButton Go;
        private MetroFramework.Controls.MetroTextBox Chats;
        private MetroFramework.Controls.MetroTextBox InsertChat;
        private MetroFramework.Controls.MetroButton Send;
    }
}