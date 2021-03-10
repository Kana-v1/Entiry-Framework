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
    public partial class NewTariff : Form
    {
        public NewTariff()
        {
            InitializeComponent();
            fillCb();
        }
        private void fillCb()//заполнение combobox-ов
        {
            using (var context = new ExamEntities())
            {
                var numbers = context.PhoneNumber.ToList();
                foreach (var num in numbers)
                {
                    num_cb.Items.Add(num.Num);
                }

                var tariff = context.Tariff.ToList();
                foreach (var t in tariff)
                {
                    tariffCb.Items.Add(t.Name);
                }
            }
        }


        //хочу чтобы в выборе нового тарифа не было текущего
        private void num_cb_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            using (var context = new ExamEntities())
            {

                
                //поиск текущего тарифа через номер
                var currentNum = long.Parse(num_cb.SelectedItem.ToString());

                //{var currentTariff = context.Tariff.Where(
                //        (ct) => ct.Id == context.PhoneNumber.Where(
                //            (num) => num.Num == currentNum).FirstOrDefault().TariffId).FirstOrDefault();
                // Это был изначальный вариант как вытащить текущий тариф, я его оставил чтобы узнать действительно ли он
                // проще читается чем вариант ниже}

                //создание таблицы, в которой есть только номера и их тарифы
                var TariffAndHisNum = context.Tariff.Join(context.PhoneNumber,
                    t => t.Id,
                    pn => pn.TariffId,
                    (t, pn) => new
                    {
                        PhoneNumber = pn.Num,
                        Name = t.Name
                    });

                //ну и тут получение, собственно, названия текущего тарифа
                var currentTariffAndNum = TariffAndHisNum.Where((ct) => ct.PhoneNumber == currentNum).FirstOrDefault();
                string currentTariffName = currentTariffAndNum.Name;

                //текущий тариф уже из таблицы тарифы
                var currentTariff = context.Tariff.Where((t) => t.Name.Equals(currentTariffName)).FirstOrDefault();

                //если для данного номера "новый тариф == старому" нужно стереть выбранный тариф
                if (currentTariff.Name == tariffCb.SelectedItem.ToString())
                {
                    tariffCb.SelectedItem = null;
                }

                //перезаполнение comboBox с учетом текущего тарифа
                tariffCb.Items.Clear();

                var tariff = context.Tariff.ToList();
                foreach (var t in tariff)
                {
                    if (t.Id == currentTariff.Id)
                    {
                        continue;
                    }
                    tariffCb.Items.Add(t.Name);

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new ExamEntities())
            {
                var currentNum = long.Parse(num_cb.SelectedItem.ToString());
                var number = context.PhoneNumber.Where((num) => num.Num == currentNum).FirstOrDefault();
                var tariff = context.Tariff.Where((t) => t.Name == tariffCb.Text).FirstOrDefault();
                number.TariffId = tariff.Id;
                context.SaveChanges();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}