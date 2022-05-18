using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsonGamesGeos2.classes
{
    public class clock

    {
        public string GetTime()
        {
            return string.Format("{0:HH:mm:ss tt}", DateTime.Now);
        }
    }
}
