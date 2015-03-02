namespace CaesarCipher
{
    partial class AboutHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutHelp));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LebelEncodeHelp = new System.Windows.Forms.Label();
            this.LabelDecodeHelp = new System.Windows.Forms.Label();
            this.LabelCopyrightHelp = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(622, 340);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LebelEncodeHelp
            // 
            this.LebelEncodeHelp.BackColor = System.Drawing.Color.Transparent;
            this.LebelEncodeHelp.Location = new System.Drawing.Point(6, 18);
            this.LebelEncodeHelp.Name = "LebelEncodeHelp";
            this.LebelEncodeHelp.Size = new System.Drawing.Size(277, 179);
            this.LebelEncodeHelp.TabIndex = 1;
            this.LebelEncodeHelp.Text = resources.GetString("LebelEncodeHelp.Text");
            // 
            // LabelDecodeHelp
            // 
            this.LabelDecodeHelp.BackColor = System.Drawing.Color.Transparent;
            this.LabelDecodeHelp.Location = new System.Drawing.Point(8, 18);
            this.LabelDecodeHelp.Name = "LabelDecodeHelp";
            this.LabelDecodeHelp.Size = new System.Drawing.Size(266, 144);
            this.LabelDecodeHelp.TabIndex = 2;
            this.LabelDecodeHelp.Text = resources.GetString("LabelDecodeHelp.Text");
            // 
            // LabelCopyrightHelp
            // 
            this.LabelCopyrightHelp.AutoSize = true;
            this.LabelCopyrightHelp.Location = new System.Drawing.Point(466, 529);
            this.LabelCopyrightHelp.Name = "LabelCopyrightHelp";
            this.LabelCopyrightHelp.Size = new System.Drawing.Size(153, 13);
            this.LabelCopyrightHelp.TabIndex = 3;
            this.LabelCopyrightHelp.Text = "Copyright (C) 2014 Daren Lobo";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.LebelEncodeHelp);
            this.groupBox1.Location = new System.Drawing.Point(9, 346);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 176);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encode";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.LabelDecodeHelp);
            this.groupBox2.Location = new System.Drawing.Point(330, 346);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 176);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Decode";
            // 
            // AboutHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 545);
            this.Controls.Add(this.LabelCopyrightHelp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutHelp";
            this.ShowInTaskbar = false;
            this.Text = "Help";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LebelEncodeHelp;
        private System.Windows.Forms.Label LabelDecodeHelp;
        private System.Windows.Forms.Label LabelCopyrightHelp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}