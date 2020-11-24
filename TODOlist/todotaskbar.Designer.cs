namespace TODOlist
{
    partial class todotaskbar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(todotaskbar));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.duedatetextbox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonmovedown = new System.Windows.Forms.Button();
            this.buttonmoveup = new System.Windows.Forms.Button();
            this.todobar = new System.Windows.Forms.PictureBox();
            this.taskactionpanel = new System.Windows.Forms.Panel();
            this.deletetaskbtn = new System.Windows.Forms.Button();
            this.mvdonebtn = new System.Windows.Forms.Button();
            this.mvdoingbtn = new System.Windows.Forms.Button();
            this.moveto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.todobar)).BeginInit();
            this.taskactionpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(108)))), ((int)(((byte)(141)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox1.Location = new System.Drawing.Point(86, 16);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(529, 19);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Add the text here";
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // duedatetextbox
            // 
            this.duedatetextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(108)))), ((int)(((byte)(141)))));
            this.duedatetextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.duedatetextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duedatetextbox.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.duedatetextbox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.duedatetextbox.Location = new System.Drawing.Point(631, 40);
            this.duedatetextbox.Margin = new System.Windows.Forms.Padding(2);
            this.duedatetextbox.Name = "duedatetextbox";
            this.duedatetextbox.Size = new System.Drawing.Size(88, 16);
            this.duedatetextbox.TabIndex = 20;
            this.duedatetextbox.Text = "12/12/2020";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.buttonmovedown.Location = new System.Drawing.Point(34, 27);
            this.buttonmovedown.Margin = new System.Windows.Forms.Padding(2);
            this.buttonmovedown.Name = "buttonmovedown";
            this.buttonmovedown.Size = new System.Drawing.Size(25, 35);
            this.buttonmovedown.TabIndex = 12;
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
            this.buttonmoveup.Location = new System.Drawing.Point(34, 2);
            this.buttonmoveup.Margin = new System.Windows.Forms.Padding(2);
            this.buttonmoveup.Name = "buttonmoveup";
            this.buttonmoveup.Size = new System.Drawing.Size(25, 32);
            this.buttonmoveup.TabIndex = 11;
            this.buttonmoveup.UseVisualStyleBackColor = false;
            // 
            // todobar
            // 
            this.todobar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("todobar.BackgroundImage")));
            this.todobar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.todobar.Location = new System.Drawing.Point(3, 2);
            this.todobar.Margin = new System.Windows.Forms.Padding(2);
            this.todobar.Name = "todobar";
            this.todobar.Size = new System.Drawing.Size(772, 60);
            this.todobar.TabIndex = 1;
            this.todobar.TabStop = false;
            this.todobar.Click += new System.EventHandler(this.todobar_Click);
            // 
            // taskactionpanel
            // 
            this.taskactionpanel.Controls.Add(this.deletetaskbtn);
            this.taskactionpanel.Controls.Add(this.mvdonebtn);
            this.taskactionpanel.Controls.Add(this.mvdoingbtn);
            this.taskactionpanel.Controls.Add(this.moveto);
            this.taskactionpanel.Location = new System.Drawing.Point(586, 8);
            this.taskactionpanel.Margin = new System.Windows.Forms.Padding(2);
            this.taskactionpanel.MaximumSize = new System.Drawing.Size(124, 104);
            this.taskactionpanel.MinimumSize = new System.Drawing.Size(124, 27);
            this.taskactionpanel.Name = "taskactionpanel";
            this.taskactionpanel.Size = new System.Drawing.Size(124, 27);
            this.taskactionpanel.TabIndex = 21;
            // 
            // deletetaskbtn
            // 
            this.deletetaskbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(64)))), ((int)(((byte)(89)))));
            this.deletetaskbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletetaskbtn.Location = new System.Drawing.Point(0, 80);
            this.deletetaskbtn.Margin = new System.Windows.Forms.Padding(2);
            this.deletetaskbtn.Name = "deletetaskbtn";
            this.deletetaskbtn.Size = new System.Drawing.Size(124, 22);
            this.deletetaskbtn.TabIndex = 3;
            this.deletetaskbtn.Text = "delete";
            this.deletetaskbtn.UseVisualStyleBackColor = false;
            // 
            // mvdonebtn
            // 
            this.mvdonebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(64)))), ((int)(((byte)(89)))));
            this.mvdonebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mvdonebtn.Location = new System.Drawing.Point(0, 54);
            this.mvdonebtn.Margin = new System.Windows.Forms.Padding(2);
            this.mvdonebtn.Name = "mvdonebtn";
            this.mvdonebtn.Size = new System.Drawing.Size(124, 22);
            this.mvdonebtn.TabIndex = 2;
            this.mvdonebtn.Text = "move to done";
            this.mvdonebtn.UseVisualStyleBackColor = false;
            // 
            // mvdoingbtn
            // 
            this.mvdoingbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(64)))), ((int)(((byte)(89)))));
            this.mvdoingbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mvdoingbtn.Location = new System.Drawing.Point(0, 27);
            this.mvdoingbtn.Margin = new System.Windows.Forms.Padding(2);
            this.mvdoingbtn.Name = "mvdoingbtn";
            this.mvdoingbtn.Size = new System.Drawing.Size(124, 22);
            this.mvdoingbtn.TabIndex = 1;
            this.mvdoingbtn.Text = "move to doing";
            this.mvdoingbtn.UseVisualStyleBackColor = false;
            // 
            // moveto
            // 
            this.moveto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(64)))), ((int)(((byte)(89)))));
            this.moveto.Dock = System.Windows.Forms.DockStyle.Top;
            this.moveto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moveto.Location = new System.Drawing.Point(0, 0);
            this.moveto.Margin = new System.Windows.Forms.Padding(2);
            this.moveto.Name = "moveto";
            this.moveto.Size = new System.Drawing.Size(124, 27);
            this.moveto.TabIndex = 0;
            this.moveto.Text = "move/delete";
            this.moveto.UseVisualStyleBackColor = false;
            this.moveto.Click += new System.EventHandler(this.moveto_Click);
            // 
            // todotaskbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Controls.Add(this.taskactionpanel);
            this.Controls.Add(this.duedatetextbox);
            this.Controls.Add(this.buttonmovedown);
            this.Controls.Add(this.buttonmoveup);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.todobar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "todotaskbar";
            this.Size = new System.Drawing.Size(775, 64);
            ((System.ComponentModel.ISupportInitialize)(this.todobar)).EndInit();
            this.taskactionpanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox todobar;
        private System.Windows.Forms.Button buttonmoveup;
        private System.Windows.Forms.Button buttonmovedown;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox duedatetextbox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel taskactionpanel;
        private System.Windows.Forms.Button deletetaskbtn;
        private System.Windows.Forms.Button mvdonebtn;
        private System.Windows.Forms.Button mvdoingbtn;
        private System.Windows.Forms.Button moveto;
    }
}
