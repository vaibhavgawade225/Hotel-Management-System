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
    public partial class Main_Factory_Factory : Form
    {
        OleDbConnection cn;
        OleDbCommand cmd;
        OleDbDataReader dread;

        public Main_Factory_Factory()
        {
            InitializeComponent();
        }

        public void connection()
        {
            string str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\\Hotel_Management_System_2020\\Hotel_Management_System_2020_2003.mdb";
            cn = new OleDbConnection(str);
            cn.Open();
        }

        private void Main_Factory_Factory_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            connection();
            cmd = new OleDbCommand("DELETE FROM Main_Category WHERE Id=" + textBox1.Text, cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("RECORD DELETED SUCCESFULLY");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection();
            cmd = new OleDbCommand("insert into Main_Category  values(" + textBox1.Text + ",'" + textBox2.Text + "')", cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("RECORD SAVED SUCCESFULLY");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Select();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            connection();
            cmd = new OleDbCommand("UPDATE Main_Category  SET Category='" + textBox2.Text + "' where Id=" + textBox1.Text, cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("RECORD UPDATED");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            connection();
            cmd = new OleDbCommand("select * from Main_Category where ID=" + textBox1.Text, cn);
            dread = cmd.ExecuteReader();
            while (dread.Read())
            {
                textBox1.Text = dread[0].ToString();
                textBox2.Text = dread[1].ToString();
            }
            dread.Close();
        }
    }
}
