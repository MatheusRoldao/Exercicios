using System;
using System.Collections.Generic;
using System.Linq;

namespace Exe12
{
    internal class Program
    {
        //Esse programa determina o maior numero informados
        static void Main(string[] args)
        {
          List<int>numeros = new List<int>();

            while (true)
            {
                Console.WriteLine("Insira um número: (ao inserir [0] o programa será fechado");
                int number = Int32.Parse(Console.ReadLine());
                     if (number == 0)
                {
                    break;
                }
                     numeros.Add(number);
            }

            Console.WriteLine("0 Maior numero inserido foi: {0} \n0 Menor numero inserido foi: {1}", numeros.Max(), numeros.Min());            
            Console.ReadKey();
        }
    }
}
