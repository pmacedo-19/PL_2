using System;
using LibrariaHospital;

namespace LibrariaHospital
{
    /// <summary>
    /// Objeto para guardar informacoes de hospitais e suas lotacoes
    /// </summary>
    [Serializable]
    public class Hospital
    {
        #region Estado

        int lotacao;
        static int nDoentes;
        static Doentes[] doentes;
        string nome;

        #endregion

        #region Construtores

        /// <summary>
        /// Construtor da classe Hospital
        /// </summary>
        public Hospital()
        {
            nome = "";
            lotacao = 0;
            nDoentes = 0;
        }

        public string Nome
        {
            get { return Nome; }
        }


        #endregion

        #region Metodos
        
        public Hospital(string h, int l, int d )
        {
            nome = h;
            lotacao = l;
            nDoentes = d;
        }


        /// <summary>
        /// Regista um doente
        /// </summary>
        /// @param Doentes="d">Ficha do Doente</param>
        public int InsereDoente(Doentes d)
        {
            if (nDoentes >= lotacao) return 0;

            doentes[nDoentes] = d;
            nDoentes++;
            d.Id = nDoentes;

            return 1;
        }

        /// <summary>
        /// Regista uma infecao num doente
        /// </summary>
        /// @param Doentes="d"> Ficha do Doente </param>
        /// @param Infecao="infec"> Informcao sobre a infecao </param>
        public static void RegistaInfecao(Infecao infec, Doentes d)
        {
            d.AdicionarInfecao = infec;
        }

        #endregion

        #region MetodosSecundarios

        /// <summary>
        /// Verificar a existencia de um doente por nome
        /// </summary>
        /// @param "nome" - Nome do Doente /param>
        /// <returns>True - se existir, False - se nao existir </returns>
        public bool ExisteDoenteNome(string nome)
        {
            for (int i = 0; i < nDoentes; i++)
            {
                if (doentes[i].Nome.CompareTo(nome) == 0)
                {
                    return true;
                }
            }
            return false;
        }


        /// <summary>
        /// Procura uma ficha por ID
        /// </summary>
        /// @param "id" - ID da Pessoa /param>
        /// <returns> Ficha da Pessoa </returns>
        public static Pessoa FichaDoenteID(int id)
        {
            for (int i = 0; i < nDoentes; i++)
            {
                if (doentes[i] != null && doentes[i].Id == id) return doentes[i];
            }
            return null;
        }

        /// <summary>
        /// Procura Ficha por nome
        /// </summary>
        /// @param "nome" - Nome do Doente /param>
        /// <returns> Ficha da pessoa </returns>
        public static Pessoa FichaDoenteNome(string nome)
        {
            for (int i = 0; i < nDoentes; i++)
            {
                if (doentes[i] != null && doentes[i].Nome.CompareTo(nome) == 0)
                {
                    return doentes[i];
                }
            }
            return null;
        }
        
        /// <summary>
        /// Conta o numero de doentes
        /// </summary>
        /// <returns> Numero de doentes </returns>
        public static int ContaDoentes(){
            int count = 0;
            for(int i = 0; i < nDoentes; i++){
                if(doentes[i].Estado == true)
                    count++;
            }
            return count;
        }

 
        /// <summary>
        /// Passa de infetado a curado
        /// </summary>
        /// @param"id" - ID do doente /param>
        public void DesativarInfetado(int id)
        {
            for(int i = 0; i < nDoentes; i++)
            {
                if(doentes[i].Id == id)
                    doentes[i].Estado = false;
            }
            
        }

        /// <summary>
        /// Mostra a ficha de um doente atraves do ID inserido pelo user
        /// </summary>
        /// @param "i" - Id /param>
        public void MostraFicha(int i)
        {
            Console.WriteLine("Ficha do id " + i + " ...");
            Console.WriteLine("Nome             : " + doentes[i].Nome);
            Console.WriteLine("Idade            : " + doentes[i].Idade);
            Console.WriteLine("ID               : " + doentes[i].Id);
            Console.WriteLine("Data nascimento  : " + doentes[i].DataNasc);
            Console.WriteLine("Sexo             : " + doentes[i].Sex);
            Console.WriteLine("Profissao        : " + doentes[i].Prof);
            Console.WriteLine("Infetado com     : " + doentes[i].AdicionarInfecao.Tipo + "nome : " + doentes[i].AdicionarInfecao.Nome);
            Console.WriteLine("Infetado         : " + doentes[i].Estado);
            Console.WriteLine();
        }

        #endregion

        #region Override

        public override string ToString()
        {
            for (int i = 0; i < nDoentes; i++)
            {
                Console.WriteLine("Nome             : " + doentes[i].Nome);
                Console.WriteLine("Idade            : " + doentes[i].Idade);
                Console.WriteLine("ID               : " + doentes[i].Id);
                Console.WriteLine("Data nascimento  : " + doentes[i].DataNasc);
                Console.WriteLine("Sexo             : " + doentes[i].Sex);
                Console.WriteLine("Profissao        : " + doentes[i].Prof);
                Console.WriteLine("Tipo de doença   : " + doentes[i].AdicionarInfecao.Tipo + "nome : " + doentes[i].AdicionarInfecao.Nome);
                Console.WriteLine("Infetado         : " + doentes[i].Estado);
                Console.WriteLine();
            }

            Console.WriteLine("Casos Infetados: " + ContaDoentes());
            Console.WriteLine();

            return "";
        }

        #endregion
    }
}