using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace ParkIT
{
    public partial class frmStatPostpaid : Form
    {
        SqlConnection con = new SqlConnection(Program.strConn);
        private String query = "SELECT reg_fname + ' ' + reg_lname AS 'Full Name',bk_slotnum AS 'Slot Num',bk_veh_type AS 'Vehicle Type',bk_veh_num AS 'Vehicle Num',bk_date AS 'Date',bk_in_time AS 'In Time',bk_out_time AS 'Out Time',bk_duration AS 'Duration',bk_total_price AS 'Price',bk_status AS 'Status' FROM dbo.tbl_booking B INNER JOIN dbo.tbl_registration R ON bk_reg_id = reg_mid;";
        private int totalBookings = 0;

        private BindingSource bindingSource1 = new BindingSource();

        public frmStatPostpaid()
        {
            InitializeComponent();
            GetData(query);
            dgvPostpaid.DataSource = bindingSource1;
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
                dgvPostpaid.AutoResizeColumns(
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
