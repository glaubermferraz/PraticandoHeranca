namespace Exercicio9;

internal class Consultoria : IServico
{
    public string Titulo { get; }
    public Funcionario Responsavel { get; }
    public Consultoria(string titulo, Funcionario responsavel)
    {
        Titulo = titulo;
        Responsavel = responsavel;
    }
    public void ExecutarServico()
    {
        Console.WriteLine($"Executando serviço de consultoria: {Titulo}");
        Console.WriteLine($"Responsável: {Responsavel.Nome} - Departamento: {Responsavel.Departamento}");
    }
}
