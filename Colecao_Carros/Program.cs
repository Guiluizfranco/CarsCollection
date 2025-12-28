using System;

class Program
{
    static void Main(string[] args)
 { 
    /*Variável de controle do loop do menu principal*/
    int op = 1;

 while (op != 0)
 { 
   /*Exibição do menu principal*/ 
   Console.WriteLine("\n");
   Console.WriteLine("------MENU PRINCIPAL------\n");
   Console.WriteLine("\n");
   Console.WriteLine("1 - Cadastrar Carro(s)\n");
   Console.WriteLine("2 - Listar Carro(s)\n");
   Console.WriteLine("3 - Atualizar Carro(s)\n");
   Console.WriteLine("4 - Excluir Carro(s)\n");
   Console.WriteLine("0 - Sair\n");
   Console.WriteLine("\n");

   string opString = Console.ReadLine();
   op = int.Parse(opString);
   
   /*Validação da opção inserida no menu principal*/
   if(op != 1 && op != 2 && op != 3 && op != 4 && op != 0)
   {
    Console.WriteLine("Por favor, insira uma opção válida.\n");

   }

   /*Chamada das funções conforme a opção escolhida no menu principal*/
   switch(op)
         {
            case 1:
            CadastrarCarros.Cadastrar(); /*Chama a função de cadastro de carros*/
            break;
            
            case 2:
            ListarCarros.Listar(); /*Chama a função de listagem de carros*/
            break;
            
            case 4:
            DeletarCarros.Deletar(); /*Chama a função de exclusão de carros*/
            break;
         }

 }


}

}
