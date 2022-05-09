using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsonGamesGeos2.classes
{
    public class WindowControls
    {
        public Point CenterControl(Control form, Control control)
        {
            return new Point((form.Width / 2) -(control.Width / 2), (form.Height / 2) - (control.Height / 2));
        }
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
