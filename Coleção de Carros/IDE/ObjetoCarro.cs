using System.Dynamic;

public class Carros
{
	private int Id;	
    private string Nome;
	private string Marca;
	private int Ano;
	private float Preco;

	public int id
	{
		get { return Id; }
		set { Id = value; }
    }
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
