using System;

namespace Exe13
{
    internal class Program
    {
        //Programa calcula o plano de salario de um funcionario da Empresa informando anos de trabalho em tal, além do salario inicial.
        static void Main(string[] args)
        {
            Console.Write("===============PROGRAMA AJUSTE DE SALÁRIO==================");
            Console.WriteLine("\nInsira o tempo de trabalho na empresa em anos ");
            byte anosTrabalhados = byte.Parse(Console.ReadLine());
            Console.WriteLine("Insira o  salario do funcionario ");
            decimal salario = Decimal.Parse(Console.ReadLine());
          
            //contas feitas após informado o tempo trabalhado
            for (byte i = 1; i <= anosTrabalhados; i++)
            {
                if (i <= 3)
                {
                    salario = salario + (salario * (50.0M / 100));
                }
                if (i > 3)
                {
                    salario = salario + salario;
                }
                if (i % 10 == 0)
                {
                    salario = salario + (salario * (10.0M / 100));
                }
            }
            Console.WriteLine("O salário novo será de: {0:F2}", salario);
        }
    }
}
