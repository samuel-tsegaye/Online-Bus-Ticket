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
    public partial class officer : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-0D3AF2C;Initial Catalog=bus;Integrated Security=True;");

        public officer()
        {
            InitializeComponent();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
        public void user_datagrid()
        {
            SqlCommand cmd = new SqlCommand("select * from User_info ", con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void clear_user()
        {
            comboBox6.Text = String.Empty;
            ufname.Clear();
            ulname.Clear();
            uemail.Clear();
            uphno.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO User_info VALUES('" + ufname.Text + "', '" + ulname.Text + "', '" + uemail.Text + "'," + uphno.Text + ",@city)", con);
            SqlDataReader dr;


            try
            {

                con.Open();
                cmd.Parameters.AddWithValue("@city", comboBox6.Text.ToString());
                dr = cmd.ExecuteReader();
                MessageBox.Show("Your Registration Has Been\n Successfully Completed");


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            clear_user();
            user_datagrid();
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            home log = new home();
            log.Show();
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Text = comboBox3.Text;
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }
        public void Ticket()
        {
            string proid;
            string query = "Select ID from SCHE_SCH1 order by ID Desc";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {

                int id = int.Parse(dr[0].ToString()) + 1;
                proid = id.ToString();
            }
            else if (Convert.IsDBNull(dr))
            {
                proid = ("1000001");
            }
            else
            {
                proid = ("1000001");
            }
            con.Close();
            textBox1.Text = proid.ToString();
        }
        private void button14_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO SCHE_SCH1 VALUES (" + textBox1.Text + ",@Date,@Station ,@Car_plate,'" + Dis_1.Text + "',@Depature ,@Arrival,'" + time.Text + "','" + price.Text + "'   )", con);
            SqlDataReader dr;


            try
            {

                con.Open();
                cmd.Parameters.AddWithValue("@Date", dateTimePicker2.Text.ToString());
                cmd.Parameters.AddWithValue("@Depature", comboBox1.Text.ToString());
                cmd.Parameters.AddWithValue("@Station", comboBox3.Text.ToString());
                cmd.Parameters.AddWithValue("@Arrival", comboBox2.Text.ToString());
                cmd.Parameters.AddWithValue("@Car_plate", comboBox4.Text.ToString());
                dr = cmd.ExecuteReader();
                MessageBox.Show("add");
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
            RefreshDatat();
            Ticket();

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
        public void RefreshDatat()
        {
            SqlCommand cmd = new SqlCommand("select * from SCHE_SCH1 ", con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView2.DataSource = dt;
        }
        public void RefreshDatat1()
        {
            SqlCommand cmd = new SqlCommand("select * from SCHE_SCH1 ", con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        public void scheid()
        {
            string proid;
            string query = "Select Ticket_no from ticket1 order by Ticket_no Desc";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {

                int id = int.Parse(dr[0].ToString()) + 1;
                proid = id.ToString();
            }
            else if (Convert.IsDBNull(dr))
            {
                proid = ("1100000");
            }
            else
            {
                proid = ("1100000");
            }
            con.Close();
            textBox2.Text = proid.ToString();
        }
        private void officer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'busDataSet21.User_acc1' table. You can move, or remove it, as needed.
            this.user_acc1TableAdapter.Fill(this.busDataSet21.User_acc1);
            // TODO: This line of code loads data into the 'busDataSet20.User_info' table. You can move, or remove it, as needed.
            this.user_infoTableAdapter1.Fill(this.busDataSet20.User_info);
            // TODO: This line of code loads data into the 'busDataSet19.User_info' table. You can move, or remove it, as needed.
            this.user_infoTableAdapter.Fill(this.busDataSet19.User_info);
            // TODO: This line of code loads data into the 'busDataSet13.SCHE_SCH1' table. You can move, or remove it, as needed.
            this.sCHE_SCH1TableAdapter.Fill(this.busDataSet13.SCHE_SCH1);
            RefreshDatat1();
            user_datagrid();
            scheid();
            Ticket();
            delete_useracc();

            SqlCommand cmd = new SqlCommand("select plate From DRI_INFO", con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            comboBox4.DataSource = dt;
            comboBox4.SelectedItem = " ";
            comboBox4.DisplayMember = "plate";






            RefreshDatat();
        }

        private void button13_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("Delete from SCHE_SCH1 where Id ='" + this.textBox3.Text + "'", con);
            SqlDataReader dr;


            try
            {
                con.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Deleted");
                textBox1.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            RefreshDatat();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            clear();
        }
        public void clear()
        {
            comboBox1.Text = String.Empty;
            comboBox2.Text = String.Empty;
            comboBox3.Text = String.Empty;
            comboBox4.Text = String.Empty;
            Dis_1.Clear();
            time.Clear();
            price.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO ticket1 VALUES (" + textBox2.Text + ",'" + tk_name.Text + "','" + tk_lname.Text + "','" + tk_phone.Text + "','" + dep.Text + "','" + arr.Text + "','" + car.Text + "','" + tp.Text + "' )", con);
            SqlDataReader dr;


            try
            {

                con.Open();

                dr = cmd.ExecuteReader();
                MessageBox.Show("        ->   ORDER COMPLETE !!   <-\n\n\n Make Sure To Print Your Ticket or \n" +
                    "Pick them Up at The Station if \n You SelectedTodo So." + "        \n\n\nYou Ticket No Is  :- " + textBox2.Text);
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
            RefreshDatat();
            scheid();
            shprintPreviewDialog.Document = shprintDocument;
            shprintPreviewDialog.ShowDialog();

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM SCHE_SCH1 where Id = '" + search.Text + "'", con);
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                    SqlDataReader rd = cmd.ExecuteReader();
                    rd.Read();
                    if (rd.HasRows)
                    {
                        id_sch.Text = rd[1].ToString();
                        sta.Text = rd[2].ToString();
                        dep.Text = rd[5].ToString();
                        arr.Text = rd[6].ToString();
                        dis.Text = rd[4].ToString();
                        car.Text = rd[3].ToString();
                        tim.Text = rd[7].ToString();
                        tp.Text = rd[8].ToString();

                    }

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
        }
        public void combocity()
        {
            SqlCommand cmd = new SqlCommand("select * from SCHE_SCH1 where Arrival = '" + comboBox7.SelectedItem.ToString() + "' ", con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView5.DataSource = dt;
        }
        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            combocity();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Datat1();
            search.Text = "";
            comboBox7.Text = String.Empty;
            id_sch.Text = "";
            sta.Text = "";
            dep.Text = "";
            arr.Text = "";
            dis.Text = "";
            car.Text = "";
            tim.Text = "";
            tp.Text = "";
            tk_email.Text = "";
            tk_lname.Text = "";
            tk_name.Text = "";
            tk_phone.Text = "";
        }
        public void Datat1()
        {

            SqlCommand cmd = new SqlCommand("select * from SCHE_SCH1 ", con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView5.DataSource = dt;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            shprintPreviewDialog.Document = shprintDocument;
            shprintPreviewDialog.ShowDialog();

        }

        private void shprintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {



            string star2 = "**********************************************************";
            string stringToPrint = "             Habesh Online Ticket Reservation             ";
            string tele1 = "                 Tele No:- +251911109213                  ";
            string tele2 = "                 Tele No:- +251911009876                  ";
            string email1 = "              Email :- habeshticket@gmail.com             ";
            string web = "              Website :- www.habeshticket.com             ";
            string star = "************************************************************";

            System.Drawing.Point posstar2 = new System.Drawing.Point(180, 10);
            System.Drawing.Point pos = new System.Drawing.Point(180, 30);
            System.Drawing.Point postele1 = new System.Drawing.Point(180, 55);
            System.Drawing.Point postele2 = new System.Drawing.Point(180, 75);
            System.Drawing.Point posemail = new System.Drawing.Point(180, 95);
            System.Drawing.Point posweb = new System.Drawing.Point(180, 115);
            System.Drawing.Point posstar = new System.Drawing.Point(180, 145);



            Font drawFont = new Font("Comic Sans MS", 14);
            Font drawFont1 = new Font("Arial", 15);
            SolidBrush drawBrush = new SolidBrush(System.Drawing.Color.Black);

            e.Graphics.DrawString(star2, drawFont1, drawBrush, posstar2);
            e.Graphics.DrawString(stringToPrint, drawFont, drawBrush, pos);
            e.Graphics.DrawString(tele1, drawFont, drawBrush, postele1);
            e.Graphics.DrawString(tele2, drawFont, drawBrush, postele2);
            e.Graphics.DrawString(email1, drawFont, drawBrush, posemail);
            e.Graphics.DrawString(web, drawFont, drawBrush, posweb);
            e.Graphics.DrawString(star, drawFont1, drawBrush, posstar);



            string time = "  " + DateTime.Now;

            System.Drawing.Point postime = new System.Drawing.Point(600, 180);
            Font f_time = new Font("Comic Sans MS", 12);
            SolidBrush time_Brush = new SolidBrush(System.Drawing.Color.Black);
            e.Graphics.DrawString(time, f_time, time_Brush, postime);

            string tickeno = "  Ticket No : - HTN-" + textBox2.Text;
            System.Drawing.Point pos_tickeno = new System.Drawing.Point(550, 210);
            Font f_tickeno = new Font("Comic Sans MS", 13);
            SolidBrush tickeno_brush = new SolidBrush(System.Drawing.Color.Black);
            e.Graphics.DrawString(tickeno, f_tickeno, tickeno_brush, pos_tickeno);


            string user = "CUSTOMER INFORMATION";
            string star3 = "-------------------------------------------------------------------------------------------";
            string fname = "First Name :                 " + tk_name.Text;
            string lname = "Last Name :                 " + tk_lname.Text;
            string teleno = "Tele.No :                   " + tk_phone.Text;
            string email = "Email :                     " + tk_email.Text;
            string star4 = "-------------------------------------------------------------------------------------------";


            System.Drawing.Point posuser = new System.Drawing.Point(100, 250);

            System.Drawing.Point fname_pos = new System.Drawing.Point(150, 280);
            System.Drawing.Point lname_pos = new System.Drawing.Point(150, 305);
            System.Drawing.Point teleno_pos = new System.Drawing.Point(150, 336);
            System.Drawing.Point email_pos = new System.Drawing.Point(150, 360);

            System.Drawing.Point posstar3 = new System.Drawing.Point(100, 260);
            System.Drawing.Point posstar4 = new System.Drawing.Point(100, 390);


            Font font_user = new Font("Monotype Corsiva", 20);
            SolidBrush user_Brush1 = new SolidBrush(System.Drawing.Color.Red);

            e.Graphics.DrawString(user, font_user, user_Brush1, posuser);


            Font user_font = new Font("Comic Sans MS", 14);

            SolidBrush user_Brush = new SolidBrush(System.Drawing.Color.Black);

            e.Graphics.DrawString(fname, user_font, user_Brush, fname_pos);
            e.Graphics.DrawString(lname, user_font, user_Brush, lname_pos);
            e.Graphics.DrawString(teleno, user_font, user_Brush, teleno_pos);
            e.Graphics.DrawString(email, user_font, user_Brush, email_pos);


            e.Graphics.DrawString(star4, drawFont1, drawBrush, posstar4);
            e.Graphics.DrawString(star3, drawFont1, drawBrush, posstar3);

            string booking = "SCHEDULING & BOOKING";
            string star5 = "-------------------------------------------------------------------------------------------";
            string stringToPrint121 = "Schedule Date :" + id_sch.Text;
            string stringToPrint11 = "Station :                         " + sta.Text;
            string stringToPrint12 = "Depapture :                    " + dep.Text;
            string stringToPrint13 = "Arrival :                         " + arr.Text;
            string stringToPrint14 = "Distance :                       " + dis.Text;
            string stringToPrint111 = "Car Plate :                       " + car.Text;
            string stringToPrint112 = "Time :*************   " + tim.Text;
            string stringToPrint113 = "Trip Price :                      " + tp.Text;

            string star6 = "-------------------------------------------------------------------------------------------";



            System.Drawing.Point posdate = new System.Drawing.Point(500, 460);
            Font f_date = new Font("Comic Sans MS", 12);
            SolidBrush date_Brush = new SolidBrush(System.Drawing.Color.Black);
            e.Graphics.DrawString(stringToPrint121, f_date, date_Brush, posdate);




            System.Drawing.Point posbook = new System.Drawing.Point(100, 423);

            System.Drawing.Point pos11 = new System.Drawing.Point(150, 480);
            System.Drawing.Point pos21 = new System.Drawing.Point(150, 505);
            System.Drawing.Point pos31 = new System.Drawing.Point(150, 530);
            System.Drawing.Point pos41 = new System.Drawing.Point(150, 555);
            System.Drawing.Point pos12 = new System.Drawing.Point(150, 580);
            System.Drawing.Point pos22 = new System.Drawing.Point(150, 605);
            System.Drawing.Point pos32 = new System.Drawing.Point(150, 630);


            System.Drawing.Point posstar5 = new System.Drawing.Point(100, 440);
            System.Drawing.Point posstar6 = new System.Drawing.Point(100, 660);



            Font Font = new Font("Comic Sans MS", 14);
            Font Font1 = new Font("Arial", 15);
            SolidBrush Brush = new SolidBrush(System.Drawing.Color.Black);


            Font book = new Font("Monotype Corsiva", 20);
            SolidBrush bookBrush = new SolidBrush(System.Drawing.Color.Red);

            e.Graphics.DrawString(booking, book, bookBrush, posbook);

            e.Graphics.DrawString(stringToPrint11, Font, Brush, pos11);
            e.Graphics.DrawString(stringToPrint12, Font, Brush, pos21);
            e.Graphics.DrawString(stringToPrint13, Font, Brush, pos31);
            e.Graphics.DrawString(stringToPrint14, Font, Brush, pos41);
            e.Graphics.DrawString(stringToPrint111, Font, Brush, pos12);
            e.Graphics.DrawString(stringToPrint112, Font, Brush, pos22);
            e.Graphics.DrawString(stringToPrint113, Font, Brush, pos32);


            e.Graphics.DrawString(star5, drawFont1, drawBrush, posstar5);
            e.Graphics.DrawString(star6, drawFont1, drawBrush, posstar6);

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("INSERT INTO User_acc1 VALUES(" + phone.Text + ", '" + username.Text + "', '" + password.Text + "')", con);
            SqlDataReader dr;


            try
            {

                con.Open();

                dr = cmd.ExecuteReader();
                MessageBox.Show("User Account Has Been Successfully Created");
                Form1 op = new Form1();
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

        private void button3_Click(object sender, EventArgs e)
        {
            clear_user();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete from User_info where phone ='" + this.uphno.Text + "'", con);
            SqlDataReader dr;


            try
            {
                con.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Deleted");
                textBox1.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            user_datagrid();
            clear_user();
        }
        public void delete_useracc()
        {
            SqlCommand cmd = new SqlCommand("select * from User_acc1 ", con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView3.DataSource = dt;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete from User_acc1 where phone ='" + this.phone.Text + "'", con);
            SqlDataReader dr;


            try
            {
                con.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Deleted");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            delete_useracc();
            acc_reset();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            acc_reset();
        }
        private void acc_reset()
        {
            phone.Text = "";
            username.Text = "";
            password.Text = "";
        }

        private void tabPage15_Click(object sender, EventArgs e)
        {

        }
    } 

}
