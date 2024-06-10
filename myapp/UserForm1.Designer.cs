namespace myapp
{
    partial class UserForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm1));
            this.sidepanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.logopanel = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.headerpanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.SrcCitytxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SrcCityBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.DsCitytxt = new System.Windows.Forms.TextBox();
            this.DsCityBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Costtxt = new System.Windows.Forms.TextBox();
            this.CostBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Typetxt = new System.Windows.Forms.TextBox();
            this.TypeBtn = new System.Windows.Forms.Button();
            this.AllBtn = new System.Windows.Forms.Button();
            this.AvToursGrid = new System.Windows.Forms.DataGridView();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.YourTakenGrid = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.sidepanel.SuspendLayout();
            this.logopanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.headerpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvToursGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YourTakenGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.sidepanel.Controls.Add(this.label4);
            this.sidepanel.Controls.Add(this.label3);
            this.sidepanel.Controls.Add(this.logopanel);
            this.sidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidepanel.Location = new System.Drawing.Point(0, 0);
            this.sidepanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(144, 420);
            this.sidepanel.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(9, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 208);
            this.label4.TabIndex = 6;
            this.label4.Text = "You can search by SourceCity or DestinationCity or Cost or TourType or all of the" +
    "se filters in list of Available Tours";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(9, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 67);
            this.label3.TabIndex = 9;
            this.label3.Text = "You can search for tours here";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.headerpanel.Size = new System.Drawing.Size(828, 56);
            this.headerpanel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(290, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Available Tours Panel";
            // 
            // SrcCitytxt
            // 
            this.SrcCitytxt.Location = new System.Drawing.Point(274, 66);
            this.SrcCitytxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SrcCitytxt.Name = "SrcCitytxt";
            this.SrcCitytxt.Size = new System.Drawing.Size(76, 20);
            this.SrcCitytxt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(148, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "SourceCity";
            // 
            // SrcCityBtn
            // 
            this.SrcCityBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SrcCityBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SrcCityBtn.Location = new System.Drawing.Point(354, 66);
            this.SrcCityBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SrcCityBtn.Name = "SrcCityBtn";
            this.SrcCityBtn.Size = new System.Drawing.Size(56, 19);
            this.SrcCityBtn.TabIndex = 6;
            this.SrcCityBtn.Text = "Search";
            this.SrcCityBtn.UseVisualStyleBackColor = false;
            this.SrcCityBtn.Click += new System.EventHandler(this.SrcCityBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(148, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "DestinationCity";
            // 
            // DsCitytxt
            // 
            this.DsCitytxt.Location = new System.Drawing.Point(274, 88);
            this.DsCitytxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DsCitytxt.Name = "DsCitytxt";
            this.DsCitytxt.Size = new System.Drawing.Size(76, 20);
            this.DsCitytxt.TabIndex = 8;
            // 
            // DsCityBtn
            // 
            this.DsCityBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DsCityBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DsCityBtn.Location = new System.Drawing.Point(354, 88);
            this.DsCityBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DsCityBtn.Name = "DsCityBtn";
            this.DsCityBtn.Size = new System.Drawing.Size(56, 19);
            this.DsCityBtn.TabIndex = 9;
            this.DsCityBtn.Text = "Search";
            this.DsCityBtn.UseVisualStyleBackColor = false;
            this.DsCityBtn.Click += new System.EventHandler(this.DsCityBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(148, 114);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cost";
            // 
            // Costtxt
            // 
            this.Costtxt.Location = new System.Drawing.Point(274, 110);
            this.Costtxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Costtxt.Name = "Costtxt";
            this.Costtxt.Size = new System.Drawing.Size(76, 20);
            this.Costtxt.TabIndex = 11;
            // 
            // CostBtn
            // 
            this.CostBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CostBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CostBtn.Location = new System.Drawing.Point(354, 110);
            this.CostBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CostBtn.Name = "CostBtn";
            this.CostBtn.Size = new System.Drawing.Size(56, 19);
            this.CostBtn.TabIndex = 12;
            this.CostBtn.Text = "Search";
            this.CostBtn.UseVisualStyleBackColor = false;
            this.CostBtn.Click += new System.EventHandler(this.CostBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(148, 136);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "TourType";
            // 
            // Typetxt
            // 
            this.Typetxt.Location = new System.Drawing.Point(274, 132);
            this.Typetxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Typetxt.Name = "Typetxt";
            this.Typetxt.Size = new System.Drawing.Size(76, 20);
            this.Typetxt.TabIndex = 15;
            // 
            // TypeBtn
            // 
            this.TypeBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TypeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TypeBtn.Location = new System.Drawing.Point(354, 132);
            this.TypeBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TypeBtn.Name = "TypeBtn";
            this.TypeBtn.Size = new System.Drawing.Size(56, 19);
            this.TypeBtn.TabIndex = 16;
            this.TypeBtn.Text = "Search";
            this.TypeBtn.UseVisualStyleBackColor = false;
            this.TypeBtn.Click += new System.EventHandler(this.TypeBtn_Click);
            // 
            // AllBtn
            // 
            this.AllBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AllBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AllBtn.Location = new System.Drawing.Point(274, 165);
            this.AllBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AllBtn.Name = "AllBtn";
            this.AllBtn.Size = new System.Drawing.Size(88, 41);
            this.AllBtn.TabIndex = 17;
            this.AllBtn.Text = "Search by all filters";
            this.AllBtn.UseVisualStyleBackColor = false;
            this.AllBtn.Click += new System.EventHandler(this.AllBtn_Click);
            // 
            // AvToursGrid
            // 
            this.AvToursGrid.BackgroundColor = System.Drawing.Color.White;
            this.AvToursGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AvToursGrid.Location = new System.Drawing.Point(561, 91);
            this.AvToursGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AvToursGrid.Name = "AvToursGrid";
            this.AvToursGrid.RowTemplate.Height = 24;
            this.AvToursGrid.Size = new System.Drawing.Size(393, 301);
            this.AvToursGrid.TabIndex = 18;
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RegisterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RegisterBtn.Location = new System.Drawing.Point(274, 378);
            this.RegisterBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(88, 32);
            this.RegisterBtn.TabIndex = 19;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = false;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LogOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LogOutBtn.Location = new System.Drawing.Point(385, 378);
            this.LogOutBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(88, 32);
            this.LogOutBtn.TabIndex = 20;
            this.LogOutBtn.Text = "LogOut";
            this.LogOutBtn.UseVisualStyleBackColor = false;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(171, 223);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Your Tours";
            // 
            // YourTakenGrid
            // 
            this.YourTakenGrid.BackgroundColor = System.Drawing.Color.White;
            this.YourTakenGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.YourTakenGrid.Location = new System.Drawing.Point(160, 249);
            this.YourTakenGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.YourTakenGrid.Name = "YourTakenGrid";
            this.YourTakenGrid.RowTemplate.Height = 24;
            this.YourTakenGrid.Size = new System.Drawing.Size(382, 124);
            this.YourTakenGrid.TabIndex = 22;
            this.YourTakenGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(569, 66);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "Available Tours";
            // 
            // UserForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(972, 420);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.YourTakenGrid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.AvToursGrid);
            this.Controls.Add(this.AllBtn);
            this.Controls.Add(this.TypeBtn);
            this.Controls.Add(this.Typetxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CostBtn);
            this.Controls.Add(this.Costtxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DsCityBtn);
            this.Controls.Add(this.DsCitytxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SrcCityBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SrcCitytxt);
            this.Controls.Add(this.headerpanel);
            this.Controls.Add(this.sidepanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm1";
            this.Load += new System.EventHandler(this.UserForm1_Load);
            this.sidepanel.ResumeLayout(false);
            this.logopanel.ResumeLayout(false);
            this.logopanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.headerpanel.ResumeLayout(false);
            this.headerpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvToursGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YourTakenGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel logopanel;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel headerpanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SrcCitytxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SrcCityBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DsCitytxt;
        private System.Windows.Forms.Button DsCityBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Costtxt;
        private System.Windows.Forms.Button CostBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Typetxt;
        private System.Windows.Forms.Button TypeBtn;
        private System.Windows.Forms.Button AllBtn;
        private System.Windows.Forms.DataGridView AvToursGrid;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView YourTakenGrid;
        private System.Windows.Forms.Label label9;
    }
}