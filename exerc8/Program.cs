using System;
class Program {
    static void Main() {
       
        Console.WriteLine("Digite a sua altura: ");
        float altura = float.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Digite o seu peso: ");
        float peso = float.Parse(Console.ReadLine() ?? "0");

        float imc = peso / (altura * altura);

        if(imc < 18.5){
            Console.WriteLine("Abaixo do peso.");
        } else if(imc >= 18.5 && imc < 25){
            Console.WriteLine("Peso normal.");
        } else if(imc > 25 && imc < 30){
            Console.WriteLine("Sobrepeso.");
        } else if(imc > 30){
            Console.WriteLine("Obesidade.");
        }

    }
}