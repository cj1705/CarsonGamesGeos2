using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace CarsonGamesGeos2.hlp
{
    public partial class help : Form
    {
       
        public help(string helpfile)
        {
            InitializeComponent();
            Get(helpfile);

        }
        public void Get(string file)
        {
            using (StreamReader sw = new StreamReader(Path.GetFullPath(file)))
            {
                Dictionary<string, string> dic = new JavaScriptSerializer().Deserialize<Dictionary<string, string>>(sw.ReadToEnd());
                foreach(var key in dic)
                {
                    richTextBox1.Text = key.Value.ToString();
                }
            }

        }




        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
