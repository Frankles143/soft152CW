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
            this.lstMainBox = new System.Windows.Forms.ListBox();
            this.txtLocationSearch = new System.Windows.Forms.RichTextBox();
            this.btnSelectLocation = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSelectYear = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSelectMonth = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtYearSearch = new System.Windows.Forms.RichTextBox();
            this.cmbMonthCombo = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dlgOpenData
            // 
            this.dlgOpenData.FileName = "inputEXTENDED";
            // 
            // lstMainBox
            // 
            this.lstMainBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMainBox.FormattingEnabled = true;
            this.lstMainBox.ItemHeight = 16;
            this.lstMainBox.Location = new System.Drawing.Point(356, 58);
            this.lstMainBox.Name = "lstMainBox";
            this.lstMainBox.Size = new System.Drawing.Size(863, 436);
            this.lstMainBox.TabIndex = 0;
            // 
            // txtLocationSearch
            // 
            this.txtLocationSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocationSearch.Location = new System.Drawing.Point(15, 35);
            this.txtLocationSearch.Name = "txtLocationSearch";
            this.txtLocationSearch.Size = new System.Drawing.Size(288, 26);
            this.txtLocationSearch.TabIndex = 1;
            this.txtLocationSearch.Text = "";
            this.txtLocationSearch.TextChanged += new System.EventHandler(this.txtLocationSearch_TextChanged);
            // 
            // btnSelectLocation
            // 
            this.btnSelectLocation.Location = new System.Drawing.Point(66, 67);
            this.btnSelectLocation.Name = "btnSelectLocation";
            this.btnSelectLocation.Size = new System.Drawing.Size(193, 36);
            this.btnSelectLocation.TabIndex = 2;
            this.btnSelectLocation.Text = "Select Location";
            this.btnSelectLocation.UseVisualStyleBackColor = true;
            this.btnSelectLocation.Click += new System.EventHandler(this.btnSelectLocation_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLocationSearch);
            this.groupBox1.Controls.Add(this.btnSelectLocation);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 118);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search for location";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtYearSearch);
            this.groupBox2.Controls.Add(this.btnSelectYear);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 97);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select a year";
            // 
            // btnSelectYear
            // 
            this.btnSelectYear.Location = new System.Drawing.Point(66, 51);
            this.btnSelectYear.Name = "btnSelectYear";
            this.btnSelectYear.Size = new System.Drawing.Size(190, 36);
            this.btnSelectYear.TabIndex = 2;
            this.btnSelectYear.Text = "Select Year";
            this.btnSelectYear.UseVisualStyleBackColor = true;
            this.btnSelectYear.Click += new System.EventHandler(this.btnSelectYear_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbMonthCombo);
            this.groupBox3.Controls.Add(this.btnSelectMonth);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 250);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(325, 101);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select a month";
            // 
            // btnSelectMonth
            // 
            this.btnSelectMonth.Location = new System.Drawing.Point(63, 51);
            this.btnSelectMonth.Name = "btnSelectMonth";
            this.btnSelectMonth.Size = new System.Drawing.Size(193, 36);
            this.btnSelectMonth.TabIndex = 2;
            this.btnSelectMonth.Text = "Select Month";
            this.btnSelectMonth.UseVisualStyleBackColor = true;
            this.btnSelectMonth.Click += new System.EventHandler(this.btnSelectMonth_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(24, 366);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 54);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(24, 440);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(117, 54);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtYearSearch
            // 
            this.txtYearSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYearSearch.Location = new System.Drawing.Point(15, 19);
            this.txtYearSearch.Name = "txtYearSearch";
            this.txtYearSearch.Size = new System.Drawing.Size(288, 26);
            this.txtYearSearch.TabIndex = 3;
            this.txtYearSearch.Text = "";
            // 
            // cmbMonthCombo
            // 
            this.cmbMonthCombo.FormattingEnabled = true;
            this.cmbMonthCombo.Location = new System.Drawing.Point(12, 21);
            this.cmbMonthCombo.Name = "cmbMonthCombo";
            this.cmbMonthCombo.Size = new System.Drawing.Size(288, 24);
            this.cmbMonthCombo.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(183, 384);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 89);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 514);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstMainBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmHome";
            this.Text = "Weather Information";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog dlgOpenData;
        private System.Windows.Forms.ListBox lstMainBox;
        private System.Windows.Forms.RichTextBox txtLocationSearch;
        private System.Windows.Forms.Button btnSelectLocation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSelectYear;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSelectMonth;
        private System.Windows.Forms.RichTextBox txtYearSearch;
        private System.Windows.Forms.ComboBox cmbMonthCombo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnExit;
    }
}

