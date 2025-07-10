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
    public partial class Cashier_Booking: Form
    {
        public Cashier_Booking()
        {
            InitializeComponent();
        }



        private void LoadAvailableTimeSlots()
        {
            if (cmbVenue.SelectedItem == null) return;

            try
            {
                var selectedVenueId = (cmbVenue.SelectedItem as Venue).VenueID;
                DateTime selectedDate = dtpBookingDate.Value.Date;

                using (var db = new CourtCraftDBEntities1())
                {
                    var availableSlots = db.TimeSlots
                        .Where(ts => ts.VenueID == selectedVenueId &&
                                     ts.SlotDate == selectedDate &&
                                     ts.IsBooked == "Available")
                        .OrderBy(ts => ts.StartTime)
                        .ToList();

                    dgvTimeSlots.DataSource = availableSlots;
                }
                if (dgvTimeSlots.Columns.Count > 0)
                {
                    dgvTimeSlots.Columns["TimeSlotID"].Visible = false;
                    dgvTimeSlots.Columns["VenueID"].Visible = false;
                    dgvTimeSlots.Columns["SlotDate"].Visible = false;
                    dgvTimeSlots.Columns["IsBooked"].Visible = false;
                    dgvTimeSlots.Columns["Venue"].Visible = false;
                    dgvTimeSlots.Columns["Bookings"].Visible = false;
                    dgvTimeSlots.Columns["StartTime"].HeaderText = "Jam Mulai";
                    dgvTimeSlots.Columns["EndTime"].HeaderText = "Jam Selesai";
                    dgvTimeSlots.Columns["Price"].HeaderText = "Harga";
                    dgvTimeSlots.Columns["Price"].DefaultCellStyle.Format = "N0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat slot waktu: " + ex.Message);
            }
        }

        private void CalculateAndDisplayTotal()
        {
            decimal currentTotal = 0;
            // Hitung total harga dari semua baris yang dipilih
            foreach (DataGridViewRow row in dgvTimeSlots.SelectedRows)
            {
                if (row.Cells["Price"].Value != null)
                {
                    currentTotal += (decimal)row.Cells["Price"].Value;
                }
            }

            if (radioFullPayment.Checked)
            {
                // Jika Full Payment, isi textbox dengan total dan kunci agar tidak bisa diubah
                txtTotalAmount.Text = currentTotal.ToString();
                txtTotalAmount.ReadOnly = true;
            }
            else if (radioDeposit.Checked)
            {
                // Jika Deposit, kosongkan textbox dan izinkan kasir mengisi manual
                // Hanya kosongkan jika user MENGKLIK radio button-nya, bukan saat selection DGV berubah
                if (!txtTotalAmount.Focused)                 {
                    txtTotalAmount.Text = "";
                }
                txtTotalAmount.ReadOnly = false;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Cashier_Booking_Load(object sender, EventArgs e)
        {
            using (var db = new CourtCraftDBEntities1())
            {
                cmbVenue.DataSource = db.Venues.ToList();
                cmbVenue.DisplayMember = "Name";
                cmbVenue.ValueMember = "VenueID";
            }
            LoadAvailableTimeSlots();
            CalculateAndDisplayTotal();
        }

        private void dgvTimeSlots_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbVenue_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAvailableTimeSlots();
        }

        private void dtpBookingDate_ValueChanged(object sender, EventArgs e)
        {
            LoadAvailableTimeSlots();
        }

        private void btnCnfBooking_Click(object sender, EventArgs e)
        {
          
            if (string.IsNullOrWhiteSpace(txtcusName.Text) ||
                dgvTimeSlots.SelectedRows.Count == 0 ||
                string.IsNullOrWhiteSpace(txtTotalAmount.Text))
            {
                MessageBox.Show("Nama pelanggan, pilihan slot, dan jumlah bayar tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtTotalAmount.Text, out decimal amountToPay))
            {
                MessageBox.Show("Jumlah bayar yang dimasukkan tidak valid! Harap masukkan angka saja.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var db = new CourtCraftDBEntities1()) 
                {
                    var newCustomer = new Customer
                    {
                        CustomerID = "C" + DateTime.Now.Ticks,
                        FullName = txtcusName.Text
                    };
                    db.Customers.Add(newCustomer);

                    var newBooking = new Booking
                    {
                        BookingID = "B" + DateTime.Now.Ticks,
                        CustomerID = newCustomer.CustomerID,
                        BookingDate = DateTime.Now.Date,
                        UserID = LoggedInUser.UserID 
                    };

                    foreach (DataGridViewRow row in dgvTimeSlots.SelectedRows)
                    {
                        string timeSlotId = row.Cells["TimeSlotID"].Value.ToString();
                        var slotToBook = db.TimeSlots.Find(timeSlotId);

                        if (slotToBook != null)
                        {
                            slotToBook.IsBooked = "Booked";
                            newBooking.TimeSlots.Add(slotToBook);
                        }
                    }
                    db.Bookings.Add(newBooking);

                    var newPayment = new Payment
                    {
                        PaymentsID = "P" + DateTime.Now.Ticks,
                        BookingID = newBooking.BookingID,
                        Totalharga = amountToPay,
                        PaymentType = radioFullPayment.Checked ? "Full Payment" : "Deposit",
                        Statuspayments = radioFullPayment.Checked ? "Paid" : "Pending"
                    };
                    db.Payments.Add(newPayment);
                    db.SaveChanges();

                    MessageBox.Show($"Booking berhasil dibuat untuk {newCustomer.FullName} dengan total bayar Rp {amountToPay:N0}. \nBooking ID: {newBooking.BookingID}", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi error saat menyimpan booking: " + ex.InnerException?.Message ?? ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void dgvTimeSlots_SelectionChanged(object sender, EventArgs e)
        {
            CalculateAndDisplayTotal();
        }

        private void btnberanda_Click(object sender, EventArgs e)
        {
            this.Hide();
            OwnerDashboard ownerForm = new OwnerDashboard();
            ownerForm.Show();
        }

        private void btnOperatingHours_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cashier_Operating_Hours opHoursForm = new Cashier_Operating_Hours();
            opHoursForm.Show();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioFullPayment_CheckedChanged(object sender, EventArgs e)
        {
            CalculateAndDisplayTotal();
        }


    }
}
