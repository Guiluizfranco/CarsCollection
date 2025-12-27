using System;
using System.Data;
using MySqlConnector;
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