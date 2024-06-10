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
    public partial class EditCity : Form
    {
        public EditCity()
        {
            InitializeComponent();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            MyContextDataContext nw = new MyContextDataContext();
            if (!string.IsNullOrEmpty(CidTxt.Text) && string.IsNullOrEmpty(CnTxt.Text))
            {
                var deleterow = from d in nw.Cities
                                where d.CityID == CidTxt.Text
                                select d;
                foreach (var detail in deleterow)
                {
                    nw.Cities.DeleteOnSubmit(detail);
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
            else if(string.IsNullOrEmpty(CidTxt.Text) && !string.IsNullOrEmpty(CnTxt.Text))
            {
                var deleterow = from d in nw.Cities
                                where d.CityName == CnTxt.Text
                                select d;
                foreach (var detail in deleterow)
                {
                    nw.Cities.DeleteOnSubmit(detail);
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
            else if(!string.IsNullOrEmpty(CidTxt.Text) && !string.IsNullOrEmpty(CnTxt.Text))
            {
                var deleterow = from d in nw.Cities
                                where d.CityID == CidTxt.Text && d.CityName == CnTxt.Text
                                select d;
                foreach (var detail in deleterow)
                {
                    nw.Cities.DeleteOnSubmit(detail);
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
            EditCity_Load(sender, e);    
        }

        private void EditCity_Load(object sender, EventArgs e)
        {
            MyContextDataContext nw = new MyContextDataContext();
            var cityinfo = from c in nw.Cities
                       select new
                       {
                           c.CityID,
                           c.CityName
                       };
            CityGrid.DataSource = cityinfo;
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            MyContextDataContext nw = new MyContextDataContext();
            if(!string.IsNullOrEmpty(CidTxt.Text) && !string.IsNullOrEmpty(CnTxt.Text))
            {
                int flag = 0;
                var cityinfo = from c in nw.Cities
                                select c;
                foreach(var ci in cityinfo)
                {
                    if(ci.CityName == CnTxt.Text || ci.CityID == CidTxt.Text)
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                {
                    City newcity = new City();
                    newcity.CityID = CidTxt.Text;
                    newcity.CityName = CnTxt.Text;
                    nw.Cities.InsertOnSubmit(newcity);
                    nw.SubmitChanges();
                }
            }
            EditCity_Load(sender, e);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            new StaffDashboard().Show();
            this.Hide();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(PcidTxt.Text) )
            {
                MyContextDataContext nw = new MyContextDataContext();
                int flag = 0;
                var cityinfo = from c in nw.Cities
                               select new
                               {
                                   c.CityID
                               };
                foreach (var ci in cityinfo)
                {
                    if (ci.CityID == PcidTxt.Text)
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 1)
                {
                    var updateobj = nw.Cities.FirstOrDefault(detail => detail.CityID.Equals(PcidTxt.Text));
                    if (!string.IsNullOrEmpty(NcnameTxt.Text))
                    {
                        updateobj.CityName = NcnameTxt.Text;
                        nw.SubmitChanges();
                    }
                }
                EditCity_Load(sender, e);
            }
        }
    }
}
