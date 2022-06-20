using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsonGamesGeos2.MainForms.Misc_Forms.control
{
    public partial class control : Form
    {
        public control()
        {
            InitializeComponent();
            classes.misc misc = new classes.misc();
            versionstring.Text = misc.GetVersionString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = listBox1.SelectedIndex;
        }

        private void tabControl1_KeyDown(object sender, KeyEventArgs e)
        {
            string tempstring = e.KeyValue.ToString();
            if (tempstring == "37" || tempstring == "38" || tempstring == "39" || tempstring == "40")
            {
                e.Handled = true;
            }
        }

        private void titlebar1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
