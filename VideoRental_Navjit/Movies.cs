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
    public partial class Movies : Form
    {
        public String appsetting = System.Configuration.ConfigurationManager.ConnectionStrings["connection"].ToString();
        SqlConnection sqlConnection = new SqlConnection();
        public Movies()
        {
            InitializeComponent();
            GetMovieList();
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
            dGWMoviesList.DataSource = dt;

        }


        private void buttonAddMovie_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(appsetting);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            //Here I am definied command type is Stored Procedure.
            cmd.CommandType = CommandType.StoredProcedure;
            //Here I mentioned the Stored Procedure Name.
            cmd.CommandText = "SPInsertUpdateMovies";
            //Here I fix the variable values to Stored Procedure Parameters. You can easily understand if you can see the Stored Procedure Code.
            cmd.Parameters.Add(new SqlParameter("@Title", SqlDbType.NVarChar)).Value = textBoxTitle.Text;
            cmd.Parameters.Add(new SqlParameter("@Rental_Cost", SqlDbType.NVarChar)).Value = textBoxRentalCost.Text;
            cmd.Parameters.Add(new SqlParameter("@Genre", SqlDbType.NVarChar)).Value = textBoxGenre.Text;
            cmd.Parameters.Add(new SqlParameter("@Plot", SqlDbType.NVarChar)).Value = textBoxPlot.Text;
            MessageBox.Show("Movie added successfully");
            GetMovieList();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            sqlConnection.Close();
        }

        private void buttonUpdateMovie_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(appsetting);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            //Here I am definied command type is Stored Procedure.
            cmd.CommandType = CommandType.StoredProcedure;
            //Here I mentioned the Stored Procedure Name.
            cmd.CommandText = "SPInsertUpdateMovies";
            //Here I fix the variable values to Stored Procedure Parameters. You can easily understand if you can see the Stored Procedure Code.
            cmd.Parameters.Add(new SqlParameter("@Title", SqlDbType.NVarChar)).Value = textBoxTitle.Text;
            cmd.Parameters.Add(new SqlParameter("@Rental_Cost", SqlDbType.NVarChar)).Value = textBoxRentalCost.Text;
            cmd.Parameters.Add(new SqlParameter("@Genre", SqlDbType.NVarChar)).Value = textBoxGenre.Text;
            cmd.Parameters.Add(new SqlParameter("@Plot", SqlDbType.NVarChar)).Value = textBoxPlot.Text;
            cmd.Parameters.Add(new SqlParameter("@MovieID", SqlDbType.NVarChar)).Value = textBoxMovieID.Text;
            MessageBox.Show("Movie updated successfully");
            GetMovieList();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            sqlConnection.Close();
        }

        private void buttonDeleteMovie_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(appsetting);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            //Here I am definied command type is Stored Procedure.
            cmd.CommandType = CommandType.StoredProcedure;
            //Here I mentioned the Stored Procedure Name.
            cmd.CommandText = "SPDeleteMovies";
            cmd.Parameters.Add(new SqlParameter("@movieID", SqlDbType.NVarChar)).Value = textBoxMovieID.Text;
            int numRes = cmd.ExecuteNonQuery();
            if (numRes > 0)
            {
                MessageBox.Show("Record Deleted Successfully !!!");
                textBoxTitle.Text = "";
                textBoxRentalCost.Text = "";
                textBoxGenre.Text = "";
                textBoxPlot.Text = "";
                textBoxMovieID.Text = "";
                GetMovieList();
            }
            else
            {
                MessageBox.Show("Please Try Again !!!");
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            RentalVideos _tabs = new RentalVideos();
            _tabs.ShowDialog();
        }

        private void dGWMoviesList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dGWMoviesList.Rows[e.RowIndex];
            textBoxMovieID.Text = row.Cells[0].Value.ToString();
            textBoxTitle.Text = row.Cells[1].Value.ToString();
            textBoxGenre.Text = row.Cells[2].Value.ToString();
            textBoxRentalCost.Text = row.Cells[3].Value.ToString();
            textBoxPlot.Text = row.Cells[4].Value.ToString();
        }

        private void Movies_Load(object sender, EventArgs e)
        {

        }
    }
}
