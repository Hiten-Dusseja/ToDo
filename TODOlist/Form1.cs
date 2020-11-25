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
    public partial class Form1 : Form
    {
        //private Button currentBtn;
        //private Panel leftBorderBtn;
        //private Form currentChildForm;

        public Form1()
        {
            InitializeComponent();
            //leftBorderBtn = new Panel();
            //leftBorderBtn.Size = new Size(7, 60);
            //dashboardpanel.Controls.Add(leftBorderBtn);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void resetbuttons()
        {
            todobutton.BackColor = Color.FromArgb(45, 64, 89);
            doingbutton.BackColor = Color.FromArgb(45, 64, 89);
            donebutton.BackColor = Color.FromArgb(45, 64, 89);
            progressbutton.BackColor = Color.FromArgb(45, 64, 89);


        }
        private void todobutton_Click(object sender, EventArgs e)
        {
            resetbuttons();
            todobutton.BackColor = Color.FromArgb(81, 108, 141);
            this.formloaderpanel.Controls.Clear();
            Formtodo formtodovrb = new Formtodo() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formtodovrb.FormBorderStyle = FormBorderStyle.None;
            this.formloaderpanel.Controls.Add(formtodovrb);
            formtodovrb.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void doingbutton_Click(object sender, EventArgs e)
        {
            resetbuttons();
            doingbutton.BackColor = Color.FromArgb(81, 108, 141);
            this.formloaderpanel.Controls.Clear();
        }

        private void donebutton_Click(object sender, EventArgs e)
        {
            resetbuttons();
            donebutton.BackColor = Color.FromArgb(81, 108, 141);
        }

        private void progressbutton_Click(object sender, EventArgs e)
        {
            resetbuttons();
            progressbutton.BackColor = Color.FromArgb(81, 108, 141);
        }

        private void delete_Click(object sender, EventArgs e)
        {

        }

        private void movetodone_Click(object sender, EventArgs e)
        {

        }

        private void delete_Click_1(object sender, EventArgs e)
        {

        }



        


    }
}
