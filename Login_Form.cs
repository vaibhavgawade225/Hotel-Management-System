using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Hotel_Management_System_2020
{    
   
    public partial class Login_Form : Form
    {
       public Login_Form()
        {
            InitializeComponent();
            textBox2.PasswordChar='*';
            textBox2.MaxLength = 15;
        }
      private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void User_form_Load(object sender, EventArgs e)
        {

        }

        private void chkType_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = "Vaibhav";
            string Password = "Gawade";
            if((textBox1.Text == username) &&(textBox2.Text == Password))
            {
                MessageBox.Show("LOGIN SUCCESSFULLY....");
                this.Hide();
                var a = new Main_Form();
                a.Show();
            }
            else 
            {
                MessageBox.Show ("Valid Username And Password");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
