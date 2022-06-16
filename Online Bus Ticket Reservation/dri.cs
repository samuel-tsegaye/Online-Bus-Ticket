using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Online_Bus_Ticket_Reservation
{
    internal class dri
    {


        static string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;

      
        public string username { get; set; }
        public string password { get; set; }

        public int LogIn(dri U)
        {
            SqlConnection con = new SqlConnection(connectionString);

            try
            {
                SqlCommand cmd = new SqlCommand(" Select * from dri_acc1 where user_name = '" + U.username + "' and password = '" + U.password + "' ", con);
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








