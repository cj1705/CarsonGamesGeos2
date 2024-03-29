﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsonGamesGeos2.MainForms.Misc_Forms.fts.forms
{
    public partial class UserSetup : Form
    {
        public UserSetup()
        {
            InitializeComponent();
        }

        private void UserSetup_Load(object sender, EventArgs e)
        {
            CarsonGamesGeos2.MainForms.Misc_Forms.fts.FTS ftsmain = (CarsonGamesGeos2.MainForms.Misc_Forms.fts.FTS)Application.OpenForms["FTS"];
            ftsmain.ChangeProgress();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if(openFileDialog1.FileName!= null)
                {
                    Bitmap image = new Bitmap(openFileDialog1.FileName);
                    Size imagesize = image.Size;
                    if(imagesize == new Size(128, 128))
                    {
                        if (!Directory.Exists("./tmp"))
                        {

                            Directory.CreateDirectory("./tmp");
                        }
                        if (File.Exists("./tmp/img.png"))
                            File.Delete("./tmp/img.png");
                        usericon.ImageLocation = openFileDialog1.FileName;

                        Image img = usericon.Image;
                        img.Save("./tmp/img.png");

                    }
                    else
                    {
                        classes.misc misc = new classes.misc();
                        classes.File_Management.Folders folders = new classes.File_Management.Folders();
                        if (!Directory.Exists("./tmp"))
                        {

                           Directory.CreateDirectory("./tmp");
                        }
                        if (File.Exists("./tmp/img.png"))
                            File.Delete("./tmp/img.png");

                        Image img = misc.resizeImage(128, 128, openFileDialog1.FileName);
                        img.Save("./tmp/img.png");
                        usericon.Image = img;

                    }
                    
                  
                }
            }
        }

        private void passwordtxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(usericon.Image == null)
            {
                if (!Directory.Exists("./tmp"))
                {

                    Directory.CreateDirectory("./tmp");
                }
                if (File.Exists("./tmp/img.png"))
                    File.Delete("./tmp/img.png");
                classes.misc misc = new classes.misc();




                Image img = MainResources.questionmark;
                img.Save(Path.GetTempPath() + "/image.png");
                img = misc.resizeImage(128, 128, Path.GetTempPath() + "/image.png");
                img.Save("./tmp/img.png");
                usericon.Image = img;
            }
         classes.usermangemnt usermangemnt = new classes.usermangemnt();usermangemnt.Setup(usernametxt.Text, passwordtxt.Text, true, "./tmp/img.png", Color.White, panel1.BackColor, Color.White,false);
            Application.Restart();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                panel1.BackColor = colorDialog1.Color;
        }
    }
}
