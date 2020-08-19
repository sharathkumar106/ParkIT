using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace ParkIT
{
    public partial class frmStatPrepaid : Form
    {
        SqlConnection con = new SqlConnection(Program.strConn);
        private String query = "SELECT pre_fname + ' ' + pre_lname AS 'Full Name', pre_phn AS 'Phone',pre_vtype AS 'Vehicle Type', pre_vnum AS 'Vehicle Num', prc_slotnum AS 'Slot Num', prc_date AS 'Date', prc_intime AS 'In Time', prc_outtime AS 'Out Time', prc_price AS 'Price', pre_addr AS 'Address', pre_rem AS 'Remarks' FROM db_internproject.dbo.tbl_pre_confirm C INNER JOIN db_internproject.dbo.tbl_preregistration R ON C.prc_premid = R.pre_mid;";
        private int totalBookings = 0;

        private BindingSource bindingSource1 = new BindingSource();

        public frmStatPrepaid()
        {
            InitializeComponent();
            GetData(query);
            dgvPrepaid.DataSource = bindingSource1;
            lblCount.Text = totalBookings.ToString();
            Program.lblTitle.Text = this.Text;
        }

        private void GetData(string selectCommand)
        {
            try
            {

                // Create a new data adapter based on the specified query.
                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand, Program.strConn);

                // Create a command builder to generate SQL update, insert, and
                // delete commands based on selectCommand.
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable
                {
                    Locale = CultureInfo.InvariantCulture
                };
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;
                totalBookings = table.Rows.Count;

                // Resize the DataGridView columns to fit the newly loaded content.
                dgvPrepaid.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
            catch (SqlException)
            {
                MessageBox.Show("Error loading the statistics");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.lblTitle.Text = "Dashboard";
        }
    }
}
