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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        private void Userbtn_Click(object sender, EventArgs e)
        {
            new User().Show();
            this.Hide();
        }


        private void Staffbtn_Click(object sender, EventArgs e)
        {
            new StaffForm().Show();
            this.Hide();
        }

    }
}
