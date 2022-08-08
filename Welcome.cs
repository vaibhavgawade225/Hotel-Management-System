using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hotel_Management_System_2020
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 1;
            progressBar1.Increment(1);
            if (progressBar1.Value >= progressBar1.Maximum)
            {
                timer1.Enabled = false;
                this.Hide();
                var a = new Login_Form();
                a.Show();
            }
        }
    }
}
