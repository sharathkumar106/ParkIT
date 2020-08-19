namespace ParkIT
{
    partial class frmHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHelp));
            this.tbPreHelp = new System.Windows.Forms.TextBox();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnPost = new System.Windows.Forms.Button();
            this.tbPostHelp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbPreHelp
            // 
            this.tbPreHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPreHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            this.tbPreHelp.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbPreHelp.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPreHelp.ForeColor = System.Drawing.SystemColors.Info;
            this.tbPreHelp.Location = new System.Drawing.Point(160, 160);
            this.tbPreHelp.Multiline = true;
            this.tbPreHelp.Name = "tbPreHelp";
            this.tbPreHelp.ReadOnly = true;
            this.tbPreHelp.Size = new System.Drawing.Size(355, 237);
            this.tbPreHelp.TabIndex = 2;
            this.tbPreHelp.Text = "1. Enter user details\r\n2. Enter vehicle details\r\n3. View available slots\r\n5. Choo" +
    "se required slot\r\n6. Choose required time\r\n7. Specify duration\r\n8. Calculate cha" +
    "rges - Rs.30/hr\r\n9. Confirm Booking";
            this.tbPreHelp.Visible = false;
            // 
            // btnPre
            // 
            this.btnPre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPre.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPre.Location = new System.Drawing.Point(160, 86);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(171, 56);
            this.btnPre.TabIndex = 3;
            this.btnPre.Text = "PREPAID";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnPost
            // 
            this.btnPost.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPost.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPost.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPost.Location = new System.Drawing.Point(344, 86);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(171, 56);
            this.btnPost.TabIndex = 4;
            this.btnPost.Text = "POSTPAID";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // tbPostHelp
            // 
            this.tbPostHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPostHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(31)))), ((int)(((byte)(42)))));
            this.tbPostHelp.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbPostHelp.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPostHelp.ForeColor = System.Drawing.SystemColors.Info;
            this.tbPostHelp.Location = new System.Drawing.Point(160, 403);
            this.tbPostHelp.Multiline = true;
            this.tbPostHelp.Name = "tbPostHelp";
            this.tbPostHelp.ReadOnly = true;
            this.tbPostHelp.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbPostHelp.Size = new System.Drawing.Size(355, 291);
            this.tbPostHelp.TabIndex = 5;
            this.tbPostHelp.Text = resources.GetString("tbPostHelp.Text");
            this.tbPostHelp.Visible = false;
            // 
            // frmHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(664, 478);
            this.Controls.Add(this.tbPostHelp);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.tbPreHelp);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHelp";
            this.Text = "Help";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPreHelp;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.TextBox tbPostHelp;
    }
}