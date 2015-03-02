namespace CaesarCipher
{
    partial class AboutProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutProgram));
            this.IconBox = new System.Windows.Forms.PictureBox();
            this.MainText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // IconBox
            // 
            this.IconBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.IconBox.Image = ((System.Drawing.Image)(resources.GetObject("IconBox.Image")));
            this.IconBox.Location = new System.Drawing.Point(0, 0);
            this.IconBox.Name = "IconBox";
            this.IconBox.Size = new System.Drawing.Size(264, 134);
            this.IconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.IconBox.TabIndex = 0;
            this.IconBox.TabStop = false;
            // 
            // MainText
            // 
            this.MainText.Location = new System.Drawing.Point(12, 163);
            this.MainText.Name = "MainText";
            this.MainText.Size = new System.Drawing.Size(240, 164);
            this.MainText.TabIndex = 1;
            this.MainText.Text = resources.GetString("MainText.Text");
            this.MainText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AboutProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 341);
            this.Controls.Add(this.MainText);
            this.Controls.Add(this.IconBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutProgram";
            this.ShowInTaskbar = false;
            this.Text = "About Program";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox IconBox;
        private System.Windows.Forms.Label MainText;
    }
}