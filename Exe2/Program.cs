using System;

namespace Exe2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------Informe a quantidade de numeros desejados---------");
            int qtdNumeros = Convert.ToInt32(Console.ReadLine());
            int somaNumeros = 0;
          
            for(int i = 1; i <= qtdNumeros; i++)//laço for onde irá continuar conforme a quantidade de numeros desejada.
            {
                Console.WriteLine("Insira o {0},Numero:",i);
                somaNumeros = somaNumeros + Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Soma dos numeros:{0} \nMédia aritmética:{1}", somaNumeros, somaNumeros / qtdNumeros);
            Console.ReadLine();
        }
    }
}
