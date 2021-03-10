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
    public partial class RefillBalance : Form
    {
        public RefillBalance()
        {
            
            InitializeComponent();
            fillNames();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void fillNames()
        {
            
            using (var context = new ExamEntities())
            {
                var clients = context.Clients.ToList();
                foreach (var c in clients)
                {
                    comboBox1.Items.Add(c.Name);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            string name = comboBox1.SelectedItem.ToString();
            using (var context = new ExamEntities())
            {
                context.Configuration.LazyLoadingEnabled = false;

                var clientid = context.Clients.Where((c) => c.Name == comboBox1.SelectedItem.ToString()).FirstOrDefault().PassNum;
                var num = context.PhoneNumber.Where((n) => n.ClientId == clientid).FirstOrDefault();

                try//случайно попал в ошибку, суть которой в том что клиент был, а его номера нет - перезаполнил бд, вроде все норм
                    //но на всякий сделал try
                {
                    //вот эти поля у num по совершенно непонятным мне причинам удалялись при удалении num из бд, 
                    //поэтому я их просто записал
                    var clientId = num.ClientId;
                    var clients = num.Clients;
                    var tariff = num.Tariff;
                    var tariffId = num.TariffId;

                    context.PhoneNumber.Remove(num);
                    context.SaveChanges();

                    try
                    {
                        num.Balance += Decimal.Parse(textBox1.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Incorrect sum for reffiling");
                        return;
                    }

                    num.ClientId = clientId;
                    num.Clients = clients;
                    num.Tariff = tariff;
                    num.TariffId = tariffId;
                    context.PhoneNumber.Add(num);
                    context.SaveChanges();

                    MessageBox.Show("Balance has been refilled");
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show("Choose another client");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
