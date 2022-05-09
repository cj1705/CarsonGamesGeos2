using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsonGamesGeos2.dev
{
    internal class debug
    {
        public void StartDebug()
        {
            Console.WriteLine(MainResources.title);
            Console.WriteLine("(1) Start Geos");
            var answer = Console.ReadLine();
            if(answer != null)
            {
                if(answer  == "1")
                {
                    Main.MainForm MainForm = new Main.MainForm();
                    MainForm.ShowDialog();
                }
            }
        }
    }
}
