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
    public partial class Tableform : Form
    {
        OleDbConnection cn;
        OleDbCommand cmd;
        OleDbDataReader dread;
        
        public Tableform()
        {
            InitializeComponent();
        }

        public void connection()
        {
            string str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\\Hotel_Management_System_2020\\Hotel_Management_System_2020_2003.mdb";
            cn = new OleDbConnection(str);
            cn.Open();
        }

        private void Tableform_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
             connection();
             cmd = new OleDbCommand("insert into Charts values(" + textBox1.Text + ",'" + textBox2.Text + "')", cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("RECORD SAVED SUCCESFULLY");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Select();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connection();
            cmd = new OleDbCommand("DELETE FROM Charts WHERE Id=" + textBox1.Text, cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("RECORD DELETED SUCCESFULLY");
        }

        private void button5_Click(object sender, EventArgs e)
        {
               connection();
               cmd = new OleDbCommand("UPDATE Charts SET Tables='" + textBox2.Text + "' where Id=" + textBox1.Text, cn);
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
            cmd = new OleDbCommand("select * from Charts where Id=" + textBox1.Text, cn);
            dread = cmd.ExecuteReader();
            while (dread.Read())
            {
            
                textBox2.Text = dread[1].ToString();

            }
            dread.Close();
        }
    }
}
