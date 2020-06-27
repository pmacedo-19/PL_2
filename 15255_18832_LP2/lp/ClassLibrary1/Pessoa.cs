using System;
using LibrariaHospital;

namespace LibrariaHospital
{
    /// <summary>
    /// Objeto para guardar informacao pessoal de pessoas
    /// </summary>
    [Serializable]
    public class Pessoa
    {

        #region Enums

        public enum Sexo 
        {
            Masculino = 0,
            Feminino = 1,
            Indeciso = 2
        }

        public enum Profissao
        {
            Advogado = 0,
            Medico = 1,
            Estudante = 2,
            DESEMPREGADO = 3,
            Dentista = 4,
            Policia = 5,
            Cozinheiro = 6,
            OUTRO
        }
        #endregion

        #region Estado

        int idade;
        string nome;
        int id;
        Sexo sexo;
        DateTime dataNascimento;
        Profissao profissao;

        #endregion

        #region Construtores

        /// <summary>
        /// Construtor para os dados pessoais
        /// </summary>
        public Pessoa()
        {
            idade = 0;
            nome = "";
            profissao = Profissao.DESEMPREGADO;
        }

        /// <summary>
        /// Construtor para os dados vindos do exterior
        /// </summary>
        /// @param "i" - Idade /param>
        /// @param "n" - Nome /param>
        /// @param "date" - DataNascimento /param>
        public Pessoa(int i, string n, DateTime date, int sexo, int profissao)
        { 
            nome = n;
            idade = i;
            this.sexo = (Sexo)sexo;
            dataNascimento = date;
            this.profissao = (Profissao)profissao;
        }
        #endregion

        #region Propriedades
      
        public int Idade
        {
            get { return idade; }
            set { if (value > 0) idade = value; }
        }
  
  
        public int Id
        {
            get { return id; }
            set { if (value > 0) id = value; }
        }

        public Sexo Sex
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public Profissao Prof
        {
            get { return profissao; }
            set { profissao = value; }
        }

        public string Nome
        {
            get { return nome; }
        }

        public DateTime DataNasc
        {
            get { return dataNascimento; }
            set
            {
                DateTime aux;
                if (DateTime.TryParse(value.ToString(), out aux) == true)
                {
                    dataNascimento = value;
                }
            }
        }
        #endregion
    }
}