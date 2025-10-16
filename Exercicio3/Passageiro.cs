namespace Exercicio3;

internal class Passageiro : Pessoa
{
    public int QuantidadeBilhetes { get; }
    public Passageiro(string nome, int idade, int quantidadeBilhetes) : base(nome, idade)
    {
               QuantidadeBilhetes = quantidadeBilhetes;
    }
    public void MostrarDados()
    {
        Console.WriteLine($"Passageiro: {Nome} - Idade: {Idade} - Bilhetes: {QuantidadeBilhetes}");
    }
}
