namespace myapp
{
    partial class StaffDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffDashboard));
            this.sidepanel = new System.Windows.Forms.Panel();
            this.logopanel = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.headerpanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.CityBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AtBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DelayBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.OfficeBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.StaffBtn = new System.Windows.Forms.Button();
            this.TourBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.sidepanel.SuspendLayout();
            this.logopanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.headerpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.sidepanel.Controls.Add(this.logopanel);
            this.sidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidepanel.Location = new System.Drawing.Point(0, 0);
            this.sidepanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(144, 297);
            this.sidepanel.TabIndex = 3;
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
            this.headerpanel.Controls.Add(this.label2);
            this.headerpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerpanel.Location = new System.Drawing.Point(144, 0);
            this.headerpanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.headerpanel.Name = "headerpanel";
            this.headerpanel.Size = new System.Drawing.Size(486, 56);
            this.headerpanel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(150, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Staff Dashboard";
            // 
            // CityBtn
            // 
            this.CityBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CityBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CityBtn.Location = new System.Drawing.Point(298, 72);
            this.CityBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CityBtn.Name = "CityBtn";
            this.CityBtn.Size = new System.Drawing.Size(71, 21);
            this.CityBtn.TabIndex = 5;
            this.CityBtn.Text = "Cities";
            this.CityBtn.UseVisualStyleBackColor = false;
            this.CityBtn.Click += new System.EventHandler(this.CityBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(162, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Edit Cities";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(162, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Edit Available Tours";
            // 
            // AtBtn
            // 
            this.AtBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AtBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AtBtn.Location = new System.Drawing.Point(298, 104);
            this.AtBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AtBtn.Name = "AtBtn";
            this.AtBtn.Size = new System.Drawing.Size(71, 44);
            this.AtBtn.TabIndex = 8;
            this.AtBtn.Text = "Available Tours";
            this.AtBtn.UseVisualStyleBackColor = false;
            this.AtBtn.Click += new System.EventHandler(this.AtBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(162, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Edit Delay of Tours";
            // 
            // DelayBtn
            // 
            this.DelayBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DelayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DelayBtn.Location = new System.Drawing.Point(298, 159);
            this.DelayBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DelayBtn.Name = "DelayBtn";
            this.DelayBtn.Size = new System.Drawing.Size(71, 28);
            this.DelayBtn.TabIndex = 10;
            this.DelayBtn.Text = "Delay";
            this.DelayBtn.UseVisualStyleBackColor = false;
            this.DelayBtn.Click += new System.EventHandler(this.DelayBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(162, 206);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Edit Offices";
            // 
            // OfficeBtn
            // 
            this.OfficeBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.OfficeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.OfficeBtn.Location = new System.Drawing.Point(298, 202);
            this.OfficeBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OfficeBtn.Name = "OfficeBtn";
            this.OfficeBtn.Size = new System.Drawing.Size(71, 28);
            this.OfficeBtn.TabIndex = 12;
            this.OfficeBtn.Text = "Offices";
            this.OfficeBtn.UseVisualStyleBackColor = false;
            this.OfficeBtn.Click += new System.EventHandler(this.OfficeBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(404, 80);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Edit Staff";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(404, 125);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Edit Tours";
            // 
            // StaffBtn
            // 
            this.StaffBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.StaffBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.StaffBtn.Location = new System.Drawing.Point(520, 72);
            this.StaffBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StaffBtn.Name = "StaffBtn";
            this.StaffBtn.Size = new System.Drawing.Size(69, 21);
            this.StaffBtn.TabIndex = 18;
            this.StaffBtn.Text = "Staff";
            this.StaffBtn.UseVisualStyleBackColor = false;
            this.StaffBtn.Click += new System.EventHandler(this.StaffBtn_Click);
            // 
            // TourBtn
            // 
            this.TourBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TourBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TourBtn.Location = new System.Drawing.Point(520, 119);
            this.TourBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TourBtn.Name = "TourBtn";
            this.TourBtn.Size = new System.Drawing.Size(69, 28);
            this.TourBtn.TabIndex = 20;
            this.TourBtn.Text = "Tours";
            this.TourBtn.UseVisualStyleBackColor = false;
            this.TourBtn.Click += new System.EventHandler(this.TourBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.logoutBtn.Location = new System.Drawing.Point(450, 228);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(76, 37);
            this.logoutBtn.TabIndex = 21;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // StaffDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(630, 297);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.TourBtn);
            this.Controls.Add(this.StaffBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.OfficeBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DelayBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AtBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CityBtn);
            this.Controls.Add(this.headerpanel);
            this.Controls.Add(this.sidepanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StaffDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffDashboard";
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

        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Panel logopanel;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel headerpanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CityBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AtBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DelayBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button OfficeBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button StaffBtn;
        private System.Windows.Forms.Button TourBtn;
        private System.Windows.Forms.Button logoutBtn;
    }
}