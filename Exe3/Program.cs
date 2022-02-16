using System;

namespace Exe3
{
    internal class Program
    {
        static void Main(string[] args)
        {   //program que exibe numeros impares de 1 até 200
            Console.Write("Os numeros Impares entre 1 até 200 são:\n");
            for (int i = 1; i < 200; i++)
                {
                    if (i % 2 != 0)
                    {
                        
                          Console.WriteLine(i);
                    }

                }
            
        }
    }
}
