using System;

namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"32F = {TempConverter.FahrenheitToCelsius(32)}C");
            Console.WriteLine($"212F = {TempConverter.FahrenheitToCelsius(212)}C");
            Console.WriteLine($"72F = {TempConverter.FahrenheitToCelsius(72)}C");
            Console.WriteLine($"0C = {TempConverter.CelsiusToFahrenheit(0)}F");
            Console.WriteLine($"100C = {TempConverter.CelsiusToFahrenheit(100)}F");
            Console.WriteLine($"22C = {TempConverter.CelsiusToFahrenheit(22)}F");
        }
    }

    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double value) 
        {
            return (value-32)/1.8;
        }

        public static double CelsiusToFahrenheit(double value) 
        { 
            return (value*9)/5 + 32;
        }
    }
}
