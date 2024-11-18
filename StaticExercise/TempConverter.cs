namespace StaticExercise;

public static class TempConverter
{
    public static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * (9.0 / 5.0); // = Celsius
    }

    public static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * (9.0 / 5.0)) + 32; // = Fahrenheit
    }
    
    
}

