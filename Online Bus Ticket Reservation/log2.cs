using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Online_Bus_Ticket_Reservation
{
    internal class log2
    {


        static string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;

        //for user
        
        public string password { get; set; }

        public int LogIn(log2 U)
        {
            SqlConnection con = new SqlConnection(connectionString);

            //user ancount login 
            try
            {
                SqlCommand cmd = new SqlCommand(" Select * from admin where password = '" + U.password + "' ", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    return 1;
                }
                else
                {
                    return -1;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error", ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return 0;
        }

    }


}








