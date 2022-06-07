using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsonGamesGeos2.classes.error.forms
{
    public partial class more_details : Form
    {
        public more_details(string text)
        {
            InitializeComponent();
            richTextBox1.Text = text;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
