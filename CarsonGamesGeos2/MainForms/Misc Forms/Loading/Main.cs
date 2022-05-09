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
        public Main()
        {
            InitializeComponent();
            pictureBox1.Image = MainResources.BOOT;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = animations.ChangeOpacity(MainResources.BOOT, 100);
        }
    }
}
