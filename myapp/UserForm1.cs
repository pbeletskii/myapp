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
    public partial class UserForm1 : Form
    {
        string i;
        public UserForm1(string passengerid)
        {
            InitializeComponent();
            i = passengerid;
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            Registeration reg = new Registeration(i);
            reg.Show();
            this.Hide();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            new User().Show();
            this.Hide();
        }

        private void SrcCityBtn_Click(object sender, EventArgs e)
        {
            MyContextDataContext nw = new MyContextDataContext();
            var info = from at in nw.Available_Tours
                        join sc in nw.Cities on at.SourceCityID equals sc.CityID
                        join dc in nw.Cities on at.DestinationCityID equals dc.CityID
                        join of in nw.Offices on at.OfficeID equals of.OfficeID
                        where sc.CityName == SrcCitytxt.Text
                        select new
                        {
                            at.TourID,
                            at.TourType,
                            going_date_and_time = at.Going,
                            comingback_date_and_time = at.CommingBack,
                            SourceCity = sc.CityName,
                            DestinationCity = dc.CityName,
                            at.Accomodation,
                            at.Breakfast,
                            at.Lunch,
                            at.Dinner,
                            at.Cost,
                            OfficeName = of.Name
                        };
            AvToursGrid.DataSource = info;
        }

        private void DsCityBtn_Click(object sender, EventArgs e)
        {
            MyContextDataContext nw = new MyContextDataContext();
            var info = from at in nw.Available_Tours
                        join sc in nw.Cities on at.SourceCityID equals sc.CityID
                        join dc in nw.Cities on at.DestinationCityID equals dc.CityID
                        join of in nw.Offices on at.OfficeID equals of.OfficeID
                        where dc.CityName == DsCitytxt.Text
                        select new
                        {
                            at.TourID,
                            at.TourType,
                            going_date_and_time = at.Going,
                            comingback_date_and_time = at.CommingBack,
                            SourceCity = sc.CityName,
                            DestinationCity = dc.CityName,
                            at.Accomodation,
                            at.Breakfast,
                            at.Lunch,
                            at.Dinner,
                            at.Cost,
                            OfficeName = of.Name
                        };
            AvToursGrid.DataSource = info;
        }

        private void CostBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Costtxt.Text))
            {
                MyContextDataContext nw = new MyContextDataContext();
                var info = from at in nw.Available_Tours
                           join sc in nw.Cities on at.SourceCityID equals sc.CityID
                           join dc in nw.Cities on at.DestinationCityID equals dc.CityID
                           join of in nw.Offices on at.OfficeID equals of.OfficeID
                           where at.Cost <= Convert.ToInt32(Costtxt.Text)
                           select new
                           {
                               at.TourID,
                               at.TourType,
                               going_date_and_time = at.Going,
                               comingback_date_and_time = at.CommingBack,
                               SourceCity = sc.CityName,
                               DestinationCity = dc.CityName,
                               at.Accomodation,
                               at.Breakfast,
                               at.Lunch,
                               at.Dinner,
                               at.Cost,
                               OfficeName = of.Name
                           };
                AvToursGrid.DataSource = info;
            }
        }

        private void TypeBtn_Click(object sender, EventArgs e)
        {
            MyContextDataContext nw = new MyContextDataContext();
            var info = from at in nw.Available_Tours
                        join sc in nw.Cities on at.SourceCityID equals sc.CityID
                        join dc in nw.Cities on at.DestinationCityID equals dc.CityID
                        join of in nw.Offices on at.OfficeID equals of.OfficeID
                        where at.TourType == Typetxt.Text
                        select new
                        {
                            at.TourID,
                            at.TourType,
                            going_date_and_time = at.Going,
                            comingback_date_and_time = at.CommingBack,
                            SourceCity = sc.CityName,
                            DestinationCity = dc.CityName,
                            at.Accomodation,
                            at.Breakfast,
                            at.Lunch,
                            at.Dinner,
                            at.Cost,
                            OfficeName = of.Name
                        };
            AvToursGrid.DataSource = info;
        }

        private void AllBtn_Click(object sender, EventArgs e)
        {
            
            MyContextDataContext nw = new MyContextDataContext();
            if (string.IsNullOrEmpty(SrcCitytxt.Text) && string.IsNullOrEmpty(DsCitytxt.Text) && string.IsNullOrEmpty(Costtxt.Text))
                TypeBtn_Click(sender, e);
            else if (string.IsNullOrEmpty(SrcCitytxt.Text) && string.IsNullOrEmpty(DsCitytxt.Text) && string.IsNullOrEmpty(Typetxt.Text))
                CostBtn_Click(sender, e);
            else if (string.IsNullOrEmpty(SrcCitytxt.Text) && string.IsNullOrEmpty(Costtxt.Text) && string.IsNullOrEmpty(Typetxt.Text))
                DsCityBtn_Click(sender, e);
            else if (string.IsNullOrEmpty(DsCitytxt.Text) && string.IsNullOrEmpty(Costtxt.Text) && string.IsNullOrEmpty(Typetxt.Text))
                SrcCityBtn_Click(sender, e);
            else if (string.IsNullOrEmpty(SrcCitytxt.Text) && string.IsNullOrEmpty(DsCitytxt.Text))
            {
                var info= from at in nw.Available_Tours
                       join sc in nw.Cities on at.SourceCityID equals sc.CityID
                       join dc in nw.Cities on at.DestinationCityID equals dc.CityID
                       join of in nw.Offices on at.OfficeID equals of.OfficeID
                       where at.Cost <= Convert.ToInt32(Costtxt.Text) && at.TourType == Typetxt.Text
                       select new
                       {
                           at.TourID,
                           at.TourType,
                           going_date_and_time = at.Going,
                           comingback_date_and_time = at.CommingBack,
                           SourceCity = sc.CityName,
                           DestinationCity = dc.CityName,
                           at.Accomodation,
                           at.Breakfast,
                           at.Lunch,
                           at.Dinner,
                           at.Cost,
                           OfficeName = of.Name
                       };
                AvToursGrid.DataSource = info;
                          
            }
            else if(string.IsNullOrEmpty(SrcCitytxt.Text) && string.IsNullOrEmpty(Costtxt.Text))
            {
                var info = from at in nw.Available_Tours
                           join sc in nw.Cities on at.SourceCityID equals sc.CityID
                           join dc in nw.Cities on at.DestinationCityID equals dc.CityID
                           join of in nw.Offices on at.OfficeID equals of.OfficeID
                           where dc.CityName == DsCitytxt.Text && at.TourType == Typetxt.Text
                           select new
                           {
                               at.TourID,
                               at.TourType,
                               going_date_and_time = at.Going,
                               comingback_date_and_time = at.CommingBack,
                               SourceCity = sc.CityName,
                               DestinationCity = dc.CityName,
                               at.Accomodation,
                               at.Breakfast,
                               at.Lunch,
                               at.Dinner,
                               at.Cost,
                               OfficeName = of.Name
                           };
                AvToursGrid.DataSource = info;
            }
            else if(string.IsNullOrEmpty(SrcCitytxt.Text) && string.IsNullOrEmpty(Typetxt.Text))
            {
                var info = from at in nw.Available_Tours
                           join sc in nw.Cities on at.SourceCityID equals sc.CityID
                           join dc in nw.Cities on at.DestinationCityID equals dc.CityID
                           join of in nw.Offices on at.OfficeID equals of.OfficeID
                           where dc.CityName == DsCitytxt.Text && at.Cost <= Convert.ToInt32(Costtxt.Text)
                           select new
                           {
                               at.TourID,
                               at.TourType,
                               going_date_and_time = at.Going,
                               comingback_date_and_time = at.CommingBack,
                               SourceCity = sc.CityName,
                               DestinationCity = dc.CityName,
                               at.Accomodation,
                               at.Breakfast,
                               at.Lunch,
                               at.Dinner,
                               at.Cost,
                               OfficeName = of.Name
                           };
                AvToursGrid.DataSource = info;
            }
            else if(string.IsNullOrEmpty(DsCitytxt.Text) && string.IsNullOrEmpty(Costtxt.Text))
            {
                var info = from at in nw.Available_Tours
                           join sc in nw.Cities on at.SourceCityID equals sc.CityID
                           join dc in nw.Cities on at.DestinationCityID equals dc.CityID
                           join of in nw.Offices on at.OfficeID equals of.OfficeID
                           where sc.CityName == SrcCitytxt.Text && at.TourType == Typetxt.Text
                           select new
                           {
                               at.TourID,
                               at.TourType,
                               going_date_and_time = at.Going,
                               comingback_date_and_time = at.CommingBack,
                               SourceCity = sc.CityName,
                               DestinationCity = dc.CityName,
                               at.Accomodation,
                               at.Breakfast,
                               at.Lunch,
                               at.Dinner,
                               at.Cost,
                               OfficeName = of.Name
                           };
                AvToursGrid.DataSource = info;
            }
            else if(string.IsNullOrEmpty(DsCitytxt.Text) && string.IsNullOrEmpty(Typetxt.Text))
            {
                var info = from at in nw.Available_Tours
                           join sc in nw.Cities on at.SourceCityID equals sc.CityID
                           join dc in nw.Cities on at.DestinationCityID equals dc.CityID
                           join of in nw.Offices on at.OfficeID equals of.OfficeID
                           where sc.CityName == SrcCitytxt.Text && at.Cost <= Convert.ToInt32(Costtxt.Text)
                           select new
                           {
                               at.TourID,
                               at.TourType,
                               going_date_and_time = at.Going,
                               comingback_date_and_time = at.CommingBack,
                               SourceCity = sc.CityName,
                               DestinationCity = dc.CityName,
                               at.Accomodation,
                               at.Breakfast,
                               at.Lunch,
                               at.Dinner,
                               at.Cost,
                               OfficeName = of.Name
                           };
                AvToursGrid.DataSource = info;
            }
            else if(string.IsNullOrEmpty(Costtxt.Text) && string.IsNullOrEmpty(Typetxt.Text))
            {
                var info = from at in nw.Available_Tours
                           join sc in nw.Cities on at.SourceCityID equals sc.CityID
                           join dc in nw.Cities on at.DestinationCityID equals dc.CityID
                           join of in nw.Offices on at.OfficeID equals of.OfficeID
                           where sc.CityName == SrcCitytxt.Text && dc.CityName == DsCitytxt.Text
                           select new
                           {
                               at.TourID,
                               at.TourType,
                               going_date_and_time = at.Going,
                               comingback_date_and_time = at.CommingBack,
                               SourceCity = sc.CityName,
                               DestinationCity = dc.CityName,
                               at.Accomodation,
                               at.Breakfast,
                               at.Lunch,
                               at.Dinner,
                               at.Cost,
                               OfficeName = of.Name
                           };
                AvToursGrid.DataSource = info;
            }
            else if(string.IsNullOrEmpty(SrcCitytxt.Text))
            {
                var info = from at in nw.Available_Tours
                           join sc in nw.Cities on at.SourceCityID equals sc.CityID
                           join dc in nw.Cities on at.DestinationCityID equals dc.CityID
                           join of in nw.Offices on at.OfficeID equals of.OfficeID
                           where dc.CityName == DsCitytxt.Text && at.Cost <= Convert.ToInt32(Costtxt.Text) && at.TourType == Typetxt.Text
                           select new
                           {
                               at.TourID,
                               at.TourType,
                               going_date_and_time = at.Going,
                               comingback_date_and_time = at.CommingBack,
                               SourceCity = sc.CityName,
                               DestinationCity = dc.CityName,
                               at.Accomodation,
                               at.Breakfast,
                               at.Lunch,
                               at.Dinner,
                               at.Cost,
                               OfficeName = of.Name
                           };
                AvToursGrid.DataSource = info;
            }
            else if(string.IsNullOrEmpty(DsCitytxt.Text))
            {
                var info = from at in nw.Available_Tours
                           join sc in nw.Cities on at.SourceCityID equals sc.CityID
                           join dc in nw.Cities on at.DestinationCityID equals dc.CityID
                           join of in nw.Offices on at.OfficeID equals of.OfficeID
                           where sc.CityName == SrcCitytxt.Text && at.Cost <= Convert.ToInt32(Costtxt.Text) && at.TourType == Typetxt.Text
                           select new
                           {
                               at.TourID,
                               at.TourType,
                               going_date_and_time = at.Going,
                               comingback_date_and_time = at.CommingBack,
                               SourceCity = sc.CityName,
                               DestinationCity = dc.CityName,
                               at.Accomodation,
                               at.Breakfast,
                               at.Lunch,
                               at.Dinner,
                               at.Cost,
                               OfficeName = of.Name
                           };
                AvToursGrid.DataSource = info;
            }
            else if (string.IsNullOrEmpty(Costtxt.Text))
            {
                var info = from at in nw.Available_Tours
                           join sc in nw.Cities on at.SourceCityID equals sc.CityID
                           join dc in nw.Cities on at.DestinationCityID equals dc.CityID
                           join of in nw.Offices on at.OfficeID equals of.OfficeID
                           where sc.CityName == SrcCitytxt.Text && dc.CityName == DsCitytxt.Text && at.TourType == Typetxt.Text
                           select new
                           {
                               at.TourID,
                               at.TourType,
                               going_date_and_time = at.Going,
                               comingback_date_and_time = at.CommingBack,
                               SourceCity = sc.CityName,
                               DestinationCity = dc.CityName,
                               at.Accomodation,
                               at.Breakfast,
                               at.Lunch,
                               at.Dinner,
                               at.Cost,
                               OfficeName = of.Name
                           };
                AvToursGrid.DataSource = info;
            }
            else if (string.IsNullOrEmpty(Typetxt.Text))
            {
                var info = from at in nw.Available_Tours
                           join sc in nw.Cities on at.SourceCityID equals sc.CityID
                           join dc in nw.Cities on at.DestinationCityID equals dc.CityID
                           join of in nw.Offices on at.OfficeID equals of.OfficeID
                           where sc.CityName == SrcCitytxt.Text && dc.CityName == DsCitytxt.Text && at.Cost <= Convert.ToInt32(Costtxt.Text)
                           select new
                           {
                               at.TourID,
                               at.TourType,
                               going_date_and_time = at.Going,
                               comingback_date_and_time = at.CommingBack,
                               SourceCity = sc.CityName,
                               DestinationCity = dc.CityName,
                               at.Accomodation,
                               at.Breakfast,
                               at.Lunch,
                               at.Dinner,
                               at.Cost,
                               OfficeName = of.Name
                           };
                AvToursGrid.DataSource = info;
            }
            else if(!string.IsNullOrEmpty(SrcCitytxt.Text) && !string.IsNullOrEmpty(DsCitytxt.Text) && !string.IsNullOrEmpty(Costtxt.Text) && !string.IsNullOrEmpty(Typetxt.Text))
            {
                var info = from at in nw.Available_Tours
                           join sc in nw.Cities on at.SourceCityID equals sc.CityID
                           join dc in nw.Cities on at.DestinationCityID equals dc.CityID
                           join of in nw.Offices on at.OfficeID equals of.OfficeID
                           where sc.CityName == SrcCitytxt.Text && dc.CityName == DsCitytxt.Text && at.Cost <= Convert.ToInt32(Costtxt.Text) && at.TourType == Typetxt.Text
                           select new
                           {
                               at.TourID,
                               at.TourType,
                               going_date_and_time = at.Going,
                               comingback_date_and_time = at.CommingBack,
                               SourceCity = sc.CityName,
                               DestinationCity = dc.CityName,
                               at.Accomodation,
                               at.Breakfast,
                               at.Lunch,
                               at.Dinner,
                               at.Cost,
                               OfficeName = of.Name
                           };
                AvToursGrid.DataSource = info;
            }
        }
        private void UserForm1_Load(object sender, EventArgs e)
        {
            MyContextDataContext nw = new MyContextDataContext();
            var info = from at in nw.Available_Tours
                       join sc in nw.Cities on at.SourceCityID equals sc.CityID
                       join dc in nw.Cities on at.DestinationCityID equals dc.CityID
                       join of in nw.Offices on at.OfficeID equals of.OfficeID
                       select new
                       {
                           at.TourID,
                           at.TourType,
                           going_date_and_time = at.Going,
                           comingback_date_and_time = at.CommingBack,
                           SourceCity = sc.CityName,
                           DestinationCity = dc.CityName,
                           at.Accomodation,
                           at.Breakfast,
                           at.Lunch,
                           at.Dinner,
                           at.Cost,
                           OfficeName = of.Name
                       };
            AvToursGrid.DataSource = info;
            var ttinfo = from tt in nw.Taken_Tours
                       join at in nw.Available_Tours on tt.TourID equals at.TourID
                       join sc in nw.Cities on at.SourceCityID equals sc.CityID
                       join dc in nw.Cities on at.DestinationCityID equals dc.CityID
                       join of in nw.Offices on at.OfficeID equals of.OfficeID
                       where tt.PassengerID == i
                       select new
                       {
                           tt.TourID,
                           at.TourType,
                           going_date_and_time = at.Going,
                           comingback_date_and_time = at.CommingBack,
                           SourceCity = sc.CityName,
                           DestinationCity = dc.CityName,
                           at.Accomodation,
                           at.Breakfast,
                           at.Lunch,
                           at.Dinner,
                           at.Cost,
                           OfficeName = of.Name
                       };
            YourTakenGrid.DataSource = ttinfo;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
