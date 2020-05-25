using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject_Navjit
{
    [TestClass]
    public class UnitTest1
    {
        public String appsetting = System.Configuration.ConfigurationManager.ConnectionStrings["connection"].ToString();
        SqlConnection sqlConnection = new SqlConnection();
        [TestMethod]
        public void TestMethod1()
        {
            var loginID = "admin";
            var password = "Admin@12344";

            DataTable dt = new DataTable();
            sqlConnection = new SqlConnection(appsetting);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            //Here I am definied command type is Stored Procedure.
            cmd.CommandType = CommandType.StoredProcedure;
            //Here I mentioned the Stored Procedure Name.
            cmd.CommandText = "SPUserLogin";
            //Here I fix the variable values to Stored Procedure Parameters. You can easily understand if you can see the Stored Procedure Code.
            cmd.Parameters.Add(new SqlParameter("@userid", SqlDbType.NVarChar)).Value = loginID;
            cmd.Parameters.Add(new SqlParameter("@pwd", SqlDbType.NVarChar)).Value = password;
            int usercount = (Int32)cmd.ExecuteScalar();// for taking single value
            if (usercount > 0)
                Assert.IsTrue(true);
            else
                Assert.IsFalse(false);
        }
    }
}
