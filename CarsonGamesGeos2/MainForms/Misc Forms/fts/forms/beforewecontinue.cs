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
        public beforewecontinue()
        {
            InitializeComponent();
        }

        private void beforewecontinue_Load(object sender, EventArgs e)
        {
            CarsonGamesGeos2.MainForms.Misc_Forms.fts.FTS ftsmain = (CarsonGamesGeos2.MainForms.Misc_Forms.fts.FTS)Application.OpenForms["FTS"];
            richTextBox1.Text = MainResources.as_is;
            ftsmain.ChangeProgress();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
