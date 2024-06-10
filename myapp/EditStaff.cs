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
    public partial class EditStaff : Form
    {
        public EditStaff()
        {
            InitializeComponent();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            MyContextDataContext nw = new MyContextDataContext();
            if (!string.IsNullOrEmpty(StaffidTxt.Text))
            {
                var deleterow = from d in nw.Staffs
                                where d.StaffID == StaffidTxt.Text
                                select d;
                foreach (var detail in deleterow)
                {
                    nw.Staffs.DeleteOnSubmit(detail);
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
            EditStaff_Load(sender, e);
        }

        private void EditStaff_Load(object sender, EventArgs e)
        {
            MyContextDataContext nw = new MyContextDataContext();
            var officeinfo = from of in nw.Offices
                             select of;
            OfficeGrd.DataSource = officeinfo;

            var staffinfo = from st in nw.Staffs
                            select st;
            StaffGrd.DataSource = staffinfo;
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            MyContextDataContext nw = new MyContextDataContext();
            if (!string.IsNullOrEmpty(StaffidTxt.Text) && !string.IsNullOrEmpty(FnTxt.Text) && !string.IsNullOrEmpty(LnTxt.Text)
                && !string.IsNullOrEmpty(OfficeidTxt.Text) && !string.IsNullOrEmpty(MobileTxt.Text) && !string.IsNullOrEmpty(HomeTxt.Text)
                && !string.IsNullOrEmpty(SalaryTxt.Text) && !string.IsNullOrEmpty(genderTxt.Text))
            {
                int flag = 0;
                int flag1 = 0;
                var officeinfo = from of in nw.Offices
                                 select of;
                var staffinfo = from st in nw.Staffs
                                select st;
                foreach (var s in staffinfo)
                {
                    if (s.StaffID == StaffidTxt.Text)
                    {
                        flag = 1;
                        break;
                    }
                }
                foreach (var o in officeinfo)
                {
                    if (o.OfficeID == OfficeidTxt.Text)
                    {
                        flag1 = 1;
                        break;
                    }
                }
                if (flag == 0 && flag1 == 1)
                {
                    Staff newstaff = new Staff();
                    newstaff.StaffID = StaffidTxt.Text;
                    newstaff.FirstName = FnTxt.Text;
                    newstaff.LastName = LnTxt.Text;
                    newstaff.MobileNumber = MobileTxt.Text;
                    newstaff.HomeNumber = HomeTxt.Text;
                    newstaff.OfficeID = OfficeidTxt.Text;
                    newstaff.Salary = Convert.ToDecimal(SalaryTxt.Text);
                    newstaff.Gender = genderTxt.Text;
                    nw.Staffs.InsertOnSubmit(newstaff);
                    nw.SubmitChanges();
                }
            }
            EditStaff_Load(sender, e);
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(StaffidTxt.Text) && !string.IsNullOrEmpty(FnTxt.Text) && !string.IsNullOrEmpty(LnTxt.Text)
                && !string.IsNullOrEmpty(OfficeidTxt.Text) && !string.IsNullOrEmpty(MobileTxt.Text) && !string.IsNullOrEmpty(HomeTxt.Text)
                && !string.IsNullOrEmpty(SalaryTxt.Text) && !string.IsNullOrEmpty(genderTxt.Text))
            {
                MyContextDataContext nw = new MyContextDataContext();
                int flag = 0;
                int flag1 = 0;
                var officeinfo = from of in nw.Offices
                                 select of;
                var staffinfo = from st in nw.Staffs
                                select st;
                foreach (var s in staffinfo)
                {
                    if (s.StaffID == StaffidTxt.Text)
                    {
                        flag = 1;
                        break;
                    }
                }
                foreach (var o in officeinfo)
                {
                    if (o.OfficeID == OfficeidTxt.Text)
                    {
                        flag1 = 1;
                        break;
                    }
                }
                if (flag == 1 && flag1 == 1)
                {
                    var updateobj = nw.Staffs.FirstOrDefault(detail => detail.StaffID.Equals(StaffidTxt.Text));
                    updateobj.FirstName = FnTxt.Text;
                    updateobj.LastName = LnTxt.Text;
                    updateobj.MobileNumber = MobileTxt.Text;
                    updateobj.HomeNumber = HomeTxt.Text;
                    updateobj.OfficeID = OfficeidTxt.Text;
                    updateobj.Salary = Convert.ToDecimal(SalaryTxt.Text);
                    updateobj.Gender = genderTxt.Text;
                    nw.SubmitChanges();
                }
                EditStaff_Load(sender, e);
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            new StaffDashboard().Show();
            this.Hide();
        }
    }
}
