using System;

namespace TemperatureConverter
{
    // ReSharper disable once ClassNeverInstantiated.Global
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Enter a temperature (Fahrenheit): ");
            var success = float.TryParse(Console.ReadLine(), out var fahrenheit);
            Console.WriteLine(success
                ? $"Your temperature in Celsius is {Math.Round(0.555 * (fahrenheit - 32), 2)}"
                : "You need to enter a valid temperature");
        }
    }
}