namespace Exercicio4;

internal class Certificado 
{
    public Profissao Profissao { get; }

    public Certificado(Profissao profissao)
    {
        Profissao = profissao;
        Console.WriteLine($"Certificado emitido para: {Profissao.Titulo}");
    }
}
