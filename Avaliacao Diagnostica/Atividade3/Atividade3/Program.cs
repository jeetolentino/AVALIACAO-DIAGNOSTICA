using System;

class Program
{
    static void Main()
    {
        // Declaração do array para 10 números
        double[] numeros = new double[10];

        Console.WriteLine("--- Localizador de Maior Número ---");

        // Loop para ler os 10 números e armazenar no array
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            numeros[i] = double.Parse(Console.ReadLine());
        }

        // Inicializamos o 'maior' com o primeiro elemento do array
        double maior = numeros[0];

        // Percorremos o array comparando cada elemento
        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] > maior)
            {
                maior = numeros[i];
            }
        }

        Console.WriteLine("\n----------------------------------");
        Console.WriteLine($"O maior número digitado foi: {maior}");
        Console.WriteLine("----------------------------------");
    }
}