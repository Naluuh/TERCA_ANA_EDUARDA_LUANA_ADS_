using System;
using System.Text.RegularExpressions;

class Program {

    static void Main (){

        Console.WriteLine("Digite sua senha de validação: ");
        string senha = Console.ReadLine() ?? "";
        
        bool tamanhoMinimo = senha.Length >=8;

        bool temMaiuscula = Regex.IsMatch (senha, "[A-Z]");

        bool temNumero = Regex.IsMatch (senha, "[0-9]");

        bool temEspecial = Regex.IsMatch (senha, @"[!@#$%^*()++\-_]");
        
        if(tamanhoMinimo && temMaiuscula && temNumero && temEspecial){
        Console.WriteLine("Senha forte! Atende todos os critérios.");
        } else {
            Console.WriteLine("Senha fraca. Verifique os seguintes pontos: ");

            if(!tamanhoMinimo){
                Console.WriteLine("Senha deve ter no mínimo 8 caracteres");
            } 
            if(!temMaiuscula){  
                Console.WriteLine("Senha deve ter no mínimo 1 letra maiúscula");
            } 
            if(!temNumero) {
                Console.WriteLine("Senha deve ter no mínimo 1 número");
            } 
            if(!temEspecial){ 
                Console.WriteLine("Senha deve ter no mínimo 1 caractere especial");
            }
        }
    }
}