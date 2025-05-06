using System;
using System.Text.RegularExpressions;

class Program {

    static void Main (){

        Console.WriteLine("Digite um número: ");
        int num = int.Parse(Console.ReadLine() ?? "0");

        for (int i = 1; i < 11; i++) {
            Console.WriteLine($"\n{num} x {i} = " + num*i);
        }

    }
}