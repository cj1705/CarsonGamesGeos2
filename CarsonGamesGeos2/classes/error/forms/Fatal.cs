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
        

        public Fatal(Exception a)
        {
            InitializeComponent();
            MainErr = a;
          
        }
        Exception MainErr;
        private void Fatal_Load(object sender, EventArgs e)
        {
            Main.MainForm mainForm = (Main.MainForm)Application.OpenForms["MainForm"];
            mainForm.Resize += MainForm_Resize;
            richTextBox1.Text = MainErr.StackTrace;
            richTextBox1.AppendText("\n\n " + MainErr.Source);
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (var assembly in assemblies)
            {
                richTextBox1.AppendText("\n\n" + assembly.GetName() + " " + assembly.Location);
            }
          
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            Main.MainForm main = (Main.MainForm)Application.OpenForms["MainForm"];

            this.Size = main.ClientSize;
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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
