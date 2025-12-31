using System;
using System.Data;
using MySqlConnector;

namespace IDE
{
    public class DBConnection
    {
        string conexao = "Server=localhost;user=root;password=Gui010306*;database=colacao_carros;";

        public static MySqlConnection Conectar()
        {
            var conn = new MySqlConnection(conexao);
            conn.open();
            return conn;
        }
    }

