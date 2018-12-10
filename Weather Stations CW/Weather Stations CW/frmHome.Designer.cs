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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstLocations = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpYear = new System.Windows.Forms.GroupBox();
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
            this.groupBox1.SuspendLayout();
            this.grpYear.SuspendLayout();
            this.grpMonths.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdMonths)).BeginInit();
            this.SuspendLayout();
            // 
            // dlgOpenData
            // 
            this.dlgOpenData.FileName = "inputEXTENDED";
            // 
            // txtLocationSearch
            // 
            this.txtLocationSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtLocationSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocationSearch.Location = new System.Drawing.Point(3, 18);
            this.txtLocationSearch.Multiline = false;
            this.txtLocationSearch.Name = "txtLocationSearch";
            this.txtLocationSearch.Size = new System.Drawing.Size(626, 26);
            this.txtLocationSearch.TabIndex = 1;
            this.txtLocationSearch.Text = "";
            this.txtLocationSearch.TextChanged += new System.EventHandler(this.txtLocationSearch_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.lstLocations);
            this.groupBox1.Controls.Add(this.txtLocationSearch);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 173);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search for location";
            // 
            // lstLocations
            // 
            this.lstLocations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstLocations.FormattingEnabled = true;
            this.lstLocations.ItemHeight = 16;
            this.lstLocations.Location = new System.Drawing.Point(3, 54);
            this.lstLocations.Name = "lstLocations";
            this.lstLocations.Size = new System.Drawing.Size(626, 116);
            this.lstLocations.TabIndex = 2;
            this.lstLocations.SelectedIndexChanged += new System.EventHandler(this.lstLocations_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1173, 448);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 54);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpYear
            // 
            this.grpYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpYear.Controls.Add(this.lstYears);
            this.grpYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpYear.Location = new System.Drawing.Point(765, 20);
            this.grpYear.Name = "grpYear";
            this.grpYear.Size = new System.Drawing.Size(491, 179);
            this.grpYear.TabIndex = 9;
            this.grpYear.TabStop = false;
            this.grpYear.Text = "Years";
            // 
            // lstYears
            // 
            this.lstYears.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstYears.FormattingEnabled = true;
            this.lstYears.ItemHeight = 16;
            this.lstYears.Location = new System.Drawing.Point(3, 18);
            this.lstYears.Name = "lstYears";
            this.lstYears.Size = new System.Drawing.Size(485, 148);
            this.lstYears.TabIndex = 0;
            this.lstYears.SelectedIndexChanged += new System.EventHandler(this.lstYears_SelectedIndexChanged);
            // 
            // grpMonths
            // 
            this.grpMonths.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpMonths.Controls.Add(this.dgdMonths);
            this.grpMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMonths.Location = new System.Drawing.Point(9, 203);
            this.grpMonths.Name = "grpMonths";
            this.grpMonths.Size = new System.Drawing.Size(632, 299);
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
            this.dgdMonths.Size = new System.Drawing.Size(626, 278);
            this.dgdMonths.TabIndex = 0;
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
            this.maxTemp.HeaderText = "Max. Temperature";
            this.maxTemp.Name = "maxTemp";
            this.maxTemp.ReadOnly = true;
            // 
            // minTemp
            // 
            this.minTemp.HeaderText = "Min. Temperature";
            this.minTemp.Name = "minTemp";
            this.minTemp.ReadOnly = true;
            // 
            // daysAirFrost
            // 
            this.daysAirFrost.HeaderText = "Days of Air Frost";
            this.daysAirFrost.Name = "daysAirFrost";
            this.daysAirFrost.ReadOnly = true;
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
            // 
            // btnEditLocation
            // 
            this.btnEditLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditLocation.Enabled = false;
            this.btnEditLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditLocation.Location = new System.Drawing.Point(650, 69);
            this.btnEditLocation.Name = "btnEditLocation";
            this.btnEditLocation.Size = new System.Drawing.Size(109, 36);
            this.btnEditLocation.TabIndex = 11;
            this.btnEditLocation.Text = "Edit Location";
            this.btnEditLocation.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(1076, 448);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 54);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNewLocation
            // 
            this.btnNewLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewLocation.Location = new System.Drawing.Point(650, 23);
            this.btnNewLocation.Name = "btnNewLocation";
            this.btnNewLocation.Size = new System.Drawing.Size(109, 36);
            this.btnNewLocation.TabIndex = 13;
            this.btnNewLocation.Text = "New Location";
            this.btnNewLocation.UseVisualStyleBackColor = true;
            this.btnNewLocation.Click += new System.EventHandler(this.btnNewLocation_Click);
            // 
            // btnNewYear
            // 
            this.btnNewYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewYear.Enabled = false;
            this.btnNewYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewYear.Location = new System.Drawing.Point(650, 115);
            this.btnNewYear.Name = "btnNewYear";
            this.btnNewYear.Size = new System.Drawing.Size(109, 36);
            this.btnNewYear.TabIndex = 14;
            this.btnNewYear.Text = "New Year";
            this.btnNewYear.UseVisualStyleBackColor = true;
            this.btnNewYear.Click += new System.EventHandler(this.btnNewYear_Click);
            // 
            // btnEditYear
            // 
            this.btnEditYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditYear.Enabled = false;
            this.btnEditYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditYear.Location = new System.Drawing.Point(650, 161);
            this.btnEditYear.Name = "btnEditYear";
            this.btnEditYear.Size = new System.Drawing.Size(109, 36);
            this.btnEditYear.TabIndex = 15;
            this.btnEditYear.Text = "Edit Year";
            this.btnEditYear.UseVisualStyleBackColor = true;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 514);
            this.Controls.Add(this.btnEditYear);
            this.Controls.Add(this.btnNewYear);
            this.Controls.Add(this.btnNewLocation);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEditLocation);
            this.Controls.Add(this.grpMonths);
            this.Controls.Add(this.grpYear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(1284, 553);
            this.Name = "frmHome";
            this.Text = "Weather Information";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.groupBox1.ResumeLayout(false);
            this.grpYear.ResumeLayout(false);
            this.grpMonths.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgdMonths)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog dlgOpenData;
        private System.Windows.Forms.RichTextBox txtLocationSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstLocations;
        private System.Windows.Forms.GroupBox grpYear;
        private System.Windows.Forms.ListBox lstYears;
        private System.Windows.Forms.GroupBox grpMonths;
        private System.Windows.Forms.DataGridView dgdMonths;
        private System.Windows.Forms.Button btnEditLocation;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNewLocation;
        private System.Windows.Forms.Button btnNewYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthId;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn minTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn daysAirFrost;
        private System.Windows.Forms.DataGridViewTextBoxColumn mmRain;
        private System.Windows.Forms.DataGridViewTextBoxColumn hrsSun;
        private System.Windows.Forms.Button btnEditYear;
    }
}

