namespace CaesarCipher
{
    partial class AboutCopyright
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutCopyright));
            this.CopyrightDetails = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CopyrightDetails
            // 
            this.CopyrightDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CopyrightDetails.Location = new System.Drawing.Point(0, 0);
            this.CopyrightDetails.Name = "CopyrightDetails";
            this.CopyrightDetails.Size = new System.Drawing.Size(429, 248);
            this.CopyrightDetails.TabIndex = 0;
            this.CopyrightDetails.Text = resources.GetString("CopyrightDetails.Text");
            this.CopyrightDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AboutCopyright
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 248);
            this.Controls.Add(this.CopyrightDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutCopyright";
            this.ShowInTaskbar = false;
            this.Text = "Copyright Details";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CopyrightDetails;
    }
}