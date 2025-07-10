namespace Ptm_sayonara
{
    partial class OwnerDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBookingMenu = new FontAwesome.Sharp.IconButton();
            this.btnOperatingHours = new FontAwesome.Sharp.IconButton();
            this.btnListvenues = new FontAwesome.Sharp.IconButton();
            this.btnRentalreports = new FontAwesome.Sharp.IconButton();
            this.btnberanda = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTdyRental = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNewbooking = new FontAwesome.Sharp.IconButton();
            this.pnlPendingDeposits = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlVanueUltilization = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGenerateReports = new System.Windows.Forms.Button();
            this.pnltotalRevenue = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlPendingDeposits.SuspendLayout();
            this.pnlVanueUltilization.SuspendLayout();
            this.pnltotalRevenue.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer1.Panel1.Controls.Add(this.btnLogout);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btnBookingMenu);
            this.splitContainer1.Panel1.Controls.Add(this.btnOperatingHours);
            this.splitContainer1.Panel1.Controls.Add(this.btnListvenues);
            this.splitContainer1.Panel1.Controls.Add(this.btnRentalreports);
            this.splitContainer1.Panel1.Controls.Add(this.btnberanda);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.pnlPendingDeposits);
            this.splitContainer1.Panel2.Controls.Add(this.pnlVanueUltilization);
            this.splitContainer1.Panel2.Controls.Add(this.btnGenerateReports);
            this.splitContainer1.Panel2.Controls.Add(this.pnltotalRevenue);
            this.splitContainer1.Size = new System.Drawing.Size(891, 531);
            this.splitContainer1.SplitterDistance = 208;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.btnLogout.IconColor = System.Drawing.Color.Black;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.IconSize = 30;
            this.btnLogout.Location = new System.Drawing.Point(16, 481);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(22, 6, 3, 8);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(178, 35);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout\r\n";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Owner Dashboard";
            // 
            // btnBookingMenu
            // 
            this.btnBookingMenu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookingMenu.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.btnBookingMenu.IconColor = System.Drawing.Color.Black;
            this.btnBookingMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBookingMenu.IconSize = 30;
            this.btnBookingMenu.Location = new System.Drawing.Point(14, 136);
            this.btnBookingMenu.Margin = new System.Windows.Forms.Padding(22, 6, 3, 8);
            this.btnBookingMenu.Name = "btnBookingMenu";
            this.btnBookingMenu.Size = new System.Drawing.Size(178, 35);
            this.btnBookingMenu.TabIndex = 4;
            this.btnBookingMenu.Text = "Booking Menu";
            this.btnBookingMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBookingMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBookingMenu.UseVisualStyleBackColor = true;
            this.btnBookingMenu.Click += new System.EventHandler(this.btnBookingMenu_Click);
            // 
            // btnOperatingHours
            // 
            this.btnOperatingHours.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperatingHours.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            this.btnOperatingHours.IconColor = System.Drawing.Color.Black;
            this.btnOperatingHours.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOperatingHours.IconSize = 30;
            this.btnOperatingHours.Location = new System.Drawing.Point(14, 285);
            this.btnOperatingHours.Margin = new System.Windows.Forms.Padding(22, 6, 3, 8);
            this.btnOperatingHours.Name = "btnOperatingHours";
            this.btnOperatingHours.Size = new System.Drawing.Size(178, 35);
            this.btnOperatingHours.TabIndex = 3;
            this.btnOperatingHours.Text = "Operating Hours";
            this.btnOperatingHours.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOperatingHours.UseVisualStyleBackColor = true;
            this.btnOperatingHours.Click += new System.EventHandler(this.btnOperatingHours_Click);
            // 
            // btnListvenues
            // 
            this.btnListvenues.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListvenues.IconChar = FontAwesome.Sharp.IconChar.BorderAll;
            this.btnListvenues.IconColor = System.Drawing.Color.Black;
            this.btnListvenues.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListvenues.IconSize = 30;
            this.btnListvenues.Location = new System.Drawing.Point(14, 186);
            this.btnListvenues.Margin = new System.Windows.Forms.Padding(22, 6, 3, 8);
            this.btnListvenues.Name = "btnListvenues";
            this.btnListvenues.Size = new System.Drawing.Size(178, 35);
            this.btnListvenues.TabIndex = 2;
            this.btnListvenues.Text = "List venues";
            this.btnListvenues.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListvenues.UseVisualStyleBackColor = true;
            this.btnListvenues.Click += new System.EventHandler(this.btnListvenues_Click);
            // 
            // btnRentalreports
            // 
            this.btnRentalreports.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentalreports.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnRentalreports.IconColor = System.Drawing.Color.Black;
            this.btnRentalreports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRentalreports.IconSize = 30;
            this.btnRentalreports.Location = new System.Drawing.Point(16, 235);
            this.btnRentalreports.Margin = new System.Windows.Forms.Padding(22, 6, 3, 8);
            this.btnRentalreports.Name = "btnRentalreports";
            this.btnRentalreports.Size = new System.Drawing.Size(178, 35);
            this.btnRentalreports.TabIndex = 1;
            this.btnRentalreports.Text = "Rental Reports";
            this.btnRentalreports.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRentalreports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRentalreports.UseVisualStyleBackColor = true;
            this.btnRentalreports.Click += new System.EventHandler(this.btnRentalreports_Click);
            // 
            // btnberanda
            // 
            this.btnberanda.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnberanda.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnberanda.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.btnberanda.IconColor = System.Drawing.Color.Black;
            this.btnberanda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnberanda.IconSize = 30;
            this.btnberanda.Location = new System.Drawing.Point(14, 86);
            this.btnberanda.Margin = new System.Windows.Forms.Padding(22, 6, 3, 8);
            this.btnberanda.Name = "btnberanda";
            this.btnberanda.Size = new System.Drawing.Size(178, 35);
            this.btnberanda.TabIndex = 0;
            this.btnberanda.Text = "Beranda";
            this.btnberanda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnberanda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnberanda.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.btnTdyRental);
            this.panel1.Location = new System.Drawing.Point(342, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 96);
            this.panel1.TabIndex = 7;
            // 
            // btnTdyRental
            // 
            this.btnTdyRental.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTdyRental.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTdyRental.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.btnTdyRental.IconColor = System.Drawing.Color.Black;
            this.btnTdyRental.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTdyRental.IconSize = 40;
            this.btnTdyRental.Location = new System.Drawing.Point(60, 14);
            this.btnTdyRental.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTdyRental.Name = "btnTdyRental";
            this.btnTdyRental.Size = new System.Drawing.Size(160, 70);
            this.btnTdyRental.TabIndex = 2;
            this.btnTdyRental.Text = "Today\'s Rentals";
            this.btnTdyRental.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTdyRental.UseVisualStyleBackColor = false;
            this.btnTdyRental.Click += new System.EventHandler(this.btnTdyRental_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.btnNewbooking);
            this.panel2.Location = new System.Drawing.Point(31, 25);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 96);
            this.panel2.TabIndex = 6;
            // 
            // btnNewbooking
            // 
            this.btnNewbooking.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewbooking.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnNewbooking.IconColor = System.Drawing.Color.Black;
            this.btnNewbooking.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNewbooking.Location = new System.Drawing.Point(62, 14);
            this.btnNewbooking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNewbooking.Name = "btnNewbooking";
            this.btnNewbooking.Size = new System.Drawing.Size(160, 70);
            this.btnNewbooking.TabIndex = 1;
            this.btnNewbooking.Text = "New Booking";
            this.btnNewbooking.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNewbooking.UseVisualStyleBackColor = true;
            this.btnNewbooking.Click += new System.EventHandler(this.btnNewbooking_Click);
            // 
            // pnlPendingDeposits
            // 
            this.pnlPendingDeposits.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlPendingDeposits.Controls.Add(this.label6);
            this.pnlPendingDeposits.Controls.Add(this.label7);
            this.pnlPendingDeposits.Location = new System.Drawing.Point(239, 146);
            this.pnlPendingDeposits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlPendingDeposits.Name = "pnlPendingDeposits";
            this.pnlPendingDeposits.Size = new System.Drawing.Size(196, 86);
            this.pnlPendingDeposits.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 28);
            this.label6.TabIndex = 1;
            this.label6.Text = "Rp. 45000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Pending Deposits";
            // 
            // pnlVanueUltilization
            // 
            this.pnlVanueUltilization.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlVanueUltilization.Controls.Add(this.label4);
            this.pnlVanueUltilization.Controls.Add(this.label5);
            this.pnlVanueUltilization.Location = new System.Drawing.Point(460, 146);
            this.pnlVanueUltilization.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlVanueUltilization.Name = "pnlVanueUltilization";
            this.pnlVanueUltilization.Size = new System.Drawing.Size(196, 86);
            this.pnlVanueUltilization.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "78%";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Vanue Ultilization";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnGenerateReports
            // 
            this.btnGenerateReports.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnGenerateReports.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGenerateReports.Location = new System.Drawing.Point(12, 264);
            this.btnGenerateReports.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerateReports.Name = "btnGenerateReports";
            this.btnGenerateReports.Size = new System.Drawing.Size(172, 47);
            this.btnGenerateReports.TabIndex = 2;
            this.btnGenerateReports.Text = "Generate Reports";
            this.btnGenerateReports.UseVisualStyleBackColor = false;
            this.btnGenerateReports.Click += new System.EventHandler(this.btnGenerateReports_Click);
            // 
            // pnltotalRevenue
            // 
            this.pnltotalRevenue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnltotalRevenue.Controls.Add(this.label3);
            this.pnltotalRevenue.Controls.Add(this.label2);
            this.pnltotalRevenue.Location = new System.Drawing.Point(12, 146);
            this.pnltotalRevenue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnltotalRevenue.Name = "pnltotalRevenue";
            this.pnltotalRevenue.Size = new System.Drawing.Size(196, 86);
            this.pnltotalRevenue.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Rp. 125,000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Revenue";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // OwnerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(891, 531);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OwnerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OwnerDashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OwnerDashboard_FormClosing);
            this.Load += new System.EventHandler(this.OwnerDashboard_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlPendingDeposits.ResumeLayout(false);
            this.pnlPendingDeposits.PerformLayout();
            this.pnlVanueUltilization.ResumeLayout(false);
            this.pnlVanueUltilization.PerformLayout();
            this.pnltotalRevenue.ResumeLayout(false);
            this.pnltotalRevenue.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private FontAwesome.Sharp.IconButton btnberanda;
        private FontAwesome.Sharp.IconButton btnBookingMenu;
        private FontAwesome.Sharp.IconButton btnOperatingHours;
        private FontAwesome.Sharp.IconButton btnListvenues;
        private FontAwesome.Sharp.IconButton btnRentalreports;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnltotalRevenue;
        private System.Windows.Forms.Button btnGenerateReports;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlVanueUltilization;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlPendingDeposits;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton btnLogout;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnTdyRental;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnNewbooking;
    }
}