using MySqlConnector;
using System;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Windows.Markup;

namespace IDE
{
    
    public class Models()
    {
     

        public void Cadastrar(int idCarro, string NomeCarro, string MarcaCarro, int AnoCarro, float PrecoCarro)
        {
            string sql = $"INSERT INTO CARROS (id, Nome, Marca, Ano, Preco) VALUES (@id, @nome, @marca, @ano, @preco);";
            

            DBConnection conexao = new DBConnection();

            using (MySqlCommand cmd = new MySqlCommand(sql, conexao.Conectar()))
            {
                cmd.Parameters.AddWithValue("@id", idCarro);
                cmd.Parameters.AddWithValue("@nome", NomeCarro);
                cmd.Parameters.AddWithValue("@marca", MarcaCarro);
                cmd.Parameters.AddWithValue("@ano", AnoCarro);
                cmd.Parameters.AddWithValue("@preco", PrecoCarro);
                cmd.ExecuteNonQuery();
            }

            

        }

        public void Atualizar(string NomeCarro, string MarcaCarro, int AnoCarro, float PrecoCarro, string id)
        {
            string sql = $"UPDATE CARROS SET Nome = @nome, Marca = @marca, Ano = @ano, Preco = @preco WHERE id = @id;";

            DBConnection conexao = new DBConnection();

            using (MySqlCommand cmd = new MySqlCommand(sql, conexao.Conectar()))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nome", NomeCarro);
                cmd.Parameters.AddWithValue("@marca", MarcaCarro);
                cmd.Parameters.AddWithValue("@ano", AnoCarro);
                cmd.Parameters.AddWithValue("@preco", PrecoCarro);
                cmd.ExecuteNonQuery();
            }
        }

        public void Deletar(int id)
        {
            string sql = $"DELETE from CARROS WHERE id = @id;";

            DBConnection conexao = new DBConnection();

            using (MySqlCommand cmd = new MySqlCommand(sql, conexao.Conectar()))
            {
                cmd.Parameters.AddWithValue("@id", id);
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
                            id = reader.GetInt32("id"),
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

