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
        classes.File_Management.Folders Folders = new File_Management.Folders();
        string prefix = "(FTS)";
        public void LoadFTS()
        {
            Main.MainForm main = (Main.MainForm)Application.OpenForms["MainForm"];
            MainForms.Misc_Forms.Loading.Loading loading = (MainForms.Misc_Forms.Loading.Loading)Application.OpenForms["Loading"];
            loading.BackColor = System.Drawing.Color.Gray;
            loading.status.ForeColor = System.Drawing.Color.Black;
            loading.status.Text = $"{prefix} Creating Folders";
            if (!Folders.CheckForFolder("./settings"))
                Folders.CreateFolder("./settings");
            if (!Folders.CheckForFolder("./settings/users"))
                Folders.CreateFolder("./settings/users");
            if (!Folders.CheckForFolder("./settings/system"))
                Folders.CreateFolder("./settings/system");
            if (!Folders.CheckForFolder("./users"))
                Folders.CreateFolder("./users");

            loading.status.Text = $"{prefix} Setting up FTS enviroment";
            MainForms.Misc_Forms.fts.Main fts = new MainForms.Misc_Forms.fts.Main();
            WindowControls windowControls = new WindowControls();
            windowControls.Open(fts, "full");
            fts.Shown += Fts_Shown;
            




        }

        private void Fts_Shown(object sender, EventArgs e)
        {
            MainForms.Misc_Forms.Loading.Loading loading = (MainForms.Misc_Forms.Loading.Loading)Application.OpenForms["Loading"];

            loading.Dispose();
        }
    }
}
