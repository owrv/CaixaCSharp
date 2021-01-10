using System;
using System.Collections.Generic;

namespace VendasEventos
{

	/// <summary>
	/// Summary description for Class1
	/// </summary>
	public class Produto
	{
		string[] produtos = new string[10];
		private int[] id = new[] {1 , 2, 3, 4, 5, 6, 7, 8, 9, 10 };

		 string nome;

		public Produto()
		{
			//
			// TODO: Add constructor logic here
			//

			produtos[0] = "Agua com gás" ;
			produtos[1] = "Agua sem gás";
			produtos[2] = "Coca-Cola Original";
			produtos[3] = "Coca-cola Sem açúcar";
			produtos[4] = "Hill Farmstead Brewery";
			produtos[5] = "Toppling Goliath";
			produtos[6] = "Mikkeller";
			produtos[7] = "Three Floyds Brewing";
			produtos[8] = "Dieu du Ciel";
			produtos[9] = "Bells Brewery";

			
		}

        public string ListarProdutos()
        {
			string a = null;

            for (int i = 0; i < id.Length; i++)
            {
                
				Console.WriteLine(id[i] + " - " + produtos[i]);
                
            }


			return a;
        }

		public string Escolha(int a)
        {
			int transforma = a - 1;
			string resultado = null;
            for (int i = 0; i<produtos.Length; i++)
            {
                if ( i == transforma)
                {
					resultado = produtos[i];

                }

            }
			return resultado;
				 
        }

        public static implicit operator string(Produto v)
        {
            throw new NotImplementedException();
        }
    }
}