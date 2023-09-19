using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricAssignmentyear2.Classes
{
    internal class Employees
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }

        public bool CheckUser()
        {
            bool check = false;
            using (SqlConnection conn = new SqlConnection(AddConnection.Getconnection()))
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                    //MessageBox.Show("Database is connected!");
                }
                SqlCommand cmd = new SqlCommand(@"SELECT [EmpName]FROM[dbo].[Employees] Where EmpNo=@EmpNo", conn);
                cmd.Parameters.AddWithValue("@EmpNo", @EmpNo);

                SqlDataReader sqlDr = cmd.ExecuteReader();
                sqlDr.Read();
                if (sqlDr.HasRows)
                {
                    EmpNo = int.Parse(sqlDr.GetValue(0).ToString());
                    EmpName = sqlDr.GetValue(1).ToString();
                    check = true;
                }
                else
                {
                    check = false;
                }
                return check;
            }
        }
     
    }
}
