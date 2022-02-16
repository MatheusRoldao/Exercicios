using System;
using System.Collections.Generic;
using System.Linq;

namespace Exe7
{
    internal class Program
    {   
        //programa que recebe numeros e exibe o maior e o menor entre eles
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            Console.WriteLine("Insira o valor de numeros a ser informados");
            int x=Int32.Parse(Console.ReadLine());


            for(int i=1;i<=x;i++)
            {
                Console.WriteLine("Insira o Numero {0}:",i);              
                //adiciona esse valor a lista que tem o nome de numeros
                numeros.Add(Int32.Parse(Console.ReadLine()));

                
            }            

            Console.WriteLine(" Menor Numero informado: {0}\n Maior Numero Informado: {1}", numeros.Min(),numeros.Max());
            Console.ReadLine();

        }
    }
}
