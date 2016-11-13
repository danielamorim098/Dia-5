using System;
using System.Linq;

namespace ConsoleApplication
{
    public class Contas
    {
        public static void Efetuar(string[] args)
        {
        
            Console.WriteLine("-----Contas------");
            Console.WriteLine("Digite um numero a:");
            var a = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o numero b:");
            var b = int.Parse(Console.ReadLine());

            Console.WriteLine("------Resultados------");
            if( args == null || args.ToList().Contains("adicao"))
            Console.WriteLine ($"{a} + {b} - {a + b}");

              if( args == null || args.ToList().Contains("subtracao")) 
            Console.WriteLine ($"{a} - {b} - {a - b}");  
            
             if( args == null || args.ToList().Contains("multiplicacao"))
            Console.WriteLine ($"{a} * {b} - {a * b}"); 

              if( args == null || args.ToList().Contains("divisao"))
            Console.WriteLine ($"{a} / {b} - {a / b}");  
            
        }
    }
}
