using module_10.Class;
using module_10.Interface;
using System;
using System.Collections.Generic;

namespace module_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Использование интерфейса ICalculatable
            ICalculatable simpleCalculator = new SimpleCalculator();
            ICalculatable advancedCalculator = new AdvancedCalculator();

            Console.WriteLine("Простой калькулятор:");
            Console.WriteLine($"Сложение: {simpleCalculator.Add(5, 3)}");
            Console.WriteLine($"Вычитание: {simpleCalculator.Subtract(5, 3)}");
            Console.WriteLine($"Умножение: {simpleCalculator.Multiply(5, 3)}");
            Console.WriteLine($"Деление: {simpleCalculator.Divide(6, 2)}");

            Console.WriteLine("\nРасширенный калькулятор:");
            Console.WriteLine($"Возведение в степень: {advancedCalculator.Power(2, 3)}");
            Console.WriteLine($"Квадратный корень: {advancedCalculator.SquareRoot(25)}");

            // Использование интерфейса IStorable
            IStorable storableCalculator = new AdvancedCalculator();
            storableCalculator.SaveState("calculator_state.txt");
            storableCalculator.LoadState("calculator_state.txt");
        }
    }
}
