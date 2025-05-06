using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int numeroAleatorio = random.Next(1, 101); // Gera número entre 1 e 100
        int tentativa;
        int tentativas = 0;

        Console.WriteLine("Jogo da Adivinhação!");
        Console.WriteLine("Tente adivinhar o número entre 1 e 100.");

        do
        {
            Console.Write("Digite sua tentativa: ");
            tentativa = int.Parse(Console.ReadLine() ?? "0");

            tentativas++;

            if (tentativa < numeroAleatorio)
            {
                Console.WriteLine("O número é maior.");
            }
            else if (tentativa > numeroAleatorio)
            {
                Console.WriteLine("O número é menor.");
            }
            else
            {
                Console.WriteLine($"Parabéns! Você acertou o número {numeroAleatorio} em {tentativas} tentativas.");
            }

        } while (tentativa != numeroAleatorio);
    }
}