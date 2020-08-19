namespace ParkIT
{
    partial class frmBookingConfirmed
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookingConfirmed));
            this.timerLoading = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSuccess = new System.Windows.Forms.Label();
            this.picConfirm = new System.Windows.Forms.PictureBox();
            this.picLoading = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // timerLoading
            // 
            this.timerLoading.Interval = 2000;
            this.timerLoading.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.lblSuccess);
            this.panel1.Controls.Add(this.picConfirm);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 453);
            this.panel1.TabIndex = 0;
            // 
            // lblSuccess
            // 
            this.lblSuccess.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSuccess.Font = new System.Drawing.Font("Montserrat", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuccess.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSuccess.Location = new System.Drawing.Point(190, 314);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(354, 40);
            this.lblSuccess.TabIndex = 3;
            this.lblSuccess.Text = "Booking Successful!";
            this.lblSuccess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picConfirm
            // 
            this.picConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picConfirm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picConfirm.BackgroundImage")));
            this.picConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picConfirm.Location = new System.Drawing.Point(229, 82);
            this.picConfirm.Name = "picConfirm";
            this.picConfirm.Size = new System.Drawing.Size(212, 204);
            this.picConfirm.TabIndex = 2;
            this.picConfirm.TabStop = false;
            // 
            // picLoading
            // 
            this.picLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picLoading.Image = ((System.Drawing.Image)(resources.GetObject("picLoading.Image")));
            this.picLoading.Location = new System.Drawing.Point(12, 12);
            this.picLoading.Name = "picLoading";
            this.picLoading.Size = new System.Drawing.Size(640, 454);
            this.picLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLoading.TabIndex = 12;
            this.picLoading.TabStop = false;
            // 
            // frmBookingConfirmed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(664, 478);
            this.Controls.Add(this.picLoading);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBookingConfirmed";
            this.Text = "Confirming....";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerLoading;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSuccess;
        private System.Windows.Forms.PictureBox picConfirm;
        private System.Windows.Forms.PictureBox picLoading;
    }
}