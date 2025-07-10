using Microsoft.VisualBasic;
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
    public partial class Owner_Vanue: Form
    {
        public Owner_Vanue()
        {
            InitializeComponent();
            LoadVenues();
        }
        private void LoadVenues()
        {
            try
            {
                using (var db = new CourtCraftDBEntities1())
                {
                    dtVanue.DataSource = db.Venues.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error memuat data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Owner_Vanue_Load(object sender, EventArgs e)
        {
           
        }

        private void btnAddListVenue_Click(object sender, EventArgs e)
        {
            string venueName = Interaction.InputBox("Masukkan Nama Venue Baru:", "Tambah Venue", "");

            if (!string.IsNullOrWhiteSpace(venueName))
            {
                try
                {
                    using (var db = new CourtCraftDBEntities1())
                    {
                        var newVenue = new Venue
                        {
                            VenueID = "V" + DateTime.Now.Ticks,
                            Name = venueName
                        };

                        db.Venues.Add(newVenue);
                        db.SaveChanges();      
                    }

                    MessageBox.Show("Venue baru berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadVenues();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error menambahkan venue: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDeleteVenues_Click(object sender, EventArgs e)
        {
            if (dtVanue.SelectedRows.Count > 0)
            {
                string venueID = dtVanue.SelectedRows[0].Cells["VenueID"].Value.ToString();

                if (MessageBox.Show("Apakah Anda yakin ingin menghapus venue ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        using (var db = new CourtCraftDBEntities1())
                        {
                            var venueToDelete = db.Venues.Find(venueID);
                            if (venueToDelete != null)
                            {
                                db.Venues.Remove(venueToDelete); 
                                db.SaveChanges();            
                                LoadVenues();                
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error menghapus venue: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Silakan pilih venue yang ingin dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnListvenues_Click(object sender, EventArgs e)
        {
        }

        private void btnRentalreports_Click(object sender, EventArgs e)
        {
            this.Hide();
            owner_Report reportForm = new owner_Report();
            reportForm.Show();
        }

        private void btnOperatingHours_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cashier_Operating_Hours opHoursForm = new Cashier_Operating_Hours();
            opHoursForm.Show();
        }
    }
}
