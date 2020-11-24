namespace TODOlist
{
    partial class Formtodo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formtodo));
            this.buttonadd = new System.Windows.Forms.Button();
            this.buttondeleteall = new System.Windows.Forms.Button();
            this.todotaskspanel = new System.Windows.Forms.FlowLayoutPanel();
            this.todotaskbar1 = new TODOlist.todotaskbar();
            this.todotaskspanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonadd
            // 
            this.buttonadd.BackColor = System.Drawing.Color.Transparent;
            this.buttonadd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonadd.BackgroundImage")));
            this.buttonadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonadd.FlatAppearance.BorderSize = 0;
            this.buttonadd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonadd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonadd.ForeColor = System.Drawing.Color.Transparent;
            this.buttonadd.Location = new System.Drawing.Point(656, 0);
            this.buttonadd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(46, 49);
            this.buttonadd.TabIndex = 1;
            this.buttonadd.UseVisualStyleBackColor = false;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // buttondeleteall
            // 
            this.buttondeleteall.BackColor = System.Drawing.Color.Transparent;
            this.buttondeleteall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttondeleteall.BackgroundImage")));
            this.buttondeleteall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttondeleteall.FlatAppearance.BorderSize = 0;
            this.buttondeleteall.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttondeleteall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttondeleteall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttondeleteall.ForeColor = System.Drawing.Color.Transparent;
            this.buttondeleteall.Location = new System.Drawing.Point(718, 0);
            this.buttondeleteall.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttondeleteall.Name = "buttondeleteall";
            this.buttondeleteall.Size = new System.Drawing.Size(45, 46);
            this.buttondeleteall.TabIndex = 6;
            this.buttondeleteall.UseVisualStyleBackColor = false;
            this.buttondeleteall.Click += new System.EventHandler(this.buttondeleteall_Click);
            // 
            // todotaskspanel
            // 
            this.todotaskspanel.AutoScroll = true;
            this.todotaskspanel.Controls.Add(this.todotaskbar1);
            this.todotaskspanel.Location = new System.Drawing.Point(2, 64);
            this.todotaskspanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.todotaskspanel.Name = "todotaskspanel";
            this.todotaskspanel.Size = new System.Drawing.Size(781, 505);
            this.todotaskspanel.TabIndex = 7;
            // 
            // todotaskbar1
            // 
            this.todotaskbar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.todotaskbar1.Location = new System.Drawing.Point(2, 2);
            this.todotaskbar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.todotaskbar1.Name = "todotaskbar1";
            this.todotaskbar1.Size = new System.Drawing.Size(775, 64);
            this.todotaskbar1.TabIndex = 0;
            this.todotaskbar1.Load += new System.EventHandler(this.todotaskbar1_Load);
            // 
            // Formtodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(792, 579);
            this.Controls.Add(this.todotaskspanel);
            this.Controls.Add(this.buttondeleteall);
            this.Controls.Add(this.buttonadd);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Formtodo";
            this.Text = "   ";
            this.Load += new System.EventHandler(this.Formtodo_Load);
            this.todotaskspanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.Button buttondeleteall;
        private System.Windows.Forms.FlowLayoutPanel todotaskspanel;
        private todotaskbar todotaskbar1;
    }
}