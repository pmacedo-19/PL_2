using LibrariaHospital;
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace DataFiles
{
    [Serializable]
    public class ListaHospital
    {
        #region Variaveis

        private static List<Hospital> lsthospital = null;

        private static BinaryFormatter formatter;

        #endregion

        #region Construtores
        /// <summary>
        /// Criacao de lista para guardar hospitals
        /// </summary>
        static ListaHospital()
        {
            lsthospital = new List<Hospital>();
            formatter = new BinaryFormatter();
        }

        /// <summary>
        /// Construtor de dados externos
        /// </summary>
        /// Recebe o objeto hospital

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

        public void Removehospital(Hospital hospital)
        {
            // If we do not have a friend with this name
            if (!lsthospital.Contains(hospital))
            {
                Console.WriteLine(hospital.Nome + " had not been added before.");
            }
            // Else if we have a friend with this name
            else
            {
                if (lsthospital.Remove(hospital))
                {
                    Console.WriteLine(hospital.Nome + " had been removed successfully.");
                }
                else
                {
                    Console.WriteLine("Unable to remove " + hospital.Nome);
                } // end if
            } // end if
        }

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
