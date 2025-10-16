namespace Exercicio2;

internal class Interno : Funcionario
{
    public decimal Salario { get; }
    public Interno(string nome, string cargo, decimal salario) : base(nome, cargo)
    {
        Salario = salario;
    }
    public override string ToString()
    {
        return $"Interno(a) {Nome} – Cargo: {Cargo} – Salário: R$ {Salario:F2}";
    }
}
