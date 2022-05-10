using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsonGamesGeos2.classes
{
    public class ControlClass
    {
        public Control CreateControl(Control control, string name, Control parrent )
        {
            control.Name = name;
            control.Parent = parrent;


            return control;
        } 
    }
}
