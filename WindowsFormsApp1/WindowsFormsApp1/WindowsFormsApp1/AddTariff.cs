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
    public partial class AddTariff : Form
    {
        string name = String.Empty;
        string description = String.Empty;
        decimal monthPay = -1;
        decimal connectPay = -1;
        public AddTariff()
        {
            InitializeComponent();
        }

        private bool UniqName()//проверка имени на уникальность
        {
            var checkName = new List<String>();
            using (var context = new ExamEntities())
            {
                var names = context.Tariff.ToList();
                foreach (var n in names)
                {
                    checkName.Add(n.Name);
                }
                if (checkName.Contains(name))
                    return false;
                return true;
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            using (var context = new ExamEntities())
            {
                var names = context.Tariff.ToList();


                try
                {
                    monthPay = Decimal.Parse(MonthPayTb.Text);
                    connectPay = Decimal.Parse(ConnectPayTb.Text);
                    name = nameTb.Text;
                    description = DescriptionTb.Text;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Incorrect data");
                    return;
                }

                if (string.IsNullOrEmpty(name) ||
                    string.IsNullOrEmpty(description) ||
                    !UniqName() ||
                    monthPay < 0 ||
                    connectPay < 0)
                {
                    MessageBox.Show("Incorrect data");
                    return;
                }

                Tariff tariff = new Tariff()
                {
                    Name = name,
                    Description = description,
                    ConnectPayment = connectPay,
                    MonthPayment = monthPay
                };

                context.Tariff.Add(tariff);
                context.SaveChanges();
                MessageBox.Show("Tariff has been added");


            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
