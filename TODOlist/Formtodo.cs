﻿using System;
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
        todotaskbar[] todotaskbaritems = new todotaskbar[15];

        private void buttondeleteall_Click(object sender, EventArgs e)
        {
            todotaskspanel.Controls.Clear();
            
            todotaskbar todotaskbaritems = new todotaskbar();
            todotaskspanel.Controls.Add(todotaskbaritems);


        }
        int i = 0;

        private void buttonadd_Click(object sender, EventArgs e)
        {
          
            todotaskbaritems[i] = new todotaskbar();
            todotaskspanel.Controls.Add(todotaskbaritems[i]);
            i++;
        }

        private void todotaskbar1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
