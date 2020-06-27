using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using LibrariaHospital;

namespace DataFiles
{
    /// <summary>
    /// Class para gestao de listas de Infecoes
    /// </summary>
    [Serializable]
    public class ListaInfecao
    {
        #region Variaveis

        private static List<Infecao> lstinfecao = null;

        private static BinaryFormatter formatter;

        #endregion

        #region Construtores
        /// <summary>
        /// Criacao de lista para guardar guardar um objeto infecao
        /// </summary>
        static ListaInfecao()
        {
            lstinfecao = new List<Infecao>();
            formatter = new BinaryFormatter();
        }

        /// <summary>
        /// Funcao para adicionar uma infecao a lista
        /// </summary>
        /// @param name="infecao"> Recebe a infecao a adicionar </param>
        /// <returns></returns>
        public static bool AddInfecao(Infecao infecao)
        {
            try
            {
                if (lstinfecao.Contains(infecao)) return false;
                lstinfecao.Add(infecao);
            }
            catch (Exception e)
            {
                throw new Exception("Error! " + e.Message);
            }
            return true;
        }

        /// <summary>
        /// Funcao para remover uma infecao da lista
        /// </summary>
        /// @param name="infecao"> Recebe o nome da Infecao a remover </param>
        public void RemoveInfecao(Infecao infecao)
        {
            // Caso nao exista essa infecao
            if (!lstinfecao.Contains(infecao))
            {
                Console.WriteLine(infecao.Nome + " had not been added before.");
            }
            // Caso exista a infecao
            else
            {
                if (lstinfecao.Remove(infecao))
                {
                    Console.WriteLine(infecao.Nome + " had been removed successfully.");
                }
                else
                {
                    Console.WriteLine("Unable to remove " + infecao.Nome);
                } 
            } 
        }

        /// <summary>
        /// Funcao para guardar a lista num ficheiro binario
        /// </summary>
        /// @param name="filename"> Ficheiro para o qual guarda a lista infecao </param>
        /// <returns></returns>
        public static bool SaveBinFile(string filename)
        {
            try
            {
                Stream str = File.Open(filename, FileMode.Create, FileAccess.Write);
                formatter.Serialize(str, lstinfecao);
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
        /// Funcao para carregar informacao da lista infecao de ficheiro binario
        /// </summary>
        /// @param name="filename"> Ficheiro binario do qual carrega as informacoes da lista </param>
        /// <returns></returns>
        public static bool LoadBinFile(string filename)
        {
            try
            {
                Stream str = File.Open(filename, FileMode.Open, FileAccess.Read);
                lstinfecao = (List<Infecao>)formatter.Deserialize(str);
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
        /// Funcao para procurar uma infecao pelo nome
        /// </summary>
        /// @param name="nome"> Nome da infecao a procurar </param>
        /// <returns></returns>
        public static Infecao ProcurarInfecaoNome(string nome)
        {
            Infecao auxI = null;
            try
            {
                auxI = lstinfecao.Find(aux => aux.Nome == nome);
            }
            catch (ArgumentNullException e)
            {
                throw new ArgumentNullException("Error! " + e.Message);
            }
            catch (Exception e)
            {
                throw new Exception("Error! " + e.Message);
            }
            return auxI;
        }


        #endregion

        #region Funcoes


        #endregion

        #region Properties
        #endregion

        #region Enums
        #endregion

        #region Overrides
        #endregion

    }
}
