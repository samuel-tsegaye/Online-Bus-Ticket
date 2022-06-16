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
    public partial class admin : Form
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-0D3AF2C;Initial Catalog=bus;Integrated Security=True;");
        public admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {

            using(busEntities2 db = new busEntities2())
            {
                ticket1BindingSource1.DataSource = db.ticket1.ToList();
            }



            // TODO: This line of code loads data into the 'ticketdatabase.ticket1' table. You can move, or remove it, as needed.
            this.ticket1TableAdapter.Fill(this.ticketdatabase.ticket1);
            
            // TODO: This line of code loads data into the 'busDataSet17.SCHE_SCH1' table. You can move, or remove it, as needed.
            this.sCHE_SCH1TableAdapter.Fill(this.busDataSet17.SCHE_SCH1);
            // TODO: This line of code loads data into the 'busDataSet15.User_info' table. You can move, or remove it, as needed.
            this.user_infoTableAdapter.Fill(this.busDataSet15.User_info);
            // TODO: This line of code loads data into the 'busDataSet14.User_acc1' table. You can move, or remove it, as needed.
            this.user_acc1TableAdapter.Fill(this.busDataSet14.User_acc1);
            // TODO: This line of code loads data into the 'busDataSet11.dri_acc1' table. You can move, or remove it, as needed.
            this.dri_acc1TableAdapter1.Fill(this.busDataSet11.dri_acc1);
            // TODO: This line of code loads data into the 'busDataSet10.dri_acc1' table. You can move, or remove it, as needed.
            this.dri_acc1TableAdapter.Fill(this.busDataSet10.dri_acc1);

            this.dRI_INFOTableAdapter.Fill(this.busDataSet.DRI_INFO);
            RefreshDataDRi();
            RefreshDataoff();
            RefreshDataDRiacc();
            RefreshDataoffacc();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

    

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

       
        public void clear()
        {
            dri_id.Text = "";
            dri_firstname.Clear();
            dri_lastname.Clear();
            dri_phone.Clear();
            dri_plate.Clear();
        }

   

       
        public void clearoff()
        {
            off_id.Clear();
            off_fname.Clear();
            off_lname.Clear();
            off_phone.Clear();
            off_email.Clear();
        }
       public void RefreshDataoffacc()
        {
            SqlCommand cmd = new SqlCommand("select * from offacc2 ", con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView3.DataSource = dt;
        }
        public void RefreshDataoff()
        {
            SqlCommand cmd = new SqlCommand("select * from OFF_INFO2 ", con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView4.DataSource = dt;
        }
        public void RefreshDataDRi()
        {
            SqlCommand cmd = new SqlCommand("select * from DRI_INFO ", con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void RefreshDataDRiacc()
        {
            SqlCommand cmd = new SqlCommand("select * from dri_acc1 ", con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView2.DataSource = dt;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            home ne = new home();
            ne.Show();
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO DRI_INFO VALUES (" + dri_id.Text + ",'" + dri_firstname.Text + "', '" + dri_lastname.Text + "', '" + dri_phone.Text + "','" + dri_plate.Text + "')", con);
            SqlDataReader dr;
            try
            {

                con.Open();

                dr = cmd.ExecuteReader();
                MessageBox.Show("Driver Information Successfully Added");
                clear();
                while (dr.Read())
                {

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            RefreshDataDRi();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("Delete from DRI_INFO where id =" + this.dri_id.Text + "", con);
            SqlDataReader dr;


            try
            {

                con.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Driver Information Successfully Deleted");
                clear();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            RefreshDataDRi();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            clear();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO dri_acc1 VALUES ("+dri_id1.Text+",'" + dri_user.Text + "', '" + dri_pass.Text + "')", con);
            SqlDataReader dr;


            try
            {

                con.Open();

                dr = cmd.ExecuteReader();
                MessageBox.Show("Driver Account Has Been Successfully Created");
                clear_divacc();
                while (dr.Read())
                {

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            RefreshDataDRiacc();
        }
        public void clear_divacc()
        {
            dri_id1.Text = "";
            dri_user.Text = "";
            dri_pass.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete from dri_acc1 where id =" + this.dri_id1.Text + "", con);
            SqlDataReader dr;


            try
            {

                con.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Driver Account Has Been Successfully Deleted");
                clear_divacc();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            RefreshDataDRiacc();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            clear_divacc();
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO OFF_INFO2 VALUES (" + off_id.Text + ",'" + off_fname.Text + "', '" + off_lname.Text + "', " + off_phone.Text + ",'" + off_email.Text + "')", con);
            SqlDataReader dr;


            try
            {

                con.Open();

                dr = cmd.ExecuteReader();
                MessageBox.Show("Officer Information Successfully Added");
                clearoff();
                while (dr.Read())
                {

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            RefreshDataoff();
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete from OFF_INFO2 where id =" + this.off_id.Text + "", con);
            SqlDataReader dr;


            try
            {

                con.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Officer Information Successfully Deleted");
                clearoff();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            RefreshDataoff();
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE OFF_INFO2 set id = " + off_id.Text + ", firstname = '" + off_fname.Text + "', lastname = '" + off_lname.Text + "', phone = '" + off_phone.Text + "', email = '" + off_email.Text + "')", con);
            SqlDataReader dr;


            try
            {

                con.Open();

                dr = cmd.ExecuteReader();
                MessageBox.Show("Update");

                while (dr.Read())
                {

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            RefreshDataoff();
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            clearoff();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO offacc2 VALUES ("+off_id4.Text+",'"+off_usernam.Text+ "', '" +off_password.Text+ "')", con);
            SqlDataReader dr;


            try
            {

                con.Open();

                dr = cmd.ExecuteReader();
                MessageBox.Show("Officer Account Has Been Successfully Created");
                clear_offacc();
                while (dr.Read())
                {

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            RefreshDataoffacc();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete from offacc2 where id =" + this.off_id4.Text + "", con);
            SqlDataReader dr;


            try
            {

                con.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Officer Account Has Been Successfully Deleted");
                clear_offacc();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            RefreshDataoffacc();
        }
        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
            //dataGridView3.CurrentRow.Selected = true;
            //off_id4.Text = dataGridView3.Rows[e.RowIndex].Cells["id"].Value.ToString();
            //off_usernam.Text = dataGridView3.Rows[e.RowIndex].Cells["username"].Value.ToString();
            //off_password.Text = dataGridView3.Rows[e.RowIndex].Cells["lastname"].Value.ToString();

        }

        private void dataGridView3_Click(object sender, EventArgs e)
        {

           
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if(e.RowIndex >= 0)
            //{
            //    DataGridViewRow row = this.dataGridView3.Rows[e.RowIndex];
            //    off_id4.Text = row.Cells["id"].Value.ToString();
            //    off_usernam.Text = row.Cells["username"].Value.ToString();
            //    off_password.Text = row.Cells["password"].Value.ToString();

            //}
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //dataGridView4.CurrentRow.Selected = true;
            ////off_id.Text = dataGridView4.Rows[e.RowIndex].Cells["id"].Value.ToString();
            //off_fname.Text = dataGridView4.Rows[e.RowIndex].Cells["Username"].Value.ToString();
            //off_lname.Text = dataGridView4.Rows[e.RowIndex].Cells["Lastname"].Value.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            clear_offacc();
        }
        public void clear_offacc()
        {
            off_id4.Text = "";
            off_usernam.Text = "";
            off_password.Text = "";
        }

        private void shprintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap objbmp = new Bitmap(this.dataGridView8.Width, this.dataGridView8.Height);
            dataGridView8.DrawToBitmap(objbmp, new Rectangle(0, 0, this.dataGridView8.Width, this.dataGridView8.Height));

            e.Graphics.DrawImage(objbmp, 0, 60);
            e.Graphics.DrawString(label15.Text, new Font("Comic Sans MS", 22, FontStyle.Bold), Brushes.Black, new Point(120, 20));
        }

        private void button25_Click(object sender, EventArgs e)
        {
            shprintPreviewDialog.Document = shprintDocument;
            shprintPreviewDialog.ShowDialog();
        }

        private void button22_Click(object sender, EventArgs e)
        {
             printPreviewDialog5.Document = printDocument5;
            printPreviewDialog5.ShowDialog();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            printPreviewDialog6.Document = printDocument6;
            printPreviewDialog6.ShowDialog();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            printPreviewDialog7.Document = printDocument7;
            printPreviewDialog7.ShowDialog();
        }

        private void printDocument5_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap objbmp5 = new Bitmap(this.dataGridView5.Width, this.dataGridView5.Height);
            dataGridView5.DrawToBitmap(objbmp5, new Rectangle(0, 0, this.dataGridView5.Width, this.dataGridView5.Height));

            e.Graphics.DrawImage(objbmp5, 0, 60);
            e.Graphics.DrawString(label19.Text, new Font("Comic Sans MS" ,20, FontStyle.Bold),Brushes.Black, new Point(120,20));
        }

        private void printDocument6_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Bitmap objbmp6 = new Bitmap(this.dataGridView6.Width, this.dataGridView6.Height);
            dataGridView6.DrawToBitmap(objbmp6, new Rectangle(0, 0, this.dataGridView6.Width, this.dataGridView6.Height));

            e.Graphics.DrawImage(objbmp6, 0, 60);
            e.Graphics.DrawString(label20.Text, new Font("Comic Sans MS", 20, FontStyle.Bold), Brushes.Black, new Point(120, 20));
        }

        private void printDocument7_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap objbmp7 = new Bitmap(this.dataGridView7.Width, this.dataGridView7.Height);
            dataGridView7.DrawToBitmap(objbmp7, new Rectangle(0, 0, this.dataGridView7.Width, this.dataGridView7.Height));

            e.Graphics.DrawImage(objbmp7, 0, 60);
            e.Graphics.DrawString(label12.Text, new Font("Comic Sans MS", 20, FontStyle.Bold), Brushes.Black, new Point(120, 20));

        }
    }
    
}
