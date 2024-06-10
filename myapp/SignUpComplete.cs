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
    public partial class SignUpComplete : Form
    {
        public SignUpComplete(string str1 , int str2)
        {
            InitializeComponent();
            UserTxt.Text = str1;
            PassTxt.Text = Convert.ToString(str2);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            new User().Show();
            this.Hide();
        }
    }
}
