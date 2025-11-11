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
        Console.WriteLine("=== Калькулятор C# ===");
        
        // Тестирование базовых арифметических операций
        Console.WriteLine("\n--- Базовые операции ---");
        Console.WriteLine($"5 + 3 = {Calculator.Add(5, 3)}");
        Console.WriteLine($"10 - 4 = {Calculator.Subtract(10, 4)}");
        Console.WriteLine($"7 * 6 = {Calculator.Multiply(7, 6)}");
        
        // Тестирование деления с обработкой ошибок
        Console.WriteLine("\n--- Тестирование деления ---");
        TestDivision(10, 2);   // Нормальное деление
        TestDivision(10, 0);   // Деление на ноль
        TestDivision(15, 3);   // Еще одно нормальное деление
        
        // Тестирование возведения в степень
        Console.WriteLine("\n--- Тестирование степени ---");
        Console.WriteLine($"2 в степени 3 = {Calculator.Power(2, 3)}");
        Console.WriteLine($"5 в степени 2 = {Calculator.Power(5, 2)}");
        Console.WriteLine($"10 в степени 0 = {Calculator.Power(10, 0)}");
        Console.WriteLine($"4 в степени 0.5 = {Calculator.Power(4, 0.5)}"); // Квадратный корень
        
        // Демонстрация комплексного выражения
        Console.WriteLine("\n--- Комплексное выражение ---");
        double result = Calculator.Add(
            Calculator.Multiply(2, 3),
            Calculator.Power(2, 4)
        );
        Console.WriteLine($"2 * 3 + 2^4 = {result}");
        
        Console.WriteLine("\nПрограмма завершена. Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
    
    // Вспомогательный метод для безопасного тестирования деления
    static void TestDivision(double a, double b)
    {
        try
        {
            double result = Calculator.Divide(a, b);
            Console.WriteLine($"{a} / {b} = {result}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine($"ОШИБКА: {a} / {b} = Деление на ноль невозможно!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"ОШИБКА: {a} / {b} = {ex.Message}");
        }
    }
}
