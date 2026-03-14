using System;

class Program
{
    static void Main()
    {
        
        string[,] alunos = new string[5, 2];
        int opcao = 0;
        int cadastrados = 0;

        while (opcao != 4)
        {
            Console.WriteLine("\n===== SISTEMA ESCOLAR =====");
            Console.WriteLine("1 - Cadastrar aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Mostrar média das notas");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha uma opção: ");

            if (!int.TryParse(Console.ReadLine(), out opcao)) continue;

            switch (opcao)
            {
                case 1:
                    if (cadastrados < 5)
                    {
                        Console.Write($"Nome do {cadastrados + 1}º aluno: ");
                        alunos[cadastrados, 0] = Console.ReadLine();
                        Console.Write($"Nota do {cadastrados + 1}º aluno: ");
                        alunos[cadastrados, 1] = Console.ReadLine();
                        cadastrados++;
                        Console.WriteLine("Aluno cadastrado com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Limite de 5 alunos atingido.");
                    }
                    break;

                case 2:
                    Console.WriteLine("\n--- Lista de Alunos ---");
                    for (int i = 0; i < cadastrados; i++)
                    {
                        Console.WriteLine($"Aluno: {alunos[i, 0]} | Nota: {alunos[i, 1]}");
                    }
                    break;

                case 3:
                    if (cadastrados == 0)
                    {
                        Console.WriteLine("Nenhum aluno cadastrado.");
                    }
                    else
                    {
                        double soma = 0;
                        for (int i = 0; i < cadastrados; i++)
                        {
                            soma += double.Parse(alunos[i, 1]);
                        }
                        double media = soma / cadastrados;
                        Console.WriteLine($"\nA média das notas dos {cadastrados} alunos é: {media:F2}");
                    }
                    break;

                case 4:
                    Console.WriteLine("Encerrando sistema...");
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}