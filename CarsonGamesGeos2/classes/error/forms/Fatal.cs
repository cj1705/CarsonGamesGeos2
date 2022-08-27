using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsonGamesGeos2.classes.error.forms
{
    public partial class Fatal : Form
    {
        public Fatal()
        {
            InitializeComponent();
          
        }

        private void Fatal_Load(object sender, EventArgs e)
        {
           
        }

        private void Fatal_Shown(object sender, EventArgs e)
        {
            try
            {
                FormCollection myForms = Application.OpenForms;
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    if (Application.OpenForms[i].Name != this.Name.ToString() && Application.OpenForms[i].Name != "MainForm" && Application.OpenForms[i].Name != "Tools")
                        Application.OpenForms[i].Dispose();
                }
                Thread.Sleep(10);
            }



            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
}
