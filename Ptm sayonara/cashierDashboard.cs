using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ptm_sayonara
{
    public partial class cashierDashboard: Form
    {
        public cashierDashboard()
        {
            InitializeComponent();
        }

        private void cashierDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Login loginForm = new Login();
                loginForm.Show();
                this.Close();
            }
        }

        private void btnNewbooking_Click(object sender, EventArgs e)
        {
            Cashier_Booking bookingForm = new Cashier_Booking();
            bookingForm.Show();
        }

        private void btnTdyRental_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cashier_Result resultForm = new Cashier_Result();
            resultForm.Show();
        }

        private void btnBookingMenu_Click(object sender, EventArgs e)
        {

            this.Hide();
            Cashier_Booking bookingForm = new Cashier_Booking();
            bookingForm.Show();
        }

        private void btnOperatingHours_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cashier_Operating_Hours opHoursForm = new Cashier_Operating_Hours();
            opHoursForm.Show();
        }
    }
}
