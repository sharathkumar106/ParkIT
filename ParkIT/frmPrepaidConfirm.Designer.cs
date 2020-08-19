namespace ParkIT
{
    partial class frmPrepaidConfirm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrepaidConfirm));
            this.cmbSlots = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtInTime = new System.Windows.Forms.DateTimePicker();
            this.DtOutTime = new System.Windows.Forms.DateTimePicker();
            this.lblContinue = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblCalc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbSlots
            // 
            this.cmbSlots.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbSlots.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSlots.FormattingEnabled = true;
            this.cmbSlots.Location = new System.Drawing.Point(311, 75);
            this.cmbSlots.Name = "cmbSlots";
            this.cmbSlots.Size = new System.Drawing.Size(215, 28);
            this.cmbSlots.TabIndex = 11;
            this.cmbSlots.SelectionChangeCommitted += new System.EventHandler(this.cmbSlots_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(125, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 55;
            this.label4.Text = "Choose Slot";
            // 
            // dtDate
            // 
            this.dtDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtDate.CustomFormat = "dd/MM/yyyy";
            this.dtDate.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDate.Location = new System.Drawing.Point(311, 122);
            this.dtDate.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtDate.Name = "dtDate";
            this.dtDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtDate.Size = new System.Drawing.Size(215, 28);
            this.dtDate.TabIndex = 56;
            this.dtDate.ValueChanged += new System.EventHandler(this.dtDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 57;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 58;
            this.label2.Text = "In-Time";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(145, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 63;
            this.label3.Text = "Out-Time";
            // 
            // dtInTime
            // 
            this.dtInTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtInTime.CalendarFont = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtInTime.CustomFormat = " hh : mm tt";
            this.dtInTime.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtInTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInTime.Location = new System.Drawing.Point(311, 175);
            this.dtInTime.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtInTime.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtInTime.Name = "dtInTime";
            this.dtInTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtInTime.ShowUpDown = true;
            this.dtInTime.Size = new System.Drawing.Size(215, 28);
            this.dtInTime.TabIndex = 64;
            this.dtInTime.Value = new System.DateTime(2020, 1, 24, 0, 0, 0, 0);
            this.dtInTime.ValueChanged += new System.EventHandler(this.dtInTime_ValueChanged);
            // 
            // DtOutTime
            // 
            this.DtOutTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DtOutTime.CalendarFont = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtOutTime.CustomFormat = " hh : mm tt";
            this.DtOutTime.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtOutTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtOutTime.Location = new System.Drawing.Point(311, 223);
            this.DtOutTime.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.DtOutTime.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DtOutTime.Name = "DtOutTime";
            this.DtOutTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DtOutTime.ShowUpDown = true;
            this.DtOutTime.Size = new System.Drawing.Size(215, 28);
            this.DtOutTime.TabIndex = 65;
            this.DtOutTime.Value = new System.DateTime(2020, 1, 24, 0, 0, 0, 0);
            this.DtOutTime.ValueChanged += new System.EventHandler(this.DtOutTime_ValueChanged);
            // 
            // lblContinue
            // 
            this.lblContinue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblContinue.BackColor = System.Drawing.Color.YellowGreen;
            this.lblContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContinue.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContinue.Location = new System.Drawing.Point(129, 367);
            this.lblContinue.Name = "lblContinue";
            this.lblContinue.Size = new System.Drawing.Size(397, 48);
            this.lblContinue.TabIndex = 66;
            this.lblContinue.Text = "Confirm";
            this.lblContinue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblContinue.Click += new System.EventHandler(this.lblContinue_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrice.BackColor = System.Drawing.Color.OliveDrab;
            this.lblPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPrice.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(311, 273);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(215, 47);
            this.lblPrice.TabIndex = 67;
            this.lblPrice.Text = "Rs. 30";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(175, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 24);
            this.label5.TabIndex = 68;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Tan;
            this.label6.Location = new System.Drawing.Point(457, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 69;
            this.label6.Text = "*per Hour";
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
            this.btnClose.TabIndex = 146;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label14.Location = new System.Drawing.Point(251, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 20);
            this.label14.TabIndex = 147;
            this.label14.Text = ":";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(251, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 20);
            this.label7.TabIndex = 147;
            this.label7.Text = ":";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(251, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 20);
            this.label8.TabIndex = 147;
            this.label8.Text = ":";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(251, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 20);
            this.label9.TabIndex = 147;
            this.label9.Text = ":";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(251, 284);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 20);
            this.label10.TabIndex = 147;
            this.label10.Text = ":";
            // 
            // lblCalc
            // 
            this.lblCalc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCalc.BackColor = System.Drawing.Color.OliveDrab;
            this.lblCalc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCalc.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalc.Location = new System.Drawing.Point(311, 273);
            this.lblCalc.Name = "lblCalc";
            this.lblCalc.Size = new System.Drawing.Size(215, 47);
            this.lblCalc.TabIndex = 148;
            this.lblCalc.Text = "CALCULATE";
            this.lblCalc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCalc.Click += new System.EventHandler(this.lblCalc_Click);
            // 
            // frmPrepaidConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(664, 478);
            this.Controls.Add(this.lblCalc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblContinue);
            this.Controls.Add(this.DtOutTime);
            this.Controls.Add(this.dtInTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbSlots);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrepaidConfirm";
            this.Text = "Confirm Booking";
            this.Load += new System.EventHandler(this.frmPrepaidConfirm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbSlots;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtInTime;
        private System.Windows.Forms.DateTimePicker DtOutTime;
        private System.Windows.Forms.Label lblContinue;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCalc;
    }
}