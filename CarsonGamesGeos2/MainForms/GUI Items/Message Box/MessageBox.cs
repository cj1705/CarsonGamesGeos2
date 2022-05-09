using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsonGamesGeos2.Main.GUI_Items.Message_Box
{
    public partial class MessageBox : Form
    {
        
      

      

        public MessageBox(string text)
        {
            InitializeComponent();

            richTextBox1.Text = ParseString(text);
            //jDragControl1.TargetControl = titlebar1.panel1;
        //    jDragControl1.GetForm = this;
        
        }

       

        private void titlebar1_Load(object sender, EventArgs e)
        {
          
        }
        public string ParseString(string text)
        {
            string a = " ";
            if (text == "-1")
            {
                a = "Generic Error -1";
            }


            return a;

        }

       

        private void MessageBox_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
