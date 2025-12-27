using System;

class Program
{
    static void Main(string[] args)
 { 
    
    int op = 1;

 while (op != 0)
 { 

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

   if(op != 1 && op != 2 && op != 3 && op != 4 && op != 0)
   {
    Console.WriteLine("Por favor, insira uma opção válida.\n");

   }

   switch(op)
         {
            case 1:
            CadastrarCarros.Cadastrar();
            break;
            
            case 2:
            ListarCarros.Listar();
            break;
            
            case 4:
            DeletarCarros.Deletar();
            break;
         }

 }


}

}
