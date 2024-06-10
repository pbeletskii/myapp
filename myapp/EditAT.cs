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
    public partial class EditAT : Form
    {
        public EditAT()
        {
            InitializeComponent();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            MyContextDataContext nw = new MyContextDataContext();
            if (!string.IsNullOrEmpty(TidTxt.Text))
            {
                var deleterow = from d in nw.Available_Tours
                                where d.TourID == TidTxt.Text
                                select d;
                foreach (var detail in deleterow)
                {
                    nw.Available_Tours.DeleteOnSubmit(detail);
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
            EditAT_Load(sender, e);
        }

        private void EditAT_Load(object sender, EventArgs e)
        {
            MyContextDataContext nw = new MyContextDataContext();
            var atinfo = from at in nw.Available_Tours
                         select at;
            var cityinfo = from c in nw.Cities
                           select c;
            var tourinfo = from t in nw.Tours
                           select t;
            var officeinfo = from of in nw.Offices
                             select of;
            AtGrid.DataSource = atinfo;
            CityGrid.DataSource = cityinfo;
            ToursGrid.DataSource = tourinfo;
            OfficeGrid.DataSource = officeinfo;
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            MyContextDataContext nw = new MyContextDataContext();
            if (!string.IsNullOrEmpty(TouridTxt.Text) && !string.IsNullOrEmpty(TtypeTxt.Text) && !string.IsNullOrEmpty(NumberTxt.Text)
                && !string.IsNullOrEmpty(GoTxt.Text) && !string.IsNullOrEmpty(ComeBackTxt.Text) && !string.IsNullOrEmpty(ScityidTxt.Text)
                && !string.IsNullOrEmpty(DcityidTxt.Text) && !string.IsNullOrEmpty(AccTxt.Text) && !string.IsNullOrEmpty(BTxt.Text)
                && !string.IsNullOrEmpty(LTxt.Text) && !string.IsNullOrEmpty(DTxt.Text) && !string.IsNullOrEmpty(CostTxt.Text)
                && !string.IsNullOrEmpty(OfficeidTxt.Text))
            {
                int flag = 0;
                int flag1 = 0;
                int flag2 = 0;
                int flag3 = 0;
                int flag4 = 0;
                var atinfo = from at in nw.Available_Tours
                             select at;
                var cityinfo = from c in nw.Cities
                               select c;
                var tourinfo = from t in nw.Tours
                               select t;
                var officeinfo = from of in nw.Offices
                                  select of;
                foreach (var a in atinfo)
                {
                    if (a.TourID == TouridTxt.Text)
                    {
                        flag = 1;
                        break;
                    }
                }
                foreach(var c in cityinfo)
                {
                    if (c.CityID == ScityidTxt.Text)
                    {
                        flag1 = 1;
                        break;
                    }
                }
                foreach(var c in cityinfo)
                {
                    if (c.CityID == DcityidTxt.Text)
                    {
                        flag2 = 1;
                        break;
                    }
                }
                foreach(var t in tourinfo)
                {
                    if (t.TourType == TtypeTxt.Text && t.Number == NumberTxt.Text)
                    {
                        flag3 = 1;
                        break;
                    }
                }
                foreach(var o in officeinfo)
                {
                    if (o.OfficeID == OfficeidTxt.Text)
                    {
                        flag4 = 1;
                        break;
                    }
                }
                if (flag == 0 && flag1 == 1 && flag2 == 1 && flag3 == 1 && flag4 == 1)
                {
                    Available_Tour newat = new Available_Tour();
                    newat.TourID = TouridTxt.Text;
                    newat.TourType = TtypeTxt.Text;
                    newat.Number = NumberTxt.Text;
                    newat.Going = Convert.ToDateTime(GoTxt.Text);
                    newat.CommingBack =Convert.ToDateTime(ComeBackTxt.Text);
                    newat.SourceCityID = ScityidTxt.Text;
                    newat.DestinationCityID = DcityidTxt.Text;
                    newat.Accomodation = AccTxt.Text;
                    newat.Breakfast = BTxt.Text;
                    newat.Lunch = LTxt.Text;
                    newat.Dinner = DTxt.Text;
                    newat.Cost = Convert.ToDecimal(CostTxt.Text);
                    newat.OfficeID = OfficeidTxt.Text;
                    nw.Available_Tours.InsertOnSubmit(newat);
                    nw.SubmitChanges();
                }
            }
            EditAT_Load(sender, e);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            new StaffDashboard().Show();
            this.Hide();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TouridTxt.Text) && !string.IsNullOrEmpty(TtypeTxt.Text) && !string.IsNullOrEmpty(NumberTxt.Text)
                    && !string.IsNullOrEmpty(GoTxt.Text) && !string.IsNullOrEmpty(ComeBackTxt.Text) && !string.IsNullOrEmpty(ScityidTxt.Text)
                    && !string.IsNullOrEmpty(DcityidTxt.Text) && !string.IsNullOrEmpty(AccTxt.Text) && !string.IsNullOrEmpty(BTxt.Text)
                    && !string.IsNullOrEmpty(LTxt.Text) && !string.IsNullOrEmpty(DTxt.Text) && !string.IsNullOrEmpty(CostTxt.Text)
                    && !string.IsNullOrEmpty(OfficeidTxt.Text))
            {
                MyContextDataContext nw = new MyContextDataContext();
                int flag = 0;
                int flag1 = 0;
                int flag2 = 0;
                int flag3 = 0;
                int flag4 = 0;
                var atinfo = from at in nw.Available_Tours
                               select at;
                var cityinfo = from c in nw.Cities
                               select c;
                var tourinfo = from t in nw.Tours
                               select t;
                var officeinfo = from of in nw.Offices
                                 select of;
                foreach (var a in atinfo)
                {
                    if (a.TourID == TouridTxt.Text)
                    {
                        flag = 1;
                        break;
                    }
                }
                foreach (var c in cityinfo)
                {
                    if (c.CityID == ScityidTxt.Text)
                    {
                        flag1 = 1;
                        break;
                    }
                }
                foreach (var c in cityinfo)
                {
                    if (c.CityID == DcityidTxt.Text)
                    {
                        flag2 = 1;
                        break;
                    }
                }
                foreach (var t in tourinfo)
                {
                    if (t.TourType == TtypeTxt.Text && t.Number == NumberTxt.Text)
                    {
                        flag3 = 1;
                        break;
                    }
                }
                foreach (var o in officeinfo)
                {
                    if (o.OfficeID == OfficeidTxt.Text)
                    {
                        flag4 = 1;
                        break;
                    }
                }
                
                if (flag == 1 && flag1 == 1 && flag2 == 1 && flag3 == 1 && flag4 ==1)
                {
                    var updateobj = nw.Available_Tours.FirstOrDefault(detail => detail.TourID.Equals(TouridTxt.Text));
                    updateobj.TourType = TtypeTxt.Text;
                    updateobj.Number = NumberTxt.Text;
                    updateobj.Going = Convert.ToDateTime(GoTxt.Text);
                    updateobj.CommingBack = Convert.ToDateTime(ComeBackTxt.Text);
                    updateobj.SourceCityID = ScityidTxt.Text;
                    updateobj.DestinationCityID = DcityidTxt.Text;
                    updateobj.Accomodation = AccTxt.Text;
                    updateobj.Breakfast = BTxt.Text;
                    updateobj.Lunch = LTxt.Text;
                    updateobj.Dinner = DTxt.Text;
                    updateobj.Cost = Convert.ToDecimal(CostTxt.Text);
                    updateobj.OfficeID = OfficeidTxt.Text;
                    nw.SubmitChanges();
                }
                EditAT_Load(sender, e);
            }
        }
    }
}
