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
    public partial class UserSingup : Form
    {
        public UserSingup()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            new User().Show();
            this.Hide();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(FirstNametxt.Text) || string.IsNullOrEmpty(LastNametxt.Text))
            {
                new Signuperror().Show();
                this.Hide();
            }
            else
            {
                string connectionString = "Data Source=localhost;Initial Catalog=TravelAgency;Integrated Security=True";
                SqlConnection con = new SqlConnection(connectionString);
                string strQuery = "Insert into Passenger (FirstName,LastName,MobileNumber,HomeNumber) values (@FirstName, @LastName, @MobileNumber, @HomeNumber)";
                SqlCommand cmd = new SqlCommand(strQuery, con);
                cmd.Parameters.AddWithValue("@FirstName", FirstNametxt.Text);
                cmd.Parameters.AddWithValue("@LastName", LastNametxt.Text);
                cmd.Parameters.AddWithValue("@MobileNumber", Mobiletxt.Text);
                cmd.Parameters.AddWithValue("@HomeNumber", Hometxt.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                
                MyContextDataContext nw = new MyContextDataContext();
                var passinfo = from pas in nw.Passengers
                               where pas.FirstName == FirstNametxt.Text && pas.LastName == LastNametxt.Text
                               && pas.MobileNumber == Mobiletxt.Text && pas.HomeNumber == Hometxt.Text
                               select new
                               {
                                   username = pas.LastName,
                                   password = Convert.ToInt32(pas.PassengerID)
                               };
                foreach (var p in passinfo)
                {
                    new SignUpComplete(p.username, p.password).Show();
                    this.Hide();
                }
            }
        }
    }
}