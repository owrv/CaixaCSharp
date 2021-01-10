using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace VendasEventos
{
    class MySqlConnector
    {

        public void conectar()
        {
            string connw;
            connw = "server=localhost;port=3306;user=weller;pwd=wellersom;database=planoa;";
            MySqlConnection obj = new MySqlConnection(connw);


            try
            {
                Console.WriteLine("Abrindo a conexão...");
                obj.Open();
                
                string r1 = "SELECT email FROM users";
                MySqlCommand cmd = new MySqlCommand(r1, obj);
                MySqlDataReader rrm = cmd.ExecuteReader();

                while (rrm.Read())
                {
                    Console.WriteLine(rrm);
                }
                rrm.Close();

                Console.WriteLine("Conexão aberta");

                Console.WriteLine("Fechando a conexão.");
                obj.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
    }
}