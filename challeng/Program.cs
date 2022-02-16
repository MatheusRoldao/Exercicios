using System;

namespace challeng
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int y = 32;
            int w = y++;
            double z = 100 % 70;
            string x = "Maria";
            Console.WriteLine("{0} tem {1} anos e saldo de {2:F2} reais", x.ToUpper(), ++y + ++w, z);
        }
    }
}
