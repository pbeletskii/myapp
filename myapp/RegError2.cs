using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myapp
{
    public partial class RegError2 : Form
    {
        string str1;
        public RegError2(string str)
        {
            InitializeComponent();
            str1 = str;
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Registeration reg = new Registeration(str1);
            reg.Show();
            this.Hide();
        }
    }
}
