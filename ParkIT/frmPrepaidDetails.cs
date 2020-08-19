using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ParkIT
{
    public partial class frmPrepaidDetails : Form
    {
        SqlConnection con = new SqlConnection(Program.strConn);

        
        string fName = "";
        string lName = "";
        string phNum = "";
        string vehType = "";
        string vehNumber = "";
        string remark = "";
        string address = "";
        public frmPrepaidDetails()
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
        private void lblContinue_Click(object sender, EventArgs e)
        {
            if (validateInputs())
            {
                con.Open(); 
                string regPrePaid = "INSERT INTO dbo.tbl_preregistration VALUES('" + fName + "','" + lName + "','" + phNum + "','" + vehType + "','" + vehNumber + "','" + remark+"','" + txtAddress.Text +"',1)";
                SqlCommand cmd = new SqlCommand(regPrePaid, con);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Close();
                cmd.Dispose();

                string getMid = "SELECT pre_mid FROM dbo.tbl_preregistration WHERE pre_fname = '"+fName+"' AND pre_lname='"+lName+"' AND pre_phn='"+phNum+"' AND pre_vnum = '"+vehNumber+"' AND pre_aflag=1";
                cmd = new SqlCommand(getMid, con);
                dr = cmd.ExecuteReader();
                if(dr.Read())
                    Program.currentPreUserID = int.Parse(dr[0].ToString());
                dr.Close();
                cmd.Dispose();
                con.Close();
               
                openChildForm(new frmPrepaidConfirm());
            }
            else
            {
                MessageBox.Show("Fill the details properly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
        }

       

        private bool validateInputs()
        {
            if (txtFname.Text == "")
            {
                con.Close();
                return false;
            }
            if (txtLname.Text == "")
            {
                con.Close();
                return false;
            }
            if (txtPhone.Text == "")
            {
                con.Close();
                return false;
            }
            if (txtVehicleno.Text == "")
            {
                con.Close();
                return false;
            }
            if (cmbVehType.SelectedItem == null)
            {
                con.Close();
                return false;
            }
            if (txtRemarks.Text == "")
            {
                con.Close();
                return false;
            }
            if (txtAddress.Text == "")
            {
                con.Close();
                return false;
            }
            con.Close();
            return true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.lblTitle.Text = "Dashboard";
        }

        private void txtVehicleno_Leave(object sender, EventArgs e)
        {
            vehNumber = txtVehicleno.Text;
        }

        private void txtFname_Leave(object sender, EventArgs e)
        {
            fName = txtFname.Text;
     
        }

        private void txtLname_Leave(object sender, EventArgs e)
        {
            lName = txtLname.Text;
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            phNum = txtPhone.Text;
        }

        private void cmbVehType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            vehType = cmbVehType.SelectedItem.ToString();
        }

        private void txtRemarks_Leave(object sender, EventArgs e)
        {
            remark = txtRemarks.Text;         
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            address = txtAddress.Text;
        }
    }
}
