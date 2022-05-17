using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarsonGamesGeos2;

namespace CarsonGamesGeos2
{
    internal class Program
    {
        [STAThread]

        static void Main(string[] args)
        {
            classes.addons.addonloader addonloader = new classes.addons.addonloader();

           Thread addons = new Thread(addonloader.LoadAddons);
            addons.Start();
            
          
#if DEBUG
            dev.debug debug = new dev.debug();
          debug.StartDebug();
          



#else
            CarsonGamesGeos2.Main.GUI_Items.Message_Box.MessageBox msgbox = new Main.GUI_Items.Message_Box.MessageBox("-1");
            msgbox.ShowDialog();
#endif



        }

       

        private static void FormedOpened_FormOpen(string obj)
        {
           
        }
    }
}
