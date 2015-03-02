namespace CaesarCipher
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Encode_copytext = new System.Windows.Forms.Button();
            this.Encode_OutputBox = new System.Windows.Forms.TextBox();
            this.EncodeSubmit = new System.Windows.Forms.Button();
            this.Encode_InputBox = new System.Windows.Forms.TextBox();
            this.Encode_IncrementBox = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Decode_copytext = new System.Windows.Forms.Button();
            this.Decode_OutputBox = new System.Windows.Forms.TextBox();
            this.Decode_DecrementBox = new System.Windows.Forms.NumericUpDown();
            this.DecodeSubmit = new System.Windows.Forms.Button();
            this.Decode_InputBox = new System.Windows.Forms.TextBox();
            this.abouToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutCaesarsCipherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wikipediaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutThisProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caesarsCipherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTheCreatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyrightCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exampleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vanillaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geekToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.azureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forecolorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backcolorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Line1 = new System.Windows.Forms.Label();
            this.colorDialogForeColor = new System.Windows.Forms.ColorDialog();
            this.colorDialogBackColor = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Encode_IncrementBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Decode_DecrementBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Encode_copytext);
            this.groupBox1.Controls.Add(this.Encode_OutputBox);
            this.groupBox1.Controls.Add(this.EncodeSubmit);
            this.groupBox1.Controls.Add(this.Encode_InputBox);
            this.groupBox1.Controls.Add(this.Encode_IncrementBox);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(274, 248);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encode";
            // 
            // Encode_copytext
            // 
            this.Encode_copytext.Location = new System.Drawing.Point(16, 219);
            this.Encode_copytext.Name = "Encode_copytext";
            this.Encode_copytext.Size = new System.Drawing.Size(252, 23);
            this.Encode_copytext.TabIndex = 7;
            this.Encode_copytext.Text = "Copy to clipboard";
            this.Encode_copytext.UseVisualStyleBackColor = true;
            this.Encode_copytext.Click += new System.EventHandler(this.Encode_copytext_Click);
            // 
            // Encode_OutputBox
            // 
            this.Encode_OutputBox.BackColor = System.Drawing.SystemColors.Window;
            this.Encode_OutputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Encode_OutputBox.ForeColor = System.Drawing.Color.Black;
            this.Encode_OutputBox.Location = new System.Drawing.Point(16, 74);
            this.Encode_OutputBox.Multiline = true;
            this.Encode_OutputBox.Name = "Encode_OutputBox";
            this.Encode_OutputBox.ReadOnly = true;
            this.Encode_OutputBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Encode_OutputBox.Size = new System.Drawing.Size(252, 140);
            this.Encode_OutputBox.TabIndex = 6;
            this.Encode_OutputBox.Text = "This box displays the encoded message.";
            // 
            // EncodeSubmit
            // 
            this.EncodeSubmit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.EncodeSubmit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.EncodeSubmit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EncodeSubmit.Location = new System.Drawing.Point(193, 45);
            this.EncodeSubmit.Name = "EncodeSubmit";
            this.EncodeSubmit.Size = new System.Drawing.Size(75, 23);
            this.EncodeSubmit.TabIndex = 5;
            this.EncodeSubmit.Text = "Encode";
            this.EncodeSubmit.UseVisualStyleBackColor = true;
            this.EncodeSubmit.Click += new System.EventHandler(this.EncodeSubmit_Click);
            // 
            // Encode_InputBox
            // 
            this.Encode_InputBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.Encode_InputBox.Location = new System.Drawing.Point(16, 19);
            this.Encode_InputBox.Multiline = true;
            this.Encode_InputBox.Name = "Encode_InputBox";
            this.Encode_InputBox.Size = new System.Drawing.Size(252, 20);
            this.Encode_InputBox.TabIndex = 3;
            this.Encode_InputBox.Text = "enter text to be encoded.";
            this.Encode_InputBox.TextChanged += new System.EventHandler(this.Encode_InputBox_TextChanged);
            // 
            // Encode_IncrementBox
            // 
            this.Encode_IncrementBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.Encode_IncrementBox.Location = new System.Drawing.Point(16, 48);
            this.Encode_IncrementBox.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.Encode_IncrementBox.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            -2147483648});
            this.Encode_IncrementBox.Name = "Encode_IncrementBox";
            this.Encode_IncrementBox.Size = new System.Drawing.Size(120, 20);
            this.Encode_IncrementBox.TabIndex = 2;
            this.Encode_IncrementBox.ValueChanged += new System.EventHandler(this.Encode_IncrementBox_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.Decode_copytext);
            this.groupBox2.Controls.Add(this.Decode_OutputBox);
            this.groupBox2.Controls.Add(this.Decode_DecrementBox);
            this.groupBox2.Controls.Add(this.DecodeSubmit);
            this.groupBox2.Controls.Add(this.Decode_InputBox);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(308, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(274, 248);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Decode";
            // 
            // Decode_copytext
            // 
            this.Decode_copytext.Location = new System.Drawing.Point(17, 219);
            this.Decode_copytext.Name = "Decode_copytext";
            this.Decode_copytext.Size = new System.Drawing.Size(251, 23);
            this.Decode_copytext.TabIndex = 8;
            this.Decode_copytext.Text = "Copy to clipboard";
            this.Decode_copytext.UseVisualStyleBackColor = true;
            this.Decode_copytext.Click += new System.EventHandler(this.Decode_copytext_Click);
            // 
            // Decode_OutputBox
            // 
            this.Decode_OutputBox.BackColor = System.Drawing.SystemColors.Window;
            this.Decode_OutputBox.ForeColor = System.Drawing.Color.Black;
            this.Decode_OutputBox.Location = new System.Drawing.Point(17, 74);
            this.Decode_OutputBox.Multiline = true;
            this.Decode_OutputBox.Name = "Decode_OutputBox";
            this.Decode_OutputBox.ReadOnly = true;
            this.Decode_OutputBox.Size = new System.Drawing.Size(251, 140);
            this.Decode_OutputBox.TabIndex = 4;
            this.Decode_OutputBox.Text = "This box displays the decoded message.";
            // 
            // Decode_DecrementBox
            // 
            this.Decode_DecrementBox.BackColor = System.Drawing.SystemColors.Window;
            this.Decode_DecrementBox.ForeColor = System.Drawing.Color.Black;
            this.Decode_DecrementBox.Location = new System.Drawing.Point(17, 48);
            this.Decode_DecrementBox.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.Decode_DecrementBox.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            -2147483648});
            this.Decode_DecrementBox.Name = "Decode_DecrementBox";
            this.Decode_DecrementBox.Size = new System.Drawing.Size(120, 20);
            this.Decode_DecrementBox.TabIndex = 2;
            this.Decode_DecrementBox.ValueChanged += new System.EventHandler(this.Decode_DecrementBox_ValueChanged);
            // 
            // DecodeSubmit
            // 
            this.DecodeSubmit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DecodeSubmit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DecodeSubmit.ForeColor = System.Drawing.Color.Black;
            this.DecodeSubmit.Location = new System.Drawing.Point(193, 45);
            this.DecodeSubmit.Name = "DecodeSubmit";
            this.DecodeSubmit.Size = new System.Drawing.Size(75, 23);
            this.DecodeSubmit.TabIndex = 1;
            this.DecodeSubmit.Text = "Decode";
            this.DecodeSubmit.UseVisualStyleBackColor = true;
            this.DecodeSubmit.Click += new System.EventHandler(this.DecodeSubmit_Click);
            // 
            // Decode_InputBox
            // 
            this.Decode_InputBox.BackColor = System.Drawing.SystemColors.Window;
            this.Decode_InputBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.Decode_InputBox.ForeColor = System.Drawing.Color.Black;
            this.Decode_InputBox.Location = new System.Drawing.Point(17, 19);
            this.Decode_InputBox.Multiline = true;
            this.Decode_InputBox.Name = "Decode_InputBox";
            this.Decode_InputBox.Size = new System.Drawing.Size(251, 20);
            this.Decode_InputBox.TabIndex = 0;
            this.Decode_InputBox.Text = "enter text to be decoded.";
            this.Decode_InputBox.TextChanged += new System.EventHandler(this.Decode_InputBox_TextChanged);
            // 
            // abouToolStripMenuItem
            // 
            this.abouToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutCaesarsCipherToolStripMenuItem,
            this.aboutThisProgramToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.abouToolStripMenuItem.Name = "abouToolStripMenuItem";
            this.abouToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.abouToolStripMenuItem.Text = "About";
            this.abouToolStripMenuItem.Click += new System.EventHandler(this.abouToolStripMenuItem_Click);
            // 
            // aboutCaesarsCipherToolStripMenuItem
            // 
            this.aboutCaesarsCipherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wikipediaToolStripMenuItem});
            this.aboutCaesarsCipherToolStripMenuItem.Name = "aboutCaesarsCipherToolStripMenuItem";
            this.aboutCaesarsCipherToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutCaesarsCipherToolStripMenuItem.Text = "About Caesar\'s Shift";
            this.aboutCaesarsCipherToolStripMenuItem.Click += new System.EventHandler(this.aboutCaesarsCipherToolStripMenuItem_Click);
            // 
            // wikipediaToolStripMenuItem
            // 
            this.wikipediaToolStripMenuItem.Name = "wikipediaToolStripMenuItem";
            this.wikipediaToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.wikipediaToolStripMenuItem.Text = "Wikipedia";
            this.wikipediaToolStripMenuItem.Click += new System.EventHandler(this.wikipediaToolStripMenuItem_Click);
            // 
            // aboutThisProgramToolStripMenuItem
            // 
            this.aboutThisProgramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caesarsCipherToolStripMenuItem,
            this.aboutTheCreatorToolStripMenuItem,
            this.copyrightCToolStripMenuItem});
            this.aboutThisProgramToolStripMenuItem.Name = "aboutThisProgramToolStripMenuItem";
            this.aboutThisProgramToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutThisProgramToolStripMenuItem.Text = "About this Program";
            this.aboutThisProgramToolStripMenuItem.Click += new System.EventHandler(this.aboutThisProgramToolStripMenuItem_Click);
            // 
            // caesarsCipherToolStripMenuItem
            // 
            this.caesarsCipherToolStripMenuItem.Name = "caesarsCipherToolStripMenuItem";
            this.caesarsCipherToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.caesarsCipherToolStripMenuItem.Text = "Caesar\'s Cipher";
            this.caesarsCipherToolStripMenuItem.Click += new System.EventHandler(this.caesarsCipherToolStripMenuItem_Click);
            // 
            // aboutTheCreatorToolStripMenuItem
            // 
            this.aboutTheCreatorToolStripMenuItem.Name = "aboutTheCreatorToolStripMenuItem";
            this.aboutTheCreatorToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.aboutTheCreatorToolStripMenuItem.Text = "The Creator";
            this.aboutTheCreatorToolStripMenuItem.Click += new System.EventHandler(this.aboutTheCreatorToolStripMenuItem_Click);
            // 
            // copyrightCToolStripMenuItem
            // 
            this.copyrightCToolStripMenuItem.Name = "copyrightCToolStripMenuItem";
            this.copyrightCToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.copyrightCToolStripMenuItem.Text = "Copyright (C)";
            this.copyrightCToolStripMenuItem.Click += new System.EventHandler(this.copyrightCToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exampleToolStripMenuItem,
            this.themesToolStripMenuItem1,
            this.generalToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.helpToolStripMenuItem.Text = "Help...";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // exampleToolStripMenuItem
            // 
            this.exampleToolStripMenuItem.Name = "exampleToolStripMenuItem";
            this.exampleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exampleToolStripMenuItem.Text = "Example";
            this.exampleToolStripMenuItem.Click += new System.EventHandler(this.exampleToolStripMenuItem_Click);
            // 
            // themesToolStripMenuItem1
            // 
            this.themesToolStripMenuItem1.Name = "themesToolStripMenuItem1";
            this.themesToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.themesToolStripMenuItem1.Text = "Themes";
            this.themesToolStripMenuItem1.Click += new System.EventHandler(this.themesToolStripMenuItem1_Click);
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.generalToolStripMenuItem.Text = "General";
            this.generalToolStripMenuItem.Click += new System.EventHandler(this.generalToolStripMenuItem_Click);
            // 
            // themesToolStripMenuItem
            // 
            this.themesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vanillaToolStripMenuItem,
            this.geekToolStripMenuItem1,
            this.azureToolStripMenuItem,
            this.customToolStripMenuItem});
            this.themesToolStripMenuItem.Name = "themesToolStripMenuItem";
            this.themesToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.themesToolStripMenuItem.Text = "Theme";
            this.themesToolStripMenuItem.Click += new System.EventHandler(this.themesToolStripMenuItem_Click);
            // 
            // vanillaToolStripMenuItem
            // 
            this.vanillaToolStripMenuItem.Name = "vanillaToolStripMenuItem";
            this.vanillaToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.vanillaToolStripMenuItem.Text = "Vanilla";
            this.vanillaToolStripMenuItem.Click += new System.EventHandler(this.vanillaToolStripMenuItem_Click);
            // 
            // geekToolStripMenuItem1
            // 
            this.geekToolStripMenuItem1.Name = "geekToolStripMenuItem1";
            this.geekToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.geekToolStripMenuItem1.Text = "Hacker";
            this.geekToolStripMenuItem1.Click += new System.EventHandler(this.geekToolStripMenuItem1_Click);
            // 
            // azureToolStripMenuItem
            // 
            this.azureToolStripMenuItem.Name = "azureToolStripMenuItem";
            this.azureToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.azureToolStripMenuItem.Text = "Azure";
            this.azureToolStripMenuItem.Click += new System.EventHandler(this.azureToolStripMenuItem_Click);
            // 
            // customToolStripMenuItem
            // 
            this.customToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forecolorToolStripMenuItem,
            this.backcolorToolStripMenuItem,
            this.applyToolStripMenuItem});
            this.customToolStripMenuItem.Name = "customToolStripMenuItem";
            this.customToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.customToolStripMenuItem.Text = "Custom";
            this.customToolStripMenuItem.Click += new System.EventHandler(this.customToolStripMenuItem_Click);
            // 
            // forecolorToolStripMenuItem
            // 
            this.forecolorToolStripMenuItem.Name = "forecolorToolStripMenuItem";
            this.forecolorToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.forecolorToolStripMenuItem.Text = "Fore color";
            this.forecolorToolStripMenuItem.Click += new System.EventHandler(this.forecolorToolStripMenuItem_Click);
            // 
            // backcolorToolStripMenuItem
            // 
            this.backcolorToolStripMenuItem.Name = "backcolorToolStripMenuItem";
            this.backcolorToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.backcolorToolStripMenuItem.Text = "Back color";
            this.backcolorToolStripMenuItem.Click += new System.EventHandler(this.backcolorToolStripMenuItem_Click);
            // 
            // applyToolStripMenuItem
            // 
            this.applyToolStripMenuItem.Name = "applyToolStripMenuItem";
            this.applyToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.applyToolStripMenuItem.Text = "Apply";
            this.applyToolStripMenuItem.Click += new System.EventHandler(this.applyToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abouToolStripMenuItem,
            this.themesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(594, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // Line1
            // 
            this.Line1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Line1.Location = new System.Drawing.Point(12, 22);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.Size(570, 2);
            this.Line1.TabIndex = 5;
            // 
            // colorDialogForeColor
            // 
            this.colorDialogForeColor.AnyColor = true;
            // 
            // colorDialogBackColor
            // 
            this.colorDialogBackColor.AnyColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.EncodeSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(594, 290);
            this.Controls.Add(this.Line1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Caesar\'s Cipher";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Encode_IncrementBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Decode_DecrementBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown Encode_IncrementBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Encode_InputBox;
        private System.Windows.Forms.Button EncodeSubmit;
        private System.Windows.Forms.TextBox Decode_InputBox;
        private System.Windows.Forms.Button DecodeSubmit;
        private System.Windows.Forms.NumericUpDown Decode_DecrementBox;
        private System.Windows.Forms.TextBox Encode_OutputBox;
        private System.Windows.Forms.TextBox Decode_OutputBox;
        private System.Windows.Forms.ToolStripMenuItem abouToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutCaesarsCipherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wikipediaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutThisProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caesarsCipherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutTheCreatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vanillaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geekToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem azureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label Line1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyrightCToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialogForeColor;
        private System.Windows.Forms.ColorDialog colorDialogBackColor;
        private System.Windows.Forms.ToolStripMenuItem forecolorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backcolorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exampleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.Button Encode_copytext;
        private System.Windows.Forms.Button Decode_copytext;
    }
}

