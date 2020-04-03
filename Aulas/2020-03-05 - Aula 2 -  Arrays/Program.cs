/*
 * Manipulação de Memória com arrays
 * https://www.c-sharpcorner.com/article/working-with-arrays-in-C-Sharp/
 * Explorar Debuging
 * lufer
 * */
using System;

namespace MyArrays
{
    /// <summary>
    /// Essencial sobre arrays
    /// </summary>
    class Program
    {
        /// <summary>
        /// Manipular arrays
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region VARIOS

            #region DECLARAR_INICIALIZAR
            //Arrays simples
            //declarar e inicializar
            int[] valores = { 1, -2, 3, -4 };
            valores[0] = valores[3] - 2;
            valores[2] *= 1;
            int[] valores2 = new int[10];
            int[] valores3;

            char[] v1 = { 'B', 'r' };
            v1[0] = 's';
            //v1[2] = 'e';         //Erro!!!
            //
            string[] quaseClubes = { "Porto", "Gil Vicente", "Braguinha" };
            string[] clubes = new string[10];
            clubes[0] = "Benfica";
            clubes[1] = "Porto";
            Console.Write("Valor para inserir no Array de QuaseClubes:");
            clubes[2] = quaseClubes[1] + " e " +  Console.ReadLine();

            Console.WriteLine("Array QuaseClubes:");
            for (int i = 0; i < quaseClubes.Length; i++)
            {
                Console.WriteLine("Clube: {0}", clubes[i]);
            }
            //Nesta listagem do array existe um problema...qual? Corrigir!
            #endregion

            Console.ReadKey();

            #region PERCORRER_ARRAYS

            //Mostrar array
            //h1: ciclos
            Console.WriteLine("Array Valores inicial:");
            for(int i=0; i < valores.Length; i++)
            {
                Console.WriteLine("FOR -  Val: {0}", valores[i]);
            }

            //h2: foreach
            foreach(int v in valores)
            {
                Console.WriteLine("ForEach - Val: " + v);
            }
            #endregion

            #region PROCURAR_ARRAYS

            Console.ReadKey();
            Console.WriteLine();    //linha em branco
            //----------------------------------------------------------
            //Procurar elemento em array
            //H1 - Um pouco aldabrada
            Console.WriteLine("Verificar se o 27 existe no array Valores:");
            Console.WriteLine("Sem utilizar Break");
            int aux = 27;
            foreach (int i in valores)
            {
                if (i==aux)
                Console.WriteLine("Existe"); //???
            }
            Console.WriteLine("Não existe");

            //H2: como deve ser
            Console.WriteLine("Utilizando Break");
            bool existe = false;
            foreach (int i in valores)
            {
                if (i == aux)
                {
                    existe = true; break;
                }
            }
            Console.WriteLine((existe== true) ? "Existe" : "Não Existe");

            //----------------------------------------------------------
            Console.WriteLine("Usando Métodos nossos");
            //Usar métodos
            bool b = Arrays.Existe(aux, valores);
            Console.WriteLine((b== true) ? "Sim" : "Não");

            #endregion

            #region ALTERAR_ARRAYS
            //
            Console.WriteLine("Alterar array Valores com método:");
            Arrays.DobraArray(valores);

            Arrays.MostraArray(valores);
            #endregion

            #region ORDENAR_ARRAYS
            //Ordenar array
            Array.Sort(valores);
            Console.WriteLine("Array Ordenado:");
            Arrays.MostraArray(valores);
            #endregion


            Console.ReadKey();

            #endregion

            #region PERCORRER_ARRAYS_II

            #region h1
            //Problema:Encontrar um valor num array
            //Solução: percorrer diretamente o array
            int[] vals = { 2, 3, -7, 11, 0 };
            int valor = 7;
            existe = false;

            for(int i=0; i<vals.Length; i++)
            {
                if (vals[i] == valor)
                {
                    existe = true;
                    break;
                }
            }
            //output

            Console.WriteLine((existe == true) ? "Existe" : "Não Existe");

            //ou
            if (existe == true)
            {
                Console.WriteLine("Existe");
            }
            else
            {
                Console.WriteLine("Não Existe");
            }

            #endregion

            #region h2
            //Problema:Encontrar um valor num array
            //Solução: Usar método implementado por nós
            existe = Arrays.ExisteValor(7, vals);
            Console.WriteLine((existe == true) ? "Existe" : "Não Existe");

            #endregion


            #endregion

            #region UsarMetodosArrays

            existe = Arrays.ExisteValorArray(27, valores);
            Console.WriteLine("Existe? " + existe);

            valores3 = Arrays.DescVal(valores, -12);
            //h1
            //if (valores3!=null) Arrays.MostraArray(valores3);
            //h2
            if (valores3 !=null && valores3.Length > 0) 
                Arrays.MostraArray(valores3);
            #endregion

            Console.ReadKey();

            #region ARRAYSMULTIDIMENSIONAIS

            //unidimensionais
            int[] outrosValores = new int[30];
            string[] nomes = new string[] { "ola", "ole", "oli" };
            int[] novo = new int[] { 1, 3, 5, 7, 9 };

            //bidimensionais
            int[,] matriz = new int[4, 4];
            int[,] mat = new int[3, 3] { { 1, 2, 3 }, { 3, 4, 4 }, { 3, 4, 5 } };
            int[,] mat2 = { { 2, 3 }, { 3, 4 } };
            string[,] desporto = new string[2, 2] { { "Benfica", "Porto" }, { "Braga", "Sporting" } };
            string[,] emails = { { "lufer", "mcunha" }, { "jcsilva", "jpsilva" } };
            
            //mostrar array bidimensional
            for (int i = 0; i < emails.GetLength(0); i++)
            {
                for (int j = 0; j < emails.GetLength(1); j++)
                {
                    Console.Write(emails[i,j] + "\t");
                }
                System.Console.WriteLine();
            }

            //jagged array
            //data_type[][] name_of_array = new data_type[rows][]
            int[][] bilheteiras = new int[3][];

            bilheteiras[0] = new int[50];   //50 lugares
            bilheteiras[1] = new int[40];   //40 lugares
            bilheteiras[2] = new int[30];   //30 lugares

            //
            int[][] jagged = new int[3][];
            jagged[0] = new int[3];
            jagged[1] = new int[] { 3, 4, -5, 13 };
            jagged[2] = new int[] { -3,-4,5,6,7,5,6};

            // Display the array elements:  
            for (int i = 0; i < jagged.Length; i++)
            {
                System.Console.Write("Element({0}): ", i + 1);
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    System.Console.Write(jagged[i][j] + "\t");
                }
                System.Console.WriteLine();
            }

            #endregion



            Console.ReadKey();
        }




    }
}
