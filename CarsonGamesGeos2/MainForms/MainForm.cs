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

namespace CarsonGamesGeos2.Main
{
    public partial class MainForm : Form
    {
        
        classes.File_Management.Folders folders = new classes.File_Management.Folders();
        classes.WindowControls WindowControls = new classes.WindowControls();
        Dictionary<string, string> size1;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           

#if DEBUG
            WindowControls.Open(new dev.GUI.Debug_Menu.Main(),"window");
#endif
            if (File.Exists("./settings/size.txt")){
                if (size1 == null)
                {

                    using (StreamReader sw = new StreamReader("./settings/size.txt"))
                    {


                        size1 = new JavaScriptSerializer().Deserialize<Dictionary<string, string>>(sw.ReadToEnd());
                        sw.Dispose();

                    }
                }
                int x = Int32.Parse(size1["main"].Split('.')[0].ToString());
                int y = Int32.Parse(size1["main"].Split('.')[1].ToString());
                Size = new Size(x, y);
            }

        }
        public void OpenForm(Form a)
        {
           
                try
                {
        
                  
                       
                    
                }
                catch (Exception ex)
                {

                }
            
            
        }

        private void MainForm_PaddingChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Resize(object sender, EventArgs e)
        {

            if (!folders.CheckForFolder("./settings"))
            {
                folders.CreateFolder("./settings");
            }
            if (!File.Exists("./settings/size.txt"))
            {
              
                using (StreamWriter sw = new StreamWriter("./settings/size.txt"))
                {


                    sw.WriteLine("{}");
                    sw.Dispose();

                }
            }
            using (StreamReader sw = new StreamReader("./settings/size.txt"))
            {


               size1  = new JavaScriptSerializer().Deserialize<Dictionary<string, string>>(sw.ReadToEnd());
                sw.Dispose();

            }
           

            int x = ((Point)this.Size).X;
            int y = ((Point)this.Size).Y;
            string xystring = $"{x.ToString()}.{y.ToString()}";
            double xy = Double.Parse(xystring);
           
            if (size1.ContainsKey("main"))
            {
                size1["main"] = xystring;
            }
            else
            {
                size1.Add("main", xystring);
            }
            using (StreamWriter sw = new StreamWriter("./settings/size.txt"))
            {

                sw.WriteLine(new JavaScriptSerializer().Serialize(size1));
                sw.Dispose();

            } // 




        }
    }
}
