using LibrariaHospital;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace DataFiles
{
    [Serializable]
    public class ListaDoentes
    {
        #region Variaveis

        private static List<Doentes> lstdoente = null;

        private static BinaryFormatter formatter;

        #endregion

        #region Construtores
        /// <summary>
        /// Criacao de lista para guardar pessoas
        /// </summary>
        static ListaDoentes()
        {
            lstdoente = new List<Doentes>();
            formatter = new BinaryFormatter();
        }

        /// <summary>
        /// Construtor de dados externos
        /// </summary>
        /// Recebe o objeto Pessoa

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

        public void RemoveDoente(Doentes doente)
        {
            // If we do not have a friend with this name
            if (!lstdoente.Contains(doente))
            {
                Console.WriteLine(doente.Nome + " had not been added before.");
            }
            // Else if we have a friend with this name
            else
            {
                if (lstdoente.Remove(doente))
                {
                    Console.WriteLine(doente.Nome + " had been removed successfully.");
                }
                else
                {
                    Console.WriteLine("Unable to remove " + doente.Nome);
                } // end if
            } // end if
        }

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
