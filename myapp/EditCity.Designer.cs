namespace myapp
{
    partial class EditCity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCity));
            this.headerpanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CidTxt = new System.Windows.Forms.TextBox();
            this.CnTxt = new System.Windows.Forms.TextBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.CityGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PcidTxt = new System.Windows.Forms.TextBox();
            this.NcnameTxt = new System.Windows.Forms.TextBox();
            this.logopanel = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sidepanel = new System.Windows.Forms.Panel();
            this.headerpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CityGrid)).BeginInit();
            this.logopanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.sidepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerpanel
            // 
            this.headerpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.headerpanel.Controls.Add(this.label4);
            this.headerpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerpanel.Location = new System.Drawing.Point(144, 0);
            this.headerpanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.headerpanel.Name = "headerpanel";
            this.headerpanel.Size = new System.Drawing.Size(712, 56);
            this.headerpanel.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(279, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Edit Cities";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(209, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "CityID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(210, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "CityName";
            // 
            // CidTxt
            // 
            this.CidTxt.Location = new System.Drawing.Point(311, 68);
            this.CidTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CidTxt.Name = "CidTxt";
            this.CidTxt.Size = new System.Drawing.Size(98, 20);
            this.CidTxt.TabIndex = 3;
            // 
            // CnTxt
            // 
            this.CnTxt.Location = new System.Drawing.Point(311, 91);
            this.CnTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CnTxt.Name = "CnTxt";
            this.CnTxt.Size = new System.Drawing.Size(98, 20);
            this.CnTxt.TabIndex = 4;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Maroon;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DeleteBtn.Location = new System.Drawing.Point(195, 143);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(90, 46);
            this.DeleteBtn.TabIndex = 5;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // InsertBtn
            // 
            this.InsertBtn.BackColor = System.Drawing.Color.Green;
            this.InsertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.InsertBtn.Location = new System.Drawing.Point(302, 143);
            this.InsertBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(90, 46);
            this.InsertBtn.TabIndex = 6;
            this.InsertBtn.Text = "Insert";
            this.InsertBtn.UseVisualStyleBackColor = false;
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.Teal;
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.UpdateBtn.Location = new System.Drawing.Point(195, 287);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(90, 46);
            this.UpdateBtn.TabIndex = 7;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BackBtn.Location = new System.Drawing.Point(629, 287);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(90, 46);
            this.BackBtn.TabIndex = 8;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // CityGrid
            // 
            this.CityGrid.BackgroundColor = System.Drawing.Color.White;
            this.CityGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CityGrid.GridColor = System.Drawing.Color.White;
            this.CityGrid.Location = new System.Drawing.Point(468, 102);
            this.CityGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CityGrid.Name = "CityGrid";
            this.CityGrid.RowTemplate.Height = 24;
            this.CityGrid.Size = new System.Drawing.Size(334, 176);
            this.CityGrid.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(210, 215);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "CityID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(212, 242);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "NewCityName";
            // 
            // PcidTxt
            // 
            this.PcidTxt.Location = new System.Drawing.Point(311, 215);
            this.PcidTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PcidTxt.Name = "PcidTxt";
            this.PcidTxt.Size = new System.Drawing.Size(98, 20);
            this.PcidTxt.TabIndex = 13;
            // 
            // NcnameTxt
            // 
            this.NcnameTxt.Location = new System.Drawing.Point(311, 241);
            this.NcnameTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NcnameTxt.Name = "NcnameTxt";
            this.NcnameTxt.Size = new System.Drawing.Size(98, 20);
            this.NcnameTxt.TabIndex = 15;
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
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.sidepanel.Controls.Add(this.logopanel);
            this.sidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidepanel.Location = new System.Drawing.Point(0, 0);
            this.sidepanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(144, 342);
            this.sidepanel.TabIndex = 2;
            // 
            // EditCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(856, 342);
            this.Controls.Add(this.NcnameTxt);
            this.Controls.Add(this.PcidTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CityGrid);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.InsertBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CidTxt);
            this.Controls.Add(this.CnTxt);
            this.Controls.Add(this.headerpanel);
            this.Controls.Add(this.sidepanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EditCity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditCity";
            this.Load += new System.EventHandler(this.EditCity_Load);
            this.headerpanel.ResumeLayout(false);
            this.headerpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CityGrid)).EndInit();
            this.logopanel.ResumeLayout(false);
            this.logopanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.sidepanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel headerpanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CidTxt;
        private System.Windows.Forms.TextBox CnTxt;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button InsertBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.DataGridView CityGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PcidTxt;
        private System.Windows.Forms.TextBox NcnameTxt;
        private System.Windows.Forms.Panel logopanel;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel sidepanel;
    }
}