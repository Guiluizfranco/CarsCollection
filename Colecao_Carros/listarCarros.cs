using MySqlConnector;
using System;

/*Classe responsável pelo listar carros no banco de dados*/
public class ListarCarros
{
  public static void Listar()
  {
    /*Escolha do filtro para listagem dos carros*/
    string valor;
    
    /*Instanciação do objeto carro*/
    Carro carro = new Carro();
   
    /*Exibição das opções de filtro*/
    Console.WriteLine("NOME  |  MARCA  |   ANO   |   PRECO\n");
    valor = Console.ReadLine().ToLower();
    
    /*Execução do filtro escolhido*/
    if(valor == "nome")
    {
      Console.WriteLine("Insira o nome do carro:\n");
      carro.Nome = Console.ReadLine();

      if(string.IsNullOrWhiteSpace(carro.Nome)){Console.WriteLine("Nome inválido! O nome não pode ser vazio."); return;} /*Validação do nome do carro*/
      
      string sql = @"SELECT * FROM carros WHERE nome = @nome;"; /*Comando SQL para listar os carros pelo nome*/
      /*Variáveis para passagem de parâmetros*/
      string variavel1 = "nome";
      string variavel2 = carro.Nome;

      Functions.functioString(sql, variavel1, variavel2); /*Chama a função para listar os carros pelo nome*/
      
    }
    /*Execução do filtro escolhido*/
    else if(valor == "marca")
    {
      Console.WriteLine("Insira a marca do carro:\n");
      carro.Marca = Console.ReadLine();

      if(string.IsNullOrWhiteSpace(carro.Marca)){Console.WriteLine("Marca inválida! A marca não pode ser vazia."); return;} /*Validação da marca do carro*/
      
      string sql = @"SELECT * FROM carros WHERE marca = @marca;"; /*Comando SQL para listar os carros pela marca*/
      /*Variáveis para passagem de parâmetros*/
      string variavel1 = "marca";
      string variavel2 = carro.Marca;
      
      Functions.functioString(sql, variavel1, variavel2);
    }
    /*Execução do filtro escolhido*/
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

        if(carro.Ano >= 2027 || carro.Ano <= 0){Console.WriteLine("Ano inválido! O ano deve estar entre 1 e 2026."); return;} /*Validação do ano do carro*/
        
        string sql1 = @"SELECT * FROM carros WHERE ano = @ano;"; /*Comando SQL para listar os carros pelo ano*/
        /*Variáveis para passagem de parâmetros*/
        string variavel1 = "ano"; 
        string variavel2 = carro.Ano.ToString();

        Functions.functioString(sql1, variavel1, variavel2); /*Chama a função para listar os carros pelo ano*/

       
         break;
       
        case 2:
         /*Variáveis para passagem de parâmetros*/
         int anoUm, anoDois;
     
         Console.WriteLine("Ano inicial (=>):\n");
         anoUm = int.Parse(Console.ReadLine());
         Console.WriteLine("Ano final (<=):\n");
         anoDois = int.Parse(Console.ReadLine());

         if(anoUm >= 2027 || anoUm <= 0 || anoDois <= anoUm || anoDois <= 0){Console.WriteLine("Ano inválido!"); return;}
      
         string sql2 = @"SELECT * FROM carros WHERE ano <= @anoInicial AND ano >= @anoFinal;"; /*Comando SQL para listar os carros pelo intervalo de anos*/
         /*Variáveis para passagem de parâmetros*/
         string variavel3 = "anoInicial";
         int variavel4 = anoUm;  
         string variavel5 = "anoFinal";
         int variavel6 = anoDois;

         Functions.functionInt(sql2, variavel3, variavel4, variavel5, variavel6); /*Chama a função para listar os carros pelo intervalo de anos*/
        
         
         break;
       }
    /*Execução do filtro escolhido*/
    }else if(valor == "preco")
     {
      /*Escolha do filtro para listagem dos carros pelo preço*/
      int op; 
      Console.WriteLine("Escolha abaixo as opções:\n");
      Console.WriteLine("1-Listar preco(s)  |  2-Filtrar (maior/menor) \n");
      op = int.Parse(Console.ReadLine());
      
      /*Execução do filtro escolhido*/
      switch(op)
            {
         case 1:

        Console.WriteLine("Insira o preco do carro:\n");
        carro.Preco = float.Parse(Console.ReadLine());

        if(carro.Preco <= 0){Console.WriteLine("Preço inválido! O preço deve ser maior que zero."); return;} /*Validação do preço do carro*/
      
        string sql1 = @"SELECT * FROM carros WHERE preco = @preco;"; /*Comando SQL para listar os carros pelo preço*/
        /*Variáveis para passagem de parâmetros*/
        string variavel1 = "preco";
        string variavel2 = carro.Preco.ToString();

        Functions.functioString(sql1, variavel1, variavel2); /*Chama a função para listar os carros pelo preço*/
         break;
       
        case 2:
        /*Variáveis para passagem de parâmetros*/
         float precoUm, precoDois;
     
         Console.WriteLine("Preco inicial (=>):\n");
         precoUm = float.Parse(Console.ReadLine());
         Console.WriteLine("Preco final (<=):\n");
         precoDois = float.Parse(Console.ReadLine());

         if(precoUm <= 0 || precoDois <= precoUm || precoDois <= 0){Console.WriteLine("Preço inválido!"); return;} /*Validação do preço do carro*/
      
         string sql2 = @"SELECT * FROM carros WHERE preco <= @precoInicial AND preco >= @precoFinal;"; /*Comando SQL para listar os carros pelo intervalo de preços*/
         /*Variáveis para passagem de parâmetros*/
         string variavel3 = "precoInicial"; 
         float variavel4 = precoUm;          
         string variavel5 = "precoFinal";
         float variavel6 = precoDois;

         Functions.functionFloat(sql2, variavel3, variavel4, variavel5, variavel6); /*Chama a função para listar os carros pelo intervalo de preços*/
        
         break;
       }
        }
        else
        {
        Console.WriteLine("Opção inválida. Por favor, escolha 'NOME', 'MARCA', 'ANO' ou 'PRECO'.");
        }
   }
}
  