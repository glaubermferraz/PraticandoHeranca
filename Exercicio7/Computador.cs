namespace Exercicio7;

internal class Computador
{
    private readonly Processador _processador;
    private readonly PlacaMae _placaMae;
    public Computador(Processador processador, PlacaMae placaMae)
    {
        _processador = processador;
        _placaMae = placaMae;
    }
    public void ExibirConfiguracao()
    {
        Console.WriteLine("Computador configurado com:");
        Console.WriteLine($"Processador: {_processador.Marca} - {_processador.Modelo}");
        Console.WriteLine($"Placa-mãe: {_placaMae.Fabricante} - {_placaMae.Socket}");
    }
}
