using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Data.Entity;

namespace Ptm_sayonara
{
    public partial class Cashier_Result: Form
    {
        public Cashier_Result()
        {
            InitializeComponent();
        }

        private void LoadTodaysData()
        {
            try
            {
                using (var db = new CourtCraftDBEntities1()) 
                {
                    DateTime today = DateTime.Today;

                    // query join
                    var bookingListForGrid = db.Bookings
                        .Where(b => b.TimeSlots.Any(ts => ts.SlotDate == today)) 
                        .Join(db.Payments,             
                              booking => booking.BookingID,
                              payment => payment.BookingID,
                              (booking, payment) => new { Booking = booking, Payment = payment }) 
                        .Select(joinedData => new {
                            BookingID = joinedData.Booking.BookingID,
                            Pelanggan = joinedData.Booking.Customer.FullName,
                            WaktuMulai = joinedData.Booking.TimeSlots.Min(ts => ts.StartTime),
                            WaktuSelesai = joinedData.Booking.TimeSlots.Max(ts => ts.EndTime),
                            Status = joinedData.Payment.Statuspayments 
                        })
                        .ToList(); 

                    dtBooking.DataSource = bookingListForGrid;

                    lblTodayRental.Text = bookingListForGrid.Count.ToString();

                    var todaysBookingIds = bookingListForGrid.Select(b => b.BookingID).ToList();
                    decimal todaysIncome = db.Payments
                                             .Where(p => todaysBookingIds.Contains(p.BookingID))
                                             .Sum(p => (decimal?)p.Totalharga) ?? 0;
                    lblPenghasilan.Text = $"Rp {todaysIncome:N0}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data rental hari ini: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Cashier_Result_Load(object sender, EventArgs e)
        {
            LoadTodaysData();
        }

        private void btnberanda_Click(object sender, EventArgs e)
        {
            this.Hide();
            OwnerDashboard ownerForm = new OwnerDashboard();
            ownerForm.Show();
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblPenghasilan_Click(object sender, EventArgs e)
        {

        }

        private void btnSettlePayment_Click(object sender, EventArgs e)
        {
            if (dtBooking.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silakan pilih booking yang ingin dilunasi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dtBooking.SelectedRows[0];
            string bookingId = selectedRow.Cells["BookingID"].Value.ToString();
            string currentStatus = selectedRow.Cells["Status"].Value.ToString();

            if (currentStatus != "Pending")
            {
                MessageBox.Show("Booking ini sudah lunas.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (var db = new CourtCraftDBEntities1()) 
                {
                   var booking = db.Bookings.Include("TimeSlots").FirstOrDefault(b => b.BookingID == bookingId);

                    var payment = db.Payments.FirstOrDefault(p => p.BookingID == bookingId);

                    if (booking != null && payment != null)
                    {
                        decimal fullBookingPrice = booking.TimeSlots.Sum(ts => ts.Price);

                        decimal remainingAmount = fullBookingPrice - payment.Totalharga;

                        string confirmationMessage = $"Total Tagihan: Rp {fullBookingPrice:N0}\n" +
                                                     $"Sudah Dibayar: Rp {payment.Totalharga:N0}\n\n" +
                                                     $"Sisa Tagihan: Rp {remainingAmount:N0}\n\n" +
                                                     "Lunasi sisa pembayaran sekarang?";

                        if (MessageBox.Show(confirmationMessage, "Konfirmasi Pelunasan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            payment.Totalharga = fullBookingPrice; 
                            payment.Statuspayments = "Paid";
                            payment.PaymentType = "Full Payment";
                            db.SaveChanges(); 
                            MessageBox.Show("Pembayaran berhasil dilunasi!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadTodaysData();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Data booking atau pembayaran tidak ditemukan.", "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi error saat proses pelunasan: " + ex.Message, "Error");
            }
        }
    }
}
