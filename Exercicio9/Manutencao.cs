namespace Exercicio9;

internal class Manutencao : IServico
{
    public string Titulo { get; }
    public Funcionario Responsavel { get; }
    public Manutencao(string titulo, Funcionario responsavel)
    {
        Titulo = titulo;
        Responsavel = responsavel;
    }
    public void ExecutarServico()
    {
        Console.WriteLine($"Executando serviço de manutenção: {Titulo}");
        Console.WriteLine($"Responsável: {Responsavel.Nome} - Departamento: {Responsavel.Departamento}");
    }
}
