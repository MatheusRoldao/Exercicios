using System;

namespace Exe10
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //programa que calcula e mostra o imposto de renda informado para cada salario
            //laço utilizado
            while (true)
            {
                Console.WriteLine("Insira o valor do Salario [Digite 0 para finalizar]");
                decimal salario = Decimal.Parse(Console.ReadLine());
                if (salario == 0 || salario == 0.0M)
                {
                    break;
                }
                else if (salario < 1903.99M){                
                     Console.WriteLine("O Salario não paga impostos");
                }
                      else if (salario < 2826.66M){                
                            Console.WriteLine("O Imposto é: {0}", (salario * (7.5M / 100)));
                }
                           else if (salario < 3751.06M) {                                                       
                                Console.WriteLine("O Imposto é: {0}", (salario * (15.0M / 100)));
                }
                                 else if (salario < 4664.68M) {               
                                      Console.WriteLine("O Imposto é: {0}", (salario * (22.5M / 100)));
                }
                                       else {                                         
                                           Console.WriteLine("O Imposto é: {0}" , (salario * (27.5m / 100)));
                   }
            }
        }
    }
}
