using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsonGamesGeos2.classes
{
    public class WindowControls
    {
        public void Open(Form form, string size)
        {
            Main.MainForm main = (Main.MainForm)Application.OpenForms["MainForm"];

            form.TopLevel = false;
            form.Parent = main;

            if(size == "full")
            {
               
                form.Size = main.ClientSize;
            }
            form.Show();
            form.BringToFront();

            form.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
