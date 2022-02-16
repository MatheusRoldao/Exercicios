using System;
using System.Collections.Generic;

namespace Exe6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa que irá calcular a média dos alunos e da sala

            Dictionary<string, decimal> alunos = new Dictionary<string, decimal>();
            decimal mediaDaTurma = 0;
            int x = 0;
           
            
            while (true)
            {
                Console.WriteLine("Insira o Nome:  [{finalizar} irá encerrar a atribuição de dados] ");
                string nome = Console.ReadLine();

                decimal notasAluno = 0;

                if (nome == "finalizar") break;

                for (int i = 1; i < 5; i++)
                {
                    Console.WriteLine("Insira a {0} NOTA " , i);
                    decimal nota = Convert.ToDecimal(Console.ReadLine());
                    mediaDaTurma = mediaDaTurma + nota;
                    notasAluno = notasAluno + nota;

                }

                notasAluno = notasAluno / 4;
                alunos.Add(nome, notasAluno);
                x++;
            }

            foreach (var item in alunos)
            {
                Console.WriteLine("{0} Teve média de {1}",item.Key, item.Value);
               
            }

            Console.WriteLine("A turma teve uma média de {0}: " , mediaDaTurma / (x * 4));

            Console.ReadKey();

        }
    }
}