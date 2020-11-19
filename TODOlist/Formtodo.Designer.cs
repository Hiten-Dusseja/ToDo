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
            this.panel1 = new System.Windows.Forms.Panel();
            this.todobar = new System.Windows.Forms.PictureBox();
            this.buttonadd = new System.Windows.Forms.Button();
            this.buttondeleteall = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.todobar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.todobar);
            this.panel1.Location = new System.Drawing.Point(2, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 80);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // todobar
            // 
            this.todobar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("todobar.BackgroundImage")));
            this.todobar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.todobar.Location = new System.Drawing.Point(10, 3);
            this.todobar.Name = "todobar";
            this.todobar.Size = new System.Drawing.Size(1029, 74);
            this.todobar.TabIndex = 0;
            this.todobar.TabStop = false;
            this.todobar.Click += new System.EventHandler(this.todobar_Click);
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
            // Formtodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1056, 713);
            this.Controls.Add(this.buttondeleteall);
            this.Controls.Add(this.buttonadd);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formtodo";
            this.Text = "   ";
            this.Load += new System.EventHandler(this.Formtodo_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.todobar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox todobar;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.Button buttondeleteall;
    }
}