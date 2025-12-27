using MySqlConnector;

public class DeletarCarros
{
public static void Deletar()
{
    String valor;

    Carro carro = new Carro();

    Console.WriteLine("Insira qual opção deseja utilizar para deletar:\n");
    Console.WriteLine("NOME  |   ID\n");
    valor = Console.ReadLine().ToLower();

    if(valor == "nome")
        {
            Console.WriteLine("Digite o nome do carro que deseja excluir:\n");
            carro.Nome = Console.ReadLine();

            string sql = "DELETE FROM carros WHERE nome = @nome;";

            var conn = dbConnection.ConnectionState();
            using(var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue(@"nome", carro.Nome);
                cmd.ExecuteNonQuery();
            }
            conn.Dispose();
        }
        else if(valor == "id")
        {
            Console.WriteLine("Digite o ID do carro que deseja excluir:\n");
            carro.Id = int.Parse(Console.ReadLine());

            string sql = "DELETE FROM carros WHERE id = @id;";

            var conn = dbConnection.ConnectionState();
            using(var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", carro.Id);
                cmd.ExecuteNonQuery();
            }
            conn.Dispose();
        }
        else
        {
            Console.WriteLine("Opção inválida. Por favor, escolha 'NOME' ou 'ID'.");
        }
}
}