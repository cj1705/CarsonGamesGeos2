using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace CarsonGamesGeos2.classes.File_Management
{
    internal class File
    {
        Main.MainForm main = (Main.MainForm)Application.OpenForms["MainForm"]; 
        public string Get(string path, string file,string key)
        {
            Dictionary<string, string> setting = new Dictionary<string, string>();
           

                setting = new JavaScriptSerializer().Deserialize<Dictionary<string, string>>(System.IO.File.ReadAllText($"./users/{main.loggedin}/settings/{path}/{file}.txt"));
            string result = setting[key];
            return result;


            
        }
    }
}
