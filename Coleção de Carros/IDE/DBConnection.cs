using System;
using MySqlConnector;


public class DBConnection
{
	private static string connectionString = "Server=localhost;user=root;password=Gui010306*;database=COLECAO_CARROS;";
    public MySqlConnection Conectar()
	{
		MySqlConnection conn = new MySqlConnection(connectionString);
        conn.Open();
        return conn;


    }
	
}
