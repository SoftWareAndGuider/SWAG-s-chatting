namespace SWAG_s_chatting
{
    partial class EditForm
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
            this.PW = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SW = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CPW = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PPW = new System.Windows.Forms.TextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // PW
            // 
            this.PW.Location = new System.Drawing.Point(25, 91);
            this.PW.Name = "PW";
            this.PW.PasswordChar = '*';
            this.PW.Size = new System.Drawing.Size(261, 21);
            this.PW.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(21, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "비밀번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label2.Location = new System.Drawing.Point(21, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "별명";
            // 
            // NM
            // 
            this.NM.Location = new System.Drawing.Point(25, 207);
            this.NM.Name = "NM";
            this.NM.Size = new System.Drawing.Size(261, 21);
            this.NM.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label3.Location = new System.Drawing.Point(21, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "비밀 단어";
            // 
            // SW
            // 
            this.SW.Location = new System.Drawing.Point(25, 264);
            this.SW.Name = "SW";
            this.SW.Size = new System.Drawing.Size(261, 21);
            this.SW.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(21, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "비밀번호 확인";
            // 
            // CPW
            // 
            this.CPW.Location = new System.Drawing.Point(25, 150);
            this.CPW.Name = "CPW";
            this.CPW.PasswordChar = '*';
            this.CPW.Size = new System.Drawing.Size(261, 21);
            this.CPW.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(21, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "현재 비밀번호";
            // 
            // PPW
            // 
            this.PPW.Location = new System.Drawing.Point(25, 324);
            this.PPW.Name = "PPW";
            this.PPW.PasswordChar = '*';
            this.PPW.Size = new System.Drawing.Size(261, 21);
            this.PPW.TabIndex = 9;
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.Location = new System.Drawing.Point(26, 363);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(260, 50);
            this.metroButton1.TabIndex = 10;
            this.metroButton1.Text = "적용";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.MetroButton1_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 427);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.PPW);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CPW);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SW);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PW);
            this.Name = "EditForm";
            this.Style = MetroFramework.MetroColorStyle.Brown;
            this.Text = "내 정보 수정";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SW;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CPW;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PPW;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}