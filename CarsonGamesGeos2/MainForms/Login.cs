using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsonGamesGeos2.MainForms
{

    public partial class Login : Form
    {
        Main.MainForm main = (Main.MainForm)Application.OpenForms["MainForm"];
        classes.animations animations = new classes.animations();
        classes.WindowControls WindowControls = new classes.WindowControls();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

            main.Resize += Main_Resize;
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            WindowControls.ResizeFullScreenWindow(this);
        }
    }
}
