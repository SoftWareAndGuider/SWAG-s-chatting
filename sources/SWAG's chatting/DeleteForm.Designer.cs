namespace SWAG_s_chatting
{
    partial class DeleteForm
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Search = new MetroFramework.Controls.MetroTextBox();
            this.Exit = new MetroFramework.Controls.MetroButton();
            this.List = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 81);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(37, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "검색";
            // 
            // Search
            // 
            // 
            // 
            // 
            this.Search.CustomButton.Image = null;
            this.Search.CustomButton.Location = new System.Drawing.Point(135, 1);
            this.Search.CustomButton.Name = "";
            this.Search.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Search.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Search.CustomButton.TabIndex = 1;
            this.Search.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Search.CustomButton.UseSelectable = true;
            this.Search.CustomButton.Visible = false;
            this.Search.Lines = new string[0];
            this.Search.Location = new System.Drawing.Point(66, 81);
            this.Search.MaxLength = 32767;
            this.Search.Name = "Search";
            this.Search.PasswordChar = '\0';
            this.Search.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Search.SelectedText = "";
            this.Search.SelectionLength = 0;
            this.Search.SelectionStart = 0;
            this.Search.ShortcutsEnabled = true;
            this.Search.Size = new System.Drawing.Size(157, 23);
            this.Search.TabIndex = 4;
            this.Search.UseSelectable = true;
            this.Search.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Search.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Exit
            // 
            this.Exit.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Exit.Location = new System.Drawing.Point(229, 81);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(124, 141);
            this.Exit.Style = MetroFramework.MetroColorStyle.Red;
            this.Exit.TabIndex = 5;
            this.Exit.Text = "나가기";
            this.Exit.UseSelectable = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // List
            // 
            this.List.FormattingEnabled = true;
            this.List.ItemHeight = 12;
            this.List.Location = new System.Drawing.Point(23, 110);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(200, 112);
            this.List.TabIndex = 6;
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 235);
            this.Controls.Add(this.List);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.metroLabel1);
            this.Name = "DeleteForm";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "채팅방 나가기";
            this.Load += new System.EventHandler(this.DeleteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox Search;
        private MetroFramework.Controls.MetroButton Exit;
        private System.Windows.Forms.ListBox List;
    }
}