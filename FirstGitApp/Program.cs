using System;

namespace ConsoleAppForGit
{
    class Program
    {
        static void Main()
        {
        Back:
            int a = 0;
            int b = 0;
            int sum = 0;
            int dif = 0;
            double mod = 0;
            double comp = 0;
            double div = 0;
            try
            {
                Console.Clear();
                Console.WriteLine("Введите первое число");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                b = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Вы ввели не число, нажмите любую клваишу и попробуйте снова");
                Console.ReadKey();
                goto Back;
            }
            sum = a + b;
            Console.WriteLine("Сумма двух чисел: {0}", sum);
            dif = a - b;
            Console.WriteLine("Разность двух чисел: {0}", dif);
            mod = ((double)Math.Abs(a) + (double)Math.Abs(b)) / 2;
            Console.WriteLine("Среднее арифметическое модулей: {0}", mod);
            comp = a * b;
            Console.WriteLine("Произведение двух чисел: {0}", comp);
            div = Convert.ToDouble(a) / Convert.ToDouble(b);
            Console.WriteLine("Частное двух чисел: {0}", div);
        }
    }
}