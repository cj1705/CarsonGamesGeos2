using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsonGamesGeos2.MainForms.Misc_Forms.fts
{
    public class formcontrol

    {

        public MainForms.Misc_Forms.fts.Main main = (MainForms.Misc_Forms.fts.Main)Application.OpenForms["FTS"];

        public void Change(Form form)
        {
            main.formpanel.Controls.Clear();
            main.formpanel.Controls.Add(form);
            form.Show();
        }
         
    }
}
