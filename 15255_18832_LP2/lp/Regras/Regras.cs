using System;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using LibrariaHospital;
using System.Runtime.Serialization;
using DataFiles;

namespace RegrasClass
{
    public class Regras
    {
        #region Constructors

        public Regras()
        {
        }
        #endregion


        #region Properties
        #endregion


        #region Functions

        public static bool InserirPessoa(Pessoa pessoa, int perfil)
        {
            // Varialvel aux
            bool resultado = false;

            if (perfil > 0)
            {
                try
                {
                    resultado = ListaPessoa.AddPessoa(pessoa);
                }

                catch (Exception e)
                {
                    throw new Exception("Error! " + e.Message);
                }
            }
            return resultado;
        }

        public static bool ListaPessoaSaveBinFile(string filename, int perfil)
        {
            // Varialvel aux
            bool resultado = false;

            if (perfil > 0)
            {
                try
                {
                    resultado = ListaPessoa.SaveBinFile(filename);
                }
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
            }
            return resultado;
        }

        public static bool ListaPessoaLoadBinFile(string filename, int perfil)
        {
            // Auxiliary variables
            bool resultado = false;
            // Apply rule
            if (perfil > 0)
            {
                // Get access to the file
                try
                {
                    resultado = ListaPessoa.LoadBinFile(filename);
                } // Error Handling - Exceptions
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
            }
            return resultado;
        }



        public static bool InserirDoente(Doentes doente, int perfil)
        {
            // Varialvel aux
            bool resultado = false;

            if (perfil > 0)
            {
                try
                {
                    resultado = ListaDoentes.AddDoente(doente);
                }

                catch (Exception e)
                {
                    throw new Exception("Error! " + e.Message);
                }
            }
            return resultado;
        }

        public static bool ListaDoentesSaveBinFile(string filename, int perfil)
        {
            // Varialvel aux
            bool resultado = false;

            if (perfil > 0)
            {
                try
                {
                    resultado = ListaDoentes.SaveBinFile(filename);
                }
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
            }
            return resultado;
        }

        public static bool ListaDoentesLoadBinFile(string filename, int perfil)
        {
            // Auxiliary variables
            bool resultado = false;
            // Apply rule
            if (perfil > 0)
            {
                // Get access to the file
                try
                {
                    resultado = ListaDoentes.LoadBinFile(filename);
                } // Error Handling - Exceptions
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
            }
            return resultado;
        }






        #endregion


        #region Enums
        #endregion
    }
}
