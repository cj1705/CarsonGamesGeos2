using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsonGamesGeos2.classes
{
    public class First_Time_Setup
    {
        public void LoadFTS()
        {
            Main.MainForm main = (Main.MainForm)Application.OpenForms["MainForm"];
            MainForms.Misc_Forms.Loading.Loading loading = (MainForms.Misc_Forms.Loading.Loading)Application.OpenForms["Loading"];
            loading.BackColor = System.Drawing.Color.Aqua;
            loading.status.Text = "Test";

        }
    }
}
