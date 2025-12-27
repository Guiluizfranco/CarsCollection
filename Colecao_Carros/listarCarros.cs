using MySqlConnector;

public class ListarCarros
{
  public static void Listar()
  {
    string valor;

    Carro carro = new Carro();
   
    Console.WriteLine("NOME  |  MARCA  |   ANO   |   PRECO\n");
    valor = Console.ReadLine().ToLower();
    
    if(valor == "nome")
    {
      Console.WriteLine("Insira o nome do carro:\n");
      carro.Nome = Console.ReadLine();
      
      string sql = @"SELECT * FROM carros WHERE nome = @nome;";
      
      var conn = dbConnection.ConnectionState();
      using(var cmd = new MySqlCommand(sql, conn))
      {
        cmd.Parameters.AddWithValue(@"nome", carro.Nome);
        
        using (var reader = cmd.ExecuteReader()){
            
            while (reader.Read()){
              Console.WriteLine($"ID: {reader["id"]} | NOME: {reader["nome"]} | MARCA: {reader["marca"]} | ANO: {reader["ano"]} | PRECO: {reader["preco"]}");
            }
        }
      }
       conn.Dispose();
    }
    else if(valor == "marca")
    {
      Console.WriteLine("Insira a marca do carro:\n");
      carro.Marca = Console.ReadLine();
      
      string sql = @"SELECT * FROM carros WHERE marca = @marca;";
      
      var conn = dbConnection.ConnectionState();
      using(var cmd = new MySqlCommand(sql, conn))
      {
        cmd.Parameters.AddWithValue(@"marca", carro.Marca);
        using (var reader = cmd.ExecuteReader()){
        while(reader.Read()){
        Console.WriteLine($"ID: {reader["id"]} | NOME: {reader["nome"]} | MARCA: {reader["marca"]} | ANO: {reader["ano"]} | PRECO: {reader["preco"]}");
         }
        }
     }
       conn.Dispose();
    }
     else if(valor == "ano")
     {
      int op; 
      Console.WriteLine("Escolha abaixo as opções:\n");
      Console.WriteLine("1-Listar ano  |  2-Filtrar (maior/menor) \n");
      op = int.Parse(Console.ReadLine());
      
      switch(op)
      {
       case 1:
        Console.WriteLine("Insira o ano do carro:\n");
        carro.Ano = int.Parse(Console.ReadLine());
      
        string sql1 = @"SELECT * FROM carros WHERE ano = @ano;";
      
        var conn1 = dbConnection.ConnectionState();
        using(var cmd = new MySqlCommand(sql1, conn1))
         {
           cmd.Parameters.AddWithValue(@"ano", carro.Ano);
           using (var reader = cmd.ExecuteReader()){
           while(reader.Read()){
           Console.WriteLine($"ID: {reader["id"]} | NOME: {reader["nome"]} | MARCA: {reader["marca"]} | ANO: {reader["ano"]} | PRECO: {reader["preco"]}");
         }
           }
         }
         conn1.Dispose();
         break;
       
        case 2:
         int anoUm, anoDois;
     
         Console.WriteLine("Ano inicial (=>):\n");
         anoUm = int.Parse(Console.ReadLine());
         Console.WriteLine("Ano final (<=):\n");
         anoDois = int.Parse(Console.ReadLine());
      
         string sql2 = @"SELECT * FROM carros WHERE ano <= @anoInicial AND ano >= @anoFinal;";
      
         var conn2 = dbConnection.ConnectionState();
         using(var cmd = new MySqlCommand(sql2, conn2))
         {
           cmd.Parameters.AddWithValue(@"anoInicial", anoUm);
           cmd.Parameters.AddWithValue(@"anoFinal", anoDois);
           using (var reader = cmd.ExecuteReader()){
           while(reader.Read()){
           Console.WriteLine($"ID: {reader["id"]} | NOME: {reader["nome"]} | MARCA: {reader["marca"]} | ANO: {reader["ano"]} | PRECO: {reader["preco"]}");
         }
           }
         }
         conn2.Dispose();
         break;
       }
    }else if(valor == "preco")
     {
      int op; 
      Console.WriteLine("Escolha abaixo as opções:\n");
      Console.WriteLine("1-Listar preco(s)  |  2-Filtrar (maior/menor) \n");
      op = int.Parse(Console.ReadLine());
      
      switch(op)
            {
                
            
         case 1:
        Console.WriteLine("Insira o preco do carro:\n");
        carro.Preco = float.Parse(Console.ReadLine());
      
        string sql1 = @"SELECT * FROM carros WHERE preco = @preco;";
      
        var conn1 = dbConnection.ConnectionState();
        using(var cmd = new MySqlCommand(sql1, conn1))
         {
           cmd.Parameters.AddWithValue(@"preco", carro.Preco);
           using (var reader = cmd.ExecuteReader()){
           while(reader.Read()){
           Console.WriteLine($"ID: {reader["id"]} | NOME: {reader["nome"]} | MARCA: {reader["marca"]} | ANO: {reader["ano"]} | PRECO: {reader["preco"]}");
         }
           }
         }
         conn1.Dispose();
         break;
       
        case 2:
         float precoUm, precoDois;
     
         Console.WriteLine("Preco inicial (=>):\n");
         precoUm = float.Parse(Console.ReadLine());
         Console.WriteLine("Preco final (<=):\n");
         precoDois = float.Parse(Console.ReadLine());
      
         string sql2 = @"SELECT * FROM carros WHERE preco <= @precoInicial AND preco >= @precoFinal;";
      
         var conn2 = dbConnection.ConnectionState();
         using(var cmd = new MySqlCommand(sql2, conn2))
         {
           cmd.Parameters.AddWithValue(@"precoInicial", precoUm);
           cmd.Parameters.AddWithValue(@"precoFinal", precoDois);
           using (var reader = cmd.ExecuteReader()){
           while(reader.Read()){
           Console.WriteLine($"ID: {reader["id"]} | NOME: {reader["nome"]} | MARCA: {reader["marca"]} | ANO: {reader["ano"]} | PRECO: {reader["preco"]}");
         }
           }
         }
         conn2.Dispose();
         break;
       }
        }
        else
        {
        Console.WriteLine("Opção inválida. Por favor, escolha 'NOME', 'MARCA', 'ANO' ou 'PRECO'.");
        }
   }
}
  