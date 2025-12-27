using System;
using System.Data;
using System.Runtime.CompilerServices;
using MySqlConnector;

public class CadastrarCarros
{
  public static void Cadastrar()
 {
    Carro carro = new Carro();
   
    Console.WriteLine("Insira o código do carro:");
    carro.Id = int.Parse(Console.ReadLine());
    Console.WriteLine("Insira o nome do carro:");
    carro.Nome = Console.ReadLine();
    Console.WriteLine("Insira a marca do carro:");
    carro.Marca = Console.ReadLine();
    Console.WriteLine("Insira o ano do carro:");
    carro.Ano = int.Parse(Console.ReadLine());
    Console.WriteLine("Insira o preço do carro:");
    carro.Preco = float.Parse(Console.ReadLine());

    
    var conn = dbConnection.ConnectionState();
      
    string sql = @"INSERT INTO carros (id,nome, marca, ano, preco) values(@id, @nome, @marca, @ano, @preco);";
    using(var cmd = new MySqlCommand(sql, conn))
      {
         cmd.Parameters.AddWithValue("@id", carro.Id);
         cmd.Parameters.AddWithValue("@nome", carro.Nome);
         cmd.Parameters.AddWithValue("@marca", carro.Marca);
         cmd.Parameters.AddWithValue("@ano", carro.Ano);
         cmd.Parameters.AddWithValue("@preco", carro.Preco);

         cmd.ExecuteNonQuery();
         Console.WriteLine("Carro cadastrado com sucesso!");
        
      }
      conn.Dispose();
    


    
 }
}

   
    


