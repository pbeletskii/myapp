using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace myapp
{
    public partial class EditTours : Form
    {
        public EditTours()
        {
            InitializeComponent();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            MyContextDataContext nw = new MyContextDataContext();
            if (!string.IsNullOrEmpty(TtypeTxt.Text) && !string.IsNullOrEmpty(NumberTxt.Text))
            {
                var deleterow = from d in nw.Tours
                                where d.TourType == TtypeTxt.Text && d.Number == NumberTxt.Text
                                select d;
                foreach (var detail in deleterow)
                {
                    nw.Tours.DeleteOnSubmit(detail);
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
            EditTours_Load(sender, e);
        }

        private void EditTours_Load(object sender, EventArgs e)
        {
            MyContextDataContext nw = new MyContextDataContext();
            var tourinfo = from t in nw.Tours
                           select t;
            TourGrd.DataSource = tourinfo;
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            MyContextDataContext nw = new MyContextDataContext();
            if (!string.IsNullOrEmpty(TtypeTxt.Text) && !string.IsNullOrEmpty(NumberTxt.Text) && !string.IsNullOrEmpty(NameTxt.Text))
            {
                int flag = 0;
                var tourinfo = from t in nw.Tours
                               select t;
                foreach (var ti in tourinfo)
                {
                    if (ti.TourType == TtypeTxt.Text && ti.Number == NumberTxt.Text)
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                {
                    Tour newtour = new Tour();
                    newtour.TourType = TtypeTxt.Text;
                    newtour.Number = NumberTxt.Text;
                    newtour.Name = NameTxt.Text;
                    nw.Tours.InsertOnSubmit(newtour);
                    nw.SubmitChanges();
                }
            }
            EditTours_Load(sender, e);
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TtypeTxt.Text) && !string.IsNullOrEmpty(NumberTxt.Text) && !string.IsNullOrEmpty(NameTxt.Text))
            {
                MyContextDataContext nw = new MyContextDataContext();
                int flag = 0;
                var tourinfo = from t in nw.Tours
                               select t;
                foreach (var ti in tourinfo)
                {
                    if (ti.TourType == TtypeTxt.Text && ti.Number == NumberTxt.Text)
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 1)
                {
                    string connectionString = "Data Source=localhost;Initial Catalog=TravelAgency;Integrated Security=True";
                    SqlConnection con = new SqlConnection(connectionString);
                    string strQuery = "update Tours set Name = @Name where TourType = @Type and Number = @Num ";
                    SqlCommand cmd = new SqlCommand(strQuery, con);
                    cmd.Parameters.AddWithValue("@Name", NameTxt.Text);
                    cmd.Parameters.AddWithValue("@Type", TtypeTxt.Text);
                    cmd.Parameters.AddWithValue("@Num", NumberTxt.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                }
                EditTours_Load(sender, e);
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            new StaffDashboard().Show();
            this.Hide();
        }
    }
}
