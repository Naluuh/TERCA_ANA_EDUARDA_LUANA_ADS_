using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;

class Program {
    static void Main() {
        Console.WriteLine("Digite uma palavra ou frase:");
        string? entrada = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(entrada)) {
            Console.WriteLine("Entrada inválida.");
            return;
        }

        string textoLimpo = RemoverAcentos(entrada.ToLower());
        textoLimpo = Regex.Replace(textoLimpo, @"[^a-z0-9]", "");

        // Invertendo o texto
        char[] array = textoLimpo.ToCharArray();
        Array.Reverse(array);
        string textoInvertido = new string(array);

        // Verifica se é palíndromo
        if (textoLimpo == textoInvertido) {
            Console.WriteLine("É um palíndromo!");
        } else {
            Console.WriteLine("Não é um palíndromo.");
        }
    }

    // Função para remover acentos
    static string RemoverAcentos(string texto) {
        var normalized = texto.Normalize(NormalizationForm.FormD);
        var sb = new StringBuilder();
        foreach (var c in normalized) {
            if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark) {
                sb.Append(c);
            }
        }
        return sb.ToString().Normalize(NormalizationForm.FormC);
    }
}