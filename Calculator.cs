using System;

namespace CalculatorApp
{
    public class Calculator
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }
        
        public static double Subtract(double a, double b)
        {
            return a - b;
        }
        
        public static double Multiply(double a, double b)
        {
            return a * b;
        }
        
        public static double Divide(double a, double b)
        {
            // Намеренная ошибка: нет проверки деления на ноль
            return a / b;
        }
        
        // Добавленная функция возведения в степень
        public static double Power(double baseNumber, double exponent)
        {
            return Math.Pow(baseNumber, exponent);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Калькулятор C#");
            
            // Тестирование функций
            Console.WriteLine($"5 + 3 = {Calculator.Add(5, 3)}");
            Console.WriteLine($"10 / 0 = {Calculator.Divide(10, 0)}"); // Вызовет исключение
            Console.WriteLine($"2 в степени 3 = {Calculator.Power(2, 3)}"); // Демонстрация новой функции
        }
    }
}
