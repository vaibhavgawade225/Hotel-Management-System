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
    public partial class Item_Form : Form
    {
        OleDbConnection cn;
        OleDbCommand cmd;
        OleDbDataReader dread;

        public Item_Form()
        {
            InitializeComponent();
        }
        public void connection()
        {
            string str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\\Hotel_Management_System_2020\\Hotel_Management_System_2020_2003.mdb";
            cn = new OleDbConnection(str);
            cn.Open();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            connection();
            cmd = new OleDbCommand("DELETE FROM Item_Master WHERE Item_code=" + textBox1.Text, cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("RECORD DELETED SUCCESFULLY");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            connection();
            cmd = new OleDbCommand("UPDATE  Item_Master  SET Item='" + textBox2.Text + "' where Item_code=" + textBox1.Text, cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("RECORD UPDATED");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection();
            cmd = new OleDbCommand("insert into  Item_Master  values("+ textBox1.Text +",'"+ textBox2.Text +"','"+ textBox3.Text +"','"+ textBox4.Text +"',"+ textBox5.Text +","+ textBox6.Text +",'"+ textBox7.Text +"',"+ textBox8.Text +")", cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("RECORD SAVED SUCCESFULLY");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }

        private void Item_Form_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            connection();
            cmd = new OleDbCommand("select * from  Item_Master  where Item_code=" + textBox1.Text, cn);
            dread = cmd.ExecuteReader();
            while (dread.Read())
            {
                
                textBox2.Text = dread[1].ToString();
                textBox3.Text = dread[2].ToString();
                textBox4.Text = dread[3].ToString();
                textBox5.Text = dread[4].ToString();
                textBox6.Text = dread[5].ToString();
                textBox7.Text = dread[6].ToString();
                textBox8.Text = dread[7].ToString();

            }
            dread.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            int a, b, c;
            a = Int32.Parse(textBox5.Text);
            b = Int32.Parse(textBox6.Text);
            c = a * b;
            textBox8.Text = c.ToString();  
        }
    }
}
