using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Online_Bus_Ticket_Reservation
{
    internal class officerlogin
    {


        static string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;

        //for user
        public string username { get; set; }
        public string password { get; set; }


        public int LogIn(officerlogin U)
        {
            SqlConnection con = new SqlConnection(connectionString);

            //user ancount login 
            try
            {
                SqlCommand cmd = new SqlCommand(" Select * from offacc2 where username = '" + U.username + "' and password = '" + U.password + "' ", con);
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








