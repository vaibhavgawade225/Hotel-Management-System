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
    public partial class Employee2020 : Form
    {
        OleDbConnection cn;
        OleDbCommand cmd;
        OleDbDataReader dread;

        public Employee2020()
        {
            InitializeComponent();
        }
        public void connection()
        {
            string str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\\Hotel_Management_System_2020\\Hotel_Management_System_2020_2003.mdb";
          cn = new OleDbConnection(str);
            cn.Open();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Employee2020_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection();
            cmd = new OleDbCommand("insert into Employee values(" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "'," + textBox4.Text + ",'" + textBox5.Text + "')", cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("RECORD SAVED SUCCESFULLY");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox1.Select();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connection();
            cmd = new OleDbCommand("DELETE FROM Employee WHERE ID=" + textBox1.Text, cn);
            //cmd.ExecuteNonQuery();
            MessageBox.Show("RECORD DELETED SUCCESFULLY");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            connection();
            cmd = new OleDbCommand("UPDATE Employee SET NAME='" + textBox2.Text + "' where id=" + textBox1.Text, cn);
            //cmd.ExecuteNonQuery();
            MessageBox.Show("record updated........");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            connection();
            cmd = new OleDbCommand("select * from Employee where EmpCode=" + textBox1.Text, cn);
            dread = cmd.ExecuteReader();
            while (dread.Read())
            {
                
                textBox2.Text = dread[1].ToString();
                textBox3.Text = dread[2].ToString();
                textBox4.Text = dread[3].ToString();
                textBox5.Text = dread[4].ToString();

            }
            dread.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {

            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Enter Employee Code");
                textBox1.Focus();
            }

            else
            {
                textBox2.Focus();
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {

            if (textBox2.Text  == "")
            {
                MessageBox.Show("Please Enter Employee Name");
                textBox2.Focus();
            }

            else
            {
                textBox2.Focus();
            }              

        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {

            if (textBox3.Text == "")
            {
                MessageBox.Show("Please enter your Name");
                textBox3.Focus();
            }

            else
            {
                textBox3.Focus();
            }              

        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            //if (textBox4.Text.Length == 10)
            //{
            //    String strcell = String.Empty;
            //    for (int i = 0; i < 10; i++)
            //    {
            //        if (Char.IsDigit(textBox4.Text*[i]))
            //        {

            //        }
            //        else
            //        {
            //            MessageBox.Show("Invalid cellNo");
            //            break;
            //        }

            //    }

            //    //MessageBox.Show("you cell Number is valid:" + phone);
            //}
            //else
            //{
            //    MessageBox.Show("CellNo Should Contain exactly 10 Digits");
            //}

        }

    }

}
