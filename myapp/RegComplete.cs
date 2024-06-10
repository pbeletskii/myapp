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
    public partial class RegComplete : Form
    {
        string str1;
        public RegComplete(string str)
        {
            InitializeComponent();
            str1 = str;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            new UserForm1(str1).Show();
            this.Hide();
        }
    }
}
