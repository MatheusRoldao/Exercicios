using System;

namespace Exe9
{
    internal class Program
    {   
        //Programa que apresenta uma tela com opçoes, selecionando o tipo de conta que deverá ser feita
        static void Main(string[] args)
        {
            bool condicao = true;
            while (condicao == true)
            {
                Console.WriteLine("Digite o numero das opçoes desejadas\n 1 - Adição\n 2 - Subtração\n 3 - Multiplicação\n 4 - Divisão\n=============================================================== ");
                int escolha = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Insira o primeiro numero");
                int numero1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Insira o segundo numero \n==============================================================");
                int numero2 = Int32.Parse(Console.ReadLine());

                if (escolha == 1)
                {
                    Console.WriteLine("A soma é:{0}", (numero1 + numero2));
                }
                else if (escolha == 2)
                {
                    Console.WriteLine("A Subtração é:{0}", (numero1 - numero2));
                      }
                      else if (escolha == 3)
                {
                            Console.WriteLine("A multiplicação é:{0}", (numero1 * numero2));
                           }
                           else if (escolha == 4)
                                {
                                Console.WriteLine("A divisão é:{0}", (numero1 / numero2));
                }
                //condição que seleciona se o programa deve continuar ou parar por si só
                Console.WriteLine("==============================================================={0}\n Deseja fazer outro calculo?('s'/'n')");
                String decisao = Console.ReadLine();
                if (decisao == "s")
                    condicao = true;
                else
                    condicao = false;
                
            }  
        }
    }
}
