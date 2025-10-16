namespace Exercicio2;

internal class Freelancer : Funcionario
{
    public decimal ValorProjeto { get; }
    public Freelancer(string nome, string cargo, decimal valorProjeto) : base(nome, cargo)
    {
        ValorProjeto = valorProjeto;
    }
    public override string ToString()
    {
        return $"Freelancer {Nome} – Cargo: {Cargo} – Projeto atual: R$ {ValorProjeto:F2}";
    }
}
