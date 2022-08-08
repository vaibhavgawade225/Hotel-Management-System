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
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void tableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var a = new Tableform();
            a.Show();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var a = new Employee2020();
            a.Show();

        }

        private void masterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Main_Form_Load(object sender, EventArgs e)
        {

        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var a = new Form1();
            a.Show();
        }

        private void mainCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var a = new Main_Factory_Factory();
            a.Show();
        }

        private void subCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var a = new Sub_Category_Form();
            a.Show();
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var a = new Item_Form();
            a.Show();
        }

        private void menuFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var a = new Menu_Form();
            a.Show();
        }

        private void designationReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var a = new Designation_rpt();
            a.Show();
        }

        private void employeeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var a = new Employee_Report();
            a.Show();
        }

        private void itemMasterReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var a = new Item_Report();
            a.Show();
        }

        private void mainCategoryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var a = new MainCategory_rpt();
            a.Show();
        }

        private void subCategoryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var a = new SubCategory_rpt();
            a.Show();
        }

        private void tableToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var a = new Tableform_rpt();
            a.Show();
        }

        private void menuReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var a = new menu_Report();
            a.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
