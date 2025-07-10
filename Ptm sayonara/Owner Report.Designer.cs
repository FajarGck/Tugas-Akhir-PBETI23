namespace Ptm_sayonara
{
    partial class owner_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(owner_Report));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.btnBookingMenu = new FontAwesome.Sharp.IconButton();
            this.btnOperatingHours = new FontAwesome.Sharp.IconButton();
            this.btnListvenues = new FontAwesome.Sharp.IconButton();
            this.btnRentalreports = new FontAwesome.Sharp.IconButton();
            this.btnberanda = new FontAwesome.Sharp.IconButton();
            this.btnexportPDF = new FontAwesome.Sharp.IconButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearchReport = new System.Windows.Forms.Button();
            this.dtReport = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtReport)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 108);
            this.label3.TabIndex = 1;
            this.label3.Text = "Rental \r\nReport";
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
            this.splitContainer1.Panel2.Controls.Add(this.btnexportPDF);
            this.splitContainer1.Panel2.Controls.Add(this.txtSearch);
            this.splitContainer1.Panel2.Controls.Add(this.btnSearchReport);
            this.splitContainer1.Panel2.Controls.Add(this.dtReport);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Size = new System.Drawing.Size(891, 531);
            this.splitContainer1.SplitterDistance = 208;
            this.splitContainer1.TabIndex = 2;
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
            this.btnListvenues.BackColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.btnListvenues.UseVisualStyleBackColor = false;
            this.btnListvenues.Click += new System.EventHandler(this.btnListvenues_Click);
            // 
            // btnRentalreports
            // 
            this.btnRentalreports.BackColor = System.Drawing.SystemColors.ButtonFace;
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
            this.btnRentalreports.UseVisualStyleBackColor = false;
            // 
            // btnberanda
            // 
            this.btnberanda.BackColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.btnberanda.Click += new System.EventHandler(this.btnberanda_Click);
            // 
            // btnexportPDF
            // 
            this.btnexportPDF.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnexportPDF.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexportPDF.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.btnexportPDF.IconColor = System.Drawing.Color.Black;
            this.btnexportPDF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnexportPDF.IconSize = 30;
            this.btnexportPDF.Location = new System.Drawing.Point(498, 134);
            this.btnexportPDF.Margin = new System.Windows.Forms.Padding(22, 6, 3, 8);
            this.btnexportPDF.Name = "btnexportPDF";
            this.btnexportPDF.Size = new System.Drawing.Size(135, 35);
            this.btnexportPDF.TabIndex = 8;
            this.btnexportPDF.Text = "Export PDF";
            this.btnexportPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexportPDF.UseVisualStyleBackColor = false;
            this.btnexportPDF.Click += new System.EventHandler(this.btnexportPDF_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(303, 29);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(182, 32);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSearchReport
            // 
            this.btnSearchReport.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearchReport.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchReport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearchReport.Location = new System.Drawing.Point(498, 25);
            this.btnSearchReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchReport.Name = "btnSearchReport";
            this.btnSearchReport.Size = new System.Drawing.Size(147, 34);
            this.btnSearchReport.TabIndex = 6;
            this.btnSearchReport.Text = "Search Report";
            this.btnSearchReport.UseVisualStyleBackColor = false;
            // 
            // dtReport
            // 
            this.dtReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtReport.Location = new System.Drawing.Point(46, 179);
            this.dtReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtReport.Name = "dtReport";
            this.dtReport.RowHeadersWidth = 62;
            this.dtReport.RowTemplate.Height = 28;
            this.dtReport.Size = new System.Drawing.Size(598, 311);
            this.dtReport.TabIndex = 4;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // owner_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(891, 531);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "owner_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OwnerReport";
            this.Load += new System.EventHandler(this.owner_Report_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnBookingMenu;
        private FontAwesome.Sharp.IconButton btnOperatingHours;
        private FontAwesome.Sharp.IconButton btnListvenues;
        private FontAwesome.Sharp.IconButton btnberanda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnRentalreports;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dtReport;
        private System.Windows.Forms.Button btnSearchReport;
        private System.Windows.Forms.TextBox txtSearch;
        private FontAwesome.Sharp.IconButton btnexportPDF;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}