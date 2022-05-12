using System;
using System.Windows.Forms;

namespace CarsonGamesGeos2.MainForms.Misc_Forms.fts
{
    public partial class FTS : Form
    {
        CarsonGamesGeos2.Main.MainForm main = (CarsonGamesGeos2.Main.MainForm)Application.OpenForms["MainForm"];
        CarsonGamesGeos2.MainForms.Misc_Forms.fts.formcontrol Formcontrol =  new formcontrol();

        classes.WindowControls WindowControls = new classes.WindowControls();
        public FTS()
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
            foreach(Form control in formpanel.Controls)
            {
                control.Size = formpanel.ClientSize;
            }

        }

        private void formpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Main_Shown(object sender, EventArgs e)
        {
            ChangeWindow(new forms.Welcome());

        }
        public void ChangeWindow(Form a)
        {



            Form form = a;
            a.TopLevel = false;


            a.TopMost = true;
            formpanel.Controls.Clear();
            formpanel.Controls.Add(form);
            form.Size = formpanel.ClientSize;
            form.Show();
            a.BringToFront();
            a.StartPosition = FormStartPosition.CenterScreen;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flatLabel1_Click(object sender, EventArgs e)
        {

        }
        public void ChangeProgress()
        {
            int numforms =  4;
            int max = 100;
            int amount = max / numforms;
            flatProgressBar1.Value = flatProgressBar1.Value + amount;

        }
    }
}
