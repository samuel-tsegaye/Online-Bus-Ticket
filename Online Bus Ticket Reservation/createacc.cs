using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Online_Bus_Ticket_Reservation
{
    public partial class createacc : Form
    {
        
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-0D3AF2C;Initial Catalog=bus;Integrated Security=True;");
        public createacc()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO User_info VALUES('" + firstname.Text + "', '" + lastname.Text + "', '" + email.Text + "'," + phone.Text + ",@city)", con);
            SqlDataReader dr;


            try
            {

                con.Open();
                cmd.Parameters.AddWithValue("@city", comboBox2.Text.ToString());
                dr = cmd.ExecuteReader();
                MessageBox.Show("Your Registration Has Been\n Successfully Completed");
                usercreateacc acc = new usercreateacc();
                acc.Show();
                this.Close();   

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
      
    }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
            home log = new home();
            log.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void createacc_Load(object sender, EventArgs e)
        {
          
      
        }
    }
}
