using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite sua senha: ");
        string senha = Console.ReadLine();

        bool temTamanhoMinimo = senha.Length >= 8;
        bool temMaiuscula = false;
        bool temNumero = false;
        bool temEspecial = false;

        foreach (char c in senha)
        {
            if (char.IsUpper(c)) temMaiuscula = true;
            else if (char.IsDigit(c)) temNumero = true;
            else if (!char.IsLetterOrDigit(c)) temEspecial = true;
        }

        if (temTamanhoMinimo && temMaiuscula && temNumero && temEspecial)
        {
            Console.WriteLine("Senha forte!");
        }
        else
        {
            Console.WriteLine("Senha fraca!");
            Console.WriteLine("Requisitos:");
            Console.WriteLine("- Mínimo de 8 caracteres");
            Console.WriteLine("- Pelo menos uma letra maiúscula");
            Console.WriteLine("- Pelo menos um número");
            Console.WriteLine("- Pelo menos um caractere especial");
        }
    }
}