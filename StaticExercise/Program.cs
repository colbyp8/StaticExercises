using System;

namespace StaticExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FarenheitToCelsius(68);
            var farenheit = TempConverter.CelsiusToFarenheit(20);
            Console.WriteLine($"Celsius : {celsius}");
            Console.WriteLine($"Farenheit : {farenheit}");
        }
    }
}
