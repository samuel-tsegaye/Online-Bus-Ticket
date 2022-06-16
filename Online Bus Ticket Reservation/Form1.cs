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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            home log = new home();
            log.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            createacc qOG = new createacc();
            qOG.Show();
            this.Close();
        }
        log UC = new log();
   
 

        private void button1_Click(object sender, EventArgs e)
        {
            UC.username = username.Text;
            UC.password = password.Text;

            int result = UC.LogIn(UC);
            if (result == 1)
            {
                Useracc us = new Useracc();
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            driver de = new driver();   
            de.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adminlog de = new adminlog();
            de.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            offacc der = new offacc(); 
            der.Show();
            this.Close();
        }
    }
}

