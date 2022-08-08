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
    public partial class Form1 : Form
    {
        OleDbConnection cn;
        OleDbCommand cmd;
        OleDbDataReader dread;
        
        public Form1()
        {
            InitializeComponent();
        }
        public void connection()
        {
            string str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\\Hotel_Management_System_2020\\Hotel_Management_System_2020_2003.mdb";
            cn = new OleDbConnection(str);
            cn.Open();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection();
            cmd = new OleDbCommand("insert into Designation values(" + textBox1.Text + ",'" + textBox2.Text + "')", cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("RECORD SAVED SUCCESFULLY");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Select();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connection();
            cmd = new OleDbCommand("DELETE FROM Designation WHERE Id=" + textBox1.Text, cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("RECORD DELETED SUCCESFULLY");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            connection();
            cmd = new OleDbCommand("UPDATE Designation SET Designations='" + textBox2.Text + "' where Id=" + textBox1.Text, cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("RECORD UPDATED");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            connection();
            cmd = new OleDbCommand("select * from Designation where Id=" + textBox1.Text, cn);
            dread = cmd.ExecuteReader();
            while (dread.Read())
            {
                
                textBox2.Text = dread[1].ToString();

            }
            dread.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
            //dataGridView1.Refresh();
        //}

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {

            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Enter ID");
                textBox1.Focus();
            }

            else
            {
                textBox2.Focus();
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
