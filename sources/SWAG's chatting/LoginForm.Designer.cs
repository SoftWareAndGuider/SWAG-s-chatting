﻿namespace SWAG_s_chatting
{
    partial class LoginForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.Login = new MetroFramework.Controls.MetroButton();
            this.InsertID = new MetroFramework.Controls.MetroTextBox();
            this.InsertPW = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.RSP = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.Lime;
            this.Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Login.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.Login.ForeColor = System.Drawing.SystemColors.Control;
            this.Login.Location = new System.Drawing.Point(232, 12);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(113, 52);
            this.Login.Style = MetroFramework.MetroColorStyle.Green;
            this.Login.TabIndex = 2;
            this.Login.Text = "로그인";
            this.Login.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Login.UseCustomBackColor = true;
            this.Login.UseSelectable = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // InsertID
            // 
            // 
            // 
            // 
            this.InsertID.CustomButton.Image = null;
            this.InsertID.CustomButton.Location = new System.Drawing.Point(192, 1);
            this.InsertID.CustomButton.Name = "";
            this.InsertID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.InsertID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.InsertID.CustomButton.TabIndex = 1;
            this.InsertID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.InsertID.CustomButton.UseSelectable = true;
            this.InsertID.CustomButton.Visible = false;
            this.InsertID.Lines = new string[0];
            this.InsertID.Location = new System.Drawing.Point(12, 12);
            this.InsertID.MaxLength = 32767;
            this.InsertID.Name = "InsertID";
            this.InsertID.PasswordChar = '\0';
            this.InsertID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.InsertID.SelectedText = "";
            this.InsertID.SelectionLength = 0;
            this.InsertID.SelectionStart = 0;
            this.InsertID.ShortcutsEnabled = true;
            this.InsertID.Size = new System.Drawing.Size(214, 23);
            this.InsertID.TabIndex = 0;
            this.InsertID.Theme = MetroFramework.MetroThemeStyle.Light;
            this.InsertID.UseSelectable = true;
            this.InsertID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.InsertID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.InsertID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InsertID_KeyDown);
            // 
            // InsertPW
            // 
            // 
            // 
            // 
            this.InsertPW.CustomButton.Image = null;
            this.InsertPW.CustomButton.Location = new System.Drawing.Point(192, 1);
            this.InsertPW.CustomButton.Name = "";
            this.InsertPW.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.InsertPW.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.InsertPW.CustomButton.TabIndex = 1;
            this.InsertPW.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.InsertPW.CustomButton.UseSelectable = true;
            this.InsertPW.CustomButton.Visible = false;
            this.InsertPW.Lines = new string[0];
            this.InsertPW.Location = new System.Drawing.Point(12, 41);
            this.InsertPW.MaxLength = 32767;
            this.InsertPW.Name = "InsertPW";
            this.InsertPW.PasswordChar = '*';
            this.InsertPW.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.InsertPW.SelectedText = "";
            this.InsertPW.SelectionLength = 0;
            this.InsertPW.SelectionStart = 0;
            this.InsertPW.ShortcutsEnabled = true;
            this.InsertPW.Size = new System.Drawing.Size(214, 23);
            this.InsertPW.TabIndex = 1;
            this.InsertPW.Theme = MetroFramework.MetroThemeStyle.Light;
            this.InsertPW.UseSelectable = true;
            this.InsertPW.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.InsertPW.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.InsertPW.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InsertPW_KeyDown);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.Yellow;
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.metroButton1.Location = new System.Drawing.Point(351, 12);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(113, 52);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "회원 가입";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.MetroButton1_Click);
            // 
            // RSP
            // 
            this.RSP.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RSP.AutoSize = true;
            this.RSP.Location = new System.Drawing.Point(12, 73);
            this.RSP.Name = "RSP";
            this.RSP.Size = new System.Drawing.Size(81, 12);
            this.RSP.TabIndex = 4;
            this.RSP.TabStop = true;
            this.RSP.Text = "비밀번호 찾기";
            this.RSP.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RSP_LinkClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 94);
            this.Controls.Add(this.RSP);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.InsertPW);
            this.Controls.Add(this.InsertID);
            this.Controls.Add(this.Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton Login;
        private MetroFramework.Controls.MetroTextBox InsertID;
        private MetroFramework.Controls.MetroTextBox InsertPW;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.LinkLabel RSP;
    }
}

