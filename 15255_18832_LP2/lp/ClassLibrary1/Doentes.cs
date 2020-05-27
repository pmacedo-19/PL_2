using System;
using LibrariaHospital;

namespace LibrariaHospital
{
    

    public class Doentes : Pessoa
    {
        #region Estado

        Infecao infetado;
        bool ativo;

        #endregion

        #region Propriedades

        public Infecao AdicionarInfecao
        {
            get { return infetado; }
            set { infetado = value; }
        }

        public bool Estado 
        {
            get { return ativo; }
            set { ativo = value; }
        }

        #endregion

        #region Construtor

        public Doentes(Infecao inf)
        {
            this.infetado = inf;
            this.ativo = true;
        }

        /// <summary>
        /// Construtor da classe Doentes
        /// </summary>
        /// <param "inf" - Ficha da infecao </param>
        /// <param "idade" - Idade do doente</param>
        /// <param "nome" - Nome do doente</param>
        /// <param "regiao" - Região do doente</param>
        /// <param "dataNasc" - Data de nascimento do doente</param>
        /// <param "sexo" - Sexo do doente</param>
        /// <param "profissao" - Profissao do doente</param>
        public Doentes( Infecao inf, int idade, string nome, int regiao, DateTime dataNasc, int sexo, int profissao) 
                        : base (idade, nome, regiao, dataNasc, sexo, profissao)
        {
            this.infetado = inf;
            this.ativo = true;
        }

        #endregion

        #region Override

        public override string ToString()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Idade: " + Idade);

            return "";
        }

        #endregion

    }
}
