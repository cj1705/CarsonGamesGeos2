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
    public partial class Main : Form
    {
        classes.animations animations = new classes.animations();
        classes.WindowControls WindowControls = new classes.WindowControls();
        public Main()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = animations.ChangeOpacity(MainResources.CGGeosLogo2, 100);
        }

        private void Main_Load(object sender, EventArgs e)
        {


            pictureBox1.Location = WindowControls.CenterControl(this, pictureBox1);
        }
    }
}
