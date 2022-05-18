using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsonGamesGeos2.MainForms.Misc_Forms.Loading
{
    public partial class Loading : Form
    {
        Main.MainForm main = (Main.MainForm)Application.OpenForms["MainForm"];
        classes.animations animations = new classes.animations();
        classes.WindowControls WindowControls = new classes.WindowControls();
        public Loading()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = animations.ChangeOpacity(MainResources.CGGeosLogo2, 100);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            main.Resize += Main_Resize;
          
            pictureBox1.Location = WindowControls.CenterControl(this, pictureBox1);
            CheckForFTS();

        }

        private void Main_Resize(object sender, EventArgs e)
        {
            WindowControls.ResizeFullScreenWindow(this);
        }

        public bool CheckForFTS()
        {
            classes.checkforfts checkforfts = new classes.checkforfts();
            if (!checkforfts.Check())
            {
                status.Text = "Loading First Time Setup..";
                classes.First_Time_Setup first_Time_Setup = new classes.First_Time_Setup();
                first_Time_Setup.LoadFTS();
                return false;
            }
            else
            {
               
                WindowControls.Login();
              
            }
            return true;
        }
    }
}
