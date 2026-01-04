using MySqlConnector;
using System;
using System.Collections.ObjectModel;

namespace IDE
{
    public class Models
    {
       
        public void Cadastrar(string NomeCarro, string MarcaCarro, int AnoCarro, float PrecoCarro)
        {
            string sql = $"INSERT INTO CARROS (Nome, Marca, Ano, Preco) VALUES (@nome, @marca, @ano, @preco);";

            DBConnection conexao = new DBConnection();

            using (MySqlCommand cmd = new MySqlCommand(sql, conexao.Conectar()))
            {
                cmd.Parameters.AddWithValue("@nome", NomeCarro);
                cmd.Parameters.AddWithValue("@marca", MarcaCarro);
                cmd.Parameters.AddWithValue("@ano", AnoCarro);
                cmd.Parameters.AddWithValue("@preco", PrecoCarro);
                cmd.ExecuteNonQuery();
            }


        }

        
        public void AdicionarValoresListaCarros(ObservableCollection<Carros> ListaCarros)
        {
            string sql = "SELECT * FROM CARROS;";
            DBConnection conexao = new DBConnection();

            using(var cmd = new MySqlCommand(sql, conexao.Conectar()))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    ListaCarros.Clear();

                    while(reader.Read())
                    {
                        ListaCarros.Add(new Carros
                        {
                            nome = reader.GetString("Nome"),
                            marca = reader.GetString("Marca"),
                            ano = reader.GetInt32("Ano"),
                            preco = reader.GetFloat("Preco")
                        });
                    }
                }

                    
                
            }
        }
    }
}

