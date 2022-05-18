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
        public void ResizeFullScreenWindow(Form form)
        {
            Main.MainForm main = (Main.MainForm)Application.OpenForms["MainForm"];

            form.Size = main.ClientSize;
        }
        public Point CenterControl(Control form, Control control)
        {
            return new Point((form.Width / 2) -(control.Width / 2), (form.Height / 2) - (control.Height / 2));
        }
        public void Login()
        {
            Main.MainForm main = (Main.MainForm)Application.OpenForms["MainForm"];
            CarsonGamesGeos2.MainForms.Login login = new MainForms.Login();
            login.TopLevel = false;
            login.Parent = main;
            login.Size = main.ClientSize;
            login.StartPosition = FormStartPosition.CenterScreen;
            login.Show();
            login.BringToFront();
            MainForms.Misc_Forms.Loading.Loading loading = (MainForms.Misc_Forms.Loading.Loading)Application.OpenForms["Loading"];
            loading.Close();

        }
        public void Open(Form form, string size)
        {
            try
            {
                Main.MainForm main = (Main.MainForm)Application.OpenForms["MainForm"];


                form.TopLevel = false;
                form.Parent = main;

                if (size == "full")
                {

                    form.Size = main.ClientSize;
                }
                form.Show();
                form.BringToFront();

                form.StartPosition = FormStartPosition.CenterScreen;
            }
            catch (Exception) { }
        }
    }
}
