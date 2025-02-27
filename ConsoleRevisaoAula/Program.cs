using System.ComponentModel;

namespace ConsoleRevisaoAula
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite a 1ª nota do aluno!");
            double nota1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a 2ª nota do aluno!");
            double nota2=Convert.ToDouble(Console.ReadLine());

            double media = (nota1 + nota2) /2;

            if (media >= 7)
            {
                Console.WriteLine("Aprovado!");
            }
            else if (false)
            {
                Console.WriteLine("Reprovado!");
            }
            else
            {
                Console.WriteLine("Recuperação");
            }
             
        }
    }
}
