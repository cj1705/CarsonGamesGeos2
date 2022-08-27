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
        Main.MainForm MainForm = (Main.MainForm)Application.OpenForms["MainForm"];
        classes.usermangemnt Usermangemnt = new classes.usermangemnt();
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

        private void tabPage1_Paint(object sender, PaintEventArgs e)
        {
            backpanel.BackColor = Color.FromArgb(Int32.Parse(Usermangemnt.GetConfig(MainForm.loggedin, "color", "bcolor")));

        }

        private void backpanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Color color = getUserColorChoice();
            if (color != null)
            {

                Usermangemnt.saveConfig(MainForm.loggedin, "color", "bcolor", color.ToArgb().ToString());
            }
        }
        public Color getUserColorChoice()
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                return colorDialog1.Color;
            }
            else
            {
                return backpanel.BackColor;
            }
        }
    }
}
