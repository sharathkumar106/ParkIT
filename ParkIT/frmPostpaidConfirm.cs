using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace ParkIT
{
    public partial class frmPostpaidConfirm : Form
    {
       
        
        SqlConnection con = new SqlConnection(Program.strConn);
        static int MIN_PRICE = 40;
        static int HOUR_PRICE = 5;
        static string outTime = "";
        string inTime = "";
        int bookDuration = 0;
        static float walletBal = 0.0f;
        static float newWalletBal= 0.0f;
        int minPrice = MIN_PRICE;
        int hrPrice = HOUR_PRICE;
        static float totalPrice = MIN_PRICE;

        private int locCheckout, locPricing;


        public frmPostpaidConfirm()
        {
            InitializeComponent();
            btnCheckout.Top = lblCheckoutMarker.Top;
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

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            btnCheckout.Visible = false;
            pnlPricing.Visible = true;
            pnlPricing.Top = locPricing;

            //get parked duration (from booking to checkout)
            bookDuration = getDuration();

            //Calculate Postpaid Price (Discounted)
            if (bookDuration < 1)
                totalPrice = minPrice - minPrice*0.1f;
            else
                totalPrice = minPrice + hrPrice* bookDuration;

            //Change Status of booking in DB
            UpdateStatus();

            //Get Wallet Balance
            walletBal = getbalance();

            //Update the Bill Labels
            updateLabelsPricing();
        }

        //Update the Bill Labels
        private void updateLabelsPricing()
        {
            lblBalance.Text = "" + walletBal;
            lblDuration.Text = "" + bookDuration;
            lblPrice.Text = "" + totalPrice;
        }

        private void frmPostpaidConfirm_Resize(object sender, EventArgs e)
        {
            locCheckout = lblCheckoutMarker.Top;
            locPricing = lblPricingMarker.Top;
        }

        private void lblConfirm_Click(object sender, EventArgs e)
        {
            if (walletBal < totalPrice)
            {
                pnlPricing.Visible = false;
                pnlWallet.Visible = true;
                pnlWallet.Top = locPricing;
            }
            else
            {
                newWalletBal = walletBal - totalPrice;
                updateWalletBalance(newWalletBal);
                openChildForm(new frmBookingConfirmed());
            }
           
        }

        private void lnkAddMoney_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlPricing.Visible = false;
            pnlWallet.Visible = true;
            pnlWallet.Top = locPricing;
        }


        private void lblLoadMoney_Click(object sender, EventArgs e)
        {
            //Add New Balance to existing wallet balance
            float newLoadedBalance = float.Parse(txtAddBal.Text) + walletBal;

            //Update the wallet balance
            updateWalletBalance(newLoadedBalance);

            //Reset wallet balance 
            walletBal = getbalance();
            lblBalance.Text = "" + walletBal;

            MessageBox.Show(pnlPricing, "Wallet Balance Updated!\nNew Balance is: " + walletBal);

            //Show Billing Panel again
            pnlWallet.Visible = false;
            pnlPricing.Visible = true;
            pnlPricing.Top = locPricing;

            //Hide add money link to prevent repeated loading of money
            lblAddMoney.Visible = false;
            lnkAddMoney.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.lblTitle.Text = "Dashboard";

        }
        
        private void frmPostpaidConfirm_Load(object sender, EventArgs e)
        {
            btnClose.Visible = false;
        }

        private int getDuration()
        {

            //Change curTime to around 2hrs from current time for real-time calculation simulation
            DateTime curTime = DateTime.ParseExact("03:45 PM","hh:mm tt",CultureInfo.InvariantCulture);
            outTime = curTime.ToString("hh:mm tt");

            con.Open();
            string getData = "SELECT bk_in_time FROM dbo.tbl_booking WHERE bk_reg_id=" + Program.currentUserID + " AND bk_status='IN'";
            SqlCommand cmd = new SqlCommand(getData, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
                inTime = dr[0].ToString();
            con.Close();
            
            //Console.WriteLine("Intime is: "+ inTime + "\n");
            DateTime oldTime = DateTime.ParseExact(inTime, "hh:mm tt", CultureInfo.InvariantCulture);
            TimeSpan ts = curTime.Subtract(oldTime);
            int hrs = ts.Hours;
            if (hrs < 1)
                return 0;
            else
                return hrs+(ts.Minutes>0?1:0);


        }

        //Update wallet balance
        //Compare wallet balance before booking success
        private void UpdateStatus()
        {
            con.Open();
            string setData = "UPDATE dbo.tbl_booking SET bk_out_time = '"+outTime+"',bk_duration = '"+bookDuration+"',bk_total_price = '"+totalPrice+"',bk_status = 'OUT' WHERE bk_reg_id = '"+Program.currentUserID+"' AND bk_status = 'IN'";
            SqlCommand cmd = new SqlCommand(setData, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private float getbalance()
        {
            float balance = 0.0f;
            con.Open();
            string getBal = "SELECT reg_walletbalance FROM dbo.tbl_registration WHERE reg_mid = " + Program.currentUserID;
            SqlCommand cmd = new SqlCommand(getBal, con);
            SqlDataReader dr =  cmd.ExecuteReader();
            if (dr.Read())
                balance = float.Parse(dr[0].ToString());
            con.Close();
            return balance;
        }

        private void updateWalletBalance(float newWalletBal)
        {
            con.Open();
            string setBal = "UPDATE dbo.tbl_registration SET reg_walletbalance = "+newWalletBal+" WHERE reg_mid = " + Program.currentUserID;
            SqlCommand cmd = new SqlCommand(setBal, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
