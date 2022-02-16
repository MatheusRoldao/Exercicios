using System;

namespace Exe8
{
    internal class Program
    {
        static void Main(string[] args)
        {
                //programa que conta de 1 até 1000 exibindo e informando os numeros que são multiplos de 3
            for(int i = 1; i < 1000; i++)
            {
                // condição para que exiba os multiplos de 3
                if (i % 3 == 0)
                    Console.WriteLine(i + " Numero Multiplo de 3 ");
                else Console.WriteLine(i);
            }
        }
    }
}
