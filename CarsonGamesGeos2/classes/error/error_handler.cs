using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsonGamesGeos2.classes.error
{
    public class error_handler
    {
        Exception a = null;
        public void ShowError(Exception e)
        {
            try
            {
                if(e.Message == "TEST_FATAL")
                {

                  a=  new AggregateException();
                    throw a;
                }
                Main.MainForm main = (Main.MainForm)Application.OpenForms["MainForm"];

                Form error = new forms.error_box(e);
                error.TopMost = true;
                error.TopLevel = false;

                error.Parent = (Main.MainForm)Application.OpenForms["MainForm"];
                error.Show();
                error.Location = new Point(main.Width / 2 - error.Width / 2, main.Height / 2 - error.Height / 2);
            }
            catch(Exception ea)
            { 
                Fatal(ea);
            }


        }
        public void Fatal(Exception e)
        {
            
                Main.MainForm main = (Main.MainForm)Application.OpenForms["MainForm"];

                Form err = new forms.Fatal(a);
                err.TopLevel = false;
                err.Parent = main;

                err.Size = main.ClientSize;

                err.TopMost = true;
                err.Show();

            }
            
            
        
    }
}
