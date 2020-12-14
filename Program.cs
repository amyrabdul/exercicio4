using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
           Double f,c;
           
            Console.WriteLine("Calculadora transformadora de Farenreit para Celsius");
            
             Console.Write("Digite a sua temperatura em Farenreit : ");
            f = double.Parse(Console.ReadLine());
            

            c = (f-32)/1.8;

         Console.WriteLine($"A sua temperatura em celsius é de {c}");
            Console.WriteLine();

        }
    }
}
