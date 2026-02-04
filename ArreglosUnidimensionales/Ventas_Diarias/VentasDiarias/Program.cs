using System;

class VentasDiarias
{
    static void Main()
    {
        double[] ventas = new double[7];
        double total = 0;
        int diaMax = 0;

        for (int i = 0; i < ventas.Length; i++)
        {
            Console.Write($"Ingrese las ventas del día {i + 1}: ");
            ventas[i] = double.Parse(Console.ReadLine());
            total += ventas[i];

            if (ventas[i] > ventas[diaMax])
                diaMax = i;
        }

        double promedio = total / ventas.Length;

        Console.WriteLine($"\nTotal vendido en la semana: {total}");
        Console.WriteLine($"Promedio diario: {promedio}");
        Console.WriteLine($"Día con la venta máxima: Día {diaMax + 1} con {ventas[diaMax]}");

        Console.ReadKey();
    }
} //Yohansel Mieses 2024 1830