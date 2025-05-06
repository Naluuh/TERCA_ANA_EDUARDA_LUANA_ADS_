using System;
using System.Collections.Generic;
class Program {
    static void Main() {
        List<Produto> produtos = new List<Produto>();

        for (int i = 1; i <= 3; i++) {
            Console.WriteLine($"Produto {i}:");

            Console.Write("Nome: ");
            string? nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Quantidade: ");
            int quant = int.Parse(Console.ReadLine() ?? "0");

            Produto produto = new Produto {
                nome = nome ?? "",
                preco = preco,
                quant = quant
            };

            produtos.Add(produto);
            Console.WriteLine();
        }

        Console.WriteLine("Lista de produtos e valor total em estoque:");

        foreach (var p in produtos) {
            Console.WriteLine($"- {p.nome} | Preço: R${p.preco:F2} | Quantidade: {p.quant} | Valor total em estoque: R${p.ValorTotalEmEstoque():F2}");
        }
    }
}

class Produto {
    public string nome { get; set; }
    public double preco { get; set; }
    public int quant { get; set; }

    public double ValorTotalEmEstoque() {
        return preco * quant;
    }
}
