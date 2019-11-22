namespace Apartment_Client
{
    partial class Form1
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
            this.uxTitleBox = new System.Windows.Forms.TextBox();
            this.uxMinPrice = new System.Windows.Forms.TextBox();
            this.uxMaxPrice = new System.Windows.Forms.TextBox();
            this.uxLocationDropdown = new System.Windows.Forms.ComboBox();
            this.uxParkingDropdown = new System.Windows.Forms.ComboBox();
            this.uxPetsDropdown = new System.Windows.Forms.ComboBox();
            this.uxLaundryDropdown = new System.Windows.Forms.ComboBox();
            this.uxMinBeds = new System.Windows.Forms.TextBox();
            this.uxMaxBeds = new System.Windows.Forms.TextBox();
            this.uxMaxBaths = new System.Windows.Forms.TextBox();
            this.uxMinBaths = new System.Windows.Forms.TextBox();
            this.uxUnitListPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.uxSearchBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxTitleBox
            // 
            this.uxTitleBox.BackColor = System.Drawing.Color.MediumPurple;
            this.uxTitleBox.Location = new System.Drawing.Point(496, 12);
            this.uxTitleBox.Name = "uxTitleBox";
            this.uxTitleBox.Size = new System.Drawing.Size(256, 20);
            this.uxTitleBox.TabIndex = 1;
            this.uxTitleBox.Text = "MHK Apartments";
            this.uxTitleBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uxMinPrice
            // 
            this.uxMinPrice.ForeColor = System.Drawing.SystemColors.GrayText;
            this.uxMinPrice.Location = new System.Drawing.Point(12, 38);
            this.uxMinPrice.Name = "uxMinPrice";
            this.uxMinPrice.Size = new System.Drawing.Size(100, 20);
            this.uxMinPrice.TabIndex = 2;
            this.uxMinPrice.Text = "Min Price";
            this.uxMinPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.uxMinPrice.Click += new System.EventHandler(this.uxMinPrice_Clicked);
            // 
            // uxMaxPrice
            // 
            this.uxMaxPrice.ForeColor = System.Drawing.SystemColors.GrayText;
            this.uxMaxPrice.Location = new System.Drawing.Point(118, 38);
            this.uxMaxPrice.Name = "uxMaxPrice";
            this.uxMaxPrice.Size = new System.Drawing.Size(100, 20);
            this.uxMaxPrice.TabIndex = 3;
            this.uxMaxPrice.Text = "Max Price";
            this.uxMaxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.uxMaxPrice.Click += new System.EventHandler(this.uxMaxPrice_Clicked);
            // 
            // uxLocationDropdown
            // 
            this.uxLocationDropdown.ForeColor = System.Drawing.SystemColors.GrayText;
            this.uxLocationDropdown.FormattingEnabled = true;
            this.uxLocationDropdown.Items.AddRange(new object[] {
            "Manhattan",
            "Wichita",
            "Lawrence",
            "Kansas City"});
            this.uxLocationDropdown.Location = new System.Drawing.Point(255, 38);
            this.uxLocationDropdown.Name = "uxLocationDropdown";
            this.uxLocationDropdown.Size = new System.Drawing.Size(85, 21);
            this.uxLocationDropdown.TabIndex = 4;
            this.uxLocationDropdown.Text = "Location";
            this.uxLocationDropdown.SelectedIndexChanged += new System.EventHandler(this.uxLocationDropdown_SelectedIndexChanged);
            // 
            // uxParkingDropdown
            // 
            this.uxParkingDropdown.ForeColor = System.Drawing.SystemColors.GrayText;
            this.uxParkingDropdown.FormattingEnabled = true;
            this.uxParkingDropdown.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.uxParkingDropdown.Location = new System.Drawing.Point(346, 38);
            this.uxParkingDropdown.Name = "uxParkingDropdown";
            this.uxParkingDropdown.Size = new System.Drawing.Size(85, 21);
            this.uxParkingDropdown.TabIndex = 5;
            this.uxParkingDropdown.Text = "Parking";
            this.uxParkingDropdown.SelectedIndexChanged += new System.EventHandler(this.uxParkingDropdown_SelectedIndexChanged);
            // 
            // uxPetsDropdown
            // 
            this.uxPetsDropdown.ForeColor = System.Drawing.SystemColors.GrayText;
            this.uxPetsDropdown.FormattingEnabled = true;
            this.uxPetsDropdown.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.uxPetsDropdown.Location = new System.Drawing.Point(437, 38);
            this.uxPetsDropdown.Name = "uxPetsDropdown";
            this.uxPetsDropdown.Size = new System.Drawing.Size(85, 21);
            this.uxPetsDropdown.TabIndex = 6;
            this.uxPetsDropdown.Text = "Pets";
            this.uxPetsDropdown.SelectedIndexChanged += new System.EventHandler(this.uxPetsDropdown_SelectedIndexChanged);
            // 
            // uxLaundryDropdown
            // 
            this.uxLaundryDropdown.ForeColor = System.Drawing.SystemColors.GrayText;
            this.uxLaundryDropdown.FormattingEnabled = true;
            this.uxLaundryDropdown.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.uxLaundryDropdown.Location = new System.Drawing.Point(528, 38);
            this.uxLaundryDropdown.Name = "uxLaundryDropdown";
            this.uxLaundryDropdown.Size = new System.Drawing.Size(85, 21);
            this.uxLaundryDropdown.TabIndex = 7;
            this.uxLaundryDropdown.Text = "Laundry";
            this.uxLaundryDropdown.SelectedIndexChanged += new System.EventHandler(this.uxLaundryDropdown_SelectedIndexChanged);
            // 
            // uxMinBeds
            // 
            this.uxMinBeds.ForeColor = System.Drawing.SystemColors.GrayText;
            this.uxMinBeds.Location = new System.Drawing.Point(652, 39);
            this.uxMinBeds.Name = "uxMinBeds";
            this.uxMinBeds.Size = new System.Drawing.Size(100, 20);
            this.uxMinBeds.TabIndex = 8;
            this.uxMinBeds.Text = "Min Beds";
            this.uxMinBeds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.uxMinBeds.Click += new System.EventHandler(this.uxMinBeds_Clicked);
            // 
            // uxMaxBeds
            // 
            this.uxMaxBeds.ForeColor = System.Drawing.SystemColors.GrayText;
            this.uxMaxBeds.Location = new System.Drawing.Point(758, 38);
            this.uxMaxBeds.Name = "uxMaxBeds";
            this.uxMaxBeds.Size = new System.Drawing.Size(100, 20);
            this.uxMaxBeds.TabIndex = 9;
            this.uxMaxBeds.Text = "Max Beds";
            this.uxMaxBeds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.uxMaxBeds.Click += new System.EventHandler(this.uxMaxBeds_Clicked);
            // 
            // uxMaxBaths
            // 
            this.uxMaxBaths.ForeColor = System.Drawing.SystemColors.GrayText;
            this.uxMaxBaths.Location = new System.Drawing.Point(995, 39);
            this.uxMaxBaths.Name = "uxMaxBaths";
            this.uxMaxBaths.Size = new System.Drawing.Size(100, 20);
            this.uxMaxBaths.TabIndex = 10;
            this.uxMaxBaths.Text = "Max Baths";
            this.uxMaxBaths.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.uxMaxBaths.Click += new System.EventHandler(this.uxMaxBaths_Clicked);
            // 
            // uxMinBaths
            // 
            this.uxMinBaths.ForeColor = System.Drawing.SystemColors.GrayText;
            this.uxMinBaths.Location = new System.Drawing.Point(889, 39);
            this.uxMinBaths.Name = "uxMinBaths";
            this.uxMinBaths.Size = new System.Drawing.Size(100, 20);
            this.uxMinBaths.TabIndex = 11;
            this.uxMinBaths.Text = "Min Baths";
            this.uxMinBaths.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.uxMinBaths.Click += new System.EventHandler(this.uxMinBaths_Clicked);
            // 
            // uxUnitListPanel
            // 
            this.uxUnitListPanel.AutoScroll = true;
            this.uxUnitListPanel.Location = new System.Drawing.Point(577, 65);
            this.uxUnitListPanel.Name = "uxUnitListPanel";
            this.uxUnitListPanel.Size = new System.Drawing.Size(600, 557);
            this.uxUnitListPanel.TabIndex = 12;
            // 
            // uxSearchBtn
            // 
            this.uxSearchBtn.BackColor = System.Drawing.Color.MediumPurple;
            this.uxSearchBtn.Location = new System.Drawing.Point(1111, 36);
            this.uxSearchBtn.Name = "uxSearchBtn";
            this.uxSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.uxSearchBtn.TabIndex = 13;
            this.uxSearchBtn.Text = "Search";
            this.uxSearchBtn.UseVisualStyleBackColor = false;
            this.uxSearchBtn.Click += new System.EventHandler(this.uxSearchBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 634);
            this.Controls.Add(this.uxSearchBtn);
            this.Controls.Add(this.uxUnitListPanel);
            this.Controls.Add(this.uxMinBaths);
            this.Controls.Add(this.uxMaxBaths);
            this.Controls.Add(this.uxMaxBeds);
            this.Controls.Add(this.uxMinBeds);
            this.Controls.Add(this.uxLaundryDropdown);
            this.Controls.Add(this.uxPetsDropdown);
            this.Controls.Add(this.uxParkingDropdown);
            this.Controls.Add(this.uxLocationDropdown);
            this.Controls.Add(this.uxMaxPrice);
            this.Controls.Add(this.uxMinPrice);
            this.Controls.Add(this.uxTitleBox);
            this.Name = "Form1";
            this.Text = "Kansas Apartments";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxTitleBox;
        private System.Windows.Forms.TextBox uxMinPrice;
        private System.Windows.Forms.TextBox uxMaxPrice;
        private System.Windows.Forms.ComboBox uxLocationDropdown;
        private System.Windows.Forms.ComboBox uxParkingDropdown;
        private System.Windows.Forms.ComboBox uxPetsDropdown;
        private System.Windows.Forms.ComboBox uxLaundryDropdown;
        private System.Windows.Forms.TextBox uxMinBeds;
        private System.Windows.Forms.TextBox uxMaxBeds;
        private System.Windows.Forms.TextBox uxMaxBaths;
        private System.Windows.Forms.TextBox uxMinBaths;
        private System.Windows.Forms.FlowLayoutPanel uxUnitListPanel;
        private System.Windows.Forms.Button uxSearchBtn;
    }
}

