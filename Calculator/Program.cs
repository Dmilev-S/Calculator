using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            double num1 = 0; double num2 = 0;

            Console.WriteLine("Консольный калькулятор в C#\r");
            Console.WriteLine("-------------------------\n");

            Console.WriteLine("Введите номер, а затем нажмите клавишу Ввод");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите другой номер, а затем нажмите клавишу Ввод");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Выберите вариант из следующего списка");
            Console.WriteLine("\ta - Плюс");
            Console.WriteLine("\ts - Минус");
            Console.WriteLine("\tm - Умножить");
            Console.WriteLine("\td - Поделить");
            Console.Write("Ваш вариант?");

            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Ваш результат: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Ваш результат: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Ваш результат: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Ваш результат: {num1} / {num2} = " + (num1 / num2));
                    break;
            }

            Console.WriteLine("Нажмите любую клавишу, чтобы закрыть приложение консоли калькулятора...");
            Console.ReadKey();            
        }
    }
}
