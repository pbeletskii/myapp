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
    public partial class StaffDashboard : Form
    {
        public StaffDashboard()
        {
            InitializeComponent();
        }

        private void CityBtn_Click(object sender, EventArgs e)
        {
            new EditCity().Show();
            this.Hide();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            new StaffForm().Show();
            this.Hide();
        }

        private void AtBtn_Click(object sender, EventArgs e)
        {
            new EditAT().Show();
            this.Hide();
        }

        private void DelayBtn_Click(object sender, EventArgs e)
        {
            new EditDelay().Show();
            this.Hide();
        }

        private void OfficeBtn_Click(object sender, EventArgs e)
        {
            new EditOffices().Show();
            this.Hide();
        }

        private void StaffBtn_Click(object sender, EventArgs e)
        {
            new EditStaff().Show();
            this.Hide();
        }

        private void TourBtn_Click(object sender, EventArgs e)
        {
            new EditTours().Show();
            this.Hide();
        }
    }
}
