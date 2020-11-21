namespace TODOlist
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.todotaskpanel = new System.Windows.Forms.Panel();
            this.buttonmovedown = new System.Windows.Forms.Button();
            this.buttonmoveup = new System.Windows.Forms.Button();
            this.labeltask = new System.Windows.Forms.Label();
            this.todobar = new System.Windows.Forms.PictureBox();
            this.todotaskpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.todobar)).BeginInit();
            this.SuspendLayout();
            // 
            // todotaskpanel
            // 
            this.todotaskpanel.Controls.Add(this.buttonmovedown);
            this.todotaskpanel.Controls.Add(this.buttonmoveup);
            this.todotaskpanel.Controls.Add(this.labeltask);
            this.todotaskpanel.Controls.Add(this.todobar);
            this.todotaskpanel.Location = new System.Drawing.Point(12, 12);
            this.todotaskpanel.Name = "todotaskpanel";
            this.todotaskpanel.Size = new System.Drawing.Size(1042, 80);
            this.todotaskpanel.TabIndex = 6;
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
            this.buttonmovedown.Location = new System.Drawing.Point(40, 34);
            this.buttonmovedown.Name = "buttonmovedown";
            this.buttonmovedown.Size = new System.Drawing.Size(33, 43);
            this.buttonmovedown.TabIndex = 8;
            this.buttonmovedown.UseVisualStyleBackColor = false;
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
            this.buttonmoveup.Location = new System.Drawing.Point(40, 3);
            this.buttonmoveup.Name = "buttonmoveup";
            this.buttonmoveup.Size = new System.Drawing.Size(33, 40);
            this.buttonmoveup.TabIndex = 7;
            this.buttonmoveup.UseVisualStyleBackColor = false;
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1055, 96);
            this.Controls.Add(this.todotaskpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.todotaskpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.todobar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel todotaskpanel;
        private System.Windows.Forms.Button buttonmovedown;
        private System.Windows.Forms.Button buttonmoveup;
        private System.Windows.Forms.Label labeltask;
        private System.Windows.Forms.PictureBox todobar;
    }
}