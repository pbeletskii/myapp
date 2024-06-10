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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            new MainMenu().Show();
            this.Hide();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            int flag = 0;
            MyContextDataContext nw = new MyContextDataContext();
            var userinfo = from p in nw.Passengers
                           select new
                           {
                               lname=p.LastName,
                                i = Convert.ToInt32(p.PassengerID)
                           };



            if (!string.IsNullOrEmpty(UserNamebox.Text) && !string.IsNullOrEmpty(Passbox.Text))
            {
                foreach (var u in userinfo)
                {
                    if (u.lname == UserNamebox.Text && u.i == Convert.ToInt32(Passbox.Text))
                    {
                        UserForm1 user = new UserForm1(Passbox.Text);
                        user.Show();
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

        private void Signupbtn_Click(object sender, EventArgs e)
        {
            new UserSingup().Show();
            this.Hide();
        }

       

    }
}
