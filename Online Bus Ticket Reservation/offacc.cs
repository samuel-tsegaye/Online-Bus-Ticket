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
    public partial class offacc : Form
    {
        public offacc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            home mm = new home();
            mm.Show();
        }
        officerlogin UC = new officerlogin();
        private void button2_Click(object sender, EventArgs e)
        {

            UC.username = username1.Text;
            UC.password = password1.Text;

            int result = UC.LogIn(UC);
            if (result == 1)
            {
                officer us = new officer();
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
    }
}
