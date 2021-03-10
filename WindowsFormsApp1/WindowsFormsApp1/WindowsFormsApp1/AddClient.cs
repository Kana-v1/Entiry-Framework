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
    public partial class AddClient : Form
    {
        string name = string.Empty;
        string surname = string.Empty;
        int passSer = 0;
        long passNum = 0;
        List<long> checkPasNum = null;
        List<int> checkPasSer = null;
        public AddClient()
        {
            InitializeComponent();
            //загрузка номеров и серий пасспортов для проверки на уникальность при создании 
            using (var context = new ExamEntities())
            {
                checkPasNum = new List<long>();
                checkPasSer = new List<int>();
                var clients = context.Clients.ToList();
                foreach (var c in clients)
                {
                    checkPasNum.Add(c.PassNum);
                    checkPasSer.Add(passSer);
                }

            }
        }

        private void addClientBtn_Click(object sender, EventArgs e)
        {
            try
            {
                name = nameTb.Text;
                surname = SurnameTb.Text;
                int.TryParse(seriesTb.Text, out passSer);
                long.TryParse(numberTb.Text, out passNum);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Incorrect data");
                return;
            }

            //проверка имени/фамилии на корректность
            bool correctString = false;
            if (!string.IsNullOrEmpty(name) &&
                !string.IsNullOrEmpty(surname) &&
                !string.IsNullOrWhiteSpace(name) &&
                !string.IsNullOrWhiteSpace(surname) &&
                !name.Any(char.IsDigit) &&
                !surname.Any(char.IsDigit))
            {
                correctString = true;
            }

            //проверка данных пасспорта на корректность
            bool correctNum = false;
            if (!checkPasNum.Contains(passNum) &&
                !checkPasSer.Contains(passSer) &&
                passNum > (long)(Math.Pow(10, 9) + 1) &&
                passSer > 1)
            {
                correctNum = true;
            }

            if (correctNum && correctString)
            {
                Clients client = new Clients()
                {
                    Name = name,
                    Surname = surname,
                    PassNum = passNum,
                    PassSeries = passSer
                };
                using (var context = new ExamEntities())
                {
                    context.Clients.Add(client);
                    context.SaveChanges();
                    MessageBox.Show("Client has been added");

                    //Создание номера новому клиенту
                    newNumber();
                }
                checkPasNum.Add(passNum);
                checkPasSer.Add(passSer);



            }
            else
            {
                MessageBox.Show("Incorrect data");
            }
        }

        private void newNumber()
        {
            using (var context = new ExamEntities())
            {
                var rand = new Random();
                var numbers = new List<long>();
                long number = 0;
                List<Clients> clients = context.Clients.ToList();
                var tariffes = context.Tariff.ToList();

                do
                {
                    number = (long)(rand.NextDouble() * long.MaxValue);
                } while (numbers.Contains(number) || number < Math.Pow(10, 11) - 1);
                numbers.Add(number);

                var num = new PhoneNumber()
                {
                    Num = number,
                    ClientId = passNum,
                    TariffId = tariffes[rand.Next(1, tariffes.Count)].Id,
                    Balance = rand.Next(100, 20000)
                };

                context.PhoneNumber.Add(num);
                context.SaveChanges();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
