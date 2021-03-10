using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
<<<<<<< HEAD
        public Form1()
        {
            InitializeComponent();
            AppDomain.CurrentDomain.SetData("DataDirectory", @"C:\ADO.NET\Exam\c-Entity-Framework-Sql-server-");
        }

=======
      public Form1()
        {
            InitializeComponent();
           AppDomain.CurrentDomain.SetData("DataDirectory", @"C:\ADO.NET\Exam\c-Entity-Framework-Sql-server-");
        }
        
>>>>>>> 713864c3ad5a8e8c1e2b869de7f636543f4313c1
        private static void del()//удаление всех данных из БД(это мне нужно было)
        {
            using (var context = new ExamEntities())
            {
                var tar = context.Tariff.ToList();
                foreach (var p in tar)
                {
                    context.Tariff.Remove(p);
                }
                var cl = context.Clients.ToList();
                foreach (var c in cl)
                {
                    context.Clients.Remove(c);
                }
                var phone = context.PhoneNumber.ToList();
                foreach (var p in phone)
                {
                    context.PhoneNumber.Remove(p);
                }
                context.SaveChanges();
            }
        }
        private static void fillDb()//заполнение БД
        {
            var rand = new Random();

            //fill Tariff
            using (var context = new ExamEntities())
            {
                for (int i = 0; i < 15; i++)
                {
                    var tariff = new Tariff()
                    {
                        Name = "Tariff_Name_" + i.ToString(),
                        Description = "Description_" + i.ToString(),
                        ConnectPayment  = (decimal) rand.Next(50, 250),
                        MonthPayment = (decimal) rand.Next(2, 100)
                    };
                    context.Tariff.Add(tariff);
                    context.SaveChanges();
                }

                //fill Clients
                var passnum = new List<long>();
                var passSer = new List<int>();
                long passnumber = 0;
                int passseries = 0;

                for (int i = 0; i < 15; i++)
                {
                    do
                    {
                        passnumber = (long)(rand.NextDouble() * long.MaxValue);
                    } while (passnum.Contains(passnumber));
                    passnum.Add(passnumber);

                    do
                    {
                        passseries = rand.Next(1, int.MaxValue);
                    } while (passSer.Contains(passseries));
                    passSer.Add(passseries);

                    var client = new Clients()
                    {
                        Name = "Name_" + i.ToString(),
                        Surname = "Surname_" + i.ToString(),
                        PassNum = passnumber,
                        PassSeries = passseries
                    };
                    context.Clients.Add(client);
                    context.SaveChanges();
                }

                //fill PhoneNumber
                var numbers = new List<long>();
                long number = 0;
                List<Clients> clients = context.Clients.ToList();
                var tariffes = context.Tariff.ToList();
                for (int i = 0; i < 15; i++)
                {
                    do
                    {
                        number = (long)(rand.NextDouble() * long.MaxValue);
                    } while (numbers.Contains(number) || number < Math.Pow(10, 11) - 1);
                    numbers.Add(number);

                    var num = new PhoneNumber()
                    {
                        Num = number,
                        ClientId = clients[i].PassNum,
                        TariffId = tariffes[i].Id,
                        Balance = rand.Next(100, 20000)
                    };

                    context.PhoneNumber.Add(num);
                    context.SaveChanges();
                }

                
            }
        }
<<<<<<< HEAD
       
=======
      

>>>>>>> 713864c3ad5a8e8c1e2b869de7f636543f4313c1
        private void button1_Click(object sender, EventArgs e)
        {
            var showForm = new ShowAllTables();
            showForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newFrom = new AddClient();
            newFrom.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fillDb();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            del();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var newForm = new RefillBalance();
            newForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var newForm = new NewTariff();
            newForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var newForm = new AddTariff();
            newForm.Show();
        }
    }
}
