using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsonGamesGeos2.classes
{
    public class getForms
    {
        public FormCollection GetAllforms()
        {
            return Application.OpenForms;
        }
    }
}
