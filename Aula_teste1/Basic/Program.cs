/*
 * <author> Pedro Macedo </author>
 * <email> a15255@alunos.ipca.pt </email>
 * <date> 21/02/2020 </date>
 * <desc>exemplos de c# </desc>
 * 
 */


using System;

namespace Basic
{
    class Program
    {
        /// <summary>
        /// Resumo da função...
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int a, b, temp;
            Console.WriteLine("Insira a:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira b:");
            b = int.Parse(Console.ReadLine());

            ///ciclo de troca de a e b
            if (a < b) 
            {
                temp = a;
                a = b;
                b = temp;

                Console.WriteLine("b maior que a \nlogo troca");
            }

            Console.WriteLine("a= {0} \nb= {1}", a, b);

            Console.ReadLine();
        }
    }
}
