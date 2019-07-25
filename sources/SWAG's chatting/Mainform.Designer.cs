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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.Chatting = new System.Windows.Forms.TabPage();
            this.NoInter = new MetroFramework.Controls.MetroCheckBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.OpenRemoveForm = new MetroFramework.Controls.MetroButton();
            this.ChattingBox = new System.Windows.Forms.TextBox();
            this.InsertChat = new MetroFramework.Controls.MetroTextBox();
            this.OpenMakeForm = new MetroFramework.Controls.MetroButton();
            this.Send = new MetroFramework.Controls.MetroButton();
            this.Internet = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Reload = new MetroFramework.Controls.MetroButton();
            this.Go = new MetroFramework.Controls.MetroButton();
            this.Next = new MetroFramework.Controls.MetroButton();
            this.Back = new MetroFramework.Controls.MetroButton();
            this.InsertURL = new MetroFramework.Controls.MetroTextBox();
            this.Setting = new System.Windows.Forms.TabPage();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.회원탈퇴 = new MetroFramework.Controls.MetroButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.FormSelected = new MetroFramework.Controls.MetroCheckBox();
            this.Users = new System.Windows.Forms.ListBox();
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
            this.Chatting.Controls.Add(this.Users);
            this.Chatting.Controls.Add(this.NoInter);
            this.Chatting.Controls.Add(this.metroButton1);
            this.Chatting.Controls.Add(this.OpenRemoveForm);
            this.Chatting.Controls.Add(this.ChattingBox);
            this.Chatting.Controls.Add(this.InsertChat);
            this.Chatting.Controls.Add(this.OpenMakeForm);
            this.Chatting.Controls.Add(this.Send);
            this.Chatting.Location = new System.Drawing.Point(4, 41);
            this.Chatting.Name = "Chatting";
            this.Chatting.Size = new System.Drawing.Size(1148, 546);
            this.Chatting.TabIndex = 0;
            this.Chatting.Text = "채팅";
            // 
            // NoInter
            // 
            this.NoInter.AutoSize = true;
            this.NoInter.Location = new System.Drawing.Point(216, 527);
            this.NoInter.Name = "NoInter";
            this.NoInter.Size = new System.Drawing.Size(101, 15);
            this.NoInter.TabIndex = 20;
            this.NoInter.Text = "방해 금지 모드";
            this.NoInter.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton1.AutoSize = true;
            this.metroButton1.Location = new System.Drawing.Point(1067, 498);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(44, 23);
            this.metroButton1.TabIndex = 19;
            this.metroButton1.Text = "삭제";
            this.metroButton1.UseSelectable = true;
            // 
            // OpenRemoveForm
            // 
            this.OpenRemoveForm.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.OpenRemoveForm.Location = new System.Drawing.Point(3, 59);
            this.OpenRemoveForm.Name = "OpenRemoveForm";
            this.OpenRemoveForm.Size = new System.Drawing.Size(38, 40);
            this.OpenRemoveForm.TabIndex = 18;
            this.OpenRemoveForm.Text = "-";
            this.OpenRemoveForm.UseSelectable = true;
            // 
            // ChattingBox
            // 
            this.ChattingBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChattingBox.BackColor = System.Drawing.Color.White;
            this.ChattingBox.Location = new System.Drawing.Point(215, 13);
            this.ChattingBox.Multiline = true;
            this.ChattingBox.Name = "ChattingBox";
            this.ChattingBox.ReadOnly = true;
            this.ChattingBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ChattingBox.Size = new System.Drawing.Size(896, 479);
            this.ChattingBox.TabIndex = 17;
            this.ChattingBox.TextChanged += new System.EventHandler(this.ChattingBox_TextChanged);
            // 
            // InsertChat
            // 
            this.InsertChat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.InsertChat.CustomButton.Image = null;
            this.InsertChat.CustomButton.Location = new System.Drawing.Point(758, 1);
            this.InsertChat.CustomButton.Name = "";
            this.InsertChat.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.InsertChat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.InsertChat.CustomButton.TabIndex = 1;
            this.InsertChat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.InsertChat.CustomButton.UseSelectable = true;
            this.InsertChat.CustomButton.Visible = false;
            this.InsertChat.Lines = new string[0];
            this.InsertChat.Location = new System.Drawing.Point(215, 498);
            this.InsertChat.MaxLength = 32767;
            this.InsertChat.Name = "InsertChat";
            this.InsertChat.PasswordChar = '\0';
            this.InsertChat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.InsertChat.SelectedText = "";
            this.InsertChat.SelectionLength = 0;
            this.InsertChat.SelectionStart = 0;
            this.InsertChat.ShortcutsEnabled = true;
            this.InsertChat.Size = new System.Drawing.Size(780, 23);
            this.InsertChat.TabIndex = 14;
            this.InsertChat.UseSelectable = true;
            this.InsertChat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.InsertChat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.InsertChat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InsertChat_KeyDown);
            // 
            // OpenMakeForm
            // 
            this.OpenMakeForm.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.OpenMakeForm.Location = new System.Drawing.Point(3, 13);
            this.OpenMakeForm.Name = "OpenMakeForm";
            this.OpenMakeForm.Size = new System.Drawing.Size(38, 40);
            this.OpenMakeForm.TabIndex = 13;
            this.OpenMakeForm.Text = "+";
            this.OpenMakeForm.UseSelectable = true;
            this.OpenMakeForm.Click += new System.EventHandler(this.MetroButton1_Click_1);
            // 
            // Send
            // 
            this.Send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Send.AutoSize = true;
            this.Send.Location = new System.Drawing.Point(1001, 498);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(60, 23);
            this.Send.TabIndex = 12;
            this.Send.Text = "보내기";
            this.Send.UseSelectable = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
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
            this.panel1.Size = new System.Drawing.Size(1074, 458);
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
            this.InsertURL.Lines = new string[0];
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
            this.InsertURL.UseSelectable = true;
            this.InsertURL.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.InsertURL.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.InsertURL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InsertURL_KeyDown);
            // 
            // Setting
            // 
            this.Setting.Controls.Add(this.metroButton2);
            this.Setting.Controls.Add(this.회원탈퇴);
            this.Setting.Location = new System.Drawing.Point(4, 41);
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(1148, 546);
            this.Setting.TabIndex = 2;
            this.Setting.Text = "설정";
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(12, 204);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(1120, 151);
            this.metroButton2.TabIndex = 1;
            this.metroButton2.Text = "metroButton2";
            this.metroButton2.UseSelectable = true;
            // 
            // 회원탈퇴
            // 
            this.회원탈퇴.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.회원탈퇴.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.회원탈퇴.Location = new System.Drawing.Point(12, 363);
            this.회원탈퇴.Name = "회원탈퇴";
            this.회원탈퇴.Size = new System.Drawing.Size(1120, 151);
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
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "채팅왔습니다.";
            this.notifyIcon1.BalloonTipTitle = "알림";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "채팅 왔습니다.";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseDoubleClick);
            // 
            // FormSelected
            // 
            this.FormSelected.AutoSize = true;
            this.FormSelected.Location = new System.Drawing.Point(357, 628);
            this.FormSelected.Name = "FormSelected";
            this.FormSelected.Size = new System.Drawing.Size(95, 15);
            this.FormSelected.TabIndex = 11;
            this.FormSelected.Text = "FormSelected";
            this.FormSelected.UseSelectable = true;
            this.FormSelected.Visible = false;
            // 
            // Users
            // 
            this.Users.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Users.FormattingEnabled = true;
            this.Users.ItemHeight = 12;
            this.Users.Location = new System.Drawing.Point(47, 14);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(150, 508);
            this.Users.TabIndex = 21;
            this.Users.SelectedIndexChanged += new System.EventHandler(this.Users_SelectedIndexChanged_1);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1198, 669);
            this.Controls.Add(this.FormSelected);
            this.Controls.Add(this.metroTabControl1);
            this.Font = new System.Drawing.Font("굴림", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.Name = "Mainform";
            this.Padding = new System.Windows.Forms.Padding(21, 60, 21, 18);
            this.Activated += new System.EventHandler(this.Mainform_Activated);
            this.Deactivate += new System.EventHandler(this.Mainform_Leave);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mainform_FormClosing);
            this.metroTabControl1.ResumeLayout(false);
            this.Chatting.ResumeLayout(false);
            this.Chatting.PerformLayout();
            this.Internet.ResumeLayout(false);
            this.Internet.PerformLayout();
            this.Setting.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage Chatting;
        private System.Windows.Forms.TabPage Internet;
        private System.Windows.Forms.TabPage Setting;
        private MetroFramework.Controls.MetroButton Send;
        private MetroFramework.Controls.MetroButton Go;
        private MetroFramework.Controls.MetroButton Next;
        private MetroFramework.Controls.MetroButton Back;
        private MetroFramework.Controls.MetroTextBox InsertURL;
        private MetroFramework.Controls.MetroButton 회원탈퇴;
        private MetroFramework.Controls.MetroButton Reload;
        private CefSharp.WinForms.ChromiumWebBrowser Browser;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton OpenMakeForm;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroTextBox InsertChat;
        private System.Windows.Forms.TextBox ChattingBox;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton OpenRemoveForm;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroCheckBox NoInter;
        private MetroFramework.Controls.MetroCheckBox FormSelected;
        private System.Windows.Forms.ListBox Users;
    }
}