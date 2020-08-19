namespace ParkIT
{
    partial class frmPostpaidDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPostpaidDetails));
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblContinue = new System.Windows.Forms.Label();
            this.dtInTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtInDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSlots = new System.Windows.Forms.ComboBox();
            this.cbVehType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVehicleno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Tan;
            this.label6.Location = new System.Drawing.Point(486, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 81;
            this.label6.Text = "*per Hour";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(130, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 24);
            this.label5.TabIndex = 80;
            this.label5.Text = "Minimum Price";
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrice.BackColor = System.Drawing.Color.OliveDrab;
            this.lblPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPrice.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPrice.Location = new System.Drawing.Point(347, 311);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(215, 36);
            this.lblPrice.TabIndex = 79;
            this.lblPrice.Text = "Rs. 40";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblContinue
            // 
            this.lblContinue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblContinue.BackColor = System.Drawing.Color.DarkKhaki;
            this.lblContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContinue.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContinue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblContinue.Location = new System.Drawing.Point(111, 399);
            this.lblContinue.Name = "lblContinue";
            this.lblContinue.Size = new System.Drawing.Size(451, 48);
            this.lblContinue.TabIndex = 78;
            this.lblContinue.Text = "Continue";
            this.lblContinue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblContinue.Click += new System.EventHandler(this.lblContinue_Click);
            // 
            // dtInTime
            // 
            this.dtInTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtInTime.CalendarFont = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtInTime.CustomFormat = " hh : mm tt";
            this.dtInTime.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtInTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInTime.Location = new System.Drawing.Point(347, 140);
            this.dtInTime.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtInTime.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtInTime.Name = "dtInTime";
            this.dtInTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtInTime.ShowUpDown = true;
            this.dtInTime.Size = new System.Drawing.Size(215, 28);
            this.dtInTime.TabIndex = 76;
            this.dtInTime.Value = new System.DateTime(2020, 2, 16, 0, 0, 0, 0);
            this.dtInTime.ValueChanged += new System.EventHandler(this.dtInTime_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(220, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 74;
            this.label2.Text = "In-Time";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(245, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 73;
            this.label1.Text = "Date";
            // 
            // dtInDate
            // 
            this.dtInDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtInDate.CustomFormat = "dd/MM/yyyy";
            this.dtInDate.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtInDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInDate.Location = new System.Drawing.Point(347, 87);
            this.dtInDate.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtInDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtInDate.Name = "dtInDate";
            this.dtInDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtInDate.Size = new System.Drawing.Size(215, 28);
            this.dtInDate.TabIndex = 72;
            this.dtInDate.ValueChanged += new System.EventHandler(this.dtInDate_ValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(184, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 71;
            this.label4.Text = "Choose Slot";
            // 
            // cmbSlots
            // 
            this.cmbSlots.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbSlots.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSlots.FormattingEnabled = true;
            this.cmbSlots.Location = new System.Drawing.Point(347, 40);
            this.cmbSlots.Name = "cmbSlots";
            this.cmbSlots.Size = new System.Drawing.Size(215, 28);
            this.cmbSlots.TabIndex = 70;
            this.cmbSlots.SelectionChangeCommitted += new System.EventHandler(this.cmbSlots_SelectionChangeCommitted);
            // 
            // cbVehType
            // 
            this.cbVehType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbVehType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbVehType.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVehType.Items.AddRange(new object[] {
            "Auto-Rikshaw",
            "Bike",
            "Car",
            "Four Wheeler",
            "Two Wheeler",
            "Others"});
            this.cbVehType.Location = new System.Drawing.Point(347, 192);
            this.cbVehType.Name = "cbVehType";
            this.cbVehType.Size = new System.Drawing.Size(215, 28);
            this.cbVehType.TabIndex = 114;
            this.cbVehType.SelectionChangeCommitted += new System.EventHandler(this.cbVehType_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(179, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 116;
            this.label3.Text = "Vehicle Type";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtVehicleno
            // 
            this.txtVehicleno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVehicleno.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtVehicleno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVehicleno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVehicleno.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehicleno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.txtVehicleno.Location = new System.Drawing.Point(347, 242);
            this.txtVehicleno.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txtVehicleno.Name = "txtVehicleno";
            this.txtVehicleno.Size = new System.Drawing.Size(215, 24);
            this.txtVehicleno.TabIndex = 115;
            this.txtVehicleno.Leave += new System.EventHandler(this.txtVehicleno_Leave);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(148, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 20);
            this.label9.TabIndex = 113;
            this.label9.Text = "Vehicle Number";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(610, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(42, 39);
            this.btnClose.TabIndex = 117;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(179, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 71;
            this.label7.Text = "Choose Slot";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(240, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 73;
            this.label8.Text = "Date";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(215, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 20);
            this.label10.TabIndex = 74;
            this.label10.Text = "In-Time";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(125, 317);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(164, 24);
            this.label11.TabIndex = 80;
            this.label11.Text = "Minimum Price";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Location = new System.Drawing.Point(143, 246);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 20);
            this.label12.TabIndex = 113;
            this.label12.Text = "Vehicle Number";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label13.Location = new System.Drawing.Point(174, 195);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 20);
            this.label13.TabIndex = 116;
            this.label13.Text = "Vehicle Type";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label14.Location = new System.Drawing.Point(295, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 20);
            this.label14.TabIndex = 71;
            this.label14.Text = ":";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label15.Location = new System.Drawing.Point(295, 93);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 20);
            this.label15.TabIndex = 71;
            this.label15.Text = ":";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label16.Location = new System.Drawing.Point(295, 146);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 20);
            this.label16.TabIndex = 71;
            this.label16.Text = ":";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label17.Location = new System.Drawing.Point(295, 195);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(13, 20);
            this.label17.TabIndex = 71;
            this.label17.Text = ":";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label18.Location = new System.Drawing.Point(295, 245);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(13, 20);
            this.label18.TabIndex = 71;
            this.label18.Text = ":";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label19.Location = new System.Drawing.Point(295, 320);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(13, 20);
            this.label19.TabIndex = 71;
            this.label19.Text = ":";
            // 
            // frmPostpaidDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(664, 478);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cbVehType);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVehicleno);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblContinue);
            this.Controls.Add(this.dtInTime);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtInDate);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbSlots);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPostpaidDetails";
            this.Text = "Enter Details";
            this.Load += new System.EventHandler(this.frmPostpaidDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblContinue;
        private System.Windows.Forms.DateTimePicker dtInTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtInDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbSlots;
        private System.Windows.Forms.ComboBox cbVehType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVehicleno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
    }
}