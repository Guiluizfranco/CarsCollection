using System.Dynamic;

public class Carros
{
	private string Nome;
	private string Marca;
	private int Ano;
	private float Preco;

	public string nome
	{
		get { return Nome; }
		set { Nome = value; }
    }

	public string marca
	{
		get { return Marca; }
		set { Marca = value; }
    }
	
	public int ano
	{
		get { return Ano; }
		set { Ano = value; }
    }

	public float preco
	{
		get { return Preco; }
		set { Preco = value; }
    }

	
}
