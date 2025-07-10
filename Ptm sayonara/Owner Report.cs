using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ptm_sayonara
{
    public partial class owner_Report: Form
    {
        public owner_Report()
        {
            InitializeComponent();
        }

        private void LoadReport(string searchTerm = "")
        {
            try
            {
                using (var db = new CourtCraftDBEntities1())
                {
                    var query = from b in db.Bookings
                                join p in db.Payments on b.BookingID equals p.BookingID 
                                join c in db.Customers on b.CustomerID equals c.CustomerID 
                                join u in db.Users on b.UserID equals u.UserID 
                                select new
                                {
                                    b.BookingID,
                                    b.BookingDate,
                                    c.FullName,
                                    p.Totalharga,
                                    p.Statuspayments,
                                    u.Username,
                                    b.TimeSlots 
                                };

                    if (!string.IsNullOrEmpty(searchTerm))
                    {
                        query = query.Where(r => r.FullName.Contains(searchTerm) ||
                                                 r.BookingID.Contains(searchTerm));
                    }

                    var reportData = query
                        .OrderByDescending(r => r.BookingDate)
                        .Select(r => new
                        {
                            BookingID = r.BookingID,
                            Tanggal = r.BookingDate,
                            Customer = r.FullName,
                            Venue = r.TimeSlots.FirstOrDefault().Venue.Name, 
                            TotalBayar = r.Totalharga,
                            Status = r.Statuspayments,
                            Kasir = r.Username
                        })
                        .ToList();

                    dtReport.DataSource = reportData;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat laporan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadReport(txtSearch.Text);
        }

        private void owner_Report_Load(object sender, EventArgs e)
        {
            LoadReport();
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

        private void btnexportPDF_Click(object sender, EventArgs e)
        {
            if (dtReport.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "HTML File (*.html)|*.html";
                saveFileDialog.FileName = "Laporan_Penyewaan_" + DateTime.Now.ToString("yyyyMMdd") + ".html";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        StringBuilder htmlBuilder = new StringBuilder();

                        htmlBuilder.Append("<html>");
                        htmlBuilder.Append("<head>");
                        htmlBuilder.Append("<title>Laporan Penyewaan</title>");
                        htmlBuilder.Append("<style>");
                        htmlBuilder.Append("body { font-family: Arial, sans-serif; }");
                        htmlBuilder.Append("table { border-collapse: collapse; width: 100%; }");
                        htmlBuilder.Append("th, td { border: 1px solid #dddddd; text-align: left; padding: 8px; }");
                        htmlBuilder.Append("th { background-color: #f2f2f2; }");
                        htmlBuilder.Append("h1 { text-align: center; }");
                        htmlBuilder.Append("</style>");
                        htmlBuilder.Append("</head>");
                        htmlBuilder.Append("<body>");
                        htmlBuilder.Append("<h1>Laporan Penyewaan - CourtCraft</h1>");
                        htmlBuilder.Append("<table>");

                        htmlBuilder.Append("<tr>");
                        foreach (DataGridViewColumn column in dtReport.Columns)
                        {
                            htmlBuilder.Append("<th>" + column.HeaderText + "</th>");
                        }
                        htmlBuilder.Append("</tr>");

                        foreach (DataGridViewRow row in dtReport.Rows)
                        {
                            htmlBuilder.Append("<tr>");
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                string cellValue = cell.Value != null ? cell.Value.ToString() : "";
                                htmlBuilder.Append("<td>" + cellValue + "</td>");
                            }
                            htmlBuilder.Append("</tr>");
                        }

                        htmlBuilder.Append("</table>");
                        htmlBuilder.Append("</body></html>");

                        File.WriteAllText(saveFileDialog.FileName, htmlBuilder.ToString());

                        Process.Start(saveFileDialog.FileName);

                        MessageBox.Show("File Laporan HTML berhasil dibuat dan dibuka di browser!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Terjadi error saat ekspor ke HTML: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Tidak ada data untuk diekspor.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            // print gak jadi
            //Font fontJudul = new Font("Arial", 20, FontStyle.Bold);
            //Font fontIsi = new Font("Arial", 30, FontStyle.Regular);
            //SolidBrush brush = new SolidBrush(Color.Black);
            //float ypos = 0f;
            //int count = 0;
            //float lefMargin = 
        }
    }
}
