using System;
using System.Globalization;
class Exerc7{
    static void Main(){
        int[] numeros = new int[10];
        int somaPares = 0;

        Console.WriteLine("Digige 10 números inteiros: ");

        for (int i = 0; i < 10; i++) {
            Console.Write($"Número {i + 1}: ");
            int num = int.Parse(Console.ReadLine() ?? "0");
            numeros[i] = num;

            if (num % 2 == 0) {
                somaPares += num;
            }
        } 

        Console.WriteLine("\nA soma dos números pares é: " + somaPares);

    }
}