namespace Exercicio4;

abstract class Profissao
{
    public string Titulo { get; }
    public Profissao(string titulo)
    {
        Titulo = titulo;
    }
}
