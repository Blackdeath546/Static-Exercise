﻿namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{TempConverter.FahrenheitToCelsius(18)}");
            
            Console.WriteLine($"{TempConverter.CelsiusToFahrenheit(32)}");
        }
    }
}
