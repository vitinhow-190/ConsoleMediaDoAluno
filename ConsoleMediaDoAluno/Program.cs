using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMediaDoAluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a nota do aluno: ");
            double media = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a porcentagem de presença do aluno: ");
            double porcent = double.Parse(Console.ReadLine());

            if (media >= 7 && porcent >= 75 || media >= 4 && porcent >= 75)
            {
                Console.Write(" aprovado!");
            }
            else if (media >= 7 && porcent < 75 || media >= 4 && porcent < 75)
            {
                Console.Write("recuperação");
            }
            else
            {
                Console.Write("retido!");
            }







            Console.ReadKey();
        }
    }
}
