using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsonGamesGeos2.classes
{
    internal class checkforfts
    {
        File_Management.Folders Folders = new File_Management.Folders();
       public bool Check()
        {
            if (Folders.CheckForFolder("./settings"))
            {
                return true;
            }
            return false;
        }
    }
}
