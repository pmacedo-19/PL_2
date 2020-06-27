using LibrariaHospital;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace DataFiles
{
    /// <summary>
    /// Class para gestao de listas de doentes
    /// </summary>
    [Serializable]
    public class ListaDoentes
    {
        #region Variaveis

        private static List<Doentes> lstdoente = null;

        private static BinaryFormatter formatter;

        #endregion

        #region Construtores

        #endregion

        #region Funcoes
        /// <summary>
        /// Criacao de lista pessoa para guardar o objeto doente
        /// </summary>
        static ListaDoentes()
        {
            lstdoente = new List<Doentes>();
            formatter = new BinaryFormatter();
        }

        /// <summary>
        /// Funcao para adicionar um doente a lista
        /// </summary>
        /// @param name="doente"> Recebe o doente a adicionar </param>
        /// <returns></returns>
        public static bool AddDoente(Doentes doente)
        {
            try
            {
                if (lstdoente.Contains(doente)) return false;
                lstdoente.Add(doente);
            }
            catch (Exception e)
            {
                throw new Exception("Error! " + e.Message);
            }
            return true;
        }

        /// <summary>
        /// Funcao para remover um doente da lista
        /// </summary>
        /// @param name="doente"> Recebe o nome do doente a remover </param>
        public void RemoveDoente(Doentes doente)
        {
            // Caso nao exista esse doente
            if (!lstdoente.Contains(doente))
            {
                Console.WriteLine(doente.Nome + " had not been added before.");
            }
            // Caso exista o doente
            else
            {
                if (lstdoente.Remove(doente))
                {
                    Console.WriteLine(doente.Nome + " had been removed successfully.");
                }
                else
                {
                    Console.WriteLine("Unable to remove " + doente.Nome);
                }
            }
        }

        /// <summary>
        /// Funcao para guardar a lista num ficheiro binario
        /// </summary>
        /// @param name="filename"> Ficheiro para o qual guarda a lista doente </param>
        /// <returns></returns>
        public static bool SaveBinFile(string filename)
        {
            try
            {
                Stream str = File.Open(filename, FileMode.Create, FileAccess.Write);
                formatter.Serialize(str, lstdoente);
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
                lstdoente = (List<Doentes>)formatter.Deserialize(str);
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
        /// Funcao para procurar um doente pelo nome
        /// </summary>
        /// @param name="nome"> Nome do doente a procurar </param>
        /// <returns></returns>
        public static Doentes ProcurarDoenteNome(string nome)
        {
            Doentes auxD = null;
            try
            {
                auxD = lstdoente.Find(aux => aux.Nome == nome);
            }
            catch (ArgumentNullException e)
            {
                throw new ArgumentNullException("Error! " + e.Message);
            }
            catch (Exception e)
            {
                throw new Exception("Error! " + e.Message);
            }
            return auxD;
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
