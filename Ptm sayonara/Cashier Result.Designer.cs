namespace Ptm_sayonara
{
    partial class Cashier_Result
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
            this.dtBooking = new System.Windows.Forms.DataGridView();
            this.pnlPenghasilan = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPenghasilan = new System.Windows.Forms.Label();
            this.pnlTodaysRental = new System.Windows.Forms.Panel();
            this.btnTodayRentals = new FontAwesome.Sharp.IconButton();
            this.lblTodayRental = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSettlePayment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtBooking)).BeginInit();
            this.pnlPenghasilan.SuspendLayout();
            this.pnlTodaysRental.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.btnSettlePayment);
            this.splitContainer1.Panel2.Controls.Add(this.dtBooking);
            this.splitContainer1.Panel2.Controls.Add(this.pnlPenghasilan);
            this.splitContainer1.Panel2.Controls.Add(this.pnlTodaysRental);
            this.splitContainer1.Size = new System.Drawing.Size(891, 531);
            this.splitContainer1.SplitterDistance = 218;
            this.splitContainer1.TabIndex = 1;
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
            this.btnberanda.BackColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.btnberanda.Click += new System.EventHandler(this.btnberanda_Click);
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
            // dtBooking
            // 
            this.dtBooking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtBooking.Location = new System.Drawing.Point(24, 247);
            this.dtBooking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtBooking.Name = "dtBooking";
            this.dtBooking.RowHeadersWidth = 62;
            this.dtBooking.RowTemplate.Height = 28;
            this.dtBooking.Size = new System.Drawing.Size(584, 231);
            this.dtBooking.TabIndex = 3;
            // 
            // pnlPenghasilan
            // 
            this.pnlPenghasilan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlPenghasilan.Controls.Add(this.label4);
            this.pnlPenghasilan.Controls.Add(this.lblPenghasilan);
            this.pnlPenghasilan.Location = new System.Drawing.Point(328, 57);
            this.pnlPenghasilan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlPenghasilan.Name = "pnlPenghasilan";
            this.pnlPenghasilan.Size = new System.Drawing.Size(280, 96);
            this.pnlPenghasilan.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Penghasilan Venue";
            // 
            // lblPenghasilan
            // 
            this.lblPenghasilan.AutoSize = true;
            this.lblPenghasilan.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPenghasilan.Location = new System.Drawing.Point(23, 35);
            this.lblPenghasilan.Name = "lblPenghasilan";
            this.lblPenghasilan.Size = new System.Drawing.Size(219, 54);
            this.lblPenghasilan.TabIndex = 1;
            this.lblPenghasilan.Text = "Rp. 100000";
            this.lblPenghasilan.Click += new System.EventHandler(this.lblPenghasilan_Click);
            // 
            // pnlTodaysRental
            // 
            this.pnlTodaysRental.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlTodaysRental.Controls.Add(this.btnTodayRentals);
            this.pnlTodaysRental.Controls.Add(this.lblTodayRental);
            this.pnlTodaysRental.Controls.Add(this.label2);
            this.pnlTodaysRental.Location = new System.Drawing.Point(24, 57);
            this.pnlTodaysRental.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTodaysRental.Name = "pnlTodaysRental";
            this.pnlTodaysRental.Size = new System.Drawing.Size(280, 96);
            this.pnlTodaysRental.TabIndex = 1;
            // 
            // btnTodayRentals
            // 
            this.btnTodayRentals.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.btnTodayRentals.IconColor = System.Drawing.Color.Black;
            this.btnTodayRentals.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTodayRentals.IconSize = 24;
            this.btnTodayRentals.Location = new System.Drawing.Point(251, 6);
            this.btnTodayRentals.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTodayRentals.Name = "btnTodayRentals";
            this.btnTodayRentals.Size = new System.Drawing.Size(27, 25);
            this.btnTodayRentals.TabIndex = 13;
            this.btnTodayRentals.UseVisualStyleBackColor = true;
            // 
            // lblTodayRental
            // 
            this.lblTodayRental.AutoSize = true;
            this.lblTodayRental.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayRental.Location = new System.Drawing.Point(16, 35);
            this.lblTodayRental.Name = "lblTodayRental";
            this.lblTodayRental.Size = new System.Drawing.Size(67, 54);
            this.lblTodayRental.TabIndex = 2;
            this.lblTodayRental.Text = "60";
            this.lblTodayRental.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Todays Rentals";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnSettlePayment
            // 
            this.btnSettlePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettlePayment.Location = new System.Drawing.Point(435, 204);
            this.btnSettlePayment.Name = "btnSettlePayment";
            this.btnSettlePayment.Size = new System.Drawing.Size(173, 32);
            this.btnSettlePayment.TabIndex = 4;
            this.btnSettlePayment.Text = "Lunasi Payment";
            this.btnSettlePayment.UseVisualStyleBackColor = true;
            this.btnSettlePayment.Click += new System.EventHandler(this.btnSettlePayment_Click);
            // 
            // Cashier_Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(891, 531);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Cashier_Result";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashierResult";
            this.Load += new System.EventHandler(this.Cashier_Result_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtBooking)).EndInit();
            this.pnlPenghasilan.ResumeLayout(false);
            this.pnlPenghasilan.PerformLayout();
            this.pnlTodaysRental.ResumeLayout(false);
            this.pnlTodaysRental.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnOperatingHours;
        private FontAwesome.Sharp.IconButton btnBookingMenu;
        private FontAwesome.Sharp.IconButton btnberanda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlPenghasilan;
        private System.Windows.Forms.Panel pnlTodaysRental;
        private System.Windows.Forms.Label lblPenghasilan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtBooking;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTodayRental;
        private FontAwesome.Sharp.IconButton btnTodayRentals;
        private System.Windows.Forms.Button btnSettlePayment;
    }
}