using System;
using LibrariaHospital;

namespace LibrariaHospital
{
    /// <summary>
    /// Objeto para guardar informacao das infecoes
    /// </summary>
    [Serializable]
    public class Infecao
    {

        #region Estado

        //Tipo de infeção ou doença apresentada
        string tipo;
        // Nome
        string nome;

        // Exemplo: tipo - virus , nome - Varicela


        #endregion

        #region Properties

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        #endregion

        #region Construtor

        /// <summary>
        /// Criacao do objeto infecao
        /// </summary>
        /// @param name="t"> Tipo de infecao (virus,bacteri, etc...) </param>
        /// @param name="n"> Nome da infecao </param>
        public Infecao(string t, string n)
        {
            nome = n;
            tipo = t;
        }

        #endregion

    }
}