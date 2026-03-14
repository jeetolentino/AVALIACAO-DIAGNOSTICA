using System;

class Program
{
    static void Main()
    {
        int opcao = 0;

        // O loop continua enquanto a opção for diferente de 5 (Sair)
        while (opcao != 5)
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1 - Somar dois números");
            Console.WriteLine("2 - Subtrair dois números");
            Console.WriteLine("3 - Multiplicar dois números");
            Console.WriteLine("4 - Dividir dois números");
            Console.WriteLine("5 - Sair");
            Console.Write("Escolha uma opção: ");

            // Tentativa de ler a opção e validar se é um número
            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.WriteLine("Por favor, insira um número válido.");
                continue;
            }

            if (opcao >= 1 && opcao <= 4)
            {
                Console.Write("Digite o primeiro número: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                double num2 = double.Parse(Console.ReadLine());

                double resultado = 0;

                switch (opcao)
                {
                    case 1:
                        resultado = num1 + num2;
                        Console.WriteLine($"Resultado da Soma: {resultado}");
                        break;
                    case 2:
                        resultado = num1 - num2;
                        Console.WriteLine($"Resultado da Subtração: {resultado}");
                        break;
                    case 3:
                        resultado = num1 * num2;
                        Console.WriteLine($"Resultado da Multiplicação: {resultado}");
                        break;
                    case 4:
                        if (num2 != 0)
                        {
                            resultado = num1 / num2;
                            Console.WriteLine($"Resultado da Divisão: {resultado}");
                        }
                        else
                        {
                            Console.WriteLine("Erro: Não é possível dividir por zero.");
                        }
                        break;
                }
            }
            else if (opcao == 5)
            {
                Console.WriteLine("Saindo do programa...");
            }
            else
            {
                Console.WriteLine("Opção inválida! Tente novamente.");
            }
        }
    }
}