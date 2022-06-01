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
        classes.usermangemnt Usermangemnt = new classes.usermangemnt();
        public Login()
        {
            InitializeComponent();
        }
        ListViewItem lstviewItem;
        ImageList lstviewItemImageList = new ImageList();
        private void Login_Load(object sender, EventArgs e)
        {

            main.Resize += Main_Resize;
            timer1.Start();
            listView1.View = View.Details;
            listView1.Columns.Add(" ");
            listView1.ForeColor = Color.White;
            listView1.Columns[0].Width = 500;
            WindowControls.CenterControl(main, listView1);

            PopulateUsers();

        }
        public void PopulateUsers()
        {
            
            foreach(var key in Usermangemnt.UserList())
            {
               

                    lstviewItem = new ListViewItem($"  {key.Key}" );
                if(key.Value == String.Empty || (key.Value == " ")){
                    lstviewItem.SubItems.Add("0");
                }
                else
                {
                    lstviewItem.SubItems.Add("1");

                }
                lstviewItemImageList.ImageSize = new Size(25, 25);
                    listView1.SmallImageList = lstviewItemImageList;
                    lstviewItem.ImageIndex = lstviewItemImageList.Images.Add(Image.FromFile($"users\\{key.Key}\\settings\\misc\\image.png"), Color.Transparent);
                    listView1.Items.Add(lstviewItem);
                
            }
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            WindowControls.ResizeFullScreenWindow(this);
        }

        private void clock_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            classes.clock clockclass = new classes.clock();
            clock.Text = clockclass.GetTime();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {



        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
                if (listView1.SelectedItems[0].SubItems[1].Text == "1")
                {
                groupBox2.Visible = true;
                    username.Text = ($"Enter the password for{listView1.SelectedItems[0].Text}");
                }
           
        }

        private void username_Click(object sender, EventArgs e)
        {

        }
    }
}
