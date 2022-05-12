using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsonGamesGeos2.MainForms.Misc_Forms.fts.forms
{
    public partial class beforewecontinue : Form
    {
        int count = 3;
        public beforewecontinue()
        {
            InitializeComponent();
        }

        private void beforewecontinue_Load(object sender, EventArgs e)
        {
            timer1.Start();
            CarsonGamesGeos2.MainForms.Misc_Forms.fts.FTS ftsmain = (CarsonGamesGeos2.MainForms.Misc_Forms.fts.FTS)Application.OpenForms["FTS"];
            richTextBox1.Text = MainResources.as_is;
            ftsmain.ChangeProgress();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count = count - 1;
            button1.Text = $"({count})";

            if (count == 0)
            {
                button1.Text = "--->";
                button1.Enabled = true; ;
                timer1.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
