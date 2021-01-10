using System;

namespace VendasEventos
{

    /// <summary>
    /// Summary description for Class1
    /// </summary>
    public class Atendente
    {
        public static string MenuPrincipal()
        {
            string opcaoUm;

            Console.WriteLine("Escolha uma opção");
            Console.WriteLine("1 - Abrir o Caixa");
            Console.WriteLine("2 - Fechar o Caixa");
            Console.WriteLine("3 - Abrir Novo Pedido");
            Console.WriteLine("4 - Consultar Pedidos");
            Console.WriteLine("5 - Bloquear o Caixa");
            Console.WriteLine("6 - Contato \n \n");
            opcaoUm = Console.ReadLine();
            opcaoUm = "3";


            return opcaoUm;
        }
    }
}