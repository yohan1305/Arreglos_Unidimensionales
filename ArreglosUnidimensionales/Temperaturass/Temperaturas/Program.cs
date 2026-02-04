using System;

class Temperaturas
{
    static void Main()
    {
        double[] temps = new double[10];
        double suma = 0;
        double max = double.MinValue;
        double min = double.MaxValue;
        int diasSobre30 = 0;

        for (int i = 0; i < temps.Length; i++)
        {
            Console.Write($"Ingrese la temperatura del día {i + 1}: ");
            temps[i] = double.Parse(Console.ReadLine());
            suma += temps[i];

            if (temps[i] > max) max = temps[i];
            if (temps[i] < min) min = temps[i];
            if (temps[i] > 30) diasSobre30++;
        }

        double promedio = suma / temps.Length;

        Console.WriteLine($"\nTemperatura más alta: {max}");
        Console.WriteLine($"Temperatura más baja: {min}");
        Console.WriteLine($"Promedio de temperaturas: {promedio}");
        Console.WriteLine($"Días por encima de 30°C: {diasSobre30}");

        Console.ReadKey();
    }
}

//Yohansel Mieses 2024 1830