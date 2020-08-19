using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
namespace ParkIT
{
    public partial class frmPrepaidConfirm : Form
    {

        SqlConnection con = new SqlConnection(Program.strConn);

        static float MIN_PRICE = 30.0f;
        int slot_num = 0,duration;
        string date,inTime,outTime;
        float price = MIN_PRICE;
        public frmPrepaidConfirm()
        {
            InitializeComponent();
            dtInTime.Value = DateTime.Now;
            DtOutTime.Value = DateTime.Now;
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

        private void lblContinue_Click(object sender, EventArgs e)
        {
            lblContinue.BackColor = Color.ForestGreen;

            con.Open();


            string insertData = "INSERT INTO dbo.tbl_pre_confirm VALUES ("+slot_num+",'"+date+"','"+inTime+"','"+outTime+"',"+price+","+Program.currentPreUserID+",1)";
            SqlCommand cmd = new SqlCommand(insertData, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();

            con.Close();
            openChildForm(new frmBookingConfirmed());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.lblTitle.Text = "Dashboard";
        }

        private void frmPrepaidConfirm_Load(object sender, EventArgs e)
        {
            ComboBox obj = cmbSlots;
            con.Open();
            string slotData = "SELECT slt_num FROM dbo.tbl_slots WHERE slt_status=1 AND slt_aflag=1";
            SqlCommand cmd = new SqlCommand(slotData, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                obj.Items.Add(dr.GetInt32(0));
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
        }

        private void cmbSlots_SelectionChangeCommitted(object sender, EventArgs e)
        {
            slot_num = int.Parse(cmbSlots.SelectedItem.ToString());

        }

        private void dtDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime curDate = DateTime.Today;
            DateTime inDate = dtDate.Value;
            if (DateTime.Compare(inDate, curDate) < 0)
            {
                dtDate.Focus();
                MessageBox.Show(this, "Cannot choose a date from past", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                date = inDate.ToString("yyyy-MM-dd");

            }
        }

        private void dtInTime_ValueChanged(object sender, EventArgs e)
        {
            DateTime objInTime = dtInTime.Value;
            DateTime objCurTime = DateTime.Now;
            DateTime objCurDate = DateTime.Today;
            if (DateTime.Compare(objInTime, objCurDate) < 0 && DateTime.Compare(objInTime, objCurTime) < 0)
            {
                dtInTime.Focus();
                dtInTime.Value = DateTime.Now;
                MessageBox.Show(this, "Choose a time from now!", "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                inTime = objInTime.ToString("hh:mm tt");
            }
        }

        private void DtOutTime_ValueChanged(object sender, EventArgs e)
        {
            DateTime objOutTime = DtOutTime.Value;
            DateTime objInTime = dtInTime.Value;
            if (DateTime.Compare(objOutTime, objInTime) < 0)
            {
                DtOutTime.Focus();
                DtOutTime.Value = DateTime.Now;
                MessageBox.Show(this, "Choose a time after In Time for Checkout", "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                outTime = objOutTime.ToString("hh:mm tt");
            }

        }

        private void lblCalc_Click(object sender, EventArgs e)
        {
            lblCalc.Visible = false;

            //Calculate duration, price and set the price label
            duration = getDuration();
            if (duration > 1)
                price = duration * MIN_PRICE;
            lblPrice.Text = "" + price;
            lblPrice.Visible = true;
        }

        //Get Duration
        private int getDuration()
        {

            DateTime exitTime = DateTime.ParseExact(outTime, "hh:mm tt", CultureInfo.InvariantCulture);
            DateTime enterTime = DateTime.ParseExact(inTime, "hh:mm tt", CultureInfo.InvariantCulture);

            TimeSpan ts = exitTime.Subtract(enterTime);
            int hrs = ts.Hours;
            if (hrs < 1)
                return 0;
            else
                return hrs + (ts.Minutes > 0 ? 1 : 0);


        }
    }
}
