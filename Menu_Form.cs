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
    public partial class Menu_Form : Form
    {
        OleDbConnection cn;
        OleDbCommand cmd;
        //OleDbDataReader dread;

        public Menu_Form()
        {
            InitializeComponent();
        }
        public void connection()
        {
            string str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\\Hotel_Management_System_2020\\Hotel_Management_System_2020_2003.mdb";
            cn = new OleDbConnection(str);
            cn.Open();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Menu_Form_Load(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            connection();
            cmd = new OleDbCommand("insert into Menu_Form values('" + textBox1.Text + "'," + textBox2.Text + "," + textBox3.Text + "," +textBox4.Text + "," + textBox5.Text + ",'" + textBox6.Text + "'," +textBox7.Text + ")", cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("RECORD SAVED SUCCESFULLY");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Select();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtBill_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAmt_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox1.Select();
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
             

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {
            int a, b, c;
            a = Int32.Parse(textBox4.Text);
            b = Int32.Parse(textBox5.Text);
            c = a - b;
            textBox7.Text = c.ToString();  
        }
    }
}
