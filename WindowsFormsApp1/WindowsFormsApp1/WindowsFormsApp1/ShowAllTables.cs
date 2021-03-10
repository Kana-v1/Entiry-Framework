using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ShowAllTables : Form
    {
        public ShowAllTables()
        {
            InitializeComponent();
        }

        private void clientBtn_Click(object sender, EventArgs e)
        {
            using (var context = new ExamEntities())
            {
                context.Configuration.LazyLoadingEnabled = false;
                var clients = context.Clients.ToList();
                dataGridView1.DataSource = clients;
               dataGridView1.Columns["PhoneNumber"].Visible = false;
            }
        }

        private void numberBtn_Click(object sender, EventArgs e)
        {
            using (var context = new ExamEntities())
            {
                context.Configuration.LazyLoadingEnabled = false;
                var num = context.PhoneNumber.ToList();
                dataGridView1.DataSource = num;
                dataGridView1.Columns["Clients"].Visible = false;
                dataGridView1.Columns["Tariff"].Visible = false;
            }
           
        }

        private void tafirrBtn_Click(object sender, EventArgs e)
        {
            using (var context = new ExamEntities())
            {
                context.Configuration.LazyLoadingEnabled = false;
                var tar = context.Tariff.ToList();
                dataGridView1.DataSource = tar;
                dataGridView1.Columns["PhoneNumber"].Visible = false;
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
