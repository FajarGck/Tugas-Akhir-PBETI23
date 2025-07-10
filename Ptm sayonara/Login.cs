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

namespace Ptm_sayonara
{
    public partial class Login: Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Validasi input sederhana
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan Password tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. Gunakan context dari Entity Framework yang sudah dibuat
                // 'using' akan memastikan koneksi dikelola secara otomatis
                using (var db = new CourtCraftDBEntities1()) // Pastikan nama ini sama dengan di App.config
                {
                    // 3. Cari user menggunakan LINQ. Jauh lebih mudah dan aman!
                    var user = db.Users.FirstOrDefault(u => u.Username == username && u.Password == password);

                    // 4. Periksa hasil login
                    if (user != null) // Jika user ditemukan
                    {
                        this.Hide(); // Sembunyikan form login

                        // Arahkan berdasarkan peran dari objek user
                        if (user.Role == "Owner")
                        {
                            OwnerDashboard ownerForm = new OwnerDashboard();
                            ownerForm.Show();
                        }
                        else if (user.Role == "Kasir")
                        {
                            cashierDashboard cashierForm = new cashierDashboard();
                            cashierForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Peran tidak dikenali.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Show();
                        }
                    }
                    else // Jika user tidak ditemukan
                    {
                        MessageBox.Show("Username atau Password salah.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                // Menangani error jika ada masalah koneksi ke DB atau lainnya
                MessageBox.Show("Terjadi error. Detail: " + ex.Message, "Error Aplikasi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
