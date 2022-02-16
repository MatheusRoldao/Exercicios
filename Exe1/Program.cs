using System;

namespace Exe1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //laço que que percorrerá os numeros de 1 até 1000 com a condição que irá exibi-los em oredem decrescente
            for (int i = 1000; i >= 1; i--) Console.WriteLine(i);         
            Console.ReadKey();
        }
    }
}
