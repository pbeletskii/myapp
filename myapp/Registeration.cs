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
    public partial class Registeration : Form
    {
        string pass;
        public Registeration(string password)
        {
            InitializeComponent();
            pass = password;
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            int flag = 0;
            int flag1 = 0;
            MyContextDataContext nw = new MyContextDataContext();
            var tourinfo = from at in nw.Available_Tours
                           select new
                           {
                               at.TourID
                           };
            var ttourinfo = from tt in nw.Taken_Tours
                            select new
                            {
                                tt.TourID,
                                i = Convert.ToInt32(tt.PassengerID)
                            };
            
            foreach (var ti in tourinfo)
            {
                if (ti.TourID == Touridtxt.Text)
                {
                    flag = 1;
                    break;
                }
            }

            if(flag == 0 || string.IsNullOrEmpty(Touridtxt.Text))
            {
                new RegError2(pass).Show();
                this.Hide();
               
            }
            foreach (var tti in ttourinfo)
            {
                if ((flag == 1) && (tti.i == Convert.ToInt32(pass)) && (tti.TourID == Touridtxt.Text))
                {
                    flag1 = 1;
                    break;
                }    
            }
            if(flag1==1)
            {
                new RegError1(pass).Show();
                this.Hide();
            }
            else if(flag1 == 0 && flag == 1)
            {
                Taken_Tour ntt = new Taken_Tour();
                ntt.TourID = Touridtxt.Text;
                ntt.PassengerID = pass;
                nw.Taken_Tours.InsertOnSubmit(ntt);
                nw.SubmitChanges();

                new RegComplete(pass).Show();
                this.Hide();
            }
          
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            new UserForm1(pass).Show();
            this.Hide();
        }
    }
}
