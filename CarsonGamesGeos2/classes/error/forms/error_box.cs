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
    public partial class error_box : Form
    {
        Exception ee;
        public error_box(Exception e)
        {
            ee = e;
            InitializeComponent();
            label1.Text = e.Message;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form more = new more_details(ee.StackTrace);
            more.Show();
        }
    }
}
