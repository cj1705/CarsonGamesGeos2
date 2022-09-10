using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsonGamesGeos2.MainForms
{
    public partial class console : Form
    {

        public console()
        {
            InitializeComponent();
        }

        private void consoleControl1_Load(object sender, EventArgs e)
        {
            try
            {
               
              

            }
            catch
            {

            }
        }

        private void titlebar1_Load(object sender, EventArgs e)
        {

        }

        private void console_Load(object sender, EventArgs e)
        {

        }

        private void consoleControl1_Load_1(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void consoleControl1_Load_2(object sender, EventArgs e)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            processStartInfo.FileName = "geos/CGConsole.exe";
            consoleControl1.StartProcess(processStartInfo);
        }
    }
}
