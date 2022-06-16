using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Bus_Ticket_Reservation
{
    public partial class driver : Form
    {
        public driver()
        {
            InitializeComponent();
        }
        dri dr = new dri();
        private void button2_Click(object sender, EventArgs e)
        {

            dr.username = username1.Text;
            dr.password = password1.Text;

            int result = dr.LogIn(dr);
            if (result == 1)
            {
                driverscreen us = new driverscreen();
                us.Show();
                this.Close();
            }
            else if (result == -1)
            {
                MessageBox.Show("Incorrect Username and Password");
            }
            else
                MessageBox.Show("Connection Error");
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            home log = new home();
            log.Show();
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void driver_Load(object sender, EventArgs e)
        {

        }
    }
}
