namespace ParkIT
{
    partial class frmPostpaidConfirm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPostpaidConfirm));
            this.btnCheckout = new System.Windows.Forms.Button();
            this.pnlPricing = new System.Windows.Forms.Panel();
            this.lnkAddMoney = new System.Windows.Forms.LinkLabel();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.lblCheckoutMarker = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblAddMoney = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPricingMarker = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAddBal = new System.Windows.Forms.TextBox();
            this.bunifuSeparator7 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label7 = new System.Windows.Forms.Label();
            this.lblLoadMoney = new System.Windows.Forms.Label();
            this.pnlWallet = new System.Windows.Forms.Panel();
            this.pnlPricing.SuspendLayout();
            this.pnlWallet.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCheckout
            // 
            this.btnCheckout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCheckout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Font = new System.Drawing.Font("Montserrat", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCheckout.Location = new System.Drawing.Point(187, 12);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(303, 60);
            this.btnCheckout.TabIndex = 3;
            this.btnCheckout.Text = "CHECKOUT";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // pnlPricing
            // 
            this.pnlPricing.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlPricing.Controls.Add(this.lnkAddMoney);
            this.pnlPricing.Controls.Add(this.lblConfirm);
            this.pnlPricing.Controls.Add(this.lblCheckoutMarker);
            this.pnlPricing.Controls.Add(this.lblDuration);
            this.pnlPricing.Controls.Add(this.label11);
            this.pnlPricing.Controls.Add(this.label1);
            this.pnlPricing.Controls.Add(this.lblBalance);
            this.pnlPricing.Controls.Add(this.lblPrice);
            this.pnlPricing.Controls.Add(this.lblAddMoney);
            this.pnlPricing.Controls.Add(this.label2);
            this.pnlPricing.Controls.Add(this.label6);
            this.pnlPricing.Controls.Add(this.label9);
            this.pnlPricing.Controls.Add(this.label5);
            this.pnlPricing.Location = new System.Drawing.Point(71, 110);
            this.pnlPricing.Name = "pnlPricing";
            this.pnlPricing.Size = new System.Drawing.Size(534, 296);
            this.pnlPricing.TabIndex = 4;
            this.pnlPricing.Visible = false;
            // 
            // lnkAddMoney
            // 
            this.lnkAddMoney.AutoSize = true;
            this.lnkAddMoney.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkAddMoney.ForeColor = System.Drawing.Color.Crimson;
            this.lnkAddMoney.LinkColor = System.Drawing.Color.Beige;
            this.lnkAddMoney.Location = new System.Drawing.Point(385, 191);
            this.lnkAddMoney.Name = "lnkAddMoney";
            this.lnkAddMoney.Size = new System.Drawing.Size(107, 20);
            this.lnkAddMoney.TabIndex = 118;
            this.lnkAddMoney.TabStop = true;
            this.lnkAddMoney.Text = "Add Money";
            this.lnkAddMoney.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAddMoney_LinkClicked);
            // 
            // lblConfirm
            // 
            this.lblConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConfirm.BackColor = System.Drawing.Color.ForestGreen;
            this.lblConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblConfirm.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblConfirm.Location = new System.Drawing.Point(41, 235);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(451, 48);
            this.lblConfirm.TabIndex = 117;
            this.lblConfirm.Text = "Confirm";
            this.lblConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblConfirm.Click += new System.EventHandler(this.lblConfirm_Click);
            // 
            // lblCheckoutMarker
            // 
            this.lblCheckoutMarker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCheckoutMarker.AutoSize = true;
            this.lblCheckoutMarker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.lblCheckoutMarker.Location = new System.Drawing.Point(113, 81);
            this.lblCheckoutMarker.Name = "lblCheckoutMarker";
            this.lblCheckoutMarker.Size = new System.Drawing.Size(12, 17);
            this.lblCheckoutMarker.TabIndex = 5;
            this.lblCheckoutMarker.Text = ".";
            // 
            // lblDuration
            // 
            this.lblDuration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDuration.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblDuration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDuration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDuration.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDuration.Location = new System.Drawing.Point(281, 78);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(138, 32);
            this.lblDuration.TabIndex = 94;
            this.lblDuration.Text = "2";
            this.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(281, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 32);
            this.label11.TabIndex = 92;
            this.label11.Text = "Rs.";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(281, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 32);
            this.label1.TabIndex = 92;
            this.label1.Text = "Rs.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBalance
            // 
            this.lblBalance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBalance.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblBalance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBalance.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblBalance.Location = new System.Drawing.Point(357, 10);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(135, 32);
            this.lblBalance.TabIndex = 93;
            this.lblBalance.Text = "500";
            this.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrice.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPrice.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPrice.Location = new System.Drawing.Point(357, 121);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(135, 32);
            this.lblPrice.TabIndex = 93;
            this.lblPrice.Text = "500";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAddMoney
            // 
            this.lblAddMoney.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddMoney.AutoSize = true;
            this.lblAddMoney.Font = new System.Drawing.Font("Montserrat Light", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddMoney.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAddMoney.Location = new System.Drawing.Point(175, 191);
            this.lblAddMoney.Name = "lblAddMoney";
            this.lblAddMoney.Size = new System.Drawing.Size(183, 20);
            this.lblAddMoney.TabIndex = 86;
            this.lblAddMoney.Text = "Insufficient Balance?";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(41, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 86;
            this.label2.Text = "Total Price";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Tan;
            this.label6.Location = new System.Drawing.Point(420, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 84;
            this.label6.Text = "*in Hours";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.label9.Location = new System.Drawing.Point(41, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 24);
            this.label9.TabIndex = 83;
            this.label9.Text = "Wallet Balance";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(41, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 24);
            this.label5.TabIndex = 83;
            this.label5.Text = "Duration";
            // 
            // lblPricingMarker
            // 
            this.lblPricingMarker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPricingMarker.AutoSize = true;
            this.lblPricingMarker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.lblPricingMarker.Location = new System.Drawing.Point(12, 110);
            this.lblPricingMarker.Name = "lblPricingMarker";
            this.lblPricingMarker.Size = new System.Drawing.Size(12, 17);
            this.lblPricingMarker.TabIndex = 6;
            this.lblPricingMarker.Text = ".";
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
            this.label14.Location = new System.Drawing.Point(27, 156);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 20);
            this.label14.TabIndex = 129;
            this.label14.Text = "Enter Amount ";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label13.Location = new System.Drawing.Point(139, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(203, 20);
            this.label13.TabIndex = 129;
            this.label13.Text = "Add Money to e-Wallet";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtAddBal
            // 
            this.txtAddBal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddBal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(53)))));
            this.txtAddBal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddBal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAddBal.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddBal.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtAddBal.Location = new System.Drawing.Point(27, 189);
            this.txtAddBal.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txtAddBal.Name = "txtAddBal";
            this.txtAddBal.Size = new System.Drawing.Size(418, 37);
            this.txtAddBal.TabIndex = 130;
            this.txtAddBal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuSeparator7
            // 
            this.bunifuSeparator7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuSeparator7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator7.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator7.LineThickness = 2;
            this.bunifuSeparator7.Location = new System.Drawing.Point(27, 231);
            this.bunifuSeparator7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator7.Name = "bunifuSeparator7";
            this.bunifuSeparator7.Size = new System.Drawing.Size(418, 10);
            this.bunifuSeparator7.TabIndex = 133;
            this.bunifuSeparator7.Transparency = 255;
            this.bunifuSeparator7.Vertical = false;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(150, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 48);
            this.label7.TabIndex = 134;
            this.label7.Text = "WALLET";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLoadMoney
            // 
            this.lblLoadMoney.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLoadMoney.BackColor = System.Drawing.Color.Turquoise;
            this.lblLoadMoney.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLoadMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLoadMoney.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadMoney.ForeColor = System.Drawing.Color.Navy;
            this.lblLoadMoney.Location = new System.Drawing.Point(27, 314);
            this.lblLoadMoney.Name = "lblLoadMoney";
            this.lblLoadMoney.Size = new System.Drawing.Size(418, 48);
            this.lblLoadMoney.TabIndex = 135;
            this.lblLoadMoney.Text = "Load Money";
            this.lblLoadMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLoadMoney.Click += new System.EventHandler(this.lblLoadMoney_Click);
            // 
            // pnlWallet
            // 
            this.pnlWallet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlWallet.Controls.Add(this.lblLoadMoney);
            this.pnlWallet.Controls.Add(this.label7);
            this.pnlWallet.Controls.Add(this.bunifuSeparator7);
            this.pnlWallet.Controls.Add(this.txtAddBal);
            this.pnlWallet.Controls.Add(this.label13);
            this.pnlWallet.Controls.Add(this.label14);
            this.pnlWallet.Location = new System.Drawing.Point(96, 41);
            this.pnlWallet.Name = "pnlWallet";
            this.pnlWallet.Size = new System.Drawing.Size(467, 400);
            this.pnlWallet.TabIndex = 145;
            this.pnlWallet.Visible = false;
            // 
            // frmPostpaidConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(664, 478);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblPricingMarker);
            this.Controls.Add(this.pnlPricing);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.pnlWallet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPostpaidConfirm";
            this.Text = "Confirm Booking";
            this.Load += new System.EventHandler(this.frmPostpaidConfirm_Load);
            this.Resize += new System.EventHandler(this.frmPostpaidConfirm_Resize);
            this.pnlPricing.ResumeLayout(false);
            this.pnlPricing.PerformLayout();
            this.pnlWallet.ResumeLayout(false);
            this.pnlWallet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Panel pnlPricing;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.Label lblCheckoutMarker;
        private System.Windows.Forms.Label lblPricingMarker;
        private System.Windows.Forms.LinkLabel lnkAddMoney;
        private System.Windows.Forms.Label lblAddMoney;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAddBal;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblLoadMoney;
        private System.Windows.Forms.Panel pnlWallet;
    }
}