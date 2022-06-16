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
    public partial class driverscreen : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-0D3AF2C;Initial Catalog=bus;Integrated Security=True;");

        public driverscreen()
        {
            InitializeComponent();
        }
       
        private void driverscreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'busDataSet23.SCHE_SCH1' table. You can move, or remove it, as needed.
            this.sCHE_SCH1TableAdapter1.Fill(this.busDataSet23.SCHE_SCH1);
            RefreshDatat();


            SqlCommand cmd = new SqlCommand("select plate From DRI_INFO", con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            comboBox4.DataSource = dt;
            comboBox4.SelectedItem = " ";
            comboBox4.DisplayMember = "plate";

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            home home = new home();
            home.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RefreshDatat();
            comboBox4.Text = String.Empty;
           
        }
   

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            combocity();
        }
        public void RefreshDatat()
        {
            SqlCommand cmd = new SqlCommand("Select * from SCHE_SCH1 ", con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void combocity()
        {
            SqlCommand cmd = new SqlCommand("Select * from SCHE_SCH1 where Car_plate = '" + comboBox4.SelectedItem.ToString() + "' ", con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
