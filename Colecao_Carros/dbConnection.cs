using System;
using System.Data;
using MySqlConnector;

/*Classe responsável pela conexão com o banco de dados*/
public class dbConnection
{
    private static string connectionString = "Server=localhost;user=root;password=Gui010306*;database=colacao_carros;";
    public static MySqlConnection ConnectionState()
    {
        var conn = new MySqlConnection(connectionString);
        conn.Open();
        return conn;
    }
    
}