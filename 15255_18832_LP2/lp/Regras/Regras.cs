using System;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using LibrariaHospital;
using System.Runtime.Serialization;
using DataFiles;
using System.Collections.Generic;

namespace RegrasClass
{
    /// <summary>
    /// Class intermedia para leitura e escrita de ficheiros
    /// </summary>
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

        /// <summary>
        /// Funcao para inserir uma pessoa
        /// </summary>
        /// @param name="pessoa"> pessoa a inserir </param>
        /// @param name="perfil"> perfil a atribuir a essa pessoa </param>
        /// <returns></returns>
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

        /// <summary>
        /// Funcao para guardar a pessoa inserida num ficheiro binario
        /// </summary>
        /// @param name="filename"> nome do ficheiro </param>
        /// @param name="perfil"> perfil da pessoa atribuida </param>
        /// <returns></returns>
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

        /// <summary>
        /// Funcao para carregar informacao de uma pessoa
        /// </summary>
        /// @param name="filename"> nome do ficheiro a carregar </param>
        /// @param name="perfil"> tipo de perfil a atribuir </param>
        /// <returns></returns>
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

        /// <summary>
        /// Funcao para procurar pessoa por nome
        /// </summary>
        /// @param name="nome"> nome da pessoa a procurar </param>
        /// @param name="perfil"> perfil da pessoa a procurar </param>
        /// <returns></returns>
        public static Pessoa ProcurarPessoaNome(string nome, int perfil)
        {
            // Get access to the class
            if (perfil > 0)
            {
                try
                {
                    return ListaPessoa.ProcurarPessoaNome(nome);
                }
                catch (ArgumentException e)
                {
                    throw new ArgumentException("Error! " + e.Message);
                }
                catch (Exception e)
                {
                    throw new Exception("Error! " + e.Message);
                }
            }
            return null;
        }


        /// <summary>
        /// Funcao para inserir um doente
        /// </summary>
        /// @param name="doente"> Doente a inserir </param>
        /// @param name="perfil"> Perfil a atribuir ao doente </param>
        /// <returns></returns>
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

        /// <summary>
        /// Funcao para guardar o doente no ficheiro binario
        /// </summary>
        /// @param name="filename"> nome do ficheiro a guardar </param>
        /// @param name="perfil"> perfil a guardar </param>
        /// <returns></returns>
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

        /// <summary>
        /// Funcao para carregar doente do ficheiro binario
        /// </summary>
        /// @param name="filename"> nome do ficheiro a carregar </param>
        /// @param name="perfil"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Funcao para procurar doente por nome
        /// </summary>
        /// @param name="nome"> nome do doente a procurar </param>
        /// @param name="perfil"></param>
        /// <returns></returns>
        public static Doentes ProcurarDoenteNome(string nome, int perfil)
        {
            // Get access to the class
            if (perfil > 0)
            {
                try
                {
                    return ListaDoentes.ProcurarDoenteNome(nome);
                }
                catch (ArgumentException e)
                {
                    throw new ArgumentException("Error! " + e.Message);
                }
                catch (Exception e)
                {
                    throw new Exception("Error! " + e.Message);
                }
            }
            return null;
        }

        /// <summary>
        /// Funcao para inserir um hospital
        /// </summary>
        /// @param name="hospital"> nome do hospital a inserir </param>
        /// @param name="perfil"></param>
        /// <returns></returns>
        public static bool InserirHospital(Hospital hospital, int perfil)
        {
            // Varialvel aux
            bool resultado = false;

            if (perfil > 0)
            {
                try
                {
                    resultado = ListaHospital.Addhospital(hospital);
                }

                catch (Exception e)
                {
                    throw new Exception("Error! " + e.Message);
                }
            }
            return resultado;
        }

        /// <summary>
        /// Funcao para guardar hospital em ficheiro binario
        /// </summary>
        /// @param name="filename"> nome do ficheiro a guardar </param>
        /// @param name="perfil"></param>
        /// <returns></returns>
        public static bool ListaHospitalSaveBinFile(string filename, int perfil)
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

        /// <summary>
        /// funcao para carregar hospital do ficheiro binario
        /// </summary>
        /// @param name="filename"> nome do ficheiro a carregar </param>
        /// @param name="perfil"></param>
        /// <returns></returns>
        public static bool ListaHospitalLoadBinFile(string filename, int perfil)
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

        /// <summary>
        /// Funcao para procurar hospital por nome
        /// </summary>
        /// @param name="nome"> nome do hospital a carregar </param>
        /// @param name="perfil"></param>
        /// <returns></returns>
        public static Hospital ProcurarHospitalNome(string nome, int perfil)
        {
            // Get access to the class
            if (perfil > 0)
            {
                try
                {
                    return ListaHospital.ProcurarHospitalNome(nome);
                }
                catch (ArgumentException e)
                {
                    throw new ArgumentException("Error! " + e.Message);
                }
                catch (Exception e)
                {
                    throw new Exception("Error! " + e.Message);
                }
            }
            return null;
        }

        /// <summary>
        /// Funcao para inserir infecao
        /// </summary>
        /// @param name="infecao"> nome da infecao a inserir </param>
        /// @param name="perfil"></param>
        /// <returns></returns>
        public static bool InserirInfecao(Infecao infecao, int perfil)
        {
            // Varialvel aux
            bool resultado = false;

            if (perfil > 0)
            {
                try
                {
                    resultado = ListaInfecao.AddInfecao(infecao);
                }

                catch (Exception e)
                {
                    throw new Exception("Error! " + e.Message);
                }
            }
            return resultado;
        }

        /// <summary>
        /// Funcao para salvar infecao em ficheiro binario
        /// </summary>
        /// @param name="filename"> nome do ficheiro a guardar </param>
        /// @param name="perfil"></param>
        /// <returns></returns>
        public static bool ListaInfecaoSaveBinFile(string filename, int perfil)
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

        /// <summary>
        /// Funcao para carregar infecao de ficheiro binario
        /// </summary>
        /// @param name="filename"> nome do ficheiro a carregar </param>
        /// @param name="perfil"></param>
        /// <returns></returns>
        public static bool ListaInfecaoLoadBinFile(string filename, int perfil)
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

        /// <summary>
        /// Procurar uma infecao pelo nome
        /// </summary>
        /// @param name="nome"> nome da infecao a procurar </param>
        /// @param name="perfil"></param>
        /// <returns></returns>
        public static Infecao ProcurarInfecaoNome(string nome, int perfil)
        {
            // Get access to the class
            if (perfil > 0)
            {
                try
                {
                    return ListaInfecao.ProcurarInfecaoNome(nome);
                }
                catch (ArgumentException e)
                {
                    throw new ArgumentException("Error! " + e.Message);
                }
                catch (Exception e)
                {
                    throw new Exception("Error! " + e.Message);
                }
            }
            return null;
        }

        #endregion


        #region Enums
        #endregion
    }
}
