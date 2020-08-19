namespace ParkIT
{
    partial class frmChoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChoice));
            this.lblPrepaid = new System.Windows.Forms.Label();
            this.lblPostpaid = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrepaid
            // 
            this.lblPrepaid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrepaid.BackColor = System.Drawing.Color.SaddleBrown;
            this.lblPrepaid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPrepaid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPrepaid.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrepaid.Location = new System.Drawing.Point(79, 169);
            this.lblPrepaid.Name = "lblPrepaid";
            this.lblPrepaid.Size = new System.Drawing.Size(513, 48);
            this.lblPrepaid.TabIndex = 10;
            this.lblPrepaid.Text = "Prepaid";
            this.lblPrepaid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPrepaid.Click += new System.EventHandler(this.lblPrepaid_Click);
            // 
            // lblPostpaid
            // 
            this.lblPostpaid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPostpaid.BackColor = System.Drawing.Color.SaddleBrown;
            this.lblPostpaid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPostpaid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPostpaid.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostpaid.Location = new System.Drawing.Point(79, 280);
            this.lblPostpaid.Name = "lblPostpaid";
            this.lblPostpaid.Size = new System.Drawing.Size(513, 48);
            this.lblPostpaid.TabIndex = 11;
            this.lblPostpaid.Text = "Postpaid";
            this.lblPostpaid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPostpaid.Click += new System.EventHandler(this.lblPostpaid_Click);
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
            this.btnClose.TabIndex = 9;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(664, 478);
            this.Controls.Add(this.lblPostpaid);
            this.Controls.Add(this.lblPrepaid);
            this.Controls.Add(this.btnClose);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChoice";
            this.Text = "Choose Service Type";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblPrepaid;
        private System.Windows.Forms.Label lblPostpaid;
        private System.Windows.Forms.Button btnClose;
    }
}