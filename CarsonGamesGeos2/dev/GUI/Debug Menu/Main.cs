using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsonGamesGeos2.dev.GUI.Debug_Menu
{
    public partial class Main : Form
    {
        classes.WindowControls WindowControls = new classes.WindowControls();
        classes.ControlClass Control = new classes.ControlClass();

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForms.Misc_Forms.Loading.Loading loading = new MainForms.Misc_Forms.Loading.Loading();
            WindowControls.Open(loading,"full");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hlp.help  hlp = new hlp.help(MainResources._0.ToString());
            hlp.Show();

        }
    }
}
