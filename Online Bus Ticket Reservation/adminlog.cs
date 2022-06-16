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
    public partial class adminlog : Form
    {
        public adminlog()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        log2 UC = new log2();   
        private void button2_Click(object sender, EventArgs e)
        {
            UC.password = password12.Text;

            int result = UC.LogIn(UC);
            if (result == 1)
            {
                admin us = new admin();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            home log = new home();
            log.Show();
        }
    }
}
