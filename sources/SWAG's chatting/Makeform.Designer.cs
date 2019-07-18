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
            this.가입 = new MetroFramework.Controls.MetroRadioButton();
            this.제작 = new MetroFramework.Controls.MetroRadioButton();
            this.채팅방들 = new System.Windows.Forms.ListBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.비밀번호 = new MetroFramework.Controls.MetroTextBox();
            this.가입하기 = new MetroFramework.Controls.MetroButton();
            this.검색 = new MetroFramework.Controls.MetroTextBox();
            this.검색하기 = new MetroFramework.Controls.MetroButton();
            this.비밀번호보이기 = new MetroFramework.Controls.MetroCheckBox();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // 가입
            // 
            this.가입.AutoSize = true;
            this.가입.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.가입.Location = new System.Drawing.Point(23, 63);
            this.가입.Name = "가입";
            this.가입.Size = new System.Drawing.Size(100, 25);
            this.가입.TabIndex = 0;
            this.가입.Text = "가입하기";
            this.가입.UseSelectable = true;
            // 
            // 제작
            // 
            this.제작.AutoSize = true;
            this.제작.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.제작.Location = new System.Drawing.Point(23, 94);
            this.제작.Name = "제작";
            this.제작.Size = new System.Drawing.Size(82, 25);
            this.제작.TabIndex = 1;
            this.제작.Text = "만들기";
            this.제작.UseSelectable = true;
            // 
            // 채팅방들
            // 
            this.채팅방들.FormattingEnabled = true;
            this.채팅방들.ItemHeight = 12;
            this.채팅방들.Location = new System.Drawing.Point(3, 31);
            this.채팅방들.Name = "채팅방들";
            this.채팅방들.Size = new System.Drawing.Size(203, 100);
            this.채팅방들.TabIndex = 0;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.비밀번호보이기);
            this.metroPanel1.Controls.Add(this.검색하기);
            this.metroPanel1.Controls.Add(this.검색);
            this.metroPanel1.Controls.Add(this.가입하기);
            this.metroPanel1.Controls.Add(this.비밀번호);
            this.metroPanel1.Controls.Add(this.채팅방들);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(129, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(648, 142);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // 비밀번호
            // 
            // 
            // 
            // 
            this.비밀번호.CustomButton.Image = null;
            this.비밀번호.CustomButton.Location = new System.Drawing.Point(188, 1);
            this.비밀번호.CustomButton.Name = "";
            this.비밀번호.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.비밀번호.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.비밀번호.CustomButton.TabIndex = 1;
            this.비밀번호.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.비밀번호.CustomButton.UseSelectable = true;
            this.비밀번호.CustomButton.Visible = false;
            this.비밀번호.Lines = new string[0];
            this.비밀번호.Location = new System.Drawing.Point(245, 3);
            this.비밀번호.MaxLength = 32767;
            this.비밀번호.Name = "비밀번호";
            this.비밀번호.PasswordChar = '\0';
            this.비밀번호.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.비밀번호.SelectedText = "";
            this.비밀번호.SelectionLength = 0;
            this.비밀번호.SelectionStart = 0;
            this.비밀번호.ShortcutsEnabled = true;
            this.비밀번호.Size = new System.Drawing.Size(210, 23);
            this.비밀번호.TabIndex = 2;
            this.비밀번호.UseSelectable = true;
            this.비밀번호.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.비밀번호.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // 가입하기
            // 
            this.가입하기.Location = new System.Drawing.Point(245, 52);
            this.가입하기.Name = "가입하기";
            this.가입하기.Size = new System.Drawing.Size(210, 79);
            this.가입하기.TabIndex = 3;
            this.가입하기.Text = "가입하기";
            this.가입하기.UseSelectable = true;
            // 
            // 검색
            // 
            // 
            // 
            // 
            this.검색.CustomButton.Image = null;
            this.검색.CustomButton.Location = new System.Drawing.Point(100, 1);
            this.검색.CustomButton.Name = "";
            this.검색.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.검색.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.검색.CustomButton.TabIndex = 1;
            this.검색.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.검색.CustomButton.UseSelectable = true;
            this.검색.CustomButton.Visible = false;
            this.검색.Lines = new string[0];
            this.검색.Location = new System.Drawing.Point(3, 3);
            this.검색.MaxLength = 32767;
            this.검색.Name = "검색";
            this.검색.PasswordChar = '\0';
            this.검색.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.검색.SelectedText = "";
            this.검색.SelectionLength = 0;
            this.검색.SelectionStart = 0;
            this.검색.ShortcutsEnabled = true;
            this.검색.Size = new System.Drawing.Size(122, 23);
            this.검색.TabIndex = 3;
            this.검색.UseSelectable = true;
            this.검색.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.검색.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // 검색하기
            // 
            this.검색하기.Location = new System.Drawing.Point(131, 3);
            this.검색하기.Name = "검색하기";
            this.검색하기.Size = new System.Drawing.Size(75, 23);
            this.검색하기.TabIndex = 4;
            this.검색하기.Text = "검색하기";
            this.검색하기.UseSelectable = true;
            // 
            // 비밀번호보이기
            // 
            this.비밀번호보이기.AutoSize = true;
            this.비밀번호보이기.Location = new System.Drawing.Point(245, 31);
            this.비밀번호보이기.Name = "비밀번호보이기";
            this.비밀번호보이기.Size = new System.Drawing.Size(110, 15);
            this.비밀번호보이기.TabIndex = 5;
            this.비밀번호보이기.Text = "비밀번호 보이기";
            this.비밀번호보이기.UseSelectable = true;
            // 
            // Makeform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 236);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.제작);
            this.Controls.Add(this.가입);
            this.Name = "Makeform";
            this.Text = "Makeform";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroRadioButton 가입;
        private MetroFramework.Controls.MetroRadioButton 제작;
        private System.Windows.Forms.ListBox 채팅방들;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton 검색하기;
        private MetroFramework.Controls.MetroTextBox 검색;
        private MetroFramework.Controls.MetroButton 가입하기;
        private MetroFramework.Controls.MetroTextBox 비밀번호;
        private MetroFramework.Controls.MetroCheckBox 비밀번호보이기;
    }
}