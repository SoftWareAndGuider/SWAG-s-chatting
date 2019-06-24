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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.InsertURL = new MetroFramework.Controls.MetroTextBox();
            this.Back = new MetroFramework.Controls.MetroButton();
            this.Next = new MetroFramework.Controls.MetroButton();
            this.Go = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(24, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(126, 292);
            this.listBox1.TabIndex = 0;
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
            this.InsertURL.Lines = new string[0];
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
            this.Go.Text = "이동";
            this.Go.UseSelectable = true;
            this.Go.Click += new System.EventHandler(this.Go_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 669);
            this.Controls.Add(this.Go);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.InsertURL);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("굴림", 9F);
            this.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.Name = "Mainform";
            this.Padding = new System.Windows.Forms.Padding(21, 60, 21, 18);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mainform_FormClosing);
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private MetroFramework.Controls.MetroTextBox InsertURL;
        private MetroFramework.Controls.MetroButton Back;
        private MetroFramework.Controls.MetroButton Next;
        private MetroFramework.Controls.MetroButton Go;
    }
}