namespace SWAG_s_chatting
{
    partial class SignUpForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PW = new System.Windows.Forms.TextBox();
            this.CPW = new System.Windows.Forms.TextBox();
            this.NM = new System.Windows.Forms.TextBox();
            this.SW = new System.Windows.Forms.TextBox();
            this.SignUp = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "비밀번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "비밀번호 확인";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(12, 28);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(149, 21);
            this.ID.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "별명";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "비밀번호 찾기용 비밀 단어";
            // 
            // PW
            // 
            this.PW.Location = new System.Drawing.Point(12, 78);
            this.PW.Name = "PW";
            this.PW.PasswordChar = '*';
            this.PW.Size = new System.Drawing.Size(149, 21);
            this.PW.TabIndex = 7;
            // 
            // CPW
            // 
            this.CPW.Location = new System.Drawing.Point(12, 128);
            this.CPW.Name = "CPW";
            this.CPW.PasswordChar = '*';
            this.CPW.Size = new System.Drawing.Size(149, 21);
            this.CPW.TabIndex = 8;
            // 
            // NM
            // 
            this.NM.Location = new System.Drawing.Point(12, 178);
            this.NM.Name = "NM";
            this.NM.Size = new System.Drawing.Size(149, 21);
            this.NM.TabIndex = 9;
            // 
            // SW
            // 
            this.SW.Location = new System.Drawing.Point(12, 228);
            this.SW.Name = "SW";
            this.SW.Size = new System.Drawing.Size(149, 21);
            this.SW.TabIndex = 10;
            // 
            // SignUp
            // 
            this.SignUp.Location = new System.Drawing.Point(14, 263);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(147, 42);
            this.SignUp.TabIndex = 11;
            this.SignUp.Text = "회원가입!";
            this.SignUp.UseSelectable = true;
            this.SignUp.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(178, 317);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.SW);
            this.Controls.Add(this.NM);
            this.Controls.Add(this.CPW);
            this.Controls.Add(this.PW);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PW;
        private System.Windows.Forms.TextBox CPW;
        private System.Windows.Forms.TextBox NM;
        private System.Windows.Forms.TextBox SW;
        private MetroFramework.Controls.MetroButton SignUp;
    }
}