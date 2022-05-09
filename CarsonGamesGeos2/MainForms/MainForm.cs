using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsonGamesGeos2.Main
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
#if DEBUG
            OpenForm(new dev.GUI.Debug_Menu.Main());
#endif
        }
        public void OpenForm(Form a)
        {
           
                try
                {
        
                  
                        Form form = a;
                        a.TopLevel = false;
                        a.Parent = this;


                        a.Show();
                        a.BringToFront();

                        a.StartPosition = FormStartPosition.CenterScreen;
                    
                }
                catch (Exception ex)
                {

                }
            
            
        }

    }
}
