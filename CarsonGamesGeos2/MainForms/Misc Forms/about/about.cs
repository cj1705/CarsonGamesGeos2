using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsonGamesGeos2.MainForms.Misc_Forms.about
{
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
        }

        private void about_Load(object sender, EventArgs e)
        {
            classes.misc misc = new classes.misc();
            versionstring.Text = misc.GetVersionString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void titlebar1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void versionstring_Click(object sender, EventArgs e)
        {

        }
    }
}
