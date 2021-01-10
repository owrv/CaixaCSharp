using System;
using static System.Console;


namespace VendasEventos
{

    /// <summary>
    /// Class pedido realiza algo
    /// </summary>
    public class Pedido
    {
       
       

        public static string AbrirNovoPedido(string operador)
        {
            // Carregar produtos disponiveis, obter retorno

            // selecione o produto
            int produtoDesejado = 5;

            Produto produtos = new Produto();
            
            WriteLine("Produtos disponíveis: ");
            WriteLine(produtos.ListarProdutos() + "\n");


            WriteLine("Insira um valor correspondente ao produto desejado: \n");
            // Aqui seleciona um produto
            //produtoDesejado = int.Parse(Console.ReadLine());

            WriteLine(produtos.Escolha(produtoDesejado) + "\n");

            


            string caixaAberto; // Será usado para verificar se o caixa já foi liberado. Será alterado para boolean 

            WriteLine("Este é um teste simples.");
            caixaAberto = operador;
            return "Operador do caixa é: " +caixaAberto + "\n";
        }
    }
}