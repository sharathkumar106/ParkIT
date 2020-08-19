using System;
using System.Windows.Forms;

namespace ParkIT
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            customizeDesign();
            lblTitle.Text = "Dashboard";
            Program.lblTitle = lblTitle;

        }
        
        private void customizeDesign()
        {
            panelStatsSubMenu.Visible = false;
            panelBookingsSubMenu.Visible = false;
            panelMenuSubMenu.Visible = false;
            
            //..

        }
        private void hideSubMenu()
        {
            if (panelStatsSubMenu.Visible == true)
                panelStatsSubMenu.Visible = false;
            if (panelBookingsSubMenu.Visible == true)
                panelBookingsSubMenu.Visible = false;
            if (panelMenuSubMenu.Visible == true)
                panelMenuSubMenu.Visible = false;

        }
        private void showSubMneu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        #region panelHomeSubMenu
        private void btnMenu_Click(object sender, EventArgs e)
        {
            showSubMneu(panelMenuSubMenu);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if(activeForm!=null)
                activeForm.Close();
            //..
            //Your Code
            //..
            hideSubMenu();
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            openChildForm(new frmAboutUs());
            //..
            //Your Code
            //..
            hideSubMenu();
        }

        private void btnExplore_Click(object sender, EventArgs e)
        {
            openChildForm(new frmChoice());
            /**
             * 
             * 
            **/
            hideSubMenu();
        }
        #endregion

        #region panelStatisticsSubMenu
        private void btnStats_Click(object sender, EventArgs e)
        {
            showSubMneu(panelStatsSubMenu);
        }

        private void btnPreBookings_Click(object sender, EventArgs e)
        {
            openChildForm(new frmStatPrepaid());
            //..
            //Your Code
            //..
            hideSubMenu();
        }

        private void btnPostBookings_Click(object sender, EventArgs e)
        {
            openChildForm(new frmStatPostpaid());
            //..
            //Your Code
            //..
            hideSubMenu();
        }
        #endregion

        #region panelBookingsSubMenu
        private void btnBookings_Click(object sender, EventArgs e)
        {
            showSubMneu(panelBookingsSubMenu);
        }

        private void btnPrepaid_Click(object sender, EventArgs e)
        {
            openChildForm(new frmPrepaidDetails());
            //..
            //Your Code
            //..
            hideSubMenu();
        }

        private void btnPostpaid_Click(object sender, EventArgs e)
        {
            openChildForm(new frmPostpaidRegister());
            //..
            //Your Code
            //..
            hideSubMenu();
        }
        #endregion

        #region panelHelp
        private void btnHelp_Click(object sender, EventArgs e)
        {
            openChildForm(new frmHelp());
            //..
            //Your Code
            //..
            hideSubMenu();
        }
        #endregion

        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            openChildForm(new frmChoice());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
