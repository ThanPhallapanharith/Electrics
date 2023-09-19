using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ElectricAssignmentyear2.Classes
{
    internal class UserLogin
    {
        public int Id { get; set; } 
        public string UserName { get; set; }
        public string Password { get; set; }

        public bool CheckUser()
        {
            //Declase
            SqlCommand cmd;
            SqlConnection conn;
            bool check = false;
            //input
            using (conn = new SqlConnection(AddConnection.Getconnection()))
            
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
            
            //process
            cmd = new SqlCommand("@SELECT * Id FROM[dbo].[Users] where UserName=@UserName and Passwors=passwords;", conn);
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@Passwords", Password);

            SqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.Read())
            {
                //output
                check = true;
            }
            else
            {
                check = false;
            }
            return check;
        }
        public bool CreateUser()
        {
            //Declase
            bool Create = false;
            SqlCommand cmd;
            SqlConnection conn;
            //input
            using (conn = new SqlConnection(AddConnection.Getconnection()))
            {
                if(conn.State !=System.Data.ConnectionState.Open)
                    conn.Open();
            }
            //process
            cmd = new SqlCommand("@SELECT Id Form [dbo].[Users] where UserName=@UserName and Passwords=@Passwords;", conn);
            cmd.Parameters.AddWithValue("@UserNamme", UserName);
            cmd.Parameters.AddWithValue("@Passwords", Password);
            //Output
            SqlDataReader dataReader = cmd.ExecuteReader();
            if(dataReader.Read())
            {
                Create = true;
            }
            else
            {
                Create = false;
            }

                return Create;
            
        }
    }
}
