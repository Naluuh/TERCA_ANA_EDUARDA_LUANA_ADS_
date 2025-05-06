using System;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

class Program {

    static void Main (){

        Console.WriteLine("Digite um número inteiro e positivo: ");
        int num = int.Parse(Console.ReadLine() ?? "0");

        if(num < 0){
            Console.WriteLine("Número inválido.");
            return;
        }

        int fatorial = 1;

        while(num > 1){
            fatorial *= num;
            num--;
        }

        Console.WriteLine("O fatorial do número é " + fatorial);

    }
}