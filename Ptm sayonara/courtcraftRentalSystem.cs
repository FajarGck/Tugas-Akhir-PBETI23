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
    public partial class courtcraftRentalSystem: Form
    {
        public courtcraftRentalSystem()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan Password tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new CourtCraftDBEntities1()) 
                {
                    var user = db.Users.FirstOrDefault(u => u.Username == username && u.Password == password);

                    if (user != null) 
                    {
                        LoggedInUser.UserID = user.UserID;
                        LoggedInUser.Username = user.Username;
                        this.Hide(); 

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
                    else 
                    {
                        MessageBox.Show("Username atau Password salah.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi error. Detail: " + ex.Message, "Error Aplikasi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void courtcraftRentalSystem_Load(object sender, EventArgs e)
        {

        }
        private bool isPasswordShown = false;
        private void btnberanda_Click(object sender, EventArgs e)
        {
            if (isPasswordShown)
            {
                txtPassword.PasswordChar = '*';
                isPasswordShown = false;
            }
            else
            {
                txtPassword.PasswordChar = '\0';
                isPasswordShown = true;
            }
        }
    }
}
