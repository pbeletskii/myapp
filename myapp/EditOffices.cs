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
    public partial class EditOffices : Form
    {
        public EditOffices()
        {
            InitializeComponent();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            MyContextDataContext nw = new MyContextDataContext();
            if (!string.IsNullOrEmpty(OfficeidTxt.Text))
            {
                var deleterow = from d in nw.Offices
                                where d.OfficeID == OfficeidTxt.Text
                                select d;
                foreach (var detail in deleterow)
                {
                    nw.Offices.DeleteOnSubmit(detail);
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
            EditOffices_Load(sender, e);
        }

        private void EditOffices_Load(object sender, EventArgs e)
        {
            MyContextDataContext nw = new MyContextDataContext();
            var officeinfo = from of in nw.Offices
                            select of;
            OfficeGrd.DataSource = officeinfo;

            var cityinfo = from c in nw.Cities
                         select c;
            CityGrd.DataSource = cityinfo;
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            MyContextDataContext nw = new MyContextDataContext();
            if (!string.IsNullOrEmpty(OfficeidTxt.Text) && !string.IsNullOrEmpty(AddTxt.Text) && !string.IsNullOrEmpty(CityidTxt.Text)
                && !string.IsNullOrEmpty(MobileTxt.Text) && !string.IsNullOrEmpty(OffnumTxt.Text) && !string.IsNullOrEmpty(FaxTxt.Text)
                && !string.IsNullOrEmpty(WhatsappTxt.Text) && !string.IsNullOrEmpty(EmailTxt.Text) && !string.IsNullOrEmpty(HourTxt.Text)
                && !string.IsNullOrEmpty(NameTxt.Text))
            {
                int flag = 0;
                int flag1 = 0;
                var officeinfo = from of in nw.Offices
                                 select of;
                var cityinfo = from c in nw.Cities
                               select c;
                foreach (var off in officeinfo)
                {
                    if (off.OfficeID == OfficeidTxt.Text)
                    {
                        flag = 1;
                        break;
                    }
                }
                foreach (var c in cityinfo)
                {
                    if (c.CityID == CityidTxt.Text)
                    {
                        flag1 = 1;
                        break;
                    }
                }
                if (flag == 0 && flag1 == 1)
                {
                    Office newoff = new Office();
                    newoff.OfficeID = OfficeidTxt.Text;
                    newoff.Address = AddTxt.Text;
                    newoff.CityID = CityidTxt.Text;
                    newoff.MobileNumber = MobileTxt.Text;
                    newoff.OfficeNumber = OffnumTxt.Text;
                    newoff.FaxNumber = FaxTxt.Text;
                    newoff.WhatsappNumber = WhatsappTxt.Text;
                    newoff.Email = EmailTxt.Text;
                    newoff.WorkHours = HourTxt.Text;
                    newoff.Name = NameTxt.Text;
                    nw.Offices.InsertOnSubmit(newoff);
                    nw.SubmitChanges();
                }
            }
            EditOffices_Load(sender, e);
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(OfficeidTxt.Text) && !string.IsNullOrEmpty(AddTxt.Text) && !string.IsNullOrEmpty(CityidTxt.Text)
                && !string.IsNullOrEmpty(MobileTxt.Text) && !string.IsNullOrEmpty(OffnumTxt.Text) && !string.IsNullOrEmpty(FaxTxt.Text)
                && !string.IsNullOrEmpty(WhatsappTxt.Text) && !string.IsNullOrEmpty(EmailTxt.Text) && !string.IsNullOrEmpty(HourTxt.Text)
                && !string.IsNullOrEmpty(NameTxt.Text))
            {
                MyContextDataContext nw = new MyContextDataContext();
                int flag = 0;
                int flag1 = 0;
                var officeinfo = from of in nw.Offices
                                 select of;
                var cityinfo = from c in nw.Cities
                               select c;
                foreach (var off in officeinfo)
                {
                    if (off.OfficeID == OfficeidTxt.Text)
                    {
                        flag = 1;
                        break;
                    }
                }
                foreach (var c in cityinfo)
                {
                    if (c.CityID == CityidTxt.Text)
                    {
                        flag1 = 1;
                        break;
                    }
                }
                if (flag == 1 && flag1 == 1)
                {
                    var updateobj = nw.Offices.FirstOrDefault(detail => detail.OfficeID.Equals(OfficeidTxt.Text));
                    updateobj.Address = AddTxt.Text;
                    updateobj.CityID = CityidTxt.Text;
                    updateobj.MobileNumber = MobileTxt.Text;
                    updateobj.OfficeNumber = OffnumTxt.Text;
                    updateobj.FaxNumber = FaxTxt.Text;
                    updateobj.WhatsappNumber = WhatsappTxt.Text;
                    updateobj.Email = EmailTxt.Text;
                    updateobj.WorkHours = HourTxt.Text;
                    updateobj.Name = NameTxt.Text;
                    nw.SubmitChanges();
                }
                EditOffices_Load(sender, e);
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            new StaffDashboard().Show();
            this.Hide();
        }
    }
}
