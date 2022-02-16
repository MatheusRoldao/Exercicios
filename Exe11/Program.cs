using System;
using System.Collections.Generic;
namespace Exe11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //listas para armazenar as informçoes dos nadadores com suas respectivas classificaçoes
            List<string> infantilA = new List<string>();
            List<string> infantilB = new List<string>();
            List<string> juvenilA = new List<string>();
            List<string> juvenilB = new List<string>();
            List<string> adulto = new List<string>();


            while (true)
            {
               
                Console.WriteLine("Insira o nome do nadador ([exit] fecha o programa)");
                var nome = Console.ReadLine();
                if (nome == "exit") break;
                    Console.WriteLine("Insira a idade do nadador");
                    byte idade = byte.Parse(Console.ReadLine());

                    if (idade >=5 && idade <= 7) {               
                        infantilA.Add(nome);
                    }else if(idade <=11) {                    
                            infantilB.Add(nome);
                          }else if(idade <=13) {               
                                   juvenilA.Add(nome);
                               }else if(idade <=17) {               
                                        juvenilB.Add(nome);
                                      }else if(idade >= 18) {               
                                               adulto.Add(nome);
                                             } 
            }
            Console.WriteLine("============================================================\n O respectivos nadadores são:");

            Console.WriteLine("Infantil A");
            if (infantilA.Count > 0)
            {
                foreach (var item in infantilA)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine("============================================================\n Infantil B");
            if (infantilB.Count > 0)
            {
                foreach (var item in infantilB)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine("============================================================\n Juvenil A");
            if (juvenilA.Count > 0)
            {
                foreach (var item in juvenilA)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine("============================================================\n Juvenil B");
            if (juvenilB.Count > 0)
            {
                foreach (var item in juvenilB)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine("============================================================\n Adulto");
            if (adulto.Count > 0)
            {
                foreach (var item in adulto)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
