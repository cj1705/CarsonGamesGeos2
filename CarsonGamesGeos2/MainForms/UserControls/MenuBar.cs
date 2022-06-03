using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsonGamesGeos.geos.UserControls.UI
{
    public partial class MenuBar : UserControl
    {
        ToolTip tt = new ToolTip();
        public MenuBar()
        {
            InitializeComponent();
            timer1.Start();
            timer2.Interval = 5000;
            timer2.Start();
            ToolTip tt = new ToolTip();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (appmenu.Visible == false)
            {

                appmenu.Visible = true;
            }
            else
            {
                appmenu.Visible = false;
            }
        }

        private void MenuBar_Load(object sender, EventArgs e)
        {
            Form frm = this.FindForm();
            this.Size = frm.Size;
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            List<string> list = new List<string>();

            label1.Text= Program.services.ClockService.getTime();
            FormCollection myForms = Application.OpenForms;

            StringBuilder sforms = new StringBuilder();

            foreach(Form form in myForms)
            {
                list.Add(form.Name);
            }
            foreach(string name in list)
            {
                ListViewItem item2 = new ListViewItem();
                item2.SubItems.Add(name);
                if (!listView1.Items.Contains(item2))
                {
                    ListViewItem item1 = new ListViewItem();
                    item1.Text = name;
                    listView1.Items.Add(item1);
                    
                }
            }

        }
        
        private void Ping()
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            appmenu.Visible = false;
            this.Visible = false;
            FormCollection myForms = Application.OpenForms;
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != this.Name.ToString() && Application.OpenForms[i].Name != "Main")
                    Application.OpenForms[i].Dispose();
            }
            //  wallpaper.BackColor = Color.Gray;
            //menuStrip1.Visible = false;
            CarsonGamesGeos.Properties.settings.Default.isloggedin = "0";
            Properties.settings.Default.reqlogin = " ";
            Properties.settings.Default.suclogin = "0";
            Properties.settings.Default.usrloggedin = "";
            Program.MainFrm.OpenForm(new login(), "Normal");
        }
        //public void DrawRoundRect(Graphics g, Pen p, float X, float Y, float width, float height, float radius)
        //{
        //    GraphicsPath gp = new GraphicsPath();
        //    gp.AddLine(X + radius, Y, X + width - (radius * 2), Y);
        //    gp.AddArc(X + width - (radius * 2), Y, radius * 2, radius * 2, 270, 90);
        //    gp.AddLine(X + width, Y + radius, X + width, Y + height - (radius * 2));
        //    gp.AddArc(X + width - (radius * 2), Y + height - (radius * 2), radius * 2, radius * 2, 0, 90);
        //    gp.AddLine(X + width - (radius * 2), Y + height, X + radius, Y + height);
        //    gp.AddArc(X, Y + height - (radius * 2), radius * 2, radius * 2, 90, 90);
        //    gp.AddLine(X, Y + height - (radius * 2), X, Y + radius);
        //    gp.AddArc(X, Y, radius * 2, radius * 2, 180, 90);
        //    gp.CloseFigure();
        //    g.DrawPath(p, gp);
        //    gp.Dispose();
        //}

        private void appmenu_Paint(object sender, PaintEventArgs e)
        {
            //Graphics v = e.Graphics;
            //DrawRoundRect(v, Pens.Blue, e.ClipRectangle.Left, e.ClipRectangle.Top, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1, 10);
            ////Without rounded corners
            ////e.Graphics.DrawRectangle(Pens.Blue, e.ClipRectangle.Left, e.ClipRectangle.Top, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1);
            //base.OnPaint(e);
        }

        private void consoleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            appmenu.Visible = false;
            Program.MainFrm.OpenForm(new cgconsole.console(), "Normal");
        }

        private void controlpanel_Click(object sender, EventArgs e)
        {
            appmenu.Visible = false;
            Program.MainFrm.OpenForm(new control(), "Normal");
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
          
            if (pictureBox1.Name == "INT-CONNECT") {
                tt.SetToolTip(this.pictureBox1,"Internet Connected");
            }
            if (pictureBox1.Name == "INT-DIS")
            {
                tt.SetToolTip(this.pictureBox1, "Internet Removed");
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            Thread pingcheck = new Thread(Ping);
            pingcheck.Start();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Ping myPing = new Ping();


                PingReply reply = myPing.Send("google.com", 1000);
                PingReply reply2 = myPing.Send("microsoft.com", 1000);
                if (reply != null || reply2 != null)
                {

                    pictureBox1.Image = Properties.Resources.INT_CONNECT;
                    pictureBox1.Name = "INT-CONNECT";
                    //Console.WriteLine(reply.ToString());

                }
            }
            catch
            {
                pictureBox1.Image = Properties.Resources.INT_REMOVE;
                pictureBox1.Name = "INT-DIS";

            }
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();

            }
        }

            private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void updatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.MainFrm.OpenForm(new ControlPF.Updates.retry(), "Normal");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void addUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.MainFrm.OpenForm(new login_stuff.addusr(),"Normal");
        }

        private void appbutton1_Click(object sender, EventArgs e)
        {
           
        }

        private void eventViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.MainFrm.OpenForm(new ControlPF.Admin.EventViewer(),"Normal");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (appmenu.Visible == false)
            {

                appmenu.Visible = true;
            }
            else
            {
                appmenu.Visible = false;
            }
        }
    }
}
