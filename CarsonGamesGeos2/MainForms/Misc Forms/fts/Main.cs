using System;
using System.Windows.Forms;

namespace CarsonGamesGeos2.MainForms.Misc_Forms.fts
{
    public partial class Main : Form
    {
        CarsonGamesGeos2.Main.MainForm main = (CarsonGamesGeos2.Main.MainForm)Application.OpenForms["MainForm"];
        classes.WindowControls WindowControls = new classes.WindowControls();
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            main.Resize += Main_Resize;
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            WindowControls.ResizeFullScreenWindow(this);

        }
    }
}
