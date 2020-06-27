using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using LibrariaHospital;

namespace DataFiles
{
    /// <summary>
    /// Class para gestao de listas de pessoas
    /// </summary>
    [Serializable]
    public class ListaPessoa
    {
        #region Variaveis

        // Criacao de uma lista pessoa vazia
        private static List<Pessoa> lstpessoa = null;

        private static BinaryFormatter formatter;

        #endregion

        #region Construtores

        #endregion

        #region Funcoes
        
        /// <summary>
        /// Criacao de lista para guardar um objeto pessoa
        /// </summary>
        static ListaPessoa()
        {
            lstpessoa = new List<Pessoa>();
            formatter = new BinaryFormatter();
        }

        /// <summary>
        /// Construtor de dados externos para adicionar um pessoa
        /// </summary>
        /// @param name="pessoa"> recebe a estrutura pessoa que se pretende adicionar </param>
        /// <returns></returns>
        public static bool AddPessoa(Pessoa pessoa)
        {
            try
            {
                if (lstpessoa.Contains(pessoa)) return false;
                lstpessoa.Add(pessoa);
            }
            catch (Exception e)
            {
                throw new Exception("Error! " + e.Message);
            }
            return true;
        }

        /// <summary>
        /// Metodo para remover uma pessoa da lista
        /// </summary>
        /// @param name="pessoa"> Recebe a pessoa que se pretende remover </param>
        public void RemovePessoa(Pessoa pessoa)
        {
            // Caso nao exista essa pessoa
            if (!lstpessoa.Contains(pessoa))
            {
                Console.WriteLine(pessoa.Nome + " had not been added before.");
            }
            // Caso exista essa pessoa
            else
            {
                if (lstpessoa.Remove(pessoa))
                {
                    Console.WriteLine(pessoa.Nome + " had been removed successfully.");
                }
                else
                {
                    Console.WriteLine("Unable to remove " + pessoa.Nome);
                }
            }
        }

        /// <summary>
        /// Funcao para guardar a lista pessoa em ficheiro binario
        /// </summary>
        /// @param name="filename"> Ficheiro para o qual guarda a lista pessoa </param>
        /// <returns></returns>
        public static bool SaveBinFile(string filename)
        {
            try
            {
                Stream str = File.Open(filename, FileMode.Create, FileAccess.Write);
                formatter.Serialize(str, lstpessoa);
                str.Flush(); // Limpar buffer
                str.Close(); // Fechar acesso a stream
                str.Dispose(); // Libertar rescursos usados pela stream
            }
            // Erros de excecao
            catch (FileNotFoundException f)
            {
                throw new FileNotFoundException("Error! " + f.Message);
            }
            catch (SerializationException f)
            {
                throw new SerializationException("Error! " + f.Message);
            }
            catch (IOException f)
            {
                throw new IOException("Error! " + f.Message);
            }
            catch (Exception f)
            {
                throw new Exception("Error! " + f.Message);
            }
            return true;
        }

        /// <summary>
        /// Funcao para carregar informacao da lista pessoa de ficheiro binario
        /// </summary>
        /// @param name="filename"> Ficheiro binario do qual carrega as informacoes da lista </param>
        /// <returns></returns>
        public static bool LoadBinFile(string filename)
        {
            try
            {
                Stream str = File.Open(filename, FileMode.Open, FileAccess.Read);
                lstpessoa = (List<Pessoa>)formatter.Deserialize(str);
                str.Flush(); // Limpar buffer
                str.Close(); // Fechar acesso a stream
                str.Dispose(); // Libertar rescursos usados pela stream
            }
            // Erros de excecao
            catch (FileNotFoundException f)
            {
                throw new FileNotFoundException("Error! " + f.Message);
            }
            catch (SerializationException f)
            {
                throw new SerializationException("Error! " + f.Message);
            }
            catch (IOException f)
            {
                throw new IOException("Error! " + f.Message);
            }
            catch (Exception f)
            {
                throw new Exception("Error! " + f.Message);
            }
            return true;
        }

        /// <summary>
        /// Funco para procurar uma pessoa na lista pelo nome
        /// </summary>
        /// @param name="nome"> Nome da pessoa que se quer procurar </param>
        /// <returns></returns>
        public static Pessoa ProcurarPessoaNome(string nome)
        {
            Pessoa auxP = null;
            try
            {
                auxP = lstpessoa.Find(aux => aux.Nome == nome);
            }
            catch (ArgumentNullException e)
            {
                throw new ArgumentNullException("Error! " + e.Message);
            }
            catch (Exception e)
            {
                throw new Exception("Error! " + e.Message);
            }
            return auxP;
        }
        #endregion

        #region Properties
        #endregion

        #region Enums
        #endregion

        #region Overrides
        #endregion
    }
}
