using System;

class InversionArreglo
{
    static void Main()
    {
        int[] numeros = new int[6];

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Ingrese el número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nArreglo en orden inverso:");
        for (int i = numeros.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(numeros[i]);
        }
    }
}

//Yohansel Mieses 2024 1830