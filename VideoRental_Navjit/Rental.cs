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
    public partial class Rental : Form
    {
        public String appsetting = System.Configuration.ConfigurationManager.ConnectionStrings["connection"].ToString();
        SqlConnection sqlConnection = new SqlConnection();
        public Rental()
        {
            InitializeComponent();
            GetCustomerList();
            GetMovieList();
            GetRentalList();
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

        private void GetMovieList()
        {
            sqlConnection = new SqlConnection(appsetting);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            //Here I am definied command type is Stored Procedure.
            cmd.CommandType = CommandType.StoredProcedure;
            //Here I mentioned the Stored Procedure Name.
            cmd.CommandText = "SPGetMovieList";
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dGWMovieList.DataSource = dt;

        }

        private void GetRentalList()
        {
            sqlConnection = new SqlConnection(appsetting);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            //Here I am definied command type is Stored Procedure.
            cmd.CommandType = CommandType.StoredProcedure;
            //Here I mentioned the Stored Procedure Name.
            cmd.CommandText = "SPGetRentalList";
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgWMovieRentalList.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(appsetting);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            //Here I am definied command type is Stored Procedure.
            cmd.CommandType = CommandType.StoredProcedure;
            //Here I mentioned the Stored Procedure Name.
            cmd.CommandText = "SPInsertRentalIssueMovie";
            //Here I fix the variable values to Stored Procedure Parameters. You can easily understand if you can see the Stored Procedure Code.
            cmd.Parameters.Add(new SqlParameter("@customerID", SqlDbType.NVarChar)).Value = textCustID.Text;
            cmd.Parameters.Add(new SqlParameter("@movieID", SqlDbType.NVarChar)).Value = textBoxMovieID.Text;
            MessageBox.Show("Movie rented to the customer");
            GetRentalList();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            sqlConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(appsetting);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            //Here I am definied command type is Stored Procedure.
            cmd.CommandType = CommandType.StoredProcedure;
            //Here I mentioned the Stored Procedure Name.
            cmd.CommandText = "SPUpdateRentalReturnMovie";
            //Here I fix the variable values to Stored Procedure Parameters. You can easily understand if you can see the Stored Procedure Code.
            cmd.Parameters.Add(new SqlParameter("@rentalID", SqlDbType.NVarChar)).Value = textBoxRentalID.Text;
            MessageBox.Show("Movie rented to the customer");
            GetRentalList();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            sqlConnection.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            RentalVideos _tabs = new RentalVideos();
            _tabs.ShowDialog();
        }

        private void radioButtonAllRented_CheckedChanged(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(appsetting);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            //Here I am definied command type is Stored Procedure.
            cmd.CommandType = CommandType.StoredProcedure;
            //Here I mentioned the Stored Procedure Name.
            cmd.CommandText = "GetMoviesRentalList";
            //Here I fix the variable values to Stored Procedure Parameters. You can easily understand if you can see the Stored Procedure Code.
            cmd.Parameters.Add(new SqlParameter("@rentalType", SqlDbType.NVarChar)).Value = "A";
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dGWMovieList.DataSource = dt;
        }

        private void radioButtonOutRented_CheckedChanged(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(appsetting);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            //Here I am definied command type is Stored Procedure.
            cmd.CommandType = CommandType.StoredProcedure;
            //Here I mentioned the Stored Procedure Name.
            cmd.CommandText = "GetMoviesRentalList";
            //Here I fix the variable values to Stored Procedure Parameters. You can easily understand if you can see the Stored Procedure Code.
            cmd.Parameters.Add(new SqlParameter("@rentalType", SqlDbType.NVarChar)).Value = "O";
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dGWMovieList.DataSource = dt;
        }

        private void dgWMovieRentalList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dgWMovieRentalList.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                textBoxRentalID.Text = row.Cells[0].Value.ToString();
                textBoxFName.Text = row.Cells[1].Value.ToString();
                textBoxLName.Text = row.Cells[2].Value.ToString();
                textBoxRentalCost.Text = row.Cells[5].Value.ToString();
            }
        }

        private void dGWCustomerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dGWCustomerList.Rows[e.RowIndex];
            textCustID.Text = row.Cells[0].Value.ToString();
            textBoxFName.Text = row.Cells[1].Value.ToString();
            textBoxLName.Text = row.Cells[2].Value.ToString();
        }

        private void dGWMovieList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dGWMovieList.Rows[e.RowIndex];
            textBoxMovieID.Text = row.Cells[0].Value.ToString();
            textBoxTitle.Text = row.Cells[1].Value.ToString();
            textBoxGenre.Text = row.Cells[2].Value.ToString();
            textBoxRentalCost.Text = row.Cells[3].Value.ToString();
            textBoxPlot.Text = row.Cells[4].Value.ToString();
        }

        private void Rental_Load(object sender, EventArgs e)
        {

        }
    }
}
