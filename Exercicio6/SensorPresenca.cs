﻿namespace Exercicio6;

internal class SensorPresenca : ISensor
{
    public void Ativar()
    {
        Console.WriteLine("Sensor de presença ativado.");
    }
    public void Desativar()
    {
        Console.WriteLine("Sensor de presença desativado.");
    }
}
