using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ParkIT
{
    public partial class frmPostpaidDetails : Form
    {
        SqlConnection con = new SqlConnection(Program.strConn);
        
        int slot_num = 0;
        string date = "";
        string inTime = "";
        string vehType = "";
        string vehNumber = "";
        

        public frmPostpaidDetails()
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

        static bool isClicked = false;
        private void lblContinue_Click(object sender, EventArgs e)
        {

            
            if (validateEntry() && !isClicked && validateInputs())
            {
                con.Open();
                string bookPostPaid = "INSERT INTO dbo.tbl_booking(bk_reg_id,bk_slotnum,bk_date,bk_in_time,bk_veh_type,bk_veh_num,bk_status) VALUES(" + Program.currentUserID + "," + slot_num + ",'" + date + "','" + inTime + "','" + vehType + "','" + txtVehicleno.Text + "','IN')";
                SqlCommand cmd = new SqlCommand(bookPostPaid, con);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Close();
                cmd.Dispose();
                con.Close();
                isClicked = true;
                openChildForm(new frmPostpaidConfirm());
            }
            else
            {
                MessageBox.Show("Only one booking allowed at a time. Please Checkout!", "Already Parked!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                openChildForm(new frmPostpaidConfirm());
            }
        }

      

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.lblTitle.Text = "Dashboard";
        }

        private void frmPostpaidDetails_Load(object sender, EventArgs e)
        {
            
            if (!validateEntry())
            {
                this.Visible = false;
                MessageBox.Show("Only one booking allowed at a time. Please Checkout!", "Already Parked!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                openChildForm(new frmPostpaidConfirm());
            }
            else
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
                dtInTime.Value = DateTime.Now;
            }
        }
           
        private bool validateInputs()
        {
            if (txtVehicleno.Text == "")
            {
                con.Close();
                return false;
            }
            if (cbVehType.SelectedItem == null)
            {
                con.Close();
                return false;
            }
            if (cmbSlots.SelectedItem == null)
            {
                con.Close();
                return false;
            }
            con.Close();
            return true;
        }
        private bool validateEntry()
        {

            con.Open();
            string getData = "SELECT * FROM dbo.tbl_booking WHERE bk_reg_id=" + Program.currentUserID + " AND bk_status='IN'";
            SqlCommand cmd = new SqlCommand(getData, con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                con.Close();
                return false;
            }
            else
            {
                con.Close();
                return true;
            }
        }

        private void dtInDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime curDate = DateTime.Today;
            DateTime inDate = dtInDate.Value;
            if (DateTime.Compare(inDate,curDate)<0)
            {
                dtInDate.Focus();
                MessageBox.Show("Invalid Date", "Error!");
            }
            else
            {
                date = inDate.ToString("yyyy-MM-dd");
               
            }
        }

        private void cmbSlots_SelectionChangeCommitted(object sender, EventArgs e)
        {
            slot_num = int.Parse(cmbSlots.SelectedItem.ToString());
            
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
                MessageBox.Show("Invalid Time", "Error!");
            }
            else
            {
                inTime = objInTime.ToString("hh:mm tt");
            }
        }

        private void cbVehType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            vehType = cbVehType.SelectedItem.ToString();
        }

        private void txtVehicleno_Leave(object sender, EventArgs e)
        {
            vehNumber = txtVehicleno.Text;
        }
    }
}
