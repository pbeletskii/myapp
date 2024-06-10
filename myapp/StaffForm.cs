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
    public partial class StaffForm : Form
    {
        public StaffForm()
        {
            InitializeComponent();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            new MainMenu().Show();
            this.Hide();
        }

        private void Enterbtn_Click(object sender, EventArgs e)
        {
           
            int flag = 0;
            MyContextDataContext nw = new MyContextDataContext();
            var staffinfo = from st in nw.Staffs
                           select new
                           {
                               uname = st.LastName,
                               pass = st.StaffID
                           };



            if (!string.IsNullOrEmpty(UserNametxt.Text) && !string.IsNullOrEmpty(Passwordtxt.Text))
            {
                foreach (var s in staffinfo)
                {
                    if (s.uname == UserNametxt.Text && s.pass == Passwordtxt.Text)
                    {
                        new StaffDashboard().Show();
                        this.Hide();
                        flag = 1;
                        break;
                    }
                }
            }
            if (flag == 0)
            {
                new LoginError().Show();
                this.Hide();
            }
        }
    }
}
