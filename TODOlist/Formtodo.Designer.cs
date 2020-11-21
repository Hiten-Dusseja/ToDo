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
            this.todotaskpanel = new System.Windows.Forms.Panel();
            this.buttonmovedown = new System.Windows.Forms.Button();
            this.buttonmoveup = new System.Windows.Forms.Button();
            this.labeltask = new System.Windows.Forms.Label();
            this.todobar = new System.Windows.Forms.PictureBox();
            this.todotaskpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.todobar)).BeginInit();
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
            this.buttonadd.Location = new System.Drawing.Point(875, 0);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(62, 60);
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
            this.buttondeleteall.Location = new System.Drawing.Point(958, 0);
            this.buttondeleteall.Name = "buttondeleteall";
            this.buttondeleteall.Size = new System.Drawing.Size(60, 57);
            this.buttondeleteall.TabIndex = 6;
            this.buttondeleteall.UseVisualStyleBackColor = false;
            this.buttondeleteall.Click += new System.EventHandler(this.buttondeleteall_Click);
            // 
            // todotaskpanel
            // 
            this.todotaskpanel.Controls.Add(this.buttonmovedown);
            this.todotaskpanel.Controls.Add(this.buttonmoveup);
            this.todotaskpanel.Controls.Add(this.labeltask);
            this.todotaskpanel.Controls.Add(this.todobar);
            this.todotaskpanel.Location = new System.Drawing.Point(2, 78);
            this.todotaskpanel.Name = "todotaskpanel";
            this.todotaskpanel.Size = new System.Drawing.Size(1042, 80);
            this.todotaskpanel.TabIndex = 7;
            // 
            // buttonmovedown
            // 
            this.buttonmovedown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(108)))), ((int)(((byte)(141)))));
            this.buttonmovedown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonmovedown.BackgroundImage")));
            this.buttonmovedown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonmovedown.FlatAppearance.BorderSize = 0;
            this.buttonmovedown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(108)))), ((int)(((byte)(141)))));
            this.buttonmovedown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(108)))), ((int)(((byte)(141)))));
            this.buttonmovedown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonmovedown.ForeColor = System.Drawing.Color.Transparent;
            this.buttonmovedown.Location = new System.Drawing.Point(42, 28);
            this.buttonmovedown.Name = "buttonmovedown";
            this.buttonmovedown.Size = new System.Drawing.Size(25, 32);
            this.buttonmovedown.TabIndex = 8;
            this.buttonmovedown.UseVisualStyleBackColor = false;
            this.buttonmovedown.Click += new System.EventHandler(this.buttonmovedown_Click_1);
            // 
            // buttonmoveup
            // 
            this.buttonmoveup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(108)))), ((int)(((byte)(141)))));
            this.buttonmoveup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonmoveup.BackgroundImage")));
            this.buttonmoveup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonmoveup.FlatAppearance.BorderSize = 0;
            this.buttonmoveup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(108)))), ((int)(((byte)(141)))));
            this.buttonmoveup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(108)))), ((int)(((byte)(141)))));
            this.buttonmoveup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonmoveup.ForeColor = System.Drawing.Color.Transparent;
            this.buttonmoveup.Location = new System.Drawing.Point(42, 3);
            this.buttonmoveup.Name = "buttonmoveup";
            this.buttonmoveup.Size = new System.Drawing.Size(25, 32);
            this.buttonmoveup.TabIndex = 7;
            this.buttonmoveup.UseVisualStyleBackColor = false;
            this.buttonmoveup.Click += new System.EventHandler(this.buttonmoveup_Click);
            // 
            // labeltask
            // 
            this.labeltask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(108)))), ((int)(((byte)(141)))));
            this.labeltask.Location = new System.Drawing.Point(106, 3);
            this.labeltask.MaximumSize = new System.Drawing.Size(500, 500);
            this.labeltask.Name = "labeltask";
            this.labeltask.Size = new System.Drawing.Size(473, 57);
            this.labeltask.TabIndex = 1;
            this.labeltask.Text = "click here to add your task";
            // 
            // todobar
            // 
            this.todobar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("todobar.BackgroundImage")));
            this.todobar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.todobar.Location = new System.Drawing.Point(13, 3);
            this.todobar.Name = "todobar";
            this.todobar.Size = new System.Drawing.Size(1029, 74);
            this.todobar.TabIndex = 0;
            this.todobar.TabStop = false;
            // 
            // Formtodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1056, 713);
            this.Controls.Add(this.todotaskpanel);
            this.Controls.Add(this.buttondeleteall);
            this.Controls.Add(this.buttonadd);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formtodo";
            this.Text = "   ";
            this.Load += new System.EventHandler(this.Formtodo_Load);
            this.todotaskpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.todobar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.Button buttondeleteall;
        private System.Windows.Forms.Panel todotaskpanel;
        private System.Windows.Forms.Button buttonmovedown;
        private System.Windows.Forms.Button buttonmoveup;
        private System.Windows.Forms.Label labeltask;
        private System.Windows.Forms.PictureBox todobar;
    }
}