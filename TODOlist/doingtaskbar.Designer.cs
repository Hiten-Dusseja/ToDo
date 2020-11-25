namespace TODOlist
{
    partial class doingtaskbar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(doingtaskbar));
            this.todobar = new System.Windows.Forms.PictureBox();
            this.taskactionpanel = new System.Windows.Forms.Panel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.deletetaskbtn = new System.Windows.Forms.Button();
            this.mvdonebtn = new System.Windows.Forms.Button();
            this.mvtodobtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonmovedown = new System.Windows.Forms.Button();
            this.buttonmoveup = new System.Windows.Forms.Button();
            this.dd = new System.Windows.Forms.Label();
            this.duedatetextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.todobar)).BeginInit();
            this.taskactionpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // todobar
            // 
            this.todobar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("todobar.BackgroundImage")));
            this.todobar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.todobar.Location = new System.Drawing.Point(13, 10);
            this.todobar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.todobar.Name = "todobar";
            this.todobar.Size = new System.Drawing.Size(1029, 74);
            this.todobar.TabIndex = 2;
            this.todobar.TabStop = false;
            // 
            // taskactionpanel
            // 
            this.taskactionpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(64)))), ((int)(((byte)(89)))));
            this.taskactionpanel.Controls.Add(this.vScrollBar1);
            this.taskactionpanel.Controls.Add(this.deletetaskbtn);
            this.taskactionpanel.Controls.Add(this.mvdonebtn);
            this.taskactionpanel.Controls.Add(this.mvtodobtn);
            this.taskactionpanel.Location = new System.Drawing.Point(826, 17);
            this.taskactionpanel.MaximumSize = new System.Drawing.Size(185, 100);
            this.taskactionpanel.MinimumSize = new System.Drawing.Size(185, 37);
            this.taskactionpanel.Name = "taskactionpanel";
            this.taskactionpanel.Size = new System.Drawing.Size(185, 37);
            this.taskactionpanel.TabIndex = 32;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(169, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(16, 12);
            this.vScrollBar1.TabIndex = 4;
            this.vScrollBar1.Visible = false;
            // 
            // deletetaskbtn
            // 
            this.deletetaskbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(64)))), ((int)(((byte)(89)))));
            this.deletetaskbtn.FlatAppearance.BorderSize = 0;
            this.deletetaskbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletetaskbtn.Location = new System.Drawing.Point(0, 69);
            this.deletetaskbtn.Name = "deletetaskbtn";
            this.deletetaskbtn.Size = new System.Drawing.Size(166, 27);
            this.deletetaskbtn.TabIndex = 3;
            this.deletetaskbtn.Text = "delete";
            this.deletetaskbtn.UseVisualStyleBackColor = false;
            // 
            // mvdonebtn
            // 
            this.mvdonebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(64)))), ((int)(((byte)(89)))));
            this.mvdonebtn.FlatAppearance.BorderSize = 0;
            this.mvdonebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mvdonebtn.Location = new System.Drawing.Point(0, 36);
            this.mvdonebtn.Name = "mvdonebtn";
            this.mvdonebtn.Size = new System.Drawing.Size(166, 27);
            this.mvdonebtn.TabIndex = 2;
            this.mvdonebtn.Text = "move to done";
            this.mvdonebtn.UseVisualStyleBackColor = false;
            // 
            // mvtodobtn
            // 
            this.mvtodobtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(64)))), ((int)(((byte)(89)))));
            this.mvtodobtn.FlatAppearance.BorderSize = 0;
            this.mvtodobtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mvtodobtn.Location = new System.Drawing.Point(0, 3);
            this.mvtodobtn.Name = "mvtodobtn";
            this.mvtodobtn.Size = new System.Drawing.Size(166, 34);
            this.mvtodobtn.TabIndex = 1;
            this.mvtodobtn.Text = "move to to-do";
            this.mvtodobtn.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(108)))), ((int)(((byte)(141)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox1.Location = new System.Drawing.Point(115, 22);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(705, 23);
            this.textBox1.TabIndex = 33;
            this.textBox1.Text = "Add the text here";
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
            this.buttonmovedown.Location = new System.Drawing.Point(63, 41);
            this.buttonmovedown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonmovedown.Name = "buttonmovedown";
            this.buttonmovedown.Size = new System.Drawing.Size(33, 43);
            this.buttonmovedown.TabIndex = 35;
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
            this.buttonmoveup.Location = new System.Drawing.Point(63, 10);
            this.buttonmoveup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonmoveup.Name = "buttonmoveup";
            this.buttonmoveup.Size = new System.Drawing.Size(33, 39);
            this.buttonmoveup.TabIndex = 34;
            this.buttonmoveup.UseVisualStyleBackColor = false;
            // 
            // dd
            // 
            this.dd.AutoSize = true;
            this.dd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(108)))), ((int)(((byte)(141)))));
            this.dd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dd.ForeColor = System.Drawing.Color.Black;
            this.dd.Location = new System.Drawing.Point(822, 58);
            this.dd.Name = "dd";
            this.dd.Size = new System.Drawing.Size(45, 20);
            this.dd.TabIndex = 37;
            this.dd.Text = "Due:";
            // 
            // duedatetextbox
            // 
            this.duedatetextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(108)))), ((int)(((byte)(141)))));
            this.duedatetextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.duedatetextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duedatetextbox.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.duedatetextbox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.duedatetextbox.Location = new System.Drawing.Point(878, 59);
            this.duedatetextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.duedatetextbox.Name = "duedatetextbox";
            this.duedatetextbox.Size = new System.Drawing.Size(117, 20);
            this.duedatetextbox.TabIndex = 36;
            this.duedatetextbox.Text = "12/12/2020";
            // 
            // doingtaskbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Controls.Add(this.dd);
            this.Controls.Add(this.duedatetextbox);
            this.Controls.Add(this.buttonmovedown);
            this.Controls.Add(this.buttonmoveup);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.taskactionpanel);
            this.Controls.Add(this.todobar);
            this.Name = "doingtaskbar";
            this.Size = new System.Drawing.Size(1050, 84);
            ((System.ComponentModel.ISupportInitialize)(this.todobar)).EndInit();
            this.taskactionpanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox todobar;
        private System.Windows.Forms.Panel taskactionpanel;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button deletetaskbtn;
        private System.Windows.Forms.Button mvdonebtn;
        private System.Windows.Forms.Button mvtodobtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonmovedown;
        private System.Windows.Forms.Button buttonmoveup;
        private System.Windows.Forms.Label dd;
        private System.Windows.Forms.TextBox duedatetextbox;
    }
}
