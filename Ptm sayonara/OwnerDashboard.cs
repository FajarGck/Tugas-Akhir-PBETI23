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
    public partial class OwnerDashboard: Form
    {
        public OwnerDashboard()
        {
            InitializeComponent();
        }
        private void LoadDashboardStats()
        {
            try
            {
                using (var db = new CourtCraftDBEntities1())
                {
                    decimal totalRevenue = db.Payments
                                             .Where(p => p.Statuspayments == "Paid")
                                             .Sum(p => (decimal?)p.Totalharga) ?? 0;

                    decimal pendingDeposits = db.Payments
                                                .Where(p => p.Statuspayments == "Pending")
                                                .Sum(p => (decimal?)p.Totalharga) ?? 0;

                    int bookedSlots = db.TimeSlots.Count(ts => ts.IsBooked == "Booked");
                    int totalSlots = db.TimeSlots.Count();
                    double venueUtilization = (totalSlots > 0) ? ((double)bookedSlots / totalSlots) * 100 : 0;

                    label3.Text = $"Rp {totalRevenue:N0}"; 
                    label6.Text = $"Rp {pendingDeposits:N0}"; 
                    label4.Text = $"{venueUtilization:F2} %";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat statistik dashboard: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void OwnerDashboard_Load(object sender, EventArgs e)
        {
            LoadDashboardStats();
        }

        private void OwnerDashboard_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnListvenues_Click(object sender, EventArgs e)
        {
            this.Hide();
            Owner_Vanue vanueForm = new Owner_Vanue();
            vanueForm.Show();
        }

        private void btnOperatingHours_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cashier_Operating_Hours opHoursForm = new Cashier_Operating_Hours();
            opHoursForm.Show();
        }

        private void btnNewbooking_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        private void btnRentalreports_Click(object sender, EventArgs e)
        {
            this.Hide();
            owner_Report reportForm = new owner_Report();
            reportForm.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerateReports_Click(object sender, EventArgs e)
        {
            this.Hide();
            owner_Report reportForm = new owner_Report();
            reportForm.Show();
        }
    }
}
