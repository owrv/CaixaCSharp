using System;

namespace VendasEventos
{
    class Program
    {
        static void Main(string[] args)
        {
            Caixa cx = new Caixa();
            cx.AbrirCaixa();

            //MySqlConnector old = new MySqlConnector();
            //old.conectar();

            Console.Clear();
            //if()
            string escolha;

            Atendente a1 = new Atendente();
            escolha = Atendente.MenuPrincipal();

            switch (escolha)
            {
                case "1":
                    Console.WriteLine("A opção escolhida foi a 1 - Abrir o Caixa");
                    // Pendnete
                    break;

                case "2":
                    Console.WriteLine("A opção escolhida foi a 2 - Fechar o Caixa");
                    // Pendente 
                    break;

                case "3":
                    Console.WriteLine("A opção escolhida foi a 3 - Abrir Novo Pedido");
                    Pedido p1 = new Pedido();
                    //Console.WriteLine(Pedido.AbrirNovoPedido);
                    Console.WriteLine(Pedido.AbrirNovoPedido("Atendente 1"));
                    // Pendente
                    break;

                case "4":
                    Console.WriteLine("A opção escolhida foi a 4 - Connsultar Pedidos");
                    // Pendente
                    break;

                case "5":
                    Console.WriteLine("A opção escolhida foi a 5 - Bloquear o Caixa");
                    // Pendente 
                    break;

                case "6":
                    Console.WriteLine("A opção escolhida foi a 6 - Contato");
                    // Pendente
                    break;

                default:
                    Console.WriteLine("A opção digitada não é valida.");
                    // Pendente
                    // ideia:
                    // Criar chamada com um contador para encerrar o processo quando erro for igual a 3.
                    break;
            }
        }
    }
}
