namespace SWAG_s_chatting
{
    partial class Makeform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Makeform));
            this.Insert = new MetroFramework.Controls.MetroRadioButton();
            this.Make = new MetroFramework.Controls.MetroRadioButton();
            this.InsertChattingRooms = new System.Windows.Forms.ListBox();
            this.InsertPanel = new MetroFramework.Controls.MetroPanel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.InsertShowPassword = new MetroFramework.Controls.MetroCheckBox();
            this.InsertRefresh = new MetroFramework.Controls.MetroButton();
            this.InsertSearchword = new MetroFramework.Controls.MetroTextBox();
            this.InsertInsert = new MetroFramework.Controls.MetroButton();
            this.InsertPassword = new MetroFramework.Controls.MetroTextBox();
            this.MakePanel = new MetroFramework.Controls.MetroPanel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.MakeInvite = new System.Windows.Forms.CheckedListBox();
            this.MakeShowPassword = new MetroFramework.Controls.MetroCheckBox();
            this.MakePassword = new MetroFramework.Controls.MetroTextBox();
            this.MakeName = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.InsertPanel.SuspendLayout();
            this.MakePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Insert
            // 
            this.Insert.AutoSize = true;
            this.Insert.Checked = true;
            this.Insert.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.Insert.Location = new System.Drawing.Point(23, 63);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(100, 25);
            this.Insert.TabIndex = 0;
            this.Insert.TabStop = true;
            this.Insert.Text = "가입하기";
            this.Insert.UseSelectable = true;
            // 
            // Make
            // 
            this.Make.AutoSize = true;
            this.Make.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.Make.Location = new System.Drawing.Point(23, 95);
            this.Make.Name = "Make";
            this.Make.Size = new System.Drawing.Size(82, 25);
            this.Make.TabIndex = 1;
            this.Make.Text = "만들기";
            this.Make.UseSelectable = true;
            this.Make.CheckedChanged += new System.EventHandler(this.Make_CheckedChanged);
            // 
            // InsertChattingRooms
            // 
            this.InsertChattingRooms.FormattingEnabled = true;
            this.InsertChattingRooms.ItemHeight = 12;
            this.InsertChattingRooms.Location = new System.Drawing.Point(3, 55);
            this.InsertChattingRooms.Name = "InsertChattingRooms";
            this.InsertChattingRooms.Size = new System.Drawing.Size(154, 76);
            this.InsertChattingRooms.TabIndex = 0;
            // 
            // InsertPanel
            // 
            this.InsertPanel.AutoSize = true;
            this.InsertPanel.Controls.Add(this.metroLabel6);
            this.InsertPanel.Controls.Add(this.metroLabel5);
            this.InsertPanel.Controls.Add(this.metroLabel4);
            this.InsertPanel.Controls.Add(this.InsertShowPassword);
            this.InsertPanel.Controls.Add(this.InsertRefresh);
            this.InsertPanel.Controls.Add(this.InsertSearchword);
            this.InsertPanel.Controls.Add(this.InsertInsert);
            this.InsertPanel.Controls.Add(this.InsertPassword);
            this.InsertPanel.Controls.Add(this.InsertChattingRooms);
            this.InsertPanel.HorizontalScrollbarBarColor = true;
            this.InsertPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.InsertPanel.HorizontalScrollbarSize = 10;
            this.InsertPanel.Location = new System.Drawing.Point(144, 63);
            this.InsertPanel.Name = "InsertPanel";
            this.InsertPanel.Size = new System.Drawing.Size(533, 142);
            this.InsertPanel.TabIndex = 2;
            this.InsertPanel.VerticalScrollbarBarColor = true;
            this.InsertPanel.VerticalScrollbarHighlightOnWheel = false;
            this.InsertPanel.VerticalScrollbarSize = 10;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(4, 26);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(37, 19);
            this.metroLabel6.TabIndex = 8;
            this.metroLabel6.Text = "검색";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(288, 4);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(97, 19);
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "비밀번호 입력";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(4, 4);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(83, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "채팅방 선택";
            // 
            // InsertShowPassword
            // 
            this.InsertShowPassword.AutoSize = true;
            this.InsertShowPassword.Location = new System.Drawing.Point(288, 56);
            this.InsertShowPassword.Name = "InsertShowPassword";
            this.InsertShowPassword.Size = new System.Drawing.Size(110, 15);
            this.InsertShowPassword.TabIndex = 5;
            this.InsertShowPassword.Text = "비밀번호 보이기";
            this.InsertShowPassword.UseSelectable = true;
            this.InsertShowPassword.CheckedChanged += new System.EventHandler(this.InsertShowPassword_CheckedChanged);
            // 
            // InsertRefresh
            // 
            this.InsertRefresh.Location = new System.Drawing.Point(164, 55);
            this.InsertRefresh.Name = "InsertRefresh";
            this.InsertRefresh.Size = new System.Drawing.Size(75, 76);
            this.InsertRefresh.TabIndex = 4;
            this.InsertRefresh.Text = "새로고침";
            this.InsertRefresh.UseSelectable = true;
            this.InsertRefresh.Click += new System.EventHandler(this.InsertRefresh_Click);
            // 
            // InsertSearchword
            // 
            // 
            // 
            // 
            this.InsertSearchword.CustomButton.Image = null;
            this.InsertSearchword.CustomButton.Location = new System.Drawing.Point(170, 1);
            this.InsertSearchword.CustomButton.Name = "";
            this.InsertSearchword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.InsertSearchword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.InsertSearchword.CustomButton.TabIndex = 1;
            this.InsertSearchword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.InsertSearchword.CustomButton.UseSelectable = true;
            this.InsertSearchword.CustomButton.Visible = false;
            this.InsertSearchword.Lines = new string[0];
            this.InsertSearchword.Location = new System.Drawing.Point(47, 26);
            this.InsertSearchword.MaxLength = 32767;
            this.InsertSearchword.Name = "InsertSearchword";
            this.InsertSearchword.PasswordChar = '\0';
            this.InsertSearchword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.InsertSearchword.SelectedText = "";
            this.InsertSearchword.SelectionLength = 0;
            this.InsertSearchword.SelectionStart = 0;
            this.InsertSearchword.ShortcutsEnabled = true;
            this.InsertSearchword.Size = new System.Drawing.Size(192, 23);
            this.InsertSearchword.TabIndex = 3;
            this.InsertSearchword.UseSelectable = true;
            this.InsertSearchword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.InsertSearchword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.InsertSearchword.TextChanged += new System.EventHandler(this.InsertSearchword_TextChanged);
            // 
            // InsertInsert
            // 
            this.InsertInsert.Location = new System.Drawing.Point(288, 83);
            this.InsertInsert.Name = "InsertInsert";
            this.InsertInsert.Size = new System.Drawing.Size(210, 49);
            this.InsertInsert.TabIndex = 3;
            this.InsertInsert.Text = "가입하기";
            this.InsertInsert.UseSelectable = true;
            this.InsertInsert.Click += new System.EventHandler(this.InsertInsert_Click);
            // 
            // InsertPassword
            // 
            // 
            // 
            // 
            this.InsertPassword.CustomButton.Image = null;
            this.InsertPassword.CustomButton.Location = new System.Drawing.Point(188, 1);
            this.InsertPassword.CustomButton.Name = "";
            this.InsertPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.InsertPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.InsertPassword.CustomButton.TabIndex = 1;
            this.InsertPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.InsertPassword.CustomButton.UseSelectable = true;
            this.InsertPassword.CustomButton.Visible = false;
            this.InsertPassword.Lines = new string[0];
            this.InsertPassword.Location = new System.Drawing.Point(288, 26);
            this.InsertPassword.MaxLength = 32767;
            this.InsertPassword.Name = "InsertPassword";
            this.InsertPassword.PasswordChar = '*';
            this.InsertPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.InsertPassword.SelectedText = "";
            this.InsertPassword.SelectionLength = 0;
            this.InsertPassword.SelectionStart = 0;
            this.InsertPassword.ShortcutsEnabled = true;
            this.InsertPassword.Size = new System.Drawing.Size(210, 23);
            this.InsertPassword.TabIndex = 2;
            this.InsertPassword.UseSelectable = true;
            this.InsertPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.InsertPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MakePanel
            // 
            this.MakePanel.AutoSize = true;
            this.MakePanel.Controls.Add(this.metroCheckBox1);
            this.MakePanel.Controls.Add(this.metroLabel3);
            this.MakePanel.Controls.Add(this.metroLabel2);
            this.MakePanel.Controls.Add(this.metroLabel1);
            this.MakePanel.Controls.Add(this.MakeInvite);
            this.MakePanel.Controls.Add(this.MakeShowPassword);
            this.MakePanel.Controls.Add(this.MakePassword);
            this.MakePanel.Controls.Add(this.MakeName);
            this.MakePanel.Controls.Add(this.metroButton1);
            this.MakePanel.HorizontalScrollbarBarColor = true;
            this.MakePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.MakePanel.HorizontalScrollbarSize = 10;
            this.MakePanel.Location = new System.Drawing.Point(144, 241);
            this.MakePanel.Name = "MakePanel";
            this.MakePanel.Size = new System.Drawing.Size(540, 181);
            this.MakePanel.TabIndex = 6;
            this.MakePanel.VerticalScrollbarBarColor = true;
            this.MakePanel.VerticalScrollbarHighlightOnWheel = false;
            this.MakePanel.VerticalScrollbarSize = 10;
            this.MakePanel.Visible = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(213, 79);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(111, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "채팅방 비밀번호";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(213, 30);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(83, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "채팅방 이름";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(4, 8);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(83, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "초대할 사람";
            // 
            // MakeInvite
            // 
            this.MakeInvite.FormattingEnabled = true;
            this.MakeInvite.Location = new System.Drawing.Point(4, 30);
            this.MakeInvite.Name = "MakeInvite";
            this.MakeInvite.Size = new System.Drawing.Size(203, 148);
            this.MakeInvite.TabIndex = 6;
            // 
            // MakeShowPassword
            // 
            this.MakeShowPassword.AutoSize = true;
            this.MakeShowPassword.Location = new System.Drawing.Point(330, 83);
            this.MakeShowPassword.Name = "MakeShowPassword";
            this.MakeShowPassword.Size = new System.Drawing.Size(110, 15);
            this.MakeShowPassword.TabIndex = 5;
            this.MakeShowPassword.Text = "비밀번호 보이기";
            this.MakeShowPassword.UseSelectable = true;
            // 
            // MakePassword
            // 
            // 
            // 
            // 
            this.MakePassword.CustomButton.Image = null;
            this.MakePassword.CustomButton.Location = new System.Drawing.Point(221, 1);
            this.MakePassword.CustomButton.Name = "";
            this.MakePassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.MakePassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MakePassword.CustomButton.TabIndex = 1;
            this.MakePassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MakePassword.CustomButton.UseSelectable = true;
            this.MakePassword.CustomButton.Visible = false;
            this.MakePassword.Lines = new string[0];
            this.MakePassword.Location = new System.Drawing.Point(213, 101);
            this.MakePassword.MaxLength = 32767;
            this.MakePassword.Name = "MakePassword";
            this.MakePassword.PasswordChar = '\0';
            this.MakePassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MakePassword.SelectedText = "";
            this.MakePassword.SelectionLength = 0;
            this.MakePassword.SelectionStart = 0;
            this.MakePassword.ShortcutsEnabled = true;
            this.MakePassword.Size = new System.Drawing.Size(243, 23);
            this.MakePassword.TabIndex = 4;
            this.MakePassword.UseSelectable = true;
            this.MakePassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MakePassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MakeName
            // 
            // 
            // 
            // 
            this.MakeName.CustomButton.Image = null;
            this.MakeName.CustomButton.Location = new System.Drawing.Point(221, 1);
            this.MakeName.CustomButton.Name = "";
            this.MakeName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.MakeName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MakeName.CustomButton.TabIndex = 1;
            this.MakeName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MakeName.CustomButton.UseSelectable = true;
            this.MakeName.CustomButton.Visible = false;
            this.MakeName.Lines = new string[0];
            this.MakeName.Location = new System.Drawing.Point(213, 53);
            this.MakeName.MaxLength = 32767;
            this.MakeName.Name = "MakeName";
            this.MakeName.PasswordChar = '\0';
            this.MakeName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MakeName.SelectedText = "";
            this.MakeName.SelectionLength = 0;
            this.MakeName.SelectionStart = 0;
            this.MakeName.ShortcutsEnabled = true;
            this.MakeName.Size = new System.Drawing.Size(243, 23);
            this.MakeName.TabIndex = 3;
            this.MakeName.UseSelectable = true;
            this.MakeName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MakeName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(213, 130);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(243, 37);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "만들기";
            this.metroButton1.UseSelectable = true;
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(302, 32);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(235, 15);
            this.metroCheckBox1.TabIndex = 10;
            this.metroCheckBox1.Text = "채팅방 숨기기 (정확히 검색시에만 보임)";
            this.metroCheckBox1.UseSelectable = true;
            // 
            // Makeform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 427);
            this.Controls.Add(this.MakePanel);
            this.Controls.Add(this.InsertPanel);
            this.Controls.Add(this.Make);
            this.Controls.Add(this.Insert);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Makeform";
            this.Resizable = false;
            this.Text = "Makeform";
            this.Load += new System.EventHandler(this.Makeform_Load);
            this.InsertPanel.ResumeLayout(false);
            this.InsertPanel.PerformLayout();
            this.MakePanel.ResumeLayout(false);
            this.MakePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroRadioButton Insert;
        private MetroFramework.Controls.MetroRadioButton Make;
        private System.Windows.Forms.ListBox InsertChattingRooms;
        private MetroFramework.Controls.MetroPanel InsertPanel;
        private MetroFramework.Controls.MetroButton InsertRefresh;
        private MetroFramework.Controls.MetroTextBox InsertSearchword;
        private MetroFramework.Controls.MetroButton InsertInsert;
        private MetroFramework.Controls.MetroTextBox InsertPassword;
        private MetroFramework.Controls.MetroCheckBox InsertShowPassword;
        private MetroFramework.Controls.MetroPanel MakePanel;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.CheckedListBox MakeInvite;
        private MetroFramework.Controls.MetroCheckBox MakeShowPassword;
        private MetroFramework.Controls.MetroTextBox MakePassword;
        private MetroFramework.Controls.MetroTextBox MakeName;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
    }
}