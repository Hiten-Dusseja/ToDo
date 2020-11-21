using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using Plasmoid.Extensions;

namespace TODOlist
{
    public partial class Formtodo : Form
    {
        public Formtodo()
        {
            InitializeComponent();
        }

        private void Formtodo_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void todobar_Click(object sender, EventArgs e)
        {

        }
        //Random R = new Random();
        private void buttondeleteall_Click(object sender, EventArgs e)
        {
            //Panel p = new Panel();
            //p.Name = "panel" + (flowLayoutPanel1.Controls.Count + 1);
            //p.BackColor = Color.FromArgb(123, R.Next(222), R.Next(222));
            //p.Size = new Size(flowLayoutPanel1.ClientSize.Width, 50);
            //flowLayoutPanel1.Controls.Add(p);
            //flowLayoutPanel1.Controls.SetChildIndex(p, 0);  // this moves the new one to the top!
            //                                                // this is just for fun:
            //p.Paint += (ss, ee) => { ee.Graphics.DrawString(p.Name, Font, Brushes.White, 22, 11); };
            //flowLayoutPanel1.Invalidate();

        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            //Panel p = new Panel();
            //p.Name = "panel" + (todotaskpanel.Controls.Count + 1);
            ////p.BackColor = Color.FromArgb(123, R.Next(222), R.Next(222));
            //p.Size = new Size(todotaskpanel.ClientSize.Width, 50);
            //todotaskpanel.Controls.Add(p);
            //todotaskpanel.Controls.SetChildIndex(p,600);  // this moves the new one to the top!
            //                                              // this is just for fun:
            ////p.Paint += (ss, ee) => { ee.Graphics.DrawString(p.Name, Font, Brushes.White, 22, 11); };
            //todotaskpanel.Invalidate();
             int i= 2;


            Panel temp = new Panel();
            temp = this.todotaskpanel;
            Controls.Add(temp);
            //  Panel temp1 = new Panel();
            temp.Location = new Point(i, 200 + i);
            this.Controls.Add(temp);




            //this.flowLayoutPanel1.Controls.Clear();
            //Formtodo formtodovrb = new Formtodo() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            //formtodovrb.FormBorderStyle = FormBorderStyle.None;
            //this.flowLayoutPanel1.Controls.Add(formtodovrb);
            //formtodovrb.Show();


        }

        private void buttonmovedown_Click(object sender, EventArgs e)
        {

        }

      

       
    }
}
