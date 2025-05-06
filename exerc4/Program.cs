using System;
using System.Text.RegularExpressions;
class Program {

    static void Main (){

        Console.WriteLine("Digite uma opção: ");
        Console.WriteLine("1 - Celsius para Fahrenheit");
        Console.WriteLine("2 - Fahrenheit para Celsius");
        Console.WriteLine("3 - Sair");
        int num = int.Parse(Console.ReadLine() ?? "0");

        switch (num) {
            case 1:{
                Console.WriteLine("Digite a temperatura em celsius: ");
                float celsius = float.Parse(Console.ReadLine() ?? "0");
                float fahrenheit = (celsius * 1.8f) + 32;
                Console.WriteLine("A temperatura em Fahrenheit é " + fahrenheit);
                break;
            }
            case 2:{
                Console.WriteLine("Digite a temperatura em Fahrenheit: ");
                float fahrenheit = float.Parse(Console.ReadLine() ?? "0");
                float celsius = (fahrenheit - 32) / 1.8f;
                Console.WriteLine("A temperatura em Celsius é " + celsius);
                break;
            }
            case 3:
            Console.WriteLine("Saindo...");
                Environment.Exit(0);
                break;

            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }
}