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

namespace Online_Bus_Ticket_Reservation
{

    public partial class usercreateacc : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-0D3AF2C;Initial Catalog=bus;Integrated Security=True;");

        public usercreateacc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                SqlCommand cmd = new SqlCommand("INSERT INTO User_acc1 VALUES(" + phone.Text + ", '" + username.Text + "', '" + password.Text + "')", con);
                SqlDataReader dr;


                try
                {

                    con.Open();

                    dr = cmd.ExecuteReader();
                    MessageBox.Show("Congratulation!\n Your Account Has Been Successfully Created...");
                    Form1 op =  new Form1();
                    op.Show();
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
    }
}


