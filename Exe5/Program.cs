using System;

namespace Exe5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa que irá receber 4 numeros e imprimir a soma dos pares e impares separadamente
            byte parSoma = 0;
            byte imparSoma = 0;

            for(byte i = 1; i <= 4; i++)
            {
                Console.Write("Insira o numero {0}:",i);
                byte numero = Convert.ToByte(Console.ReadLine());

                if(numero %2 != 0)
                {
                    imparSoma = (byte)(imparSoma + numero);

                }else 
                    parSoma=(byte)(parSoma + numero);
            }

            Console.WriteLine(" Soma dos pares: {0}\n Soma dos impares: {1}", parSoma, imparSoma);
            Console.ReadKey();

        }
    }
}
