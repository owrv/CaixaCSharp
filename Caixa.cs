using System;
using System.Collections.Generic;

	/// <summary>
	/// Summary description for Class1
	/// </summary>
namespace VendasEventos
{
	public class Caixa
	{
		public Caixa()
		{
			//
			// Diretivas de caixa
			//
			int idMaster;
			string senhaMaster;
			int idOperador;
			string senhaOperador;

		}

		public string[] CaixaPrincipal()
		{
			string[] perfil = { "atendente", "supervisor", "administrador", "manutenção" };

			return perfil;

		}

		public string AbrirCaixa()
		{
			bool resposta = false;
			int contador = 0;
			int contadorCaixaRetorno = 1;
			int contar;
			string usuario;
			string senha;
			bool status = false;
			string escolha;
			string resuultado;
			string[] opcoes = CaixaPrincipal();
			List<object> caixaRetorno = new List<object>();
			List<object> posicaoDOpcoes = new List<object>();
			

			Console.WriteLine("Lista de perfil de acessos disponíveis.");
			Console.WriteLine("Para acessar, é preciso escolher uma das opções abaixo.");
			// opções

			// leitura das opções existentes de perfil
			foreach (string opcao in opcoes)
			{
				posicaoDOpcoes.Add(contador);
				Console.WriteLine(contador++ + " - " + opcao);
			}

			escolha = Console.ReadLine();

            contadorCaixaRetorno = (contadorCaixaRetorno < 1) ? contadorCaixaRetorno = 1 : contadorCaixaRetorno = caixaRetorno.Count;

			// buscar posição de um item de matriz do tipo string
			ArrayUtil use = new ArrayUtil();
			resuultado = use.buscarPosicaoReferenciaNumerica(opcoes, escolha);
			//Console.WriteLine("O valor buscado é: " + resuultado);

			do
			{
				try
				{
					resposta = (Int32.Parse(escolha) >= 0) && (Int32.Parse(escolha) < opcoes.Length) ? true : false;
				}
				catch (Exception ex)
				{
					Console.WriteLine("Digite um valor númerico entre! 0 e " + opcoes.Length);
				}

				if (!resposta)
				{
					Console.WriteLine("A opção escolhida não é valida, por favor escolha uma opção valida.");
					escolha = Console.ReadLine();
				}
			} while (!resposta);

			int escolhido = Int32.Parse(escolha);

			Console.WriteLine("A opção escolhida foi: " + opcoes[escolhido] + "\n");
			Console.WriteLine("Insira o usuário:");
			usuario = Console.ReadLine();
			Console.WriteLine("Insira a senha: ");
			senha = Console.ReadLine();

			return escolha;
		}
	}
}