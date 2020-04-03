using System;


namespace Testes
{
    class program
    {
        static void main(string[] args)
        {
            //array simples
            int n = 1;
            int k = 0;
            bool exists = false;

            int[] values = new int [n];

            for(int i = 0; i<values.Length; i++)
            {
                if (k == values[i])
                {
                    exists = true; break;
                }
            }
        }
    }
}