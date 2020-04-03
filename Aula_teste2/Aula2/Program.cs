using System;

namespace Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            char s;
            float result = 0;

            a = int.Parse(Console.ReadLine());

            b = int.Parse(Console.ReadLine());

            s = char.Parse(Console.ReadLine());

            if ( s == '*' )
            {
                result = a * b;

            } else if ( s == '+' )
            {
                result = a + b;

            } else if ( s == '-' )
            {
                result = a - b;

            } else if ( s == '/' )
            {
                result = a / b;

            } else
            {
                Console.WriteLine("Error");
            }


            Console.WriteLine(result);
        }
    }
}
