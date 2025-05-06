using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> tarefas = new List<string>();
        List<bool> concluido = new List<bool>();
        bool sair = false;

        while (!sair) {
            Console.WriteLine("\n--- Lista de Tarefas ---");
            Console.WriteLine("1. Adicionar tarefa");
            Console.WriteLine("2. Listar tarefas");
            Console.WriteLine("3. Marcar tarefa como concluída");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine()  ?? "";

            switch (opcao) {
                case "1":
                    Console.Write("Digite a tarefa: ");
                    string descricao = Console.ReadLine()  ?? "";
                    tarefas.Add(descricao);
                    concluido.Add(false);
                    Console.WriteLine("Tarefa adicionada com sucesso!");
                    break;

                case "2":
                    Console.WriteLine("\n--- Tarefas ---");
                    if (tarefas.Count == 0) {
                        Console.WriteLine("Nenhuma tarefa cadastrada.");
                    }
                    else {
                        for (int i = 0; i < tarefas.Count; i++)
                        {
                            string status = concluido[i] ? "[Concluída]" : "[Pendente]";
                            Console.WriteLine($"{i + 1}. {status} {tarefas[i]}");
                        }
                    }
                    break;

                case "3":
                    Console.Write("Digite o número da tarefa a ser marcada como concluída: ");
                    if (int.TryParse(Console.ReadLine(), out int numero) && numero >= 1 && numero <= tarefas.Count) {
                        if (!concluido[numero - 1]) {
                            concluido[numero - 1] = true;
                            Console.WriteLine("Tarefa marcada como concluída.");
                        } else {
                            Console.WriteLine("Esta tarefa já está marcada como concluída.");
                        }
                    } else {
                        Console.WriteLine("Número inválido.");
                    }
                    break;

                case "4":
                    sair = true;
                    Console.WriteLine("Saindo do programa...");
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}