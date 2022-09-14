namespace exemplo_fundamentos.models
{
  public class Pessoa
  {
    public string? Nome { get; set; }
    public int Idade { get; set; }

    public void Apresentar()
    {
      Console.WriteLine($"Olá, meu nome é {this.Nome} e tenho {Idade} anos.");
    }
  }
}