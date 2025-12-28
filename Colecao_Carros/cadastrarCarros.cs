using System;
using System.Data;
using System.Runtime.CompilerServices;
using MySqlConnector;

/*Classe responsável pelo cadastro de carros no banco de dados*/
public class CadastrarCarros
{
  public static void Cadastrar()   
 {
    Carro carro = new Carro();
        
        Console.WriteLine("Insira o nome do carro:"); 
        carro.Nome = Console.ReadLine(); 

        /*Validação do nome do carro*/
        if(string.IsNullOrWhiteSpace(carro.Nome)){Console.WriteLine("Nome inválido! O nome não pode ser vazio."); return;}
   
        Console.WriteLine("Insira a marca do carro:");
        carro.Marca = Console.ReadLine(); 
        
        /*Validação da marca do carro*/
        if(string.IsNullOrWhiteSpace(carro.Marca)){Console.WriteLine("Marca inválida! A marca não pode ser vazia."); return;}

        Console.WriteLine("Insira o ano do carro:");
        carro.Ano = int.Parse(Console.ReadLine()); 
        
        /*Validação do ano do carro*/
        if(carro.Ano >= 2027 || carro.Ano <= 0){Console.WriteLine("Ano inválido! O ano deve estar entre 1 e 2026."); return;}

        Console.WriteLine("Insira o preço do carro:");
        carro.Preco = float.Parse(Console.ReadLine()); 

        /*Validação do preço do carro*/
        if(carro.Preco <= 0){Console.WriteLine("Preço inválido! O preço deve ser maior que zero."); return;}
     
    

    var conn = dbConnection.ConnectionState(); /*Abre a conexão com o banco de dados*/
      
    string sql = @"INSERT INTO carros (nome, marca, ano, preco) values(@nome, @marca, @ano, @preco);"; /*Comando SQL para inserir os dados no banco*/
    using(var cmd = new MySqlCommand(sql, conn))
      {
         cmd.Parameters.AddWithValue("@nome", carro.Nome);
         cmd.Parameters.AddWithValue("@marca", carro.Marca);
         cmd.Parameters.AddWithValue("@ano", carro.Ano);
         cmd.Parameters.AddWithValue("@preco", carro.Preco);

         cmd.ExecuteNonQuery(); /*Executa o comando SQL*/
        
         Console.WriteLine("Carro cadastrado com sucesso!");
      }
      conn.Dispose();
      
 }
}

   
    


