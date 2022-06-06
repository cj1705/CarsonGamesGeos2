using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarsonGamesGeos2.classes;
using Timer = System.Windows.Forms.Timer;

namespace CarsonGamesGeos.geos.UserControls.UI
{
    public partial class MenuBar : UserControl
    {
        private const string V = "MainForm";
        ToolTip tt = new ToolTip();
        CarsonGamesGeos2.Main.MainForm MainForm = (CarsonGamesGeos2.Main.MainForm)Application.OpenForms["MainForm"];
        CarsonGamesGeos2.classes.WindowControls WindowControls = new WindowControls();
        misc Misc = new misc();
        public MenuBar()
        {
            usermangemnt usermangemnt = new usermangemnt();
            InitializeComponent();
            timer1.Start();
            timer2.Interval = 5000;
            timer2.Start();
            ToolTip tt = new ToolTip();
            getOpened.Start();
            CloseOld.Start();
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            files.Click += filesToolStripMenuItem_Click;
            MainForm.Resize += MainForm_Resize;
            label2.Text = MainForm.loggedin;
            Image img = Misc.resizeImage(101, 84, usermangemnt.GetProfilePicture(label2.Text));
            userpicture.Image = img;

            


        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            this.Dock = DockStyle.None;
            this.Size = MainForm.ClientSize;
            this.Dock = DockStyle.Bottom;
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

                Thread t = new Thread (OpenAppMenu);
                t.Start();


            }
            else
            {
                appmenu.Visible = false;
            }
        }
        public void OpenAppMenu()
        {
            int gotox = 100;
            appmenu.Invoke(new Action(delegate () { appmenu.Location = new Point(appmenu.Location.X - 100, appmenu.Location.Y); }));
            
            Timer timer = new Timer();
            timer.Tick += Timer_Tick;
            timer.Interval = 500;
            appmenu.Invoke(new Action(delegate () {
                appmenu.BringToFront();
                appmenu.Visible = true;
            }));



            while (gotox > 0)
            {
                appmenu.Invoke(new Action(delegate () { appmenu.Location = new Point(appmenu.Location.X + 1, appmenu.Location.Y); }));



               
               gotox = gotox -1;

            }



        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Animate_Tick(object sender, EventArgs e)
        {
        }

        private void MenuBar_Load(object sender, EventArgs e)
        {
            Form frm = this.FindForm();
            this.Size = frm.Size;
         //   desktop.Size = new Size(1024, 743);

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
            UpdateDesktop();
            List<string> list = new List<string>();

            label1.Text = DateTime.Now.ToString("HH:mm:ss");



        }

        private void Ping()
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            this.Visible = false;
            FormCollection myForms = Application.OpenForms;
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != this.Name.ToString() && Application.OpenForms[i].Name != "Main")
                    Application.OpenForms[i].Dispose();
            }
            //  wallpaper.BackColor = Color.Gray;
            //menuStrip1.Visible = false;
          //  CarsonGamesGeos.Properties.settings.Default.isloggedin = "0";
          //  Properties.settings.Default.reqlogin = " ";
         //   Properties.settings.Default.suclogin = "0";
         //   Properties.settings.Default.usrloggedin = "";
         //   Program.MainFrm.OpenForm(new login(), "Normal");
        }

        private void appmenu_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void consoleToolStripMenuItem1_Click(object sender, EventArgs e)
        {

         //   Program.MainFrm.OpenForm(new cgconsole.console(), "Normal");
            Close();
        }

        private void controlpanel_Click(object sender, EventArgs e)
        {

           // Program.MainFrm.OpenForm(new control(), "Normal");
            Close();
        }
        public void Close()
        {
            appmenu.Visible = false;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {

            if (pictureBox1.Name == "INT-CONNECT")
            {
                tt.SetToolTip(this.pictureBox1, "Internet Connected");
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

             //       pictureBox1.Image = Properties.Resources.INT_CONNECT;
                    pictureBox1.Name = "INT-CONNECT";
                    //Console.WriteLine(reply.ToString());

                }
            }
            catch
            {
          //      pictureBox1.Image = Properties.Resources.INT_REMOVE;
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
        public void UpdateDesktop()
        {
            //string[] current_items = { " " };

            //try
            //{

            //    foreach (string file in Directory.GetFiles(Program.MainFrm.userpath + "desktop"))
            //    {
            //        //foreach(string item in desktop.Items)
            //        //{
            //        //    if (!current_items.Contains(item))
            //        //    {
            //        //        current_items.Append(item);
            //        //    }
            //        //}

            //        //foreach(string a in current_items)
            //        //{
            //        //    Console.WriteLine(a);
            //        //    Console.WriteLine("END");
            //        //}

            //            ListViewItem item1 = desktop.FindItemWithText(Path.GetFileName(file));

            //            if (item1 == null)
            //            {
            //                ListViewItem newitem = new ListViewItem(Path.GetFileName(file));
            //                newitem.ForeColor = Color.White;
            //                desktop.Items.Add(newitem);

            //        }


            //    }


            //}
            //catch(Exception e)
            //{

            //}
        }



        private void updatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
        //    Program.MainFrm.OpenForm(new ControlPF.Updates.retry(), "Normal");
            Close();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowControls.Open(new CarsonGamesGeos2.MainForms.Misc_Forms.about.about(), "normal");
            Close();
        }
        private void filesToolStripMenuItem_Click(object sender, EventArgs e)
        {
       //     Program.MainFrm.OpenForm(new apps.filemanager(), "Normal");
            Close();
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
        //    Program.MainFrm.OpenForm(new login_stuff.addusr(), "Normal");
            Close();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          //  Program.MainFrm.OpenForm(new exit(), "Normal");
            Close();
        }

        private void getOpened_Tick(object sender, EventArgs e)
        {
            //if(tasklist.BackColor == Color.Black)
            //{
            //    panel1.ForeColor = Color.White;
            //}
            //if (tasklist.BackColor == Color.White)
            //{
            //    panel1.ForeColor = Color.Black;
            //}
            FormCollection Forms = Application.OpenForms;
            foreach (Form form in Forms)
            {
                ListViewItem item1 = tasklist.FindItemWithText(form.Name);

                if (item1 == null)
                {
                    if (form.Name != V)
                    {
                        tasklist.Items.Add(form.Name);
                    }
                }

            }

            //foreach (Form form in Forms)
            //{
            //    try
            //    {
            //        ListViewItem formname = tasklist.FindItemWithText(form.Name);

            //        if (form.Focused)
            //        {
            //            int index = tasklist.Items.IndexOf(formname);
            //            tasklist.Items[index].BackColor = Color.Blue;
            //        }


            //        if (!form.Focused)
            //        {
            //            int index = tasklist.Items.IndexOf(formname);
            //            tasklist.Items[index].BackColor = Color.White;
            //        }
            //    }
            //    catch (Exception)
            //    {

            //    }
            //}

        }
        private string[] ConvertToArray(ListView ListView1)
        {
            string[] array = new string[ListView1.Items.Count];
            for (int i = 0; i <= ListView1.Items.Count - 1; i++)
            {
                array[i] = ListView1.Items[i].Text;
            }
            return array;
        }

        private void CloseOld_Tick(object sender, EventArgs e)
        {
            foreach (string formtxt in ConvertToArray(tasklist))
            {

                ListViewItem formname = tasklist.FindItemWithText(formtxt);

                Form form = Application.OpenForms[formtxt];
                if (form == null)
                {
                    tasklist.Items.Remove(formname);
                }

            }
        }



        private void minToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem selectedForm = tasklist.SelectedItems[0];
            Min(selectedForm.Text);
        }

        public void Min(string frmname)
        {

            Form form = Application.OpenForms[frmname];
            form.Hide();

        }
        public void BTF(string frmname)
        {

            Form form = Application.OpenForms[frmname];
            if (form.WindowState == FormWindowState.Minimized)
            {
                form.WindowState = FormWindowState.Normal;
            }
            form.Show();
            form.BringToFront();

        }

        private void bringToFrontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem selectedForm = tasklist.SelectedItems[0];
            BTF(selectedForm.Text);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem selectedForm = tasklist.SelectedItems[0];
            CloseFRM(selectedForm.Text);
        }
        public void CloseFRM(string frmname)
        {
            Form form = Application.OpenForms[frmname];
            form.Dispose();
        }

        private void tasklist_MouseEnter(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }


        private void timer4_Tick(object sender, EventArgs e)
        {

        }

        private void paintToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {

        }

        private void internetToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void taskmanger_Click(object sender, EventArgs e)
        {

        }

        private void Options_Click(object sender, EventArgs e)
        {

        }

        private void about_Click(object sender, EventArgs e)
        {

        }

        private void files_Click(object sender, EventArgs e)
        {

        }

        private void apps_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip2_Opening_1(object sender, CancelEventArgs e)
        {

        }

        private void tasklist_Click(object sender, EventArgs e)
        {

        }

        private void tasklist_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                if (tasklist.FocusedItem != null && tasklist.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    contextMenuStrip2.Show(Cursor.Position);
                }
            }
            try
            {

                if (e.Button == MouseButtons.Left)
                {
                    if (tasklist.FocusedItem != null && tasklist.FocusedItem.Bounds.Contains(e.Location) == true)
                    {
                        ListViewItem selectedForm = tasklist.SelectedItems[0];
                        Form form = Application.OpenForms[selectedForm.Text];
                        if (form.WindowState == FormWindowState.Minimized)
                        {
                            form.WindowState = FormWindowState.Normal;
                        }

                        form.BringToFront();
                        form.Focus();
                    }
                    tasklist.SelectedItems.Clear();
                }









            }


            catch (Exception)
            {

            }
        }

        private void timer1_Tick_2(object sender, EventArgs e)
        
        {
            clock clock = new clock();
            label1.Text = clock.GetTime();
        }

        private void MenuBar_Load_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void tasklist_CacheVirtualItems(object sender, CacheVirtualItemsEventArgs e)
        {

        }

        private void minToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ListViewItem selectedForm = tasklist.SelectedItems[0];
            Min(selectedForm.Text);
        }

        private void bringToFrontToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ListViewItem selectedForm = tasklist.SelectedItems[0];
            BTF(selectedForm.Text);
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ListViewItem selectedForm = tasklist.SelectedItems[0];
            CloseFRM(selectedForm.Text);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void userpicture_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
