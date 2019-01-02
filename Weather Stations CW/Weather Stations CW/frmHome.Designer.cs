namespace Weather_Stations_CW
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
            this.grpLocation = new System.Windows.Forms.GroupBox();
            this.btnCancelNewLocation = new System.Windows.Forms.Button();
            this.btnSaveLocation = new System.Windows.Forms.Button();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.btnNewLocation = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtLongtitude = new System.Windows.Forms.TextBox();
            this.btnEditLocation = new System.Windows.Forms.Button();
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
            this.btnCancelEditMonth = new System.Windows.Forms.Button();
            this.dgdMonths = new System.Windows.Forms.DataGridView();
            this.monthId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daysAirFrost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mmRain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hrsSun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSaveMonth = new System.Windows.Forms.Button();
            this.btnEditMonth = new System.Windows.Forms.Button();
            this.btnNewYear = new System.Windows.Forms.Button();
            this.btnEditYear = new System.Windows.Forms.Button();
            this.grpYear = new System.Windows.Forms.GroupBox();
            this.btnCancelNewYear = new System.Windows.Forms.Button();
            this.btnSaveYear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYearDateInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescriptionInput = new System.Windows.Forms.TextBox();
            this.dlgSaveData = new System.Windows.Forms.SaveFileDialog();
            this.pnlGraphics = new System.Windows.Forms.Panel();
            this.cmbGraphicOptions = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblMaxValue = new System.Windows.Forms.Label();
            this.lblMinValue = new System.Windows.Forms.Label();
            this.grpLocation.SuspendLayout();
            this.grpMonths.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdMonths)).BeginInit();
            this.grpYear.SuspendLayout();
            this.SuspendLayout();
            // 
            // dlgOpenData
            // 
            this.dlgOpenData.FileName = "inputEXTENDED";
            // 
            // txtLocationSearch
            // 
            this.txtLocationSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocationSearch.Location = new System.Drawing.Point(6, 18);
            this.txtLocationSearch.Multiline = false;
            this.txtLocationSearch.Name = "txtLocationSearch";
            this.txtLocationSearch.Size = new System.Drawing.Size(199, 26);
            this.txtLocationSearch.TabIndex = 1;
            this.txtLocationSearch.Text = "";
            this.txtLocationSearch.TextChanged += new System.EventHandler(this.txtLocationSearch_TextChanged);
            // 
            // grpLocation
            // 
            this.grpLocation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpLocation.Controls.Add(this.btnCancelNewLocation);
            this.grpLocation.Controls.Add(this.btnSaveLocation);
            this.grpLocation.Controls.Add(this.txtLatitude);
            this.grpLocation.Controls.Add(this.btnNewLocation);
            this.grpLocation.Controls.Add(this.label12);
            this.grpLocation.Controls.Add(this.txtLongtitude);
            this.grpLocation.Controls.Add(this.btnEditLocation);
            this.grpLocation.Controls.Add(this.label11);
            this.grpLocation.Controls.Add(this.txtPostcode);
            this.grpLocation.Controls.Add(this.txtCounty);
            this.grpLocation.Controls.Add(this.label10);
            this.grpLocation.Controls.Add(this.txtStreetNumberAndName);
            this.grpLocation.Controls.Add(this.label9);
            this.grpLocation.Controls.Add(this.label8);
            this.grpLocation.Controls.Add(this.label7);
            this.grpLocation.Controls.Add(this.txtName);
            this.grpLocation.Controls.Add(this.lstLocations);
            this.grpLocation.Controls.Add(this.txtLocationSearch);
            this.grpLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLocation.Location = new System.Drawing.Point(9, 23);
            this.grpLocation.Name = "grpLocation";
            this.grpLocation.Size = new System.Drawing.Size(841, 201);
            this.grpLocation.TabIndex = 3;
            this.grpLocation.TabStop = false;
            this.grpLocation.Text = "Location";
            // 
            // btnCancelNewLocation
            // 
            this.btnCancelNewLocation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCancelNewLocation.Enabled = false;
            this.btnCancelNewLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelNewLocation.Location = new System.Drawing.Point(700, 154);
            this.btnCancelNewLocation.Name = "btnCancelNewLocation";
            this.btnCancelNewLocation.Size = new System.Drawing.Size(109, 36);
            this.btnCancelNewLocation.TabIndex = 13;
            this.btnCancelNewLocation.Text = "Cancel";
            this.btnCancelNewLocation.UseVisualStyleBackColor = true;
            this.btnCancelNewLocation.Click += new System.EventHandler(this.btnCancelNewLocation_Click);
            // 
            // btnSaveLocation
            // 
            this.btnSaveLocation.Enabled = false;
            this.btnSaveLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveLocation.Location = new System.Drawing.Point(700, 109);
            this.btnSaveLocation.Name = "btnSaveLocation";
            this.btnSaveLocation.Size = new System.Drawing.Size(109, 36);
            this.btnSaveLocation.TabIndex = 8;
            this.btnSaveLocation.Text = "Save Location";
            this.btnSaveLocation.UseVisualStyleBackColor = true;
            this.btnSaveLocation.Click += new System.EventHandler(this.btnSaveLocation_Click);
            // 
            // txtLatitude
            // 
            this.txtLatitude.Location = new System.Drawing.Point(409, 162);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.ReadOnly = true;
            this.txtLatitude.Size = new System.Drawing.Size(273, 22);
            this.txtLatitude.TabIndex = 5;
            // 
            // btnNewLocation
            // 
            this.btnNewLocation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNewLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewLocation.Location = new System.Drawing.Point(700, 18);
            this.btnNewLocation.Name = "btnNewLocation";
            this.btnNewLocation.Size = new System.Drawing.Size(109, 36);
            this.btnNewLocation.TabIndex = 6;
            this.btnNewLocation.Text = "New Location";
            this.btnNewLocation.UseVisualStyleBackColor = true;
            this.btnNewLocation.Click += new System.EventHandler(this.btnNewLocation_Click);
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
            this.txtLongtitude.ReadOnly = true;
            this.txtLongtitude.Size = new System.Drawing.Size(273, 22);
            this.txtLongtitude.TabIndex = 4;
            // 
            // btnEditLocation
            // 
            this.btnEditLocation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnEditLocation.Enabled = false;
            this.btnEditLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditLocation.Location = new System.Drawing.Point(700, 64);
            this.btnEditLocation.Name = "btnEditLocation";
            this.btnEditLocation.Size = new System.Drawing.Size(109, 36);
            this.btnEditLocation.TabIndex = 7;
            this.btnEditLocation.Text = "Edit Location";
            this.btnEditLocation.UseVisualStyleBackColor = true;
            this.btnEditLocation.Click += new System.EventHandler(this.btnEditLocation_Click);
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
            this.txtPostcode.ReadOnly = true;
            this.txtPostcode.Size = new System.Drawing.Size(273, 22);
            this.txtPostcode.TabIndex = 3;
            // 
            // txtCounty
            // 
            this.txtCounty.Location = new System.Drawing.Point(409, 78);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.ReadOnly = true;
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
            this.txtStreetNumberAndName.ReadOnly = true;
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
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(273, 22);
            this.txtName.TabIndex = 0;
            // 
            // lstLocations
            // 
            this.lstLocations.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstLocations.FormattingEnabled = true;
            this.lstLocations.ItemHeight = 16;
            this.lstLocations.Location = new System.Drawing.Point(6, 48);
            this.lstLocations.Name = "lstLocations";
            this.lstLocations.Size = new System.Drawing.Size(283, 132);
            this.lstLocations.TabIndex = 2;
            this.lstLocations.SelectedIndexChanged += new System.EventHandler(this.lstLocations_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1356, 654);
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
            this.lstYears.Location = new System.Drawing.Point(6, 21);
            this.lstYears.Name = "lstYears";
            this.lstYears.Size = new System.Drawing.Size(283, 132);
            this.lstYears.TabIndex = 0;
            this.lstYears.SelectedIndexChanged += new System.EventHandler(this.lstYears_SelectedIndexChanged);
            // 
            // grpMonths
            // 
            this.grpMonths.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpMonths.Controls.Add(this.btnCancelEditMonth);
            this.grpMonths.Controls.Add(this.dgdMonths);
            this.grpMonths.Controls.Add(this.btnSaveMonth);
            this.grpMonths.Controls.Add(this.btnEditMonth);
            this.grpMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMonths.Location = new System.Drawing.Point(12, 404);
            this.grpMonths.Name = "grpMonths";
            this.grpMonths.Size = new System.Drawing.Size(679, 313);
            this.grpMonths.TabIndex = 10;
            this.grpMonths.TabStop = false;
            this.grpMonths.Text = "Months";
            // 
            // btnCancelEditMonth
            // 
            this.btnCancelEditMonth.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancelEditMonth.Enabled = false;
            this.btnCancelEditMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelEditMonth.Location = new System.Drawing.Point(550, 121);
            this.btnCancelEditMonth.Name = "btnCancelEditMonth";
            this.btnCancelEditMonth.Size = new System.Drawing.Size(112, 44);
            this.btnCancelEditMonth.TabIndex = 18;
            this.btnCancelEditMonth.Text = "Cancel";
            this.btnCancelEditMonth.UseVisualStyleBackColor = true;
            this.btnCancelEditMonth.Click += new System.EventHandler(this.btnCancelEditMonth_Click);
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
            this.dgdMonths.Size = new System.Drawing.Size(541, 292);
            this.dgdMonths.TabIndex = 0;
            this.dgdMonths.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdMonths_CellClick);
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
            // btnSaveMonth
            // 
            this.btnSaveMonth.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSaveMonth.Enabled = false;
            this.btnSaveMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveMonth.Location = new System.Drawing.Point(550, 71);
            this.btnSaveMonth.Name = "btnSaveMonth";
            this.btnSaveMonth.Size = new System.Drawing.Size(112, 44);
            this.btnSaveMonth.TabIndex = 16;
            this.btnSaveMonth.Text = "Save Month Data";
            this.btnSaveMonth.UseVisualStyleBackColor = true;
            this.btnSaveMonth.Click += new System.EventHandler(this.btnSaveMonth_Click);
            // 
            // btnEditMonth
            // 
            this.btnEditMonth.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditMonth.Enabled = false;
            this.btnEditMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMonth.Location = new System.Drawing.Point(550, 21);
            this.btnEditMonth.Name = "btnEditMonth";
            this.btnEditMonth.Size = new System.Drawing.Size(112, 44);
            this.btnEditMonth.TabIndex = 17;
            this.btnEditMonth.Text = "Edit Month Data";
            this.btnEditMonth.UseVisualStyleBackColor = true;
            this.btnEditMonth.Click += new System.EventHandler(this.btnEditMonth_Click);
            // 
            // btnNewYear
            // 
            this.btnNewYear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNewYear.Enabled = false;
            this.btnNewYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewYear.Location = new System.Drawing.Point(697, 23);
            this.btnNewYear.Name = "btnNewYear";
            this.btnNewYear.Size = new System.Drawing.Size(109, 36);
            this.btnNewYear.TabIndex = 11;
            this.btnNewYear.Text = "New Year";
            this.btnNewYear.UseVisualStyleBackColor = true;
            this.btnNewYear.Click += new System.EventHandler(this.btnNewYear_Click);
            // 
            // btnEditYear
            // 
            this.btnEditYear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnEditYear.Enabled = false;
            this.btnEditYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditYear.Location = new System.Drawing.Point(697, 65);
            this.btnEditYear.Name = "btnEditYear";
            this.btnEditYear.Size = new System.Drawing.Size(109, 36);
            this.btnEditYear.TabIndex = 12;
            this.btnEditYear.Text = "Edit Year";
            this.btnEditYear.UseVisualStyleBackColor = true;
            this.btnEditYear.Click += new System.EventHandler(this.btnEditYear_Click);
            // 
            // grpYear
            // 
            this.grpYear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.grpYear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpYear.Controls.Add(this.btnCancelNewYear);
            this.grpYear.Controls.Add(this.btnSaveYear);
            this.grpYear.Controls.Add(this.label2);
            this.grpYear.Controls.Add(this.txtYearDateInput);
            this.grpYear.Controls.Add(this.lstYears);
            this.grpYear.Controls.Add(this.label1);
            this.grpYear.Controls.Add(this.btnEditYear);
            this.grpYear.Controls.Add(this.btnNewYear);
            this.grpYear.Controls.Add(this.txtDescriptionInput);
            this.grpYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpYear.Location = new System.Drawing.Point(12, 236);
            this.grpYear.Name = "grpYear";
            this.grpYear.Size = new System.Drawing.Size(838, 156);
            this.grpYear.TabIndex = 4;
            this.grpYear.TabStop = false;
            this.grpYear.Text = "Year";
            // 
            // btnCancelNewYear
            // 
            this.btnCancelNewYear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCancelNewYear.Enabled = false;
            this.btnCancelNewYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelNewYear.Location = new System.Drawing.Point(550, 107);
            this.btnCancelNewYear.Name = "btnCancelNewYear";
            this.btnCancelNewYear.Size = new System.Drawing.Size(109, 36);
            this.btnCancelNewYear.TabIndex = 22;
            this.btnCancelNewYear.Text = "Cancel";
            this.btnCancelNewYear.UseVisualStyleBackColor = true;
            this.btnCancelNewYear.Click += new System.EventHandler(this.btnCancelNewYear_Click);
            // 
            // btnSaveYear
            // 
            this.btnSaveYear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSaveYear.Enabled = false;
            this.btnSaveYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveYear.Location = new System.Drawing.Point(697, 107);
            this.btnSaveYear.Name = "btnSaveYear";
            this.btnSaveYear.Size = new System.Drawing.Size(109, 36);
            this.btnSaveYear.TabIndex = 18;
            this.btnSaveYear.Text = "Save Year";
            this.btnSaveYear.UseVisualStyleBackColor = true;
            this.btnSaveYear.Click += new System.EventHandler(this.btnSaveYear_Click);
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
            this.txtYearDateInput.ReadOnly = true;
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
            this.txtDescriptionInput.ReadOnly = true;
            this.txtDescriptionInput.Size = new System.Drawing.Size(276, 22);
            this.txtDescriptionInput.TabIndex = 10;
            // 
            // pnlGraphics
            // 
            this.pnlGraphics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGraphics.BackColor = System.Drawing.SystemColors.Window;
            this.pnlGraphics.Location = new System.Drawing.Point(889, 328);
            this.pnlGraphics.Name = "pnlGraphics";
            this.pnlGraphics.Size = new System.Drawing.Size(450, 320);
            this.pnlGraphics.TabIndex = 11;
            this.pnlGraphics.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGraphics_Paint);
            // 
            // cmbGraphicOptions
            // 
            this.cmbGraphicOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbGraphicOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGraphicOptions.FormattingEnabled = true;
            this.cmbGraphicOptions.Items.AddRange(new object[] {
            "Maximum Temperature",
            "Minimum Temperature",
            "Days of Air Frost",
            "Rain (mm)",
            "Hours of sunlight"});
            this.cmbGraphicOptions.Location = new System.Drawing.Point(889, 687);
            this.cmbGraphicOptions.Name = "cmbGraphicOptions";
            this.cmbGraphicOptions.Size = new System.Drawing.Size(269, 21);
            this.cmbGraphicOptions.TabIndex = 12;
            this.cmbGraphicOptions.SelectedIndexChanged += new System.EventHandler(this.cmbGraphicOptions_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(911, 654);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Jan";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(946, 654);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Feb";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(981, 654);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Mar";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1016, 654);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Apr";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1051, 654);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "May";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1086, 654);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Jun";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1121, 654);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "Jul";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1156, 654);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "Aug";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1296, 654);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(27, 13);
            this.label17.TabIndex = 21;
            this.label17.Text = "Dec";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1261, 654);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(27, 13);
            this.label18.TabIndex = 22;
            this.label18.Text = "Nov";
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(1226, 654);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(24, 13);
            this.label19.TabIndex = 23;
            this.label19.Text = "Oct";
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(1191, 654);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(26, 13);
            this.label20.TabIndex = 24;
            this.label20.Text = "Sep";
            // 
            // lblMaxValue
            // 
            this.lblMaxValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaxValue.AutoSize = true;
            this.lblMaxValue.Location = new System.Drawing.Point(854, 338);
            this.lblMaxValue.Name = "lblMaxValue";
            this.lblMaxValue.Size = new System.Drawing.Size(0, 13);
            this.lblMaxValue.TabIndex = 25;
            // 
            // lblMinValue
            // 
            this.lblMinValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMinValue.AutoSize = true;
            this.lblMinValue.Location = new System.Drawing.Point(868, 631);
            this.lblMinValue.Name = "lblMinValue";
            this.lblMinValue.Size = new System.Drawing.Size(13, 13);
            this.lblMinValue.TabIndex = 26;
            this.lblMinValue.Text = "0";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 720);
            this.Controls.Add(this.lblMinValue);
            this.Controls.Add(this.lblMaxValue);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbGraphicOptions);
            this.Controls.Add(this.pnlGraphics);
            this.Controls.Add(this.grpMonths);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpLocation);
            this.Controls.Add(this.grpYear);
            this.MinimumSize = new System.Drawing.Size(1467, 759);
            this.Name = "frmHome";
            this.Text = "Weather Information";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.grpLocation.ResumeLayout(false);
            this.grpLocation.PerformLayout();
            this.grpMonths.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgdMonths)).EndInit();
            this.grpYear.ResumeLayout(false);
            this.grpYear.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog dlgOpenData;
        private System.Windows.Forms.RichTextBox txtLocationSearch;
        private System.Windows.Forms.GroupBox grpLocation;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstLocations;
        private System.Windows.Forms.ListBox lstYears;
        private System.Windows.Forms.GroupBox grpMonths;
        private System.Windows.Forms.DataGridView dgdMonths;
        private System.Windows.Forms.Button btnEditLocation;
        private System.Windows.Forms.Button btnNewLocation;
        private System.Windows.Forms.Button btnNewYear;
        private System.Windows.Forms.Button btnEditYear;
        private System.Windows.Forms.Button btnSaveMonth;
        private System.Windows.Forms.Button btnEditMonth;
        private System.Windows.Forms.GroupBox grpYear;
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
        private System.Windows.Forms.Button btnCancelNewLocation;
        private System.Windows.Forms.Button btnCancelNewYear;
        private System.Windows.Forms.Button btnCancelEditMonth;
        private System.Windows.Forms.SaveFileDialog dlgSaveData;
        public System.Windows.Forms.Panel pnlGraphics;
        private System.Windows.Forms.ComboBox cmbGraphicOptions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblMaxValue;
        private System.Windows.Forms.Label lblMinValue;
    }
}

