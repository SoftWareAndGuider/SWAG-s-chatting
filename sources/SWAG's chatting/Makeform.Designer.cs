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
            this.Insert = new MetroFramework.Controls.MetroRadioButton();
            this.Make = new MetroFramework.Controls.MetroRadioButton();
            this.InsertChattingRooms = new System.Windows.Forms.ListBox();
            this.InsertPanel = new MetroFramework.Controls.MetroPanel();
            this.InsertShowPassword = new MetroFramework.Controls.MetroCheckBox();
            this.InsertSearch = new MetroFramework.Controls.MetroButton();
            this.InsertSearchword = new MetroFramework.Controls.MetroTextBox();
            this.InsertInsert = new MetroFramework.Controls.MetroButton();
            this.InsertPassword = new MetroFramework.Controls.MetroTextBox();
            this.MakePanel = new MetroFramework.Controls.MetroPanel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.MakeName = new MetroFramework.Controls.MetroTextBox();
            this.MakePassword = new MetroFramework.Controls.MetroTextBox();
            this.MakeShowPassword = new MetroFramework.Controls.MetroCheckBox();
            this.MakeInvite = new System.Windows.Forms.CheckedListBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
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
            this.Make.Location = new System.Drawing.Point(23, 94);
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
            this.InsertChattingRooms.Location = new System.Drawing.Point(3, 31);
            this.InsertChattingRooms.Name = "InsertChattingRooms";
            this.InsertChattingRooms.Size = new System.Drawing.Size(203, 100);
            this.InsertChattingRooms.TabIndex = 0;
            // 
            // InsertPanel
            // 
            this.InsertPanel.Controls.Add(this.InsertShowPassword);
            this.InsertPanel.Controls.Add(this.InsertSearch);
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
            // InsertShowPassword
            // 
            this.InsertShowPassword.AutoSize = true;
            this.InsertShowPassword.Location = new System.Drawing.Point(245, 31);
            this.InsertShowPassword.Name = "InsertShowPassword";
            this.InsertShowPassword.Size = new System.Drawing.Size(110, 15);
            this.InsertShowPassword.TabIndex = 5;
            this.InsertShowPassword.Text = "비밀번호 보이기";
            this.InsertShowPassword.UseSelectable = true;
            // 
            // InsertSearch
            // 
            this.InsertSearch.Location = new System.Drawing.Point(131, 3);
            this.InsertSearch.Name = "InsertSearch";
            this.InsertSearch.Size = new System.Drawing.Size(75, 23);
            this.InsertSearch.TabIndex = 4;
            this.InsertSearch.Text = "검색";
            this.InsertSearch.UseSelectable = true;
            // 
            // InsertSearchword
            // 
            // 
            // 
            // 
            this.InsertSearchword.CustomButton.Image = null;
            this.InsertSearchword.CustomButton.Location = new System.Drawing.Point(100, 1);
            this.InsertSearchword.CustomButton.Name = "";
            this.InsertSearchword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.InsertSearchword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.InsertSearchword.CustomButton.TabIndex = 1;
            this.InsertSearchword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.InsertSearchword.CustomButton.UseSelectable = true;
            this.InsertSearchword.CustomButton.Visible = false;
            this.InsertSearchword.Lines = new string[0];
            this.InsertSearchword.Location = new System.Drawing.Point(3, 3);
            this.InsertSearchword.MaxLength = 32767;
            this.InsertSearchword.Name = "InsertSearchword";
            this.InsertSearchword.PasswordChar = '\0';
            this.InsertSearchword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.InsertSearchword.SelectedText = "";
            this.InsertSearchword.SelectionLength = 0;
            this.InsertSearchword.SelectionStart = 0;
            this.InsertSearchword.ShortcutsEnabled = true;
            this.InsertSearchword.Size = new System.Drawing.Size(122, 23);
            this.InsertSearchword.TabIndex = 3;
            this.InsertSearchword.UseSelectable = true;
            this.InsertSearchword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.InsertSearchword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // InsertInsert
            // 
            this.InsertInsert.Location = new System.Drawing.Point(245, 52);
            this.InsertInsert.Name = "InsertInsert";
            this.InsertInsert.Size = new System.Drawing.Size(210, 79);
            this.InsertInsert.TabIndex = 3;
            this.InsertInsert.Text = "가입하기";
            this.InsertInsert.UseSelectable = true;
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
            this.InsertPassword.Location = new System.Drawing.Point(245, 3);
            this.InsertPassword.MaxLength = 32767;
            this.InsertPassword.Name = "InsertPassword";
            this.InsertPassword.PasswordChar = '\0';
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
            this.MakePanel.Location = new System.Drawing.Point(144, 42);
            this.MakePanel.Name = "MakePanel";
            this.MakePanel.Size = new System.Drawing.Size(477, 181);
            this.MakePanel.TabIndex = 6;
            this.MakePanel.VerticalScrollbarBarColor = true;
            this.MakePanel.VerticalScrollbarHighlightOnWheel = false;
            this.MakePanel.VerticalScrollbarSize = 10;
            this.MakePanel.Visible = false;
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
            // MakeInvite
            // 
            this.MakeInvite.FormattingEnabled = true;
            this.MakeInvite.Location = new System.Drawing.Point(4, 30);
            this.MakeInvite.Name = "MakeInvite";
            this.MakeInvite.Size = new System.Drawing.Size(203, 148);
            this.MakeInvite.TabIndex = 6;
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
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(213, 30);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(83, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "채팅방 이름";
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
            // Makeform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 251);
            this.Controls.Add(this.MakePanel);
            this.Controls.Add(this.InsertPanel);
            this.Controls.Add(this.Make);
            this.Controls.Add(this.Insert);
            this.Name = "Makeform";
            this.Text = "Makeform";
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
        private MetroFramework.Controls.MetroButton InsertSearch;
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
    }
}