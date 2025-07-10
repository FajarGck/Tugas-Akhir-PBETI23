namespace Ptm_sayonara
{
    partial class Cashier_Booking
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
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.dtpBookingDate = new System.Windows.Forms.DateTimePicker();
            this.dgvTimeSlots = new System.Windows.Forms.DataGridView();
            this.cmbVenue = new System.Windows.Forms.ComboBox();
            this.radioDeposit = new System.Windows.Forms.RadioButton();
            this.radioFullPayment = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCnlBooking = new System.Windows.Forms.Button();
            this.btnCnfBooking = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcusName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeSlots)).BeginInit();
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
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.txtTotalAmount);
            this.splitContainer1.Panel2.Controls.Add(this.dtpBookingDate);
            this.splitContainer1.Panel2.Controls.Add(this.dgvTimeSlots);
            this.splitContainer1.Panel2.Controls.Add(this.cmbVenue);
            this.splitContainer1.Panel2.Controls.Add(this.radioDeposit);
            this.splitContainer1.Panel2.Controls.Add(this.radioFullPayment);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.btnCnlBooking);
            this.splitContainer1.Panel2.Controls.Add(this.btnCnfBooking);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.txtcusName);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
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
            this.btnBookingMenu.BackColor = System.Drawing.SystemColors.ButtonFace;
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
            this.btnBookingMenu.UseVisualStyleBackColor = false;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(348, 397);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "Total :";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(398, 397);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(191, 22);
            this.txtTotalAmount.TabIndex = 25;
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpBookingDate
            // 
            this.dtpBookingDate.Location = new System.Drawing.Point(26, 136);
            this.dtpBookingDate.Name = "dtpBookingDate";
            this.dtpBookingDate.Size = new System.Drawing.Size(186, 22);
            this.dtpBookingDate.TabIndex = 24;
            this.dtpBookingDate.ValueChanged += new System.EventHandler(this.dtpBookingDate_ValueChanged);
            // 
            // dgvTimeSlots
            // 
            this.dgvTimeSlots.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTimeSlots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimeSlots.Location = new System.Drawing.Point(27, 189);
            this.dgvTimeSlots.Name = "dgvTimeSlots";
            this.dgvTimeSlots.RowHeadersWidth = 51;
            this.dgvTimeSlots.RowTemplate.Height = 24;
            this.dgvTimeSlots.Size = new System.Drawing.Size(562, 194);
            this.dgvTimeSlots.TabIndex = 23;
            this.dgvTimeSlots.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTimeSlots_CellContentClick);
            this.dgvTimeSlots.SelectionChanged += new System.EventHandler(this.dgvTimeSlots_SelectionChanged);
            // 
            // cmbVenue
            // 
            this.cmbVenue.FormattingEnabled = true;
            this.cmbVenue.Location = new System.Drawing.Point(26, 104);
            this.cmbVenue.Name = "cmbVenue";
            this.cmbVenue.Size = new System.Drawing.Size(214, 24);
            this.cmbVenue.TabIndex = 22;
            this.cmbVenue.SelectedIndexChanged += new System.EventHandler(this.cmbVenue_SelectedIndexChanged);
            // 
            // radioDeposit
            // 
            this.radioDeposit.AutoSize = true;
            this.radioDeposit.Location = new System.Drawing.Point(179, 428);
            this.radioDeposit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioDeposit.Name = "radioDeposit";
            this.radioDeposit.Size = new System.Drawing.Size(75, 20);
            this.radioDeposit.TabIndex = 20;
            this.radioDeposit.TabStop = true;
            this.radioDeposit.Text = "Deposit";
            this.radioDeposit.UseVisualStyleBackColor = true;
            this.radioDeposit.CheckedChanged += new System.EventHandler(this.radioFullPayment_CheckedChanged);
            // 
            // radioFullPayment
            // 
            this.radioFullPayment.AutoSize = true;
            this.radioFullPayment.Location = new System.Drawing.Point(28, 428);
            this.radioFullPayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioFullPayment.Name = "radioFullPayment";
            this.radioFullPayment.Size = new System.Drawing.Size(112, 20);
            this.radioFullPayment.TabIndex = 19;
            this.radioFullPayment.TabStop = true;
            this.radioFullPayment.Text = "Full Payments";
            this.radioFullPayment.UseVisualStyleBackColor = true;
            this.radioFullPayment.CheckedChanged += new System.EventHandler(this.radioFullPayment_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "Payment Type";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnCnlBooking
            // 
            this.btnCnlBooking.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCnlBooking.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCnlBooking.Location = new System.Drawing.Point(310, 479);
            this.btnCnlBooking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCnlBooking.Name = "btnCnlBooking";
            this.btnCnlBooking.Size = new System.Drawing.Size(147, 37);
            this.btnCnlBooking.TabIndex = 17;
            this.btnCnlBooking.Text = "Cancel Booking";
            this.btnCnlBooking.UseVisualStyleBackColor = false;
            // 
            // btnCnfBooking
            // 
            this.btnCnfBooking.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnCnfBooking.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCnfBooking.Location = new System.Drawing.Point(462, 479);
            this.btnCnfBooking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCnfBooking.Name = "btnCnfBooking";
            this.btnCnfBooking.Size = new System.Drawing.Size(147, 37);
            this.btnCnfBooking.TabIndex = 16;
            this.btnCnfBooking.Text = "Confirm Booking";
            this.btnCnfBooking.UseVisualStyleBackColor = false;
            this.btnCnfBooking.Click += new System.EventHandler(this.btnCnfBooking_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(347, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "End Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Start Time";
            // 
            // txtcusName
            // 
            this.txtcusName.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcusName.Location = new System.Drawing.Point(350, 103);
            this.txtcusName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcusName.Name = "txtcusName";
            this.txtcusName.Size = new System.Drawing.Size(240, 25);
            this.txtcusName.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(347, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Venue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 54);
            this.label3.TabIndex = 2;
            this.label3.Text = "New Booking";
            // 
            // Cashier_Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(891, 531);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Cashier_Booking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashierBooking";
            this.Load += new System.EventHandler(this.Cashier_Booking_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeSlots)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnOperatingHours;
        private FontAwesome.Sharp.IconButton btnBookingMenu;
        private FontAwesome.Sharp.IconButton btnberanda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcusName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCnlBooking;
        private System.Windows.Forms.Button btnCnfBooking;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioDeposit;
        private System.Windows.Forms.RadioButton radioFullPayment;
        private System.Windows.Forms.DataGridView dgvTimeSlots;
        private System.Windows.Forms.ComboBox cmbVenue;
        private System.Windows.Forms.DateTimePicker dtpBookingDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalAmount;
    }
}