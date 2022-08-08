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
 

    public partial class Sub_Category_Form : Form
    {
        OleDbConnection cn;
        OleDbCommand cmd;
        OleDbDataReader dread;

        public Sub_Category_Form()
        {
            InitializeComponent();
        }
         public void connection()
        {
            string str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\\Hotel_Management_System_2020\\Hotel_Management_System_2020_2003.mdb";
            cn = new OleDbConnection(str);
            cn.Open();
        }

        private void Sub_Category_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotel_Management_System_2020_2003DataSet3.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter1.Fill(this.hotel_Management_System_2020_2003DataSet3.Category);
            // TODO: This line of code loads data into the 'hotel_Management_System_2020_2003DataSet2.Category' table. You can move, or remove it, as needed.
            //this.categoryTableAdapter.Fill(this.hotel_Management_System_2020_2003DataSet2.Category);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
              connection();
              cmd = new OleDbCommand("DELETE FROM Category WHERE Id=" + textBox1.Text, cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("RECORD DELETED SUCCESFULLY");
        }

        private void button2_Click(object sender, EventArgs e)
        {
             connection();
             cmd = new OleDbCommand("insert into Category values(" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "')", cn);
             cmd.ExecuteNonQuery();
            MessageBox.Show("RECORD SAVED SUCCESFULLY");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
           textBox1.Select();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            connection();
            cmd = new OleDbCommand("UPDATE Category SET Category='" + textBox2.Text + "' where Id=" + textBox1.Text, cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("RECORD UPDATED");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            connection();
            cmd = new OleDbCommand("select * from Category where Id=" + textBox1.Text, cn);
            dread = cmd.ExecuteReader();
            while (dread.Read())
            {
                textBox1.Text = dread[0].ToString();
                textBox2.Text = dread[1].ToString();
                textBox3.Text = dread[2].ToString();
            }
            dread.Close();
        }
    }
}
