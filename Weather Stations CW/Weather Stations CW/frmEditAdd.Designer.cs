namespace Weather_Stations_CW
{
    partial class frmEditAdd
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
            this.grpLocation = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStreetNumberAndNameInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCountyInput = new System.Windows.Forms.TextBox();
            this.txtPostcodeInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLongtitudeInput = new System.Windows.Forms.TextBox();
            this.txtLatitudeInput = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpLocation.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLocation
            // 
            this.grpLocation.Controls.Add(this.txtLatitudeInput);
            this.grpLocation.Controls.Add(this.txtLongtitudeInput);
            this.grpLocation.Controls.Add(this.label6);
            this.grpLocation.Controls.Add(this.label5);
            this.grpLocation.Controls.Add(this.txtPostcodeInput);
            this.grpLocation.Controls.Add(this.txtCountyInput);
            this.grpLocation.Controls.Add(this.label4);
            this.grpLocation.Controls.Add(this.label3);
            this.grpLocation.Controls.Add(this.txtStreetNumberAndNameInput);
            this.grpLocation.Controls.Add(this.label2);
            this.grpLocation.Controls.Add(this.label1);
            this.grpLocation.Controls.Add(this.txtNameInput);
            this.grpLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLocation.Location = new System.Drawing.Point(12, 12);
            this.grpLocation.Name = "grpLocation";
            this.grpLocation.Size = new System.Drawing.Size(490, 360);
            this.grpLocation.TabIndex = 1;
            this.grpLocation.TabStop = false;
            this.grpLocation.Text = "Location";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // txtNameInput
            // 
            this.txtNameInput.Location = new System.Drawing.Point(99, 49);
            this.txtNameInput.Name = "txtNameInput";
            this.txtNameInput.Size = new System.Drawing.Size(355, 22);
            this.txtNameInput.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Street Number\r\n   and Name:";
            // 
            // txtStreetNumberAndNameInput
            // 
            this.txtStreetNumberAndNameInput.Location = new System.Drawing.Point(99, 100);
            this.txtStreetNumberAndNameInput.Name = "txtStreetNumberAndNameInput";
            this.txtStreetNumberAndNameInput.Size = new System.Drawing.Size(355, 22);
            this.txtStreetNumberAndNameInput.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "County:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Postcode:";
            // 
            // txtCountyInput
            // 
            this.txtCountyInput.Location = new System.Drawing.Point(99, 151);
            this.txtCountyInput.Name = "txtCountyInput";
            this.txtCountyInput.Size = new System.Drawing.Size(355, 22);
            this.txtCountyInput.TabIndex = 6;
            // 
            // txtPostcodeInput
            // 
            this.txtPostcodeInput.Location = new System.Drawing.Point(99, 202);
            this.txtPostcodeInput.Name = "txtPostcodeInput";
            this.txtPostcodeInput.Size = new System.Drawing.Size(355, 22);
            this.txtPostcodeInput.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Longtitude:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Latitude:";
            // 
            // txtLongtitudeInput
            // 
            this.txtLongtitudeInput.Location = new System.Drawing.Point(99, 253);
            this.txtLongtitudeInput.Name = "txtLongtitudeInput";
            this.txtLongtitudeInput.Size = new System.Drawing.Size(355, 22);
            this.txtLongtitudeInput.TabIndex = 10;
            // 
            // txtLatitudeInput
            // 
            this.txtLatitudeInput.Location = new System.Drawing.Point(99, 304);
            this.txtLatitudeInput.Name = "txtLatitudeInput";
            this.txtLatitudeInput.Size = new System.Drawing.Size(355, 22);
            this.txtLatitudeInput.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(547, 265);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 40);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(547, 332);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(105, 40);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // frmEditAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 390);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpLocation);
            this.Name = "frmEditAdd";
            this.Text = "frmEditAdd";
            this.grpLocation.ResumeLayout(false);
            this.grpLocation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpLocation;
        private System.Windows.Forms.TextBox txtNameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStreetNumberAndNameInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPostcodeInput;
        private System.Windows.Forms.TextBox txtCountyInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLatitudeInput;
        private System.Windows.Forms.TextBox txtLongtitudeInput;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
    }
}