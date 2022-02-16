using System;

namespace Exe4
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //imprime a tabuada do numero desejado
            Console.WriteLine("Insira o Numero desejado para a tabuada:");
            byte numero=Convert.ToByte(Console.ReadLine());            

            for (int i= 0; i<= 10; i++)
            {
                Console.WriteLine("{0}x{1}={2}",numero,i,numero*i);
            }
            Console.ReadKey();
        }
    }
}
