﻿namespace Weather_Stations_CW
{
    partial class frmHome
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
            this.dlgOpenData = new System.Windows.Forms.OpenFileDialog();
            this.txtLocationSearch = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtLongtitude = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtStreetNumberAndName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lstLocations = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstYears = new System.Windows.Forms.ListBox();
            this.grpMonths = new System.Windows.Forms.GroupBox();
            this.dgdMonths = new System.Windows.Forms.DataGridView();
            this.monthId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daysAirFrost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mmRain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hrsSun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditLocation = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNewLocation = new System.Windows.Forms.Button();
            this.btnNewYear = new System.Windows.Forms.Button();
            this.btnEditYear = new System.Windows.Forms.Button();
            this.btnSaveMonth = new System.Windows.Forms.Button();
            this.btnEditMonth = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYearDateInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescriptionInput = new System.Windows.Forms.TextBox();
            this.btnSaveLocation = new System.Windows.Forms.Button();
            this.btnSaveYear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpMonths.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdMonths)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dlgOpenData
            // 
            this.dlgOpenData.FileName = "inputEXTENDED";
            // 
            // txtLocationSearch
            // 
            this.txtLocationSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocationSearch.Location = new System.Drawing.Point(11, 18);
            this.txtLocationSearch.Multiline = false;
            this.txtLocationSearch.Name = "txtLocationSearch";
            this.txtLocationSearch.Size = new System.Drawing.Size(199, 26);
            this.txtLocationSearch.TabIndex = 1;
            this.txtLocationSearch.Text = "";
            this.txtLocationSearch.TextChanged += new System.EventHandler(this.txtLocationSearch_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.txtLatitude);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtLongtitude);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtPostcode);
            this.groupBox1.Controls.Add(this.txtCounty);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtStreetNumberAndName);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lstLocations);
            this.groupBox1.Controls.Add(this.txtLocationSearch);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 201);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Location";
            // 
            // txtLatitude
            // 
            this.txtLatitude.Location = new System.Drawing.Point(409, 162);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(273, 22);
            this.txtLatitude.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(350, 164);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 16);
            this.label12.TabIndex = 12;
            this.label12.Text = "Latitude:";
            // 
            // txtLongtitude
            // 
            this.txtLongtitude.Location = new System.Drawing.Point(409, 134);
            this.txtLongtitude.Name = "txtLongtitude";
            this.txtLongtitude.Size = new System.Drawing.Size(273, 22);
            this.txtLongtitude.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(335, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "Longtitude:";
            // 
            // txtPostcode
            // 
            this.txtPostcode.Location = new System.Drawing.Point(409, 106);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(273, 22);
            this.txtPostcode.TabIndex = 3;
            // 
            // txtCounty
            // 
            this.txtCounty.Location = new System.Drawing.Point(409, 78);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(273, 22);
            this.txtCounty.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(339, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Postcode:";
            // 
            // txtStreetNumberAndName
            // 
            this.txtStreetNumberAndName.Location = new System.Drawing.Point(409, 50);
            this.txtStreetNumberAndName.Name = "txtStreetNumberAndName";
            this.txtStreetNumberAndName.Size = new System.Drawing.Size(273, 22);
            this.txtStreetNumberAndName.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(350, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "County:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(314, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 32);
            this.label8.TabIndex = 12;
            this.label8.Text = "Street Number\r\n   and Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(360, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(409, 18);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(273, 22);
            this.txtName.TabIndex = 0;
            // 
            // lstLocations
            // 
            this.lstLocations.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstLocations.FormattingEnabled = true;
            this.lstLocations.ItemHeight = 16;
            this.lstLocations.Location = new System.Drawing.Point(11, 48);
            this.lstLocations.Name = "lstLocations";
            this.lstLocations.Size = new System.Drawing.Size(283, 132);
            this.lstLocations.TabIndex = 2;
            this.lstLocations.SelectedIndexChanged += new System.EventHandler(this.lstLocations_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1173, 642);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 54);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstYears
            // 
            this.lstYears.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstYears.FormattingEnabled = true;
            this.lstYears.ItemHeight = 16;
            this.lstYears.Location = new System.Drawing.Point(8, 18);
            this.lstYears.Name = "lstYears";
            this.lstYears.Size = new System.Drawing.Size(283, 132);
            this.lstYears.TabIndex = 0;
            this.lstYears.SelectedIndexChanged += new System.EventHandler(this.lstYears_SelectedIndexChanged);
            // 
            // grpMonths
            // 
            this.grpMonths.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpMonths.Controls.Add(this.dgdMonths);
            this.grpMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMonths.Location = new System.Drawing.Point(12, 392);
            this.grpMonths.Name = "grpMonths";
            this.grpMonths.Size = new System.Drawing.Size(532, 313);
            this.grpMonths.TabIndex = 10;
            this.grpMonths.TabStop = false;
            this.grpMonths.Text = "Months";
            // 
            // dgdMonths
            // 
            this.dgdMonths.AllowUserToAddRows = false;
            this.dgdMonths.AllowUserToDeleteRows = false;
            this.dgdMonths.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgdMonths.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdMonths.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.monthId,
            this.maxTemp,
            this.minTemp,
            this.daysAirFrost,
            this.mmRain,
            this.hrsSun});
            this.dgdMonths.Location = new System.Drawing.Point(3, 18);
            this.dgdMonths.Name = "dgdMonths";
            this.dgdMonths.ReadOnly = true;
            this.dgdMonths.Size = new System.Drawing.Size(526, 292);
            this.dgdMonths.TabIndex = 0;
            this.dgdMonths.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdMonths_CellClick);
            this.dgdMonths.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdMonths_CellContentClick);
            // 
            // monthId
            // 
            this.monthId.HeaderText = "Month";
            this.monthId.Name = "monthId";
            this.monthId.ReadOnly = true;
            this.monthId.Width = 80;
            // 
            // maxTemp
            // 
            this.maxTemp.HeaderText = "Max. Temp";
            this.maxTemp.Name = "maxTemp";
            this.maxTemp.ReadOnly = true;
            this.maxTemp.Width = 80;
            // 
            // minTemp
            // 
            this.minTemp.HeaderText = "Min. Temp";
            this.minTemp.Name = "minTemp";
            this.minTemp.ReadOnly = true;
            this.minTemp.Width = 80;
            // 
            // daysAirFrost
            // 
            this.daysAirFrost.HeaderText = "Days of Air Frost";
            this.daysAirFrost.Name = "daysAirFrost";
            this.daysAirFrost.ReadOnly = true;
            this.daysAirFrost.Width = 80;
            // 
            // mmRain
            // 
            this.mmRain.HeaderText = "Rain (mm)";
            this.mmRain.Name = "mmRain";
            this.mmRain.ReadOnly = true;
            this.mmRain.Width = 80;
            // 
            // hrsSun
            // 
            this.hrsSun.HeaderText = "Hours of Sunlight";
            this.hrsSun.Name = "hrsSun";
            this.hrsSun.ReadOnly = true;
            this.hrsSun.Width = 80;
            // 
            // btnEditLocation
            // 
            this.btnEditLocation.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditLocation.Enabled = false;
            this.btnEditLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditLocation.Location = new System.Drawing.Point(709, 107);
            this.btnEditLocation.Name = "btnEditLocation";
            this.btnEditLocation.Size = new System.Drawing.Size(109, 36);
            this.btnEditLocation.TabIndex = 7;
            this.btnEditLocation.Text = "Edit Location";
            this.btnEditLocation.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(1076, 642);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 54);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNewLocation
            // 
            this.btnNewLocation.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNewLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewLocation.Location = new System.Drawing.Point(709, 65);
            this.btnNewLocation.Name = "btnNewLocation";
            this.btnNewLocation.Size = new System.Drawing.Size(109, 36);
            this.btnNewLocation.TabIndex = 6;
            this.btnNewLocation.Text = "New Location";
            this.btnNewLocation.UseVisualStyleBackColor = true;
            this.btnNewLocation.Click += new System.EventHandler(this.btnNewLocation_Click);
            // 
            // btnNewYear
            // 
            this.btnNewYear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNewYear.Enabled = false;
            this.btnNewYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewYear.Location = new System.Drawing.Point(709, 250);
            this.btnNewYear.Name = "btnNewYear";
            this.btnNewYear.Size = new System.Drawing.Size(109, 36);
            this.btnNewYear.TabIndex = 11;
            this.btnNewYear.Text = "New Year";
            this.btnNewYear.UseVisualStyleBackColor = true;
            this.btnNewYear.Click += new System.EventHandler(this.btnNewYear_Click);
            // 
            // btnEditYear
            // 
            this.btnEditYear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditYear.Enabled = false;
            this.btnEditYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditYear.Location = new System.Drawing.Point(709, 292);
            this.btnEditYear.Name = "btnEditYear";
            this.btnEditYear.Size = new System.Drawing.Size(109, 36);
            this.btnEditYear.TabIndex = 12;
            this.btnEditYear.Text = "Edit Year";
            this.btnEditYear.UseVisualStyleBackColor = true;
            // 
            // btnSaveMonth
            // 
            this.btnSaveMonth.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSaveMonth.Enabled = false;
            this.btnSaveMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveMonth.Location = new System.Drawing.Point(567, 642);
            this.btnSaveMonth.Name = "btnSaveMonth";
            this.btnSaveMonth.Size = new System.Drawing.Size(112, 44);
            this.btnSaveMonth.TabIndex = 16;
            this.btnSaveMonth.Text = "Save Month Data";
            this.btnSaveMonth.UseVisualStyleBackColor = true;
            // 
            // btnEditMonth
            // 
            this.btnEditMonth.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditMonth.Enabled = false;
            this.btnEditMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMonth.Location = new System.Drawing.Point(567, 592);
            this.btnEditMonth.Name = "btnEditMonth";
            this.btnEditMonth.Size = new System.Drawing.Size(112, 44);
            this.btnEditMonth.TabIndex = 17;
            this.btnEditMonth.Text = "Edit Month Data";
            this.btnEditMonth.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtYearDateInput);
            this.groupBox2.Controls.Add(this.lstYears);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtDescriptionInput);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(691, 156);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(357, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Year:";
            // 
            // txtYearDateInput
            // 
            this.txtYearDateInput.Location = new System.Drawing.Point(403, 37);
            this.txtYearDateInput.Name = "txtYearDateInput";
            this.txtYearDateInput.Size = new System.Drawing.Size(276, 22);
            this.txtYearDateInput.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Year Description:";
            // 
            // txtDescriptionInput
            // 
            this.txtDescriptionInput.Location = new System.Drawing.Point(403, 79);
            this.txtDescriptionInput.Name = "txtDescriptionInput";
            this.txtDescriptionInput.Size = new System.Drawing.Size(276, 22);
            this.txtDescriptionInput.TabIndex = 10;
            // 
            // btnSaveLocation
            // 
            this.btnSaveLocation.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSaveLocation.Enabled = false;
            this.btnSaveLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveLocation.Location = new System.Drawing.Point(709, 149);
            this.btnSaveLocation.Name = "btnSaveLocation";
            this.btnSaveLocation.Size = new System.Drawing.Size(109, 36);
            this.btnSaveLocation.TabIndex = 8;
            this.btnSaveLocation.Text = "Save Location";
            this.btnSaveLocation.UseVisualStyleBackColor = true;
            this.btnSaveLocation.Click += new System.EventHandler(this.btnSaveLocation_Click);
            // 
            // btnSaveYear
            // 
            this.btnSaveYear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSaveYear.Enabled = false;
            this.btnSaveYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveYear.Location = new System.Drawing.Point(709, 334);
            this.btnSaveYear.Name = "btnSaveYear";
            this.btnSaveYear.Size = new System.Drawing.Size(109, 36);
            this.btnSaveYear.TabIndex = 18;
            this.btnSaveYear.Text = "Save Year";
            this.btnSaveYear.UseVisualStyleBackColor = true;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 708);
            this.Controls.Add(this.btnSaveYear);
            this.Controls.Add(this.btnSaveLocation);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnEditMonth);
            this.Controls.Add(this.btnSaveMonth);
            this.Controls.Add(this.btnEditYear);
            this.Controls.Add(this.btnNewYear);
            this.Controls.Add(this.btnNewLocation);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEditLocation);
            this.Controls.Add(this.grpMonths);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(1284, 553);
            this.Name = "frmHome";
            this.Text = "Weather Information";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpMonths.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgdMonths)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog dlgOpenData;
        private System.Windows.Forms.RichTextBox txtLocationSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstLocations;
        private System.Windows.Forms.ListBox lstYears;
        private System.Windows.Forms.GroupBox grpMonths;
        private System.Windows.Forms.DataGridView dgdMonths;
        private System.Windows.Forms.Button btnEditLocation;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNewLocation;
        private System.Windows.Forms.Button btnNewYear;
        private System.Windows.Forms.Button btnEditYear;
        private System.Windows.Forms.Button btnSaveMonth;
        private System.Windows.Forms.Button btnEditMonth;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox txtPostcode;
        public System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtStreetNumberAndName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtLatitude;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtLongtitude;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthId;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn minTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn daysAirFrost;
        private System.Windows.Forms.DataGridViewTextBoxColumn mmRain;
        private System.Windows.Forms.DataGridViewTextBoxColumn hrsSun;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtYearDateInput;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtDescriptionInput;
        private System.Windows.Forms.Button btnSaveLocation;
        private System.Windows.Forms.Button btnSaveYear;
    }
}

