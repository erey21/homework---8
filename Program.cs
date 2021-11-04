using System;

namespace homework___8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание № 8");
            Console.WriteLine("Введите сумму вклада: ");
            double sum = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите количество месяцев: ");
            double month = Convert.ToDouble(Console.ReadLine());

            for (int i = 0; i < month; i++) {
                sum += sum * 0.07;
            }
            Console.WriteLine("Итоговая сумма: ");
            Console.WriteLine(sum);
        }
    }
}
