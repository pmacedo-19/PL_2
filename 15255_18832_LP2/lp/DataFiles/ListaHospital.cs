using LibrariaHospital;
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace DataFiles
{
    /// <summary>
    /// Class para gestao de listas de hospitais
    /// </summary>
    [Serializable]
    public class ListaHospital
    {
        #region Variaveis

        private static List<Hospital> lsthospital = null;

        private static BinaryFormatter formatter;

        #endregion

        #region Construtores
        /// <summary>
        /// Criacao de lista para guardar o objeto hospital
        /// </summary>
        static ListaHospital()
        {
            lsthospital = new List<Hospital>();
            formatter = new BinaryFormatter();
        }

        /// <summary>
        /// Funcao para adicionar um hospital a lista
        /// </summary>
        /// @param name="hospital"> Recebe o Hospital a adicionar</param>
        /// <returns></returns>
        public static bool Addhospital(Hospital hospital)
        {
            try
            {
                if (lsthospital.Contains(hospital)) return false;
                lsthospital.Add(hospital);
            }
            catch (Exception e)
            {
                throw new Exception("Error! " + e.Message);
            }
            return true;
        }

        /// <summary>
        /// Funcao para remover um hospital da lista
        /// </summary>
        /// @param name="hospital"> Recebe o nome do Hospital a remover </param>
        public void Removehospital(Hospital hospital)
        {
            // Caso nao exista esse hospital
            if (!lsthospital.Contains(hospital))
            {
                Console.WriteLine(hospital.Nome + " had not been added before.");
            }
            // Caso exista esse hospital
            else
            {
                if (lsthospital.Remove(hospital))
                {
                    Console.WriteLine(hospital.Nome + " had been removed successfully.");
                }
                else
                {
                    Console.WriteLine("Unable to remove " + hospital.Nome);
                } 
            } 
        }

        /// <summary>
        /// Funcao para guardar a lista num ficheiro binario
        /// </summary>
        /// @param name="filename"> Ficheiro para o qual guarda a lista hospital </param>
        /// <returns></returns>
        public static bool SaveBinFile(string filename)
        {
            try
            {
                Stream str = File.Open(filename, FileMode.Create, FileAccess.Write);
                formatter.Serialize(str, lsthospital);
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
        /// Funcao para carregar informacao da lista hospital de ficheiro binario
        /// </summary>
        /// @param name="filename"> Ficheiro binario do qual carrega as informacoes da lista </param>
        /// <returns></returns>
        public static bool LoadBinFile(string filename)
        {
            try
            {
                Stream str = File.Open(filename, FileMode.Open, FileAccess.Read);
                lsthospital = (List<Hospital>)formatter.Deserialize(str);
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
        /// Funcao para procurar um hospital pelo nome
        /// </summary>
        /// @param name="nome"> Nome do hospital a procurar </param>
        /// <returns></returns>
        public static Hospital ProcurarHospitalNome(string nome)
        {
            Hospital auxH = null;
            try
            {
                auxH = lsthospital.Find(aux => aux.Nome == nome);
            }
            catch (ArgumentNullException e)
            {
                throw new ArgumentNullException("Error! " + e.Message);
            }
            catch (Exception e)
            {
                throw new Exception("Error! " + e.Message);
            }
            return auxH;
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
