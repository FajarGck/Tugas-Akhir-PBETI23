namespace Ptm_sayonara
{
    partial class cashierDashboard
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
            this.btnOperatingHours = new FontAwesome.Sharp.IconButton();
            this.btnBookingMenu = new FontAwesome.Sharp.IconButton();
            this.btnberanda = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTdyRental = new FontAwesome.Sharp.IconButton();
            this.pnltotalRevenue = new System.Windows.Forms.Panel();
            this.btnNewbooking = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnOperatingHours);
            this.splitContainer1.Panel1.Controls.Add(this.btnBookingMenu);
            this.splitContainer1.Panel1.Controls.Add(this.btnberanda);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.pnltotalRevenue);
            this.splitContainer1.Size = new System.Drawing.Size(891, 531);
            this.splitContainer1.SplitterDistance = 218;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.btnLogout.IconColor = System.Drawing.Color.Black;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.IconSize = 30;
            this.btnLogout.Location = new System.Drawing.Point(22, 481);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(22, 6, 3, 8);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(178, 35);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Logout\r\n";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnOperatingHours
            // 
            this.btnOperatingHours.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperatingHours.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            this.btnOperatingHours.IconColor = System.Drawing.Color.Black;
            this.btnOperatingHours.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOperatingHours.IconSize = 30;
            this.btnOperatingHours.Location = new System.Drawing.Point(22, 180);
            this.btnOperatingHours.Margin = new System.Windows.Forms.Padding(22, 6, 3, 8);
            this.btnOperatingHours.Name = "btnOperatingHours";
            this.btnOperatingHours.Size = new System.Drawing.Size(178, 35);
            this.btnOperatingHours.TabIndex = 9;
            this.btnOperatingHours.Text = "Operating Hours";
            this.btnOperatingHours.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOperatingHours.UseVisualStyleBackColor = true;
            this.btnOperatingHours.Click += new System.EventHandler(this.btnOperatingHours_Click);
            // 
            // btnBookingMenu
            // 
            this.btnBookingMenu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookingMenu.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.btnBookingMenu.IconColor = System.Drawing.Color.Black;
            this.btnBookingMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBookingMenu.IconSize = 30;
            this.btnBookingMenu.Location = new System.Drawing.Point(22, 130);
            this.btnBookingMenu.Margin = new System.Windows.Forms.Padding(22, 6, 3, 8);
            this.btnBookingMenu.Name = "btnBookingMenu";
            this.btnBookingMenu.Size = new System.Drawing.Size(178, 35);
            this.btnBookingMenu.TabIndex = 8;
            this.btnBookingMenu.Text = "Booking Menu";
            this.btnBookingMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBookingMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBookingMenu.UseVisualStyleBackColor = true;
            this.btnBookingMenu.Click += new System.EventHandler(this.btnBookingMenu_Click);
            // 
            // btnberanda
            // 
            this.btnberanda.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnberanda.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnberanda.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.btnberanda.IconColor = System.Drawing.Color.Black;
            this.btnberanda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnberanda.IconSize = 30;
            this.btnberanda.Location = new System.Drawing.Point(22, 81);
            this.btnberanda.Margin = new System.Windows.Forms.Padding(22, 6, 3, 8);
            this.btnberanda.Name = "btnberanda";
            this.btnberanda.Size = new System.Drawing.Size(178, 35);
            this.btnberanda.TabIndex = 7;
            this.btnberanda.Text = "Beranda";
            this.btnberanda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnberanda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnberanda.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Owner Dashboard";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.btnTdyRental);
            this.panel1.Location = new System.Drawing.Point(335, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 96);
            this.panel1.TabIndex = 2;
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
            // pnltotalRevenue
            // 
            this.pnltotalRevenue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnltotalRevenue.Controls.Add(this.btnNewbooking);
            this.pnltotalRevenue.Location = new System.Drawing.Point(24, 30);
            this.pnltotalRevenue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnltotalRevenue.Name = "pnltotalRevenue";
            this.pnltotalRevenue.Size = new System.Drawing.Size(280, 96);
            this.pnltotalRevenue.TabIndex = 1;
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
            // cashierDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(891, 531);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "cashierDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cashierDashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.cashierDashboard_FormClosed);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnltotalRevenue.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnberanda;
        private FontAwesome.Sharp.IconButton btnBookingMenu;
        private FontAwesome.Sharp.IconButton btnOperatingHours;
        private FontAwesome.Sharp.IconButton btnLogout;
        private System.Windows.Forms.Panel pnltotalRevenue;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnNewbooking;
        private FontAwesome.Sharp.IconButton btnTdyRental;
    }
}