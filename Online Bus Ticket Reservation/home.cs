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
    public partial class home : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-0D3AF2C;Initial Catalog=bus;Integrated Security=True;");

        public home()
        {
            InitializeComponent();
        }
   
        private void home_Load(object sender, EventArgs e)
        {
           RefreshDatat();
           
        }
        public void RefreshDatat()
        {
           
            SqlCommand cmd = new SqlCommand("select * from SCHE_SCH1 ", con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        public void combocity()
        {
            SqlCommand cmd = new SqlCommand("select * from SCHE_SCH1 where Depature = '" + comboBox3.SelectedItem.ToString() +"' ", con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void combocity1()
        {
            SqlCommand cmd = new SqlCommand("select * from SCHE_SCH1 where Arrival = '" + comboBox2.SelectedItem.ToString() + "' ", con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
        }
 
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 log = new Form1();
            log.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            createacc Create = new createacc();
            Create.Show();
            this.Close();    
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            combocity();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            combocity1();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RefreshDatat();
           
            comboBox2.Text = String.Empty;
            comboBox3.Text = String.Empty;
        }

     
    }
}
