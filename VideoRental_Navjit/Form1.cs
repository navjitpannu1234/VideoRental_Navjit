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
    public partial class Form1 : Form
    {
        public String appsetting = System.Configuration.ConfigurationManager.ConnectionStrings["connection"].ToString();
        SqlConnection sqlConnection = new SqlConnection();

        public Form1()
        {
            InitializeComponent();
        }

        private void txtLogin_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(appsetting);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            //Here I am definied command type is Stored Procedure.
            cmd.CommandType= CommandType.StoredProcedure;
            //Here I mentioned the Stored Procedure Name.
            cmd.CommandText = "SPUserLogin";
            //Here I fix the variable values to Stored Procedure Parameters. You can easily understand if you can see the Stored Procedure Code.
            cmd.Parameters.Add(new SqlParameter("@userid", SqlDbType.NVarChar)).Value = txtUsername.Text;
            cmd.Parameters.Add(new SqlParameter("@pwd", SqlDbType.NVarChar)).Value = txtPassword.Text;
            int usercount = (Int32)cmd.ExecuteScalar();// for taking single value
            
            if (usercount == 1)  // comparing users from table 
            {
                this.Hide();
                RentalVideos _tabs = new RentalVideos();
                _tabs.ShowDialog();
            }
            else
            {
                txtUsername.Text = "";
                txtPassword.Text = "";
                MessageBox.Show("Login ID and Password is incorrect.");
            }
            
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            sqlConnection.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
