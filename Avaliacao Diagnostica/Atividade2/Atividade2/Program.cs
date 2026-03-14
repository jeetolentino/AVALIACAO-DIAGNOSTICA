using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("--- Impressão de Intervalo ---");

        
        Console.Write("Digite o número inicial: ");
        int inicio = int.Parse(Console.ReadLine());

        Console.Write("Digite o número final: ");
        int fim = int.Parse(Console.ReadLine());

        
        if (inicio < fim)
        {
            Console.WriteLine($"\nImprimindo números de {inicio} até {fim}:");

            
            for (int i = inicio; i <= fim; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(); 
        }
        else
        {
            Console.WriteLine("\nErro: O número inicial deve ser menor que o número final.");
        }

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}