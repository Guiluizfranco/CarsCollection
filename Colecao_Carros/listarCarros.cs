using MySqlConnector;

public class ListarCarros
{

  public static void functioString(string sql, string variavel1, string variavel2)
  {
    var conn = dbConnection.ConnectionState();
    using(var cmd = new MySqlCommand(sql, conn))
    {
      cmd.Parameters.AddWithValue($"@{variavel1}", variavel2);
      using (MySqlDataReader reader = cmd.ExecuteReader()){
         if(reader.HasRows == false){
            Console.WriteLine("Nenhum carro encontrado.\n");
          
         }
          else
          {
            while(reader.Read()){
              Console.WriteLine($"ID: {reader["id"]} | NOME: {reader["nome"]} | MARCA: {reader["marca"]} | ANO: {reader["ano"]} | PRECO: {reader["preco"]}");
          }
        }
     }
       
    }
  }
  public static void functionInt(string sql, string variavel1, int variavel2, string variavel3, int variavel4)
  {
    var conn = dbConnection.ConnectionState();
    using(var cmd = new MySqlCommand(sql, conn))
    {
      cmd.Parameters.AddWithValue($"@{variavel1}", variavel2);
      cmd.Parameters.AddWithValue($"@{variavel3}", variavel4);
      using (MySqlDataReader reader = cmd.ExecuteReader()){
         if(reader.HasRows == false){
            Console.WriteLine("Nenhum carro encontrado.\n");
          
         }
          else
          {
            while(reader.Read()){
              Console.WriteLine($"ID: {reader["id"]} | NOME: {reader["nome"]} | MARCA: {reader["marca"]} | ANO: {reader["ano"]} | PRECO: {reader["preco"]}");
          }
        }
     }
      
    }
  }

   public static void functionFloat(string sql, string variavel1, float variavel2, string variavel3, float variavel4)
  {
    var conn = dbConnection.ConnectionState();
    using(var cmd = new MySqlCommand(sql, conn))
    {
      cmd.Parameters.AddWithValue($"@{variavel1}", variavel2);
      cmd.Parameters.AddWithValue($"@{variavel3}", variavel4);
      using (MySqlDataReader reader = cmd.ExecuteReader()){
         if(reader.HasRows == false){
            Console.WriteLine("Nenhum carro encontrado.\n");
          
         }
          else
          {
            while(reader.Read()){
              Console.WriteLine($"ID: {reader["id"]} | NOME: {reader["nome"]} | MARCA: {reader["marca"]} | ANO: {reader["ano"]} | PRECO: {reader["preco"]}");
          }
        }
     }
       
    }
  }
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
      string variavel1 = "nome";
      string variavel2 = carro.Nome;

      functioString(sql, variavel1, variavel2);
      
    }
    else if(valor == "marca")
    {
      Console.WriteLine("Insira a marca do carro:\n");
      carro.Marca = Console.ReadLine();
      
      string sql = @"SELECT * FROM carros WHERE marca = @marca;";
      string variavel1 = "marca";
      string variavel2 = carro.Marca;
      
      functioString(sql, variavel1, variavel2);
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
        string variavel1 = "ano"; 
        string variavel2 = carro.Ano.ToString();

        functioString(sql1, variavel1, variavel2);

       
         break;
       
        case 2:
         int anoUm, anoDois;
     
         Console.WriteLine("Ano inicial (=>):\n");
         anoUm = int.Parse(Console.ReadLine());
         Console.WriteLine("Ano final (<=):\n");
         anoDois = int.Parse(Console.ReadLine());
      
         string sql2 = @"SELECT * FROM carros WHERE ano <= @anoInicial AND ano >= @anoFinal;";
         
         string variavel3 = "anoInicial";
         int variavel4 = anoUm;  
         string variavel5 = "anoFinal";
         int variavel6 = anoDois;

         functionInt(sql2, variavel3, variavel4, variavel5, variavel6);
        
         
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
      
        string variavel1 = "preco";
        string variavel2 = carro.Preco.ToString();

        functioString(sql1, variavel1, variavel2);
         break;
       
        case 2:
         float precoUm, precoDois;
     
         Console.WriteLine("Preco inicial (=>):\n");
         precoUm = float.Parse(Console.ReadLine());
         Console.WriteLine("Preco final (<=):\n");
         precoDois = float.Parse(Console.ReadLine());
      
         string sql2 = @"SELECT * FROM carros WHERE preco <= @precoInicial AND preco >= @precoFinal;";
         string variavel3 = "precoInicial";
         float variavel4 = precoUm;  
         string variavel5 = "precoFinal";
         float variavel6 = precoDois;

         functionFloat(sql2, variavel3, variavel4, variavel5, variavel6);
        
         break;
       }
        }
        else
        {
        Console.WriteLine("Opção inválida. Por favor, escolha 'NOME', 'MARCA', 'ANO' ou 'PRECO'.");
        }
   }
}
  