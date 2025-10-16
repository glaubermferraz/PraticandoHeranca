namespace Exercicio1;

internal class PessoaVIP : Pessoa
{
    public string Fidelidade { get; set; }
    public string CodigoVIP { get; set; } 
    public PessoaVIP(string nome, int idade, string fidelidade, string codigoVIP) : base(nome, idade)
    {
        Fidelidade = fidelidade;
        CodigoVIP = codigoVIP;
    }
}
