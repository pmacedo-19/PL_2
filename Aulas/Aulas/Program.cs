using System;

namespace Aulas
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, aux = 0;

            int[] values = new int [100];

            Console.WriteLine("Insira o numero a pesquisar: ");

            for (int i = 0; i < values.Length ; i++)
            {
                if (values[i] == x)
                {
                    aux = x;
                }

            }

            Console.WriteLine("{0}", aux );
        }
    }
}
