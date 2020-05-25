using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRental_Navjit
{
    public partial class Customers : Form
    {
        public String appsetting = System.Configuration.ConfigurationManager.ConnectionStrings["connection"].ToString();
        SqlConnection sqlConnection = new SqlConnection();
        public Customers()
        {
            InitializeComponent();
            GetCustomerList();
        }

        private void GetCustomerList()
        {
            sqlConnection = new SqlConnection(appsetting);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            //Here I am definied command type is Stored Procedure.
            cmd.CommandType = CommandType.StoredProcedure;
            //Here I mentioned the Stored Procedure Name.
            cmd.CommandText = "SPGetCustomerList";
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dGWCustomerList.DataSource = dt;

        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(appsetting);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            //Here I am definied command type is Stored Procedure.
            cmd.CommandType = CommandType.StoredProcedure;
            //Here I mentioned the Stored Procedure Name.
            cmd.CommandText = "SPInsertUpdateCustomer";
            //Here I fix the variable values to Stored Procedure Parameters. You can easily understand if you can see the Stored Procedure Code.
            cmd.Parameters.Add(new SqlParameter("@FirstName", SqlDbType.NVarChar)).Value = textBoxFirstName.Text;
            cmd.Parameters.Add(new SqlParameter("@LastName", SqlDbType.NVarChar)).Value = textBoxLastName.Text;
            cmd.Parameters.Add(new SqlParameter("@Address", SqlDbType.NVarChar)).Value = textBoxAddress.Text;
            cmd.Parameters.Add(new SqlParameter("@Phone", SqlDbType.NVarChar)).Value = textBoxPhoneNumber.Text;
            MessageBox.Show("Customer added successfully");
            GetCustomerList();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            sqlConnection.Close();
        }


        private void buttonUpdateCustomer_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(appsetting);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            //Here I am definied command type is Stored Procedure.
            cmd.CommandType = CommandType.StoredProcedure;
            //Here I mentioned the Stored Procedure Name.
            cmd.CommandText = "SPInsertUpdateCustomer";
            //Here I fix the variable values to Stored Procedure Parameters. You can easily understand if you can see the Stored Procedure Code.
            cmd.Parameters.Add(new SqlParameter("@FirstName", SqlDbType.NVarChar)).Value = textBoxFirstName.Text;
            cmd.Parameters.Add(new SqlParameter("@LastName", SqlDbType.NVarChar)).Value = textBoxLastName.Text;
            cmd.Parameters.Add(new SqlParameter("@Address", SqlDbType.NVarChar)).Value = textBoxAddress.Text;
            cmd.Parameters.Add(new SqlParameter("@Phone", SqlDbType.NVarChar)).Value = textBoxPhoneNumber.Text;
            cmd.Parameters.Add(new SqlParameter("@CustID", SqlDbType.NVarChar)).Value = textBoxCustID.Text;
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxAddress.Text = "";
            textBoxPhoneNumber.Text = "";
            textBoxCustID.Text = "";
            MessageBox.Show("Customer updated successfully");
            GetCustomerList();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            sqlConnection.Close();
        }

        private void buttonDeleteCustomer_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(appsetting);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            //Here I am definied command type is Stored Procedure.
            cmd.CommandType = CommandType.StoredProcedure;
            //Here I mentioned the Stored Procedure Name.
            cmd.CommandText = "SPDeleteCustomers";
            cmd.Parameters.Add(new SqlParameter("@customerID", SqlDbType.NVarChar)).Value = textBoxCustID.Text;
            int numRes = cmd.ExecuteNonQuery();
            if (numRes > 0)
            {
                MessageBox.Show("Record Deleted Successfully !!!");
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxAddress.Text = "";
                textBoxPhoneNumber.Text = "";
                textBoxCustID.Text = "";
                GetCustomerList();
            }
            else
            {
                MessageBox.Show("Please Try Again !!!");
            }

        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            RentalVideos _tabs = new RentalVideos();
            _tabs.ShowDialog();
        }

        private void dGWCustomerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dGWCustomerList.Rows[e.RowIndex];
                textBoxCustID.Text = row.Cells[0].Value.ToString();
                textBoxFirstName.Text = row.Cells[1].Value.ToString();
                textBoxLastName.Text = row.Cells[2].Value.ToString();
                textBoxAddress.Text = row.Cells[3].Value.ToString();
                textBoxPhoneNumber.Text = row.Cells[4].Value.ToString();
            }
        }
    }
}
