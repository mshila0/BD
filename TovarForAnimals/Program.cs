using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TovarForAnimals
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ProductsForm("", ""));
            //Application.Run(new AddUpdateForm(5, 1));

            //private void button1_Click(object sender, EventArgs e)
            //{
            //    MessageBox.Show(
            //        "Выберите один из вариантов",
            //        "Сообщение",
            //        MessageBoxButtons.YesNo,
            //        MessageBoxIcon.Information,
            //        MessageBoxDefaultButton.Button1,
            //        MessageBoxOptions.DefaultDesktopOnly);
            //}

    //            Add(TimeSpan value): добавляет к дате значение TimeSpan

    //AddDays(double value): добавляет к текущей дате несколько дней

    //AddHours(double value): добавляет к текущей дате несколько часов

    //AddMinutes(double value): добавляет к текущей дате несколько минут

    //AddMonths(int value): добавляет к текущей дате несколько месяцев

    //AddYears(int value): добавляет к текущей дате несколько лет

    //Например, добавим к некоторой дате 3 часа:

    //            1
    //2
    //DateTime date1 = new DateTime(2015, 7, 20, 18, 30, 25); // 20.07.2015 18:30:25
    //            Console.WriteLine(date1.AddHours(3)); // 20.07.2015 21:30:25
    //            Для вычитания дат используется метод Subtract(DateTime date):

    //1
    //2
    //3
    //DateTime date1 = new DateTime(2015, 7, 20, 18, 30, 25); // 20.07.2015 18:30:25
    //            DateTime date2 = new DateTime(2015, 7, 20, 15, 30, 25); // 20.07.2015 15:30:25
    //            Console.WriteLine(date1.Subtract(date2)); // 03:00:00
        }
    }
}
