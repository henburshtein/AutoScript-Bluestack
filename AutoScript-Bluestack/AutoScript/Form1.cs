using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutoScript
{
    public partial class Form1 : Form
    {
        public int a=0; 
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            
            SendKeys.Send("^V");
            SendKeys.Send("{Enter}");
        //    SendKeys.Send("{Escape}");

        //   // if (a < 1)
        ////    {
        //  //      SendKeys.Send("{Tab}");
        // //       SendKeys.Send("{Tab}");
        // //       SendKeys.Send("{Tab}");
        // //       SendKeys.Send("{Tab}");
        // //   }
        ////    a++;
            
        //    SendKeys.Send("{Enter}");
        //    int i = 2;
        //    for (int j = 0; j < i; j++)
        //    {
        //        SendKeys.Send("{Down}");
        //    }
        //    i++;
        //    SendKeys.Send("{Enter}");


                
        }

     

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
           


        }
    }
}
