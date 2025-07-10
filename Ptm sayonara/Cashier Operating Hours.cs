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
    public partial class Cashier_Operating_Hours: Form
    {
        private List<DayOfWeek> selectedDays = new List<DayOfWeek>();
        public Cashier_Operating_Hours()
        {
            InitializeComponent();
        }

        private void btnMon_Click(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;
            DayOfWeek day;

            switch (selectedButton.Text)
            {
                case "Mon": day = DayOfWeek.Monday; break;
                case "Tue": day = DayOfWeek.Tuesday; break;
                case "Wed": day = DayOfWeek.Wednesday; break;
                case "Thu": day = DayOfWeek.Thursday; break;
                case "Fri": day = DayOfWeek.Friday; break;
                case "Sat": day = DayOfWeek.Saturday; break;
                case "Sun": day = DayOfWeek.Sunday; break;
                default: return;
            }

            if (selectedDays.Contains(day))
            {
                selectedDays.Remove(day);
                selectedButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText; 
            }
            else
            {
                selectedDays.Add(day);
                selectedButton.BackColor = System.Drawing.Color.MediumSeaGreen; 
            }
        }

        private void btnTue_Click(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;
            DayOfWeek day;

            switch (selectedButton.Text)
            {
                case "Mon": day = DayOfWeek.Monday; break;
                case "Tue": day = DayOfWeek.Tuesday; break;
                case "Wed": day = DayOfWeek.Wednesday; break;
                case "Thu": day = DayOfWeek.Thursday; break;
                case "Fri": day = DayOfWeek.Friday; break;
                case "Sat": day = DayOfWeek.Saturday; break;
                case "Sun": day = DayOfWeek.Sunday; break;
                default: return;
            }

            if (selectedDays.Contains(day))
            {
                selectedDays.Remove(day);
                selectedButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            }
            else
            {
                selectedDays.Add(day);
                selectedButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            }
        }

        private void btnWed_Click(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;
            DayOfWeek day;

            switch (selectedButton.Text)
            {
                case "Mon": day = DayOfWeek.Monday; break;
                case "Tue": day = DayOfWeek.Tuesday; break;
                case "Wed": day = DayOfWeek.Wednesday; break;
                case "Thu": day = DayOfWeek.Thursday; break;
                case "Fri": day = DayOfWeek.Friday; break;
                case "Sat": day = DayOfWeek.Saturday; break;
                case "Sun": day = DayOfWeek.Sunday; break;
                default: return;
            }

            if (selectedDays.Contains(day))
            {
                selectedDays.Remove(day);
                selectedButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText; 
            }
            else
            {
                selectedDays.Add(day);
                selectedButton.BackColor = System.Drawing.Color.MediumSeaGreen; 
            }
        }

        private void btnThu_Click(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;
            DayOfWeek day;

            switch (selectedButton.Text)
            {
                case "Mon": day = DayOfWeek.Monday; break;
                case "Tue": day = DayOfWeek.Tuesday; break;
                case "Wed": day = DayOfWeek.Wednesday; break;
                case "Thu": day = DayOfWeek.Thursday; break;
                case "Fri": day = DayOfWeek.Friday; break;
                case "Sat": day = DayOfWeek.Saturday; break;
                case "Sun": day = DayOfWeek.Sunday; break;
                default: return;
            }

            if (selectedDays.Contains(day))
            {
                selectedDays.Remove(day);
                selectedButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText; 
            }
            else
            {
                selectedDays.Add(day);
                selectedButton.BackColor = System.Drawing.Color.MediumSeaGreen; 
            }
        }

        private void btnFri_Click(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;
            DayOfWeek day;

            switch (selectedButton.Text)
            {
                case "Mon": day = DayOfWeek.Monday; break;
                case "Tue": day = DayOfWeek.Tuesday; break;
                case "Wed": day = DayOfWeek.Wednesday; break;
                case "Thu": day = DayOfWeek.Thursday; break;
                case "Fri": day = DayOfWeek.Friday; break;
                case "Sat": day = DayOfWeek.Saturday; break;
                case "Sun": day = DayOfWeek.Sunday; break;
                default: return;
            }

            if (selectedDays.Contains(day))
            {
                selectedDays.Remove(day);
                selectedButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText; 
            }
            else
            {
                selectedDays.Add(day);
                selectedButton.BackColor = System.Drawing.Color.MediumSeaGreen; 
            }
        }

        private void btnSat_Click(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;
            DayOfWeek day;

            switch (selectedButton.Text)
            {
                case "Mon": day = DayOfWeek.Monday; break;
                case "Tue": day = DayOfWeek.Tuesday; break;
                case "Wed": day = DayOfWeek.Wednesday; break;
                case "Thu": day = DayOfWeek.Thursday; break;
                case "Fri": day = DayOfWeek.Friday; break;
                case "Sat": day = DayOfWeek.Saturday; break;
                case "Sun": day = DayOfWeek.Sunday; break;
                default: return;
            }

            if (selectedDays.Contains(day))
            {
                selectedDays.Remove(day);
                selectedButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText; 
            }
            else
            {
                selectedDays.Add(day);
                selectedButton.BackColor = System.Drawing.Color.MediumSeaGreen; 
            }
        }

        private void btnSun_Click(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;
            DayOfWeek day;

            switch (selectedButton.Text)
            {
                case "Mon": day = DayOfWeek.Monday; break;
                case "Tue": day = DayOfWeek.Tuesday; break;
                case "Wed": day = DayOfWeek.Wednesday; break;
                case "Thu": day = DayOfWeek.Thursday; break;
                case "Fri": day = DayOfWeek.Friday; break;
                case "Sat": day = DayOfWeek.Saturday; break;
                case "Sun": day = DayOfWeek.Sunday; break;
                default: return;
            }

            if (selectedDays.Contains(day))
            {
                selectedDays.Remove(day);
                selectedButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText; 
            }
            else
            {
                selectedDays.Add(day);
                selectedButton.BackColor = System.Drawing.Color.MediumSeaGreen; 
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                TimeSpan openingTime = TimeSpan.Parse(txtOpeningTime.Text); 
                TimeSpan closingTime = TimeSpan.Parse(txtClosingTime.Text);
                decimal dayPrice = decimal.Parse(txtdayPrice.Text);
                decimal nightPrice = decimal.Parse(txtnightPrice.Text);
                TimeSpan nightPriceStart = new TimeSpan(18, 0, 0); 

                if (selectedDays.Count == 0)
                {
                    MessageBox.Show("Silakan pilih minimal satu hari.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var db = new CourtCraftDBEntities1())
                {
                    var venues = db.Venues.ToList();
                    int generatedCount = 0;

                    for (int i = 0; i < 30; i++)
                    {
                        DateTime currentDate = DateTime.Today.AddDays(i);

                        if (selectedDays.Contains(currentDate.DayOfWeek))
                        {
                            foreach (var venue in venues)
                            {
                                for (TimeSpan time = openingTime; time < closingTime; time = time.Add(TimeSpan.FromHours(1)))
                                {
                                    var newSlot = new TimeSlot
                                    {
                                        TimeSlotID = "TS" + DateTime.Now.Ticks + i + time.Hours,
                                        VenueID = venue.VenueID,
                                        SlotDate = currentDate,
                                        StartTime = time,
                                        EndTime = time.Add(TimeSpan.FromHours(1)),
                                        IsBooked = "Available", 
                                        Price = (time < nightPriceStart) ? dayPrice : nightPrice 
                                    };
                                    db.TimeSlots.Add(newSlot);
                                    generatedCount++;
                                }
                            }
                        }
                    }

                    db.SaveChanges();
                    MessageBox.Show($"{generatedCount} slot waktu berhasil dibuat untuk 30 hari ke depan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Format input salah. Contoh waktu: '08:00', Contoh harga: '50000'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void Cashier_Operating_Hours_Load(object sender, EventArgs e)
        {

        }
    }
}
