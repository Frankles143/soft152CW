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
            this.btnExit = new System.Windows.Forms.Button();
            this.lstLocations = new System.Windows.Forms.ListBox();
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
            this.txtLocationSearch.Size = new System.Drawing.Size(568, 26);
            this.txtLocationSearch.TabIndex = 1;
            this.txtLocationSearch.Text = "";
            this.txtLocationSearch.TextChanged += new System.EventHandler(this.txtLocationSearch_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstLocations);
            this.groupBox1.Controls.Add(this.txtLocationSearch);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 179);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search for location";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1149, 448);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 54);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstLocations
            // 
            this.lstLocations.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstLocations.FormattingEnabled = true;
            this.lstLocations.ItemHeight = 16;
            this.lstLocations.Location = new System.Drawing.Point(3, 60);
            this.lstLocations.Name = "lstLocations";
            this.lstLocations.Size = new System.Drawing.Size(568, 116);
            this.lstLocations.TabIndex = 2;
            this.lstLocations.SelectedIndexChanged += new System.EventHandler(this.lstLocations_SelectedIndexChanged);
            // 
            // grpYear
            // 
            this.grpYear.Controls.Add(this.lstYears);
            this.grpYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpYear.Location = new System.Drawing.Point(606, 23);
            this.grpYear.Name = "grpYear";
            this.grpYear.Size = new System.Drawing.Size(623, 179);
            this.grpYear.TabIndex = 9;
            this.grpYear.TabStop = false;
            this.grpYear.Text = "Years";
            // 
            // lstYears
            // 
            this.lstYears.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstYears.FormattingEnabled = true;
            this.lstYears.ItemHeight = 16;
            this.lstYears.Location = new System.Drawing.Point(3, 18);
            this.lstYears.Name = "lstYears";
            this.lstYears.Size = new System.Drawing.Size(617, 158);
            this.lstYears.TabIndex = 0;
            // 
            // grpMonths
            // 
            this.grpMonths.Controls.Add(this.dgdMonths);
            this.grpMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMonths.Location = new System.Drawing.Point(9, 208);
            this.grpMonths.Name = "grpMonths";
            this.grpMonths.Size = new System.Drawing.Size(573, 267);
            this.grpMonths.TabIndex = 10;
            this.grpMonths.TabStop = false;
            this.grpMonths.Text = "Months";
            // 
            // dgdMonths
            // 
            this.dgdMonths.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdMonths.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.monthId,
            this.maxTemp,
            this.minTemp,
            this.daysAirFrost,
            this.mmRain,
            this.hrsSun});
            this.dgdMonths.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgdMonths.Location = new System.Drawing.Point(3, 18);
            this.dgdMonths.Name = "dgdMonths";
            this.dgdMonths.Size = new System.Drawing.Size(567, 246);
            this.dgdMonths.TabIndex = 0;
            // 
            // monthId
            // 
            this.monthId.HeaderText = "Month";
            this.monthId.Name = "monthId";
            // 
            // maxTemp
            // 
            this.maxTemp.HeaderText = "Max. Temperature";
            this.maxTemp.Name = "maxTemp";
            // 
            // minTemp
            // 
            this.minTemp.HeaderText = "Min. Temperature";
            this.minTemp.Name = "minTemp";
            // 
            // daysAirFrost
            // 
            this.daysAirFrost.HeaderText = "Days of Air Frost";
            this.daysAirFrost.Name = "daysAirFrost";
            // 
            // mmRain
            // 
            this.mmRain.HeaderText = "Rain (mm)";
            this.mmRain.Name = "mmRain";
            // 
            // hrsSun
            // 
            this.hrsSun.HeaderText = "Hours of Sunlight";
            this.hrsSun.Name = "hrsSun";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 514);
            this.Controls.Add(this.grpMonths);
            this.Controls.Add(this.grpYear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn monthId;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn minTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn daysAirFrost;
        private System.Windows.Forms.DataGridViewTextBoxColumn mmRain;
        private System.Windows.Forms.DataGridViewTextBoxColumn hrsSun;
    }
}

