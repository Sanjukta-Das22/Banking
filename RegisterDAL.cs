using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BankLibrary
{
   public class RegisterDAL
    {
        string constring = "Data Source=LAPTOP-825A6PK0\\SQLEXPRESS;Initial Catalog=Banking;Integrated Security=True";
        public  void GetDetails(Registration obj )
        {
            using(SqlConnection con=new SqlConnection(constring))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("dbo.SaveChanges",con);
                cmd.CommandType =CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Account_No", obj.Account_No);
                cmd.Parameters.AddWithValue("@Account_Name", obj.Account_Name);
                cmd.Parameters.AddWithValue("@Mobile_No", obj.Mobile_No);
                cmd.Parameters.AddWithValue("@Email", obj.Email);
                cmd.Parameters.AddWithValue("Password", obj.Password);
                cmd.Parameters.AddWithValue("@Address", obj.Address);
                cmd.Parameters.AddWithValue("@Bank_Branch", obj.Bank_Branch);
                cmd.Parameters.AddWithValue("@IFSC", obj.IFSC);

                 cmd.ExecuteNonQuery();
                con.Close();

                
            }

            
           
        }
    }
}
