using System;

namespace IDE
{
    public class DeletarCarros()
    {
        public static void Deletar()
        {
            /*Escolha do filtro para deleção dos carros*/
            String valor;

            /*Instanciação do objeto carro*/
            Carro carro = new Carro();

            /*Exibição das opções de filtro*/
            Console.WriteLine("Insira qual opção deseja utilizar para deletar:\n");
            Console.WriteLine("NOME  |   MARCA\n");
            valor = Console.ReadLine().ToLower();

            /*Execução do filtro escolhido*/
            if (valor == "nome")
            {
                /*Execução do filtro escolhido*/
                Console.WriteLine("Digite o nome do carro que deseja excluir:\n");
                carro.Nome = Console.ReadLine();

                string sql = "DELETE FROM carros WHERE nome = @nome;"; /*Comando SQL para deletar os carros pelo nome*/

                /*Variáveis para passagem de parâmetros*/
                string variavel1 = "nome";
                string variavel2 = carro.Nome;

                Functions.functioString(sql, variavel1, variavel2); /*Chama a função para deletar os carros pelo nome*/

            }
            else if (valor == "marca")
            {
                /*Execução do filtro escolhido*/
                Console.WriteLine("Digite a marca do carro que deseja excluir:\n");
                carro.Marca = Console.ReadLine();

                string sql = "DELETE FROM carros WHERE marca = @marca;"; /*Comando SQL para deletar os carros pela marca*/

                /*Variáveis para passagem de parâmetros*/
                string variavel1 = "marca";
                string variavel2 = carro.Marca;

                Functions.functioString(sql, variavel1, variavel2); /*Chama a função para deletar os carros pela marca*/
            }
            else
            {
                Console.WriteLine("Opção inválida. Por favor, escolha 'NOME' ou 'MARCA'."); /*Validação da opção escolhida*/
            }
        }
    }
}
