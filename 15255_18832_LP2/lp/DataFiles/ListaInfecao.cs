using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using LibrariaHospital;

namespace DataFiles
{
    [Serializable]
    public class ListaInfecao
    {
        #region Variaveis

        private static List<Infecao> lstinfecao = null;

        private static BinaryFormatter formatter;

        #endregion

        #region Construtores
        /// <summary>
        /// Criacao de lista para guardar infecaos
        /// </summary>
        static ListaInfecao()
        {
            lstinfecao = new List<Infecao>();
            formatter = new BinaryFormatter();
        }

        /// <summary>
        /// Construtor de dados externos
        /// </summary>
        /// Recebe o objeto Infecao

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

        public void RemoveInfecao(Infecao infecao)
        {
            // If we do not have a friend with this name
            if (!lstinfecao.Contains(infecao))
            {
                Console.WriteLine(infecao.Nome + " had not been added before.");
            }
            // Else if we have a friend with this name
            else
            {
                if (lstinfecao.Remove(infecao))
                {
                    Console.WriteLine(infecao.Nome + " had been removed successfully.");
                }
                else
                {
                    Console.WriteLine("Unable to remove " + infecao.Nome);
                } // end if
            } // end if
        }

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
