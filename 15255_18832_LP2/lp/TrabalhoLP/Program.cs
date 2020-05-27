using System;
using LibrariaHospital;


namespace TrabalhoLPII
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dados teste para o programa
            //doençass
            Infecao infecao1 = new Infecao("Bacteria", "Salmonela");
            Infecao infecao2 = new Infecao("Cancro", "tumor");
            Infecao infecao3 = new Infecao("Virus", "Gripe-A");
            Infecao infecao4 = new Infecao("Cancro", "carcinoma");
            Infecao infecao5 = new Infecao("Cancro", "linfoma");
            Infecao infecao6 = new Infecao("Virus", "Varicela");

            // pacientes
            Doentes doente1 = new Doentes(infecao1, 32, "Ricardo", 0, DateTime.Today, 0, 0);
            Doentes doente2 = new Doentes(infecao2, 45, "Pedro", 1, DateTime.Today, 0, 1);
            Doentes doente3 = new Doentes(infecao3, 41, "Tiago", 2, DateTime.Today, 2, 4);
            Doentes doente4 = new Doentes(infecao4, 62, "Maria", 0, DateTime.Today, 1, 3);
            Doentes doente5 = new Doentes(infecao5, 48, "Antonio", 0, DateTime.Today, 0, 0);
            Doentes doente6 = new Doentes(infecao6, 12, "Antonieta", 0, DateTime.Today, 1, 2);

            // hospital
            Hospital hos = new Hospital();

            // Associar os doentes ao hospital
            hos.InsereDoente(doente1);
            hos.InsereDoente(doente2);
            hos.InsereDoente(doente3);
            hos.InsereDoente(doente4);
            hos.InsereDoente(doente5);
            hos.InsereDoente(doente6);

            // Obter as fichas de todos os infetados ou ex infetados & O número total de casos infetados
            hos.ToString();

            Console.WriteLine("================================================================================="); 
           
            // Desativar determinado infetado inserindo o seu id
            hos.DesativarInfetado(4);

            // Fichas alualizadas
            hos.ToString();

            Console.WriteLine("=================================================================================");

            // Obter a ficha de um determinado doente através do id
            hos.MostraFicha(0);
        }
    }
}
