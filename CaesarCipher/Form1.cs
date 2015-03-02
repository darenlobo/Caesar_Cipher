using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CaesarCipher
{
    
    public partial class Form1 : Form
    {
        public string Encode_Input = "you haven't input any text yet!!!";
        public string Encode_Output = "you haven't input any text yet!!!";
        public string Decode_Input = "you haven't input any text yet!!!";
        public string Decode_Output = "you haven't input any text yet!!!";
        public int IncrementBase = 0;
        public int DecrementBase = 0;
        public Color MyForeColor = new Color();
        public Color MyBackColor = new Color();

        public Form1()
        {
            InitializeComponent();
                        
        }

       
        static string Encode(string value, int shift)
        {
            char[] buffer = value.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                
                // Letter.
                char letter = buffer[i];
                // Add shift to all.
                if (char.IsLetter(letter))
                {
                    letter = (char)(letter + shift);
                    // Subtract 26 on overflow.
                    // Add 26 on underflow.
                    if (letter > 'z')
                    {
                        letter = (char)(letter - 26);
                    }
                    else if (letter < 'a')
                    {
                        letter = (char)(letter + 26);
                    }
                    // Store.
                    buffer[i] = letter;
                }
            }
            return new string(buffer);
        }

        
        private void Encode_InputBox_TextChanged(object sender, EventArgs e)
        {
            Encode_Input = Encode_InputBox.Text.ToString();
            
        }

        

        private void EncodeSubmit_Click(object sender, EventArgs e)
        {
            IncrementBase = Convert.ToInt32(Encode_IncrementBox.Value);
            Encode_OutputBox.Text = Encode(Encode_Input, IncrementBase);
        }

        private void Encode_IncrementBox_ValueChanged(object sender, EventArgs e)
        {
            IncrementBase = Convert.ToInt32(Encode_IncrementBox.Value);
            Encode_OutputBox.Text = Encode(Encode_Input, IncrementBase);
        }

        private void Decode_InputBox_TextChanged(object sender, EventArgs e)
        {
            Decode_Input = Decode_InputBox.Text.ToString();
        }

        private void DecodeSubmit_Click(object sender, EventArgs e)
        {
            DecrementBase = -1 * Convert.ToInt32(Decode_DecrementBox.Value);
            Decode_OutputBox.Text = Encode(Decode_Input, DecrementBase);
        }

        private void Decode_DecrementBox_ValueChanged(object sender, EventArgs e)
        {
            DecrementBase = -1 * Convert.ToInt32(Decode_DecrementBox.Value);
            Decode_OutputBox.Text = Encode(Decode_Input, DecrementBase);
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) { }
        private void abouToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void aboutThisProgramToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void aboutCaesarsCipherToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void customToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void helpToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void themesToolStripMenuItem_Click(object sender, EventArgs e) { }
                      
       private void caesarsCipherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutProgram about = new AboutProgram();
            about.Show();
        }

       private void aboutTheCreatorToolStripMenuItem_Click(object sender, EventArgs e)
       {
           AboutCreator about = new AboutCreator();
           about.Show();
       }     
           

       private void wikipediaToolStripMenuItem_Click(object sender, EventArgs e)
       {
           System.Diagnostics.Process.Start("http://en.wikipedia.org/wiki/Caesar_cipher");
       }

       private void copyrightCToolStripMenuItem_Click(object sender, EventArgs e)
       {
           AboutCopyright about = new AboutCopyright();
           about.Show();

       }

       private void azureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeColor(System.Drawing.Color.White, System.Drawing.Color.SkyBlue);
        }

        private void forecolorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialogForeColor.ShowDialog() == DialogResult.OK)
            {
               MyForeColor = colorDialogForeColor.Color;
            }
        }

        private void backcolorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialogBackColor.ShowDialog() == DialogResult.OK)
            {
                MyBackColor = colorDialogBackColor.Color;
            }
        }

        private void applyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeColor(MyForeColor, MyBackColor);
        }

        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutHelp help = new AboutHelp();
            help.Show();
        }

        private void exampleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpExample about = new HelpExample();
            about.Show();
        }
        
       
     
        private void Encode_copytext_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Encode_OutputBox.Text);
        }

        private void Decode_copytext_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Decode_OutputBox.Text);
        }

        private void ChangeColor(Color MyForeColor, Color MyBackColor)
       {
           //Set Fore Colors
           this.ForeColor = MyForeColor;
            //menu
           menuStrip1.ForeColor = MyForeColor;
           aboutCaesarsCipherToolStripMenuItem.ForeColor = MyForeColor;
           abouToolStripMenuItem.ForeColor = MyForeColor;
           aboutTheCreatorToolStripMenuItem.ForeColor = MyForeColor;
           aboutThisProgramToolStripMenuItem.ForeColor = MyForeColor;
           azureToolStripMenuItem.ForeColor = MyForeColor;
           caesarsCipherToolStripMenuItem.ForeColor = MyForeColor;
           copyrightCToolStripMenuItem.ForeColor = MyForeColor;
           customToolStripMenuItem.ForeColor = MyForeColor;
           geekToolStripMenuItem1.ForeColor = MyForeColor;
           helpToolStripMenuItem.ForeColor = MyForeColor;
           themesToolStripMenuItem.ForeColor = MyForeColor;
           vanillaToolStripMenuItem.ForeColor = MyForeColor;
           wikipediaToolStripMenuItem.ForeColor = MyForeColor;
           forecolorToolStripMenuItem.ForeColor = MyForeColor;
           backcolorToolStripMenuItem.ForeColor = MyForeColor;
           applyToolStripMenuItem.ForeColor = MyForeColor;
           themesToolStripMenuItem1.ForeColor = MyForeColor;
           exampleToolStripMenuItem.ForeColor = MyForeColor;
           generalToolStripMenuItem.ForeColor = MyForeColor;

            //Encode Decode Boxes
           Encode_IncrementBox.ForeColor = MyForeColor;
           Encode_InputBox.ForeColor = MyForeColor;
           Encode_OutputBox.ForeColor = MyForeColor;
           EncodeSubmit.ForeColor = MyForeColor;
           Decode_DecrementBox.ForeColor = MyForeColor;
           Decode_InputBox.ForeColor = MyForeColor;
           Decode_OutputBox.ForeColor = MyForeColor;
           DecodeSubmit.ForeColor = MyForeColor;
           groupBox1.ForeColor = MyForeColor;
           groupBox2.ForeColor = MyForeColor;
           Encode_copytext.ForeColor = MyForeColor;
           Decode_copytext.ForeColor = MyForeColor;

            //Set Back Colors 
           this.BackColor = MyBackColor;
            //menu
           menuStrip1.BackColor = MyBackColor;
           aboutCaesarsCipherToolStripMenuItem.BackColor = MyBackColor;
           abouToolStripMenuItem.BackColor = MyBackColor;
           aboutTheCreatorToolStripMenuItem.BackColor = MyBackColor;
           aboutThisProgramToolStripMenuItem.BackColor = MyBackColor;
           azureToolStripMenuItem.BackColor = MyBackColor;
           caesarsCipherToolStripMenuItem.BackColor = MyBackColor;
           copyrightCToolStripMenuItem.BackColor = MyBackColor;
           customToolStripMenuItem.BackColor = MyBackColor;
           geekToolStripMenuItem1.BackColor = MyBackColor;
           helpToolStripMenuItem.BackColor = MyBackColor;
           themesToolStripMenuItem.BackColor = MyBackColor;
           vanillaToolStripMenuItem.BackColor = MyBackColor;
           wikipediaToolStripMenuItem.BackColor = MyBackColor;
           forecolorToolStripMenuItem.BackColor = MyBackColor;
           backcolorToolStripMenuItem.BackColor = MyBackColor;
           applyToolStripMenuItem.BackColor = MyBackColor;
           themesToolStripMenuItem1.BackColor = MyBackColor;
           exampleToolStripMenuItem.BackColor = MyBackColor;
           generalToolStripMenuItem.BackColor = MyBackColor;

           //Encode Decode Boxes                        
           Encode_IncrementBox.BackColor = MyBackColor;
           Encode_InputBox.BackColor = MyBackColor;
           Encode_OutputBox.BackColor = MyBackColor;
           EncodeSubmit.BackColor = MyBackColor;
           Decode_DecrementBox.BackColor = MyBackColor;
           Decode_InputBox.BackColor = MyBackColor;
           Decode_OutputBox.BackColor = MyBackColor;
           DecodeSubmit.BackColor = MyBackColor;
           groupBox1.BackColor = MyBackColor;
           groupBox2.BackColor = MyBackColor;
           Encode_copytext.BackColor = MyBackColor;
           Decode_copytext.BackColor = MyBackColor;


           
           
        }

        private void geekToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChangeColor(System.Drawing.Color.PaleGreen, System.Drawing.Color.Black); 
        }

        private void vanillaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Template
            ChangeColor(System.Drawing.Color.Black, SystemColors.Control);
         
            //BackColor White
            Encode_IncrementBox.BackColor = System.Drawing.Color.White;
            Encode_InputBox.BackColor = System.Drawing.Color.White;
            Encode_OutputBox.BackColor = System.Drawing.Color.White;
            EncodeSubmit.UseVisualStyleBackColor = true;
            Decode_DecrementBox.BackColor = System.Drawing.Color.White;
            Decode_InputBox.BackColor = System.Drawing.Color.White;
            Decode_OutputBox.BackColor = System.Drawing.Color.White;
            DecodeSubmit.UseVisualStyleBackColor = true;
             
            

        }

        private void themesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HelpThemes about = new HelpThemes();
            about.Show();
        }

        

       

        
       

      
        
        


        
                
        

    
       

       
       

       
        
        
           
           
    }
 }

        

             
    

