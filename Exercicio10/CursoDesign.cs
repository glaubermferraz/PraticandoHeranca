namespace Exercicio10;

internal class CursoDesign : ICurso 
{
    public string Titulo { get; }
    private Instrutor Instrutor { get; }
    public CursoDesign(string titulo, Instrutor instrutor)
    {
        Titulo = titulo;
        Instrutor = instrutor;
    }
    public void ValidarConteudo()
    {
        Console.WriteLine($"Validando conteúdo do curso de design: {Titulo}");
    }
    public void PublicarCurso()
    {
        Console.WriteLine($"Curso publicado com sucesso: {Titulo} - Instrutor: {Instrutor.Nome} ({Instrutor.Especialidade})");
    }
}
