using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double nota1, nota2, nota3, nota4, media;

            Console.Write("Insira sua nota 1: ");
            nota1= Convert.ToDouble(Console.ReadLine());

            Console.Write("Insira sua nota 2: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Insira sua nota 3: ");
            nota3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Insira sua nota 4: ");
            nota4 = Convert.ToDouble(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            if (media >= 7) {
                Console.WriteLine("Você foi aprovado !!");

            }
            else
            {
                Console.WriteLine("Você foi reprovado !!");
            }
        }
    }
}
