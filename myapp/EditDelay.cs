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
    public partial class EditDelay : Form
    {
        public EditDelay()
        {
            InitializeComponent();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            MyContextDataContext nw = new MyContextDataContext();
            if (!string.IsNullOrEmpty(TouridTxt.Text))
            {
                var deleterow = from d in nw.DelayofTours
                                where d.TourID == TouridTxt.Text
                                select d;
                foreach (var detail in deleterow)
                {
                    nw.DelayofTours.DeleteOnSubmit(detail);
                }
                try
                {
                    nw.SubmitChanges();
                }
                catch (Exception ee)
                {
                    Console.WriteLine(ee);
                }
            }
            EditDelay_Load(sender, e);
        }

        private void EditDelay_Load(object sender, EventArgs e)
        {
            MyContextDataContext nw = new MyContextDataContext();
            var delayinfo = from d in nw.DelayofTours
                           select new
                           {
                               d.TourID,
                               d.DelayatGoing,
                               d.DelayatComingBack
                           };
            DelayGrid.DataSource = delayinfo;

            var atinfo = from at in nw.Available_Tours
                         select at;
            AtGrid.DataSource = atinfo;
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            MyContextDataContext nw = new MyContextDataContext();
            if (!string.IsNullOrEmpty(TouridTxt.Text) && !string.IsNullOrEmpty(DgoTxt.Text) && !string.IsNullOrEmpty(DcomeTxt.Text))
            {
                int flag = 0;
                int flag1 = 0;
                var delayinfo = from d in nw.DelayofTours
                               select d;
                var atinfo = from at in nw.Available_Tours
                             select at;
                foreach (var de in delayinfo)
                {
                    if (de.TourID == TouridTxt.Text)
                    {
                        flag = 1;
                        break;
                    }
                }
                foreach(var a in atinfo)
                {
                    if(a.TourID == TouridTxt.Text)
                    {
                        flag1 = 1;
                        break;
                    }
                }
                if (flag == 0 && flag1 == 1)
                {
                    DelayofTour newdelay = new DelayofTour();
                    newdelay.TourID = TouridTxt.Text;
                    newdelay.DelayatGoing = TimeSpan.Parse(DgoTxt.Text);
                    newdelay.DelayatComingBack = TimeSpan.Parse(DcomeTxt.Text);
                    nw.DelayofTours.InsertOnSubmit(newdelay);
                    nw.SubmitChanges();
                }
            }
            EditDelay_Load(sender, e);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            new StaffDashboard().Show();
            this.Hide();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TouridTxt.Text) && !string.IsNullOrEmpty(DgoTxt.Text) && !string.IsNullOrEmpty(DcomeTxt.Text))
            {
                MyContextDataContext nw = new MyContextDataContext();
                int flag = 0;
                var delayinfo = from d in nw.DelayofTours
                                select d;
                foreach (var de in delayinfo)
                {
                    if (de.TourID == TouridTxt.Text)
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 1)
                {
                    var updateobj = nw.DelayofTours.FirstOrDefault(detail => detail.TourID.Equals(TouridTxt.Text));
                    updateobj.DelayatGoing = TimeSpan.Parse(DgoTxt.Text);
                    updateobj.DelayatComingBack = TimeSpan.Parse(DcomeTxt.Text);
                    nw.SubmitChanges();
                }
                EditDelay_Load(sender, e);
            }
        }
    }
}
