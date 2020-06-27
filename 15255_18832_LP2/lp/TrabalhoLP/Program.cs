/*! \mainpage Linguagem de programação II
 * 
 * \section intro_sec Projeto I Fase 4 (Melhoria)
 *
 * Ferramenta de gestão de: 
 *                          - Doentes e não doentes;
 *                          - Infeções;
 *                          - Hospitais;
 *
 * 
 * \subsection autores Autores:
 * 
 *      Pedro Macedo - a15255
 *      Ricardo Silva - a18832
 *
 *
 */

using LibrariaHospital;
using RegrasClass;
using System;
using System.Security;

namespace TrabalhoLPII
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Ficheiros
            const string SRC_FILE_BIN_PESSOA = "PessoaData.bin";
            const string SRC_FILE_BIN_DOENTES = "DoentesData.bin";
            const string SRC_FILE_BIN_HOSPITAL = "HospitalData.bin";
            const string SRC_FILE_BIN_INFECAO = "InfecaoData.bin";

            #endregion

            #region Testes
            //// Dados teste para o programa
            ////doençass
            Infecao infecao1 = new Infecao("Bacteria", "Salmonela");
            //Infecao infecao2 = new Infecao("Cancro", "tumor");
            //Infecao infecao3 = new Infecao("Virus", "Gripe-A");
            //Infecao infecao4 = new Infecao("Cancro", "carcinoma");
            //Infecao infecao5 = new Infecao("Cancro", "linfoma");
            //Infecao infecao6 = new Infecao("Virus", "Varicela");

            //// pacientes
            //Doentes doente1 = new Doentes(infecao1, 32, "Ricardo", 0, DateTime.Today, 0, 0);
            //Doentes doente2 = new Doentes(infecao2, 45, "Pedro", 1, DateTime.Today, 0, 1);
            //Doentes doente3 = new Doentes(infecao3, 41, "Tiago", 2, DateTime.Today, 2, 4);
            //Doentes doente4 = new Doentes(infecao4, 62, "Maria", 0, DateTime.Today, 1, 3);
            //Doentes doente5 = new Doentes(infecao5, 48, "Antonio", 0, DateTime.Today, 0, 0);
            //Doentes doente6 = new Doentes(infecao6, 12, "Antonieta", 0, DateTime.Today, 1, 2);

            //// hospital
            //Hospital hos = new Hospital();

            //// Associar os doentes ao hospital
            //hos.InsereDoente(doente1);
            //hos.InsereDoente(doente2);
            //hos.InsereDoente(doente3);
            //hos.InsereDoente(doente4);
            //hos.InsereDoente(doente5);
            //hos.InsereDoente(doente6);

            //// Obter as fichas de todos os infetados ou ex infetados & O número total de casos infetados
            //hos.ToString();

            //Console.WriteLine("=================================================================================");

            //// Desativar determinado infetado inserindo o seu id
            //hos.DesativarInfetado(4);

            //// Fichas alualizadas
            //hos.ToString();

            //Console.WriteLine("=================================================================================");

            //// Obter a ficha de um determinado doente através do id
            //hos.MostraFicha(0);

            #endregion

            #region Testes2
            Pessoa pessoa1 = new Pessoa(19, "Ze", DateTime.Now, 1, 1);
            Pessoa pessoa2 = new Pessoa(29, "Manel",DateTime.Now, 1, 1);


            try
            {
                Regras.InserirPessoa(pessoa1, 7);
                Regras.InserirPessoa(pessoa2, 8);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: {0}", e.Message);
            }

            Regras.ListaPessoaSaveBinFile(SRC_FILE_BIN_PESSOA, 7);
            Regras.ListaPessoaSaveBinFile(SRC_FILE_BIN_PESSOA, 8);


            Doentes d1 = new Doentes(infecao1, 32, "Ricardo", 0, DateTime.Today, 0, 0);
            Doentes d2 = new Doentes(infecao1, 13, "Manel", 0, DateTime.Today, 0, 0);
            try
            {
                Regras.InserirDoente(d1, 7);
                Regras.InserirDoente(d2, 8);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: {0}", e.Message);
            }

            Regras.ListaDoentesSaveBinFile(SRC_FILE_BIN_DOENTES, 7);


            Hospital hospital1 = new Hospital("Hospital da Luz", 500, 20);
            Hospital hospital2 = new Hospital("Hospital de S. Joao", 500, 20);
            Regras.InserirHospital(hospital1, 7);
            Regras.InserirHospital(hospital2, 8);
            Regras.ListaHospitalSaveBinFile(SRC_FILE_BIN_HOSPITAL, 7);
            Regras.ListaHospitalSaveBinFile(SRC_FILE_BIN_HOSPITAL, 8);


            Infecao infecaoA = new Infecao("Bacteria", "Salmonela");
            Infecao infecaoB = new Infecao("Virus", "Gripe-A");
            Regras.InserirInfecao(infecaoA, 7);
            Regras.InserirInfecao(infecaoB, 8);
            Regras.ListaInfecaoSaveBinFile(SRC_FILE_BIN_INFECAO, 7);
            Regras.ListaInfecaoSaveBinFile(SRC_FILE_BIN_INFECAO, 8);


            Pessoa aux = Regras.ProcurarPessoaNome("Ze", 7);
            Console.WriteLine(aux.ToString());



            #endregion


            //#region Variaveis
            //bool sair = false;
            //#endregion

            //#region Menu
            //while(!sair)
            //{
            //    Console.Clear();


            //}

        }
    }
}
