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
        classes.WindowControls WindowControls = new classes.WindowControls();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
#if DEBUG
            WindowControls.Open(new dev.GUI.Debug_Menu.Main(),"window");
#endif
        }
        public void OpenForm(Form a)
        {
           
                try
                {
        
                  
                       
                    
                }
                catch (Exception ex)
                {

                }
            
            
        }

    }
}
