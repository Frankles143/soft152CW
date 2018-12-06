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
            this.grpSelectYear = new System.Windows.Forms.GroupBox();
            this.btnSelectYear = new System.Windows.Forms.Button();
            this.grpSelectMonth = new System.Windows.Forms.GroupBox();
            this.btnSelectMonth = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpSelectYear.SuspendLayout();
            this.grpSelectMonth.SuspendLayout();
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
            // grpSelectYear
            // 
            this.grpSelectYear.Controls.Add(this.btnSelectYear);
            this.grpSelectYear.Enabled = false;
            this.grpSelectYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSelectYear.Location = new System.Drawing.Point(9, 147);
            this.grpSelectYear.Name = "grpSelectYear";
            this.grpSelectYear.Size = new System.Drawing.Size(325, 81);
            this.grpSelectYear.TabIndex = 4;
            this.grpSelectYear.TabStop = false;
            this.grpSelectYear.Text = "Select a year";
            // 
            // btnSelectYear
            // 
            this.btnSelectYear.Location = new System.Drawing.Point(66, 31);
            this.btnSelectYear.Name = "btnSelectYear";
            this.btnSelectYear.Size = new System.Drawing.Size(190, 36);
            this.btnSelectYear.TabIndex = 2;
            this.btnSelectYear.Text = "Select Year";
            this.btnSelectYear.UseVisualStyleBackColor = true;
            this.btnSelectYear.Click += new System.EventHandler(this.btnSelectYear_Click);
            // 
            // grpSelectMonth
            // 
            this.grpSelectMonth.Controls.Add(this.btnSelectMonth);
            this.grpSelectMonth.Enabled = false;
            this.grpSelectMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSelectMonth.Location = new System.Drawing.Point(12, 234);
            this.grpSelectMonth.Name = "grpSelectMonth";
            this.grpSelectMonth.Size = new System.Drawing.Size(325, 86);
            this.grpSelectMonth.TabIndex = 5;
            this.grpSelectMonth.TabStop = false;
            this.grpSelectMonth.Text = "Select a month";
            // 
            // btnSelectMonth
            // 
            this.btnSelectMonth.Location = new System.Drawing.Point(63, 33);
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
            this.Controls.Add(this.grpSelectMonth);
            this.Controls.Add(this.grpSelectYear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstMainBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmHome";
            this.Text = "Weather Information";
            this.groupBox1.ResumeLayout(false);
            this.grpSelectYear.ResumeLayout(false);
            this.grpSelectMonth.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog dlgOpenData;
        private System.Windows.Forms.ListBox lstMainBox;
        private System.Windows.Forms.RichTextBox txtLocationSearch;
        private System.Windows.Forms.Button btnSelectLocation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpSelectYear;
        private System.Windows.Forms.Button btnSelectYear;
        private System.Windows.Forms.GroupBox grpSelectMonth;
        private System.Windows.Forms.Button btnSelectMonth;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnExit;
    }
}

