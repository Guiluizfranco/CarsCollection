using MySqlConnector;
using System;
using System.Data.Common;


/*Classe com funções reutilizáveis para operações no banco de dados*/

namespace IDE
{
    public class Functions
    {
        public static void functioString(string sql, string variavel1, string variavel2)
        {
            var conn = dbConnection.ConnectionState();
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue($"@{variavel1}", variavel2);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows == false)
                    {
                        Console.WriteLine("Nenhum carro encontrado.\n");

                    }
                    else
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"ID: {reader["id"]} | NOME: {reader["nome"]} | MARCA: {reader["marca"]} | ANO: {reader["ano"]} | PRECO: {reader["preco"]}");
                        }
                    }
                }

            }
        }

        public static void functionInt(string sql, string variavel1, int variavel2, string variavel3, int variavel4)
        {
            var conn = dbConnection.ConnectionState();
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue($"@{variavel1}", variavel2);
                cmd.Parameters.AddWithValue($"@{variavel3}", variavel4);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows == false)
                    {
                        Console.WriteLine("Nenhum carro encontrado.\n");

                    }
                    else
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"ID: {reader["id"]} | NOME: {reader["nome"]} | MARCA: {reader["marca"]} | ANO: {reader["ano"]} | PRECO: {reader["preco"]}");
                        }
                    }
                }

            }
        }

        public static void functionFloat(string sql, string variavel1, float variavel2, string variavel3, float variavel4)
        {
            var conn = dbConnection.ConnectionState();
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue($"@{variavel1}", variavel2);
                cmd.Parameters.AddWithValue($"@{variavel3}", variavel4);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows == false)
                    {
                        Console.WriteLine("Nenhum carro encontrado.\n");

                    }
                    else
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"ID: {reader["id"]} | NOME: {reader["nome"]} | MARCA: {reader["marca"]} | ANO: {reader["ano"]} | PRECO: {reader["preco"]}");
                        }
                    }
                }

            }
        }
    }

}
