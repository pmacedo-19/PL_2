using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using LibrariaHospital;

namespace DataFiles
{
    public class ListaPessoa
    {
        #region Variaveis

        private static List<Pessoa> lstpessoa = null;

        private static BinaryFormatter formatter;

        #endregion

        #region Construtores
        /// <summary>
        /// Criacao de lista para guardar pessoas
        /// </summary>
        static ListaPessoa()
        {
            lstpessoa = new List<Pessoa>();
            formatter = new BinaryFormatter();
        }

        /// <summary>
        /// Construtor de dados externos
        /// </summary>
        /// Recebe o objeto Pessoa
        
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

        public void RemovePessoa(Pessoa pessoa)
        {
            // If we do not have a friend with this name
            if (!lstpessoa.Contains(pessoa))
            {
                Console.WriteLine(pessoa.Nome + " had not been added before.");
            }
            // Else if we have a friend with this name
            else
            {
                if (lstpessoa.Remove(pessoa))
                {
                    Console.WriteLine(pessoa.Nome + " had been removed successfully.");
                }
                else
                {
                    Console.WriteLine("Unable to remove " + pessoa.Nome);
                } // end if
            } // end if
        }

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
