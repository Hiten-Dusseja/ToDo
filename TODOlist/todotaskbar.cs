using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TODOlist
{
    public partial class todotaskbar : UserControl
    {
        public todotaskbar()
        {
            InitializeComponent();
        }
     
      

       

       

        private bool isCollapsed;


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                //.Image = Resources.Collapse_Arrow_20px;
                taskactionpanel.Height += 10;
                if (taskactionpanel.Size == taskactionpanel.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
               // button5.Image = Resources.Expand_Arrow_20px;
                taskactionpanel.Height -= 10;
                if (taskactionpanel.Size == taskactionpanel.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }

        }

        private void moveto_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Add the text here";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Add the text here")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void todobar_Click(object sender, EventArgs e)
        {
            
           
        }
    }
}
