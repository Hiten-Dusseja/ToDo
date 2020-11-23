namespace TODOlist
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.navpanel = new System.Windows.Forms.Panel();
            this.doingbutton = new System.Windows.Forms.Button();
            this.donebutton = new System.Windows.Forms.Button();
            this.progressbutton = new System.Windows.Forms.Button();
            this.todobutton = new System.Windows.Forms.Button();
            this.logopanel = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.formloaderpanel = new System.Windows.Forms.Panel();
            this.navpanel.SuspendLayout();
            this.logopanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // navpanel
            // 
            this.navpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(64)))), ((int)(((byte)(89)))));
            this.navpanel.Controls.Add(this.doingbutton);
            this.navpanel.Controls.Add(this.donebutton);
            this.navpanel.Controls.Add(this.progressbutton);
            this.navpanel.Controls.Add(this.todobutton);
            this.navpanel.Controls.Add(this.logopanel);
            this.navpanel.Location = new System.Drawing.Point(3, 2);
            this.navpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.navpanel.Name = "navpanel";
            this.navpanel.Size = new System.Drawing.Size(265, 758);
            this.navpanel.TabIndex = 1;
            // 
            // doingbutton
            // 
            this.doingbutton.FlatAppearance.BorderSize = 0;
            this.doingbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doingbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doingbutton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.doingbutton.Image = ((System.Drawing.Image)(resources.GetObject("doingbutton.Image")));
            this.doingbutton.Location = new System.Drawing.Point(-3, 254);
            this.doingbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.doingbutton.Name = "doingbutton";
            this.doingbutton.Size = new System.Drawing.Size(268, 82);
            this.doingbutton.TabIndex = 3;
            this.doingbutton.Text = "  DOING";
            this.doingbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.doingbutton.UseVisualStyleBackColor = true;
            this.doingbutton.Click += new System.EventHandler(this.doingbutton_Click);
            // 
            // donebutton
            // 
            this.donebutton.FlatAppearance.BorderSize = 0;
            this.donebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.donebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donebutton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.donebutton.Image = ((System.Drawing.Image)(resources.GetObject("donebutton.Image")));
            this.donebutton.Location = new System.Drawing.Point(0, 334);
            this.donebutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.donebutton.Name = "donebutton";
            this.donebutton.Size = new System.Drawing.Size(267, 82);
            this.donebutton.TabIndex = 2;
            this.donebutton.Text = "  DONE";
            this.donebutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.donebutton.UseVisualStyleBackColor = true;
            this.donebutton.Click += new System.EventHandler(this.donebutton_Click);
            // 
            // progressbutton
            // 
            this.progressbutton.FlatAppearance.BorderSize = 0;
            this.progressbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.progressbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressbutton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.progressbutton.Image = ((System.Drawing.Image)(resources.GetObject("progressbutton.Image")));
            this.progressbutton.Location = new System.Drawing.Point(0, 414);
            this.progressbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressbutton.Name = "progressbutton";
            this.progressbutton.Size = new System.Drawing.Size(267, 82);
            this.progressbutton.TabIndex = 1;
            this.progressbutton.Text = "  PROGRESS";
            this.progressbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.progressbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.progressbutton.UseVisualStyleBackColor = true;
            this.progressbutton.Click += new System.EventHandler(this.progressbutton_Click);
            // 
            // todobutton
            // 
            this.todobutton.FlatAppearance.BorderSize = 0;
            this.todobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.todobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todobutton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.todobutton.Image = ((System.Drawing.Image)(resources.GetObject("todobutton.Image")));
            this.todobutton.Location = new System.Drawing.Point(0, 175);
            this.todobutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.todobutton.Name = "todobutton";
            this.todobutton.Size = new System.Drawing.Size(267, 82);
            this.todobutton.TabIndex = 0;
            this.todobutton.Text = "  TO-DO";
            this.todobutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.todobutton.UseVisualStyleBackColor = true;
            this.todobutton.Click += new System.EventHandler(this.todobutton_Click);
            // 
            // logopanel
            // 
            this.logopanel.Controls.Add(this.logo);
            this.logopanel.Location = new System.Drawing.Point(0, 0);
            this.logopanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logopanel.Name = "logopanel";
            this.logopanel.Size = new System.Drawing.Size(264, 174);
            this.logopanel.TabIndex = 0;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(71, 11);
            this.logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(109, 130);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // formloaderpanel
            // 
            this.formloaderpanel.Location = new System.Drawing.Point(273, 2);
            this.formloaderpanel.Name = "formloaderpanel";
            this.formloaderpanel.Size = new System.Drawing.Size(1078, 713);
            this.formloaderpanel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1355, 723);
            this.Controls.Add(this.formloaderpanel);
            this.Controls.Add(this.navpanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "ToDo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.navpanel.ResumeLayout(false);
            this.logopanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navpanel;
        private System.Windows.Forms.Button doingbutton;
        private System.Windows.Forms.Button donebutton;
        private System.Windows.Forms.Button progressbutton;
        private System.Windows.Forms.Button todobutton;
        private System.Windows.Forms.Panel logopanel;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel formloaderpanel;
    }
}

