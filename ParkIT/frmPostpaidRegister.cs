using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ParkIT
{
    public partial class frmPostpaidRegister : Form
    {
        SqlConnection con = new SqlConnection(Program.strConn);
        string emailID ="";

        public frmPostpaidRegister()
        {
            InitializeComponent();
            setColor(lblSignup);
        }

        //Variables
        private int leftLoc;
        private Form activeForm = null;
       
        //Methods
        private void setColor(Label obj)
        {
            obj.BackColor = Color.DarkKhaki;
            obj.ForeColor = Color.WhiteSmoke;
        }

        private void resetColor(Label obj)
        {
            obj.BackColor = Color.LemonChiffon;
            obj.ForeColor = Color.Navy;
        }
        
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

        //Events
        private void lblSignup_Click(object sender, EventArgs e)
        {
            pnlSignup.Visible = true;
            pnlSignin.Visible = false;
            pnlSignup.Left = leftLoc;
            setColor(lblSignup);
            resetColor(lblSignin);
        }

        private void lblSignin_Click(object sender, EventArgs e)
        {
            pnlSignin.Visible = true;
            pnlSignup.Visible = false;
            pnlSignin.Left = leftLoc;
            setColor(lblSignin);
            resetColor(lblSignup);
        }

        private void frmPostpaid_Resize(object sender, EventArgs e)
        {
            leftLoc = pnlSignup.Left;
        }
        
        private void lblLoadMoney_Click(object sender, EventArgs e)
        {
            if (funLoadMoney())
            {
                pnlWallet.Visible = false;
                MessageBox.Show(pnlWallet, "Money added to Wallet!\nSign In to Continue");
                pnlSignin.Visible = true;
                pnlSignin.Left = leftLoc;
            }
        }

        private bool funLoadMoney()
        {
            con.Open();
            string loadMoney = "UPDATE dbo.tbl_registration SET reg_walletbalance='" + txtWalletMoney.Text + "' WHERE reg_email = '"+emailID+"'";
            SqlCommand cmd = new SqlCommand(loadMoney, con);
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            if (funRegister())
            {
                emailID = txtEmail.Text;
                lblSignin.Visible = false;
                lblSignup.Visible = false;
                pnlSignup.Visible = false;
                MessageBox.Show(pnlSignup, "Registration Successful!");
                pnlWallet.Visible = true;
                pnlWallet.Left = leftLoc;
            }
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            if (fnUserExists())
            {
           
                pnlSignin.Visible = false;
                pnlSignup.Visible = false;
                lblSignin.Visible = false;
                lblSignup.Visible = false;
                Program.isLoggedIn = true;
                Program.currentUserName = txtLoginId.Text;
                Program.currentPassword = txtLoginPassword.Text;
                openChildForm(new frmPostpaidDetails());
            }
            else
            {
                MessageBox.Show("Username or Password does not exist!","Incorrect Details");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.lblTitle.Text = "Dashboard";

        }

        private bool fnUserExists()
        { 
           
            con.Open();
            string chkUser = "SELECT reg_mid,reg_email,reg_password FROM dbo.tbl_registration WHERE reg_email = '" + txtLoginId.Text + "' AND reg_password = '"+txtLoginPassword.Text+"'";
            SqlCommand cmd = new SqlCommand(chkUser, con);
            SqlDataReader dr = cmd.ExecuteReader();
            
            if (dr.Read())
            {
                
                Program.currentUserID = dr.GetInt32(0);
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }


        private bool funRegister()
        {

            if (funValidate())
            {
                con.Open();
                string addUser = "INSERT INTO dbo.tbl_registration VALUES ('" + txtFname.Text + "', '" + txtLname.Text + "','" + txtEmail.Text + "', '" + txtPassword.Text + "', '" + txtPhone.Text + "','0.0','1')";
                SqlCommand cmd = new SqlCommand(addUser, con);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            else
                return false;
        }

        static Regex Valid_FName = Program.StringOnly();
        static Regex Valid_LName = Program.StringOnly();
        static Regex Valid_Email = Program.EmailOnly();
        static Regex Valid_Password = Program.PasswordOnly();
        static Regex Valid_Phone = Program.NumberOnly();


        private bool funValidate()
        {
            //for Fname
            if (Valid_FName.IsMatch(txtFname.Text) != true)
            {
                MessageBox.Show("FName accepts only alphabetical characters", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtFname.Focus();
                return false;
            }

            //for Lname
            if (Valid_LName.IsMatch(txtLname.Text) != true)
            {
                MessageBox.Show("LName accepts only alphabetical characters", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtLname.Focus();
                return false;
            }

            //for Phone 
            if (Valid_Phone.IsMatch(txtPhone.Text) != true)
            {
                MessageBox.Show("Phone accepts numbers only.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPhone.Focus();
                return false;
            }
            
            //for Password 
            if (Valid_Password.IsMatch(txtPassword.Text) != true)
            {
                MessageBox.Show("Password must be atleast 8 to 15 characters. It must contain atleast one Upper case letter and at least one Number.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPassword.Focus();
                return false;
            }

            if (!isUnique(txtEmail.Text))
            {
                MessageBox.Show("Email already exists! Use another Email or Sign In to Continue","Email Exists");
                txtEmail.Focus();
                return false;
            }


            //for Email Address 
            if (Valid_Email.IsMatch(txtEmail.Text) != true)
            {
                MessageBox.Show("Invalid Email Address!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEmail.Focus();
                return false;
            }
            
            return true;
        }

        private void txtConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtConfirmPassword.Text = "";
                
                
            }
        }

        private bool isUnique(string email)
        {
            con.Open();
            string chkEmail = "SELECT reg_email FROM dbo.tbl_registration WHERE reg_email = '" + email + "'";
            SqlCommand cmd = new SqlCommand(chkEmail, con);
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

        private void txtLoginId_Leave(object sender, EventArgs e)
        {
            //for Email Address 
            if (Valid_Email.IsMatch(txtLoginId.Text) != true)
            {
                MessageBox.Show("Invalid Email Address!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtLoginId.Focus();
            }
            
        }

        private void txtLoginPassword_Leave(object sender, EventArgs e)
        {
            //for Password 
            if (Valid_Password.IsMatch(txtLoginPassword.Text) != true)
            {
                MessageBox.Show("Password must be atleast 8 to 15 characters. It must contain atleast one Upper case letter and at least one Number.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtLoginPassword.Focus();

            }
        }
    }
}
