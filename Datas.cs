using System;
using static System.Console;

namespace VendasEventos
{

    /// <summary>
    /// Summary description for Class1
    /// </summary>
    public class Datas
    {
        public string Formatar(string v)
        
        {
            string a = "AAAAMMDD";
            int contagem = a.Length;
            string a2 = "DDMMAAAA";

            switch (v)
            {
                case "AAAAMMDD":
                    WriteLine("Acessou o a " + a);
                    break;
                case "DDMMAAAA":
                    WriteLine("Acessou o a2 " + a2);
                    break;
                default:
                    WriteLine("Nenhuma opção compativel");
                    break;
            }
            return a;
        }

    }

}