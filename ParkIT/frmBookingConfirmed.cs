using System;
using System.Windows.Forms;

namespace ParkIT
{
    public partial class frmBookingConfirmed : Form
    {
       
        public frmBookingConfirmed()
        {
            InitializeComponent();
            timerLoading.Start();
            Program.lblTitle.Text = this.Text;
        }
      
        private void timer1_Tick(object sender, EventArgs e)
        {
            picLoading.Visible = false;
            timerLoading.Stop();
            picConfirm.Visible = true;
        }

        
    }
    
}
