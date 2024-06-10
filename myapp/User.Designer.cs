namespace myapp
{
    partial class User
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tourIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sidepanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.logopanel = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.headerpanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UserNamebox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Passbox = new System.Windows.Forms.TextBox();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.Backbtn = new System.Windows.Forms.Button();
            this.Signupbtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.sidepanel.SuspendLayout();
            this.logopanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.headerpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tourIDToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 26);
            // 
            // tourIDToolStripMenuItem
            // 
            this.tourIDToolStripMenuItem.Name = "tourIDToolStripMenuItem";
            this.tourIDToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.tourIDToolStripMenuItem.Text = "TourID";
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.sidepanel.Controls.Add(this.label5);
            this.sidepanel.Controls.Add(this.logopanel);
            this.sidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidepanel.Location = new System.Drawing.Point(0, 0);
            this.sidepanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(144, 258);
            this.sidepanel.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(15, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 118);
            this.label5.TabIndex = 11;
            this.label5.Text = "UserName is LastName and Password is PassengerID";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // logopanel
            // 
            this.logopanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logopanel.Controls.Add(this.logo);
            this.logopanel.Controls.Add(this.pictureBox1);
            this.logopanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logopanel.Location = new System.Drawing.Point(0, 0);
            this.logopanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logopanel.Name = "logopanel";
            this.logopanel.Size = new System.Drawing.Size(144, 56);
            this.logopanel.TabIndex = 3;
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.Font = new System.Drawing.Font("Mistral", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo.Location = new System.Drawing.Point(62, 20);
            this.logo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(80, 16);
            this.logo.TabIndex = 3;
            this.logo.Text = "Travle Agency";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // headerpanel
            // 
            this.headerpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.headerpanel.Controls.Add(this.label4);
            this.headerpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerpanel.Location = new System.Drawing.Point(144, 0);
            this.headerpanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.headerpanel.Name = "headerpanel";
            this.headerpanel.Size = new System.Drawing.Size(256, 56);
            this.headerpanel.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(77, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "User Panel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(148, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "UserName";
            // 
            // UserNamebox
            // 
            this.UserNamebox.Location = new System.Drawing.Point(256, 80);
            this.UserNamebox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserNamebox.Name = "UserNamebox";
            this.UserNamebox.Size = new System.Drawing.Size(98, 20);
            this.UserNamebox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(148, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // Passbox
            // 
            this.Passbox.Location = new System.Drawing.Point(256, 115);
            this.Passbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Passbox.Name = "Passbox";
            this.Passbox.Size = new System.Drawing.Size(98, 20);
            this.Passbox.TabIndex = 6;
            // 
            // Loginbtn
            // 
            this.Loginbtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Loginbtn.Location = new System.Drawing.Point(245, 155);
            this.Loginbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(64, 32);
            this.Loginbtn.TabIndex = 7;
            this.Loginbtn.Text = "Login";
            this.Loginbtn.UseVisualStyleBackColor = false;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // Backbtn
            // 
            this.Backbtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Backbtn.Location = new System.Drawing.Point(317, 155);
            this.Backbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(64, 32);
            this.Backbtn.TabIndex = 8;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = false;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // Signupbtn
            // 
            this.Signupbtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Signupbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Signupbtn.Location = new System.Drawing.Point(167, 155);
            this.Signupbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Signupbtn.Name = "Signupbtn";
            this.Signupbtn.Size = new System.Drawing.Size(64, 32);
            this.Signupbtn.TabIndex = 9;
            this.Signupbtn.Text = "SignUp";
            this.Signupbtn.UseVisualStyleBackColor = false;
            this.Signupbtn.Click += new System.EventHandler(this.Signupbtn_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 258);
            this.Controls.Add(this.Signupbtn);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.Passbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserNamebox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.headerpanel);
            this.Controls.Add(this.sidepanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.contextMenuStrip1.ResumeLayout(false);
            this.sidepanel.ResumeLayout(false);
            this.logopanel.ResumeLayout(false);
            this.logopanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.headerpanel.ResumeLayout(false);
            this.headerpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tourIDToolStripMenuItem;
        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Panel headerpanel;
        private System.Windows.Forms.Panel logopanel;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserNamebox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Passbox;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Signupbtn;
    }
}