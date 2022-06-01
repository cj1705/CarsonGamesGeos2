using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsonGamesGeos.geos.UserControls.UI
{
    public partial class Titlebar : UserControl
    {

        private bool mouseDown;
        private Point lastLocation;

        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        public bool IsActive(IntPtr handle)
        {
            IntPtr activeHandle = GetForegroundWindow();
            return (activeHandle == handle);
        }

        public Titlebar()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        public Form Parrentfrm()
        {
            Form frm = this.FindForm();
            return frm;
        }

        private void Titlebar_Load(object sender, EventArgs e)
        {
           
            timer1.Start();


            //jDragControl1.GetForm = frm;
            //  jDragControl1.TargetControl = panel1;
            //label4.AutoSize = false;
            //   label4.Dock = DockStyle.Fill;

            flatLabel1.Text = Parrentfrm().Name;

            this.Width = Parrentfrm().Width + 5;
            

            panel1.Width = this.Width;
            int frmwidth = Parrentfrm().Width;
            //label4.Left = frmwidth - 400;
            xbutton.Left = frmwidth - 25;
            minbutton.Left = xbutton.Left - 50;
            Parrentfrm().Paint += Titlebar_Paint1;
        }

        private void Titlebar_Paint1(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.Parrentfrm().ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void xbutton_Click(object sender, EventArgs e)
        {


            Form frm = this.FindForm();
            flatLabel1.Text = "Closing - " + frm.Name;
            frm.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms[this.FindForm().Name];
            
        }
        void CheckFocus()
        {

        }
        public void listview1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Form frm = Application.OpenForms[this.FindForm().Name];

                frm.Show();
                frm.BringToFront();



            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms[this.FindForm().Name];

            frm.WindowState = FormWindowState.Minimized;


        }

        private void flatClose1_Click(object sender, EventArgs e)
        {

        }

        private void flatLabel1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                ParentForm.Location = new Point(
                    (ParentForm.Location.X - lastLocation.X) + e.X, (ParentForm.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
           
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Titlebar_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Black, this.Bounds);

        }
    }
      
   
}
