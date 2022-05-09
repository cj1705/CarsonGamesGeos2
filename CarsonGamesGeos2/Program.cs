using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarsonGamesGeos2;

namespace CarsonGamesGeos2
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            dev.debug debug = new dev.debug();
            debug.StartDebug();



#else
            CarsonGamesGeos2.Main.GUI_Items.Message_Box.MessageBox msgbox = new Main.GUI_Items.Message_Box.MessageBox("-1");
            msgbox.ShowDialog();
#endif



        }
    }
}
