﻿namespace Exercicio7;

internal class PlacaMae
{
    public string Fabricante { get; }
    public string Socket { get; }
    public PlacaMae(string fabricante, string socket)
    {
        Fabricante = fabricante;
        Socket = socket;
    }
}
