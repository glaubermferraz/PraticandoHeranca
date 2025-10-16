namespace Exercicio5;

internal class Pergaminho : ItemDigital
{
    public string Conteudo { get; }
    public Pergaminho(string titulo, string conteudo) : base(titulo)
    {
        Conteudo = conteudo;
    }
    public void MostrarDetalhes()
    {
        Console.WriteLine("Detalhes do Pergaminho:");
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Conteúdo: {Conteudo}");
    }
}
