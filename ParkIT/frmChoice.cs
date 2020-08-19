using System;
using System.Windows.Forms;

namespace ParkIT
{
    public partial class frmChoice : Form
    {
        public frmChoice()
        {
            InitializeComponent();
        }

        
        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
           
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Controls.Add(childForm);
            Tag = childForm;
            DoubleBuffered = true;
            childForm.BringToFront();
            childForm.Show();
            Program.lblTitle.Text = childForm.Text;
        }

        private void lblPrepaid_Click(object sender, EventArgs e)
        {
            
            openChildForm(new frmPrepaidDetails());
        }

        private void lblPostpaid_Click(object sender, EventArgs e)
        {
            if (Program.isLoggedIn)
            {
                openChildForm(new frmPostpaidDetails());
            }
            else
                openChildForm(new frmPostpaidRegister());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.lblTitle.Text = "Dashboard";
        }
    }
}
