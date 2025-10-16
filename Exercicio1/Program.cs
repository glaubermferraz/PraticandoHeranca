using Exercicio1;

Console.WriteLine("Hello, World!");

PessoaVIP cliente1 = new PessoaVIP("Ana", 28, "12345", "VIP2024");
PessoaVIP cliente2 = new PessoaVIP("Bruno", 35, "67890", "VIP2024");

Console.WriteLine($"Cliente 1: {cliente1.Nome}, Idade: {cliente1.Idade}, Fidelidade: {cliente1.Fidelidade}, Código VIP: {cliente1.CodigoVIP}");
Console.WriteLine($"Cliente 2: {cliente2.Nome}, Idade: {cliente2.Idade}, Fidelidade: {cliente2.Fidelidade}, Código VIP: {cliente2.CodigoVIP}");

/*
Você está desenvolvendo um sistema para um clube, onde a experiência do cliente é prioridade. Os membros comuns têm acesso básico, mas os clientes VIP possuem benefícios exclusivos, como níveis de fidelidade e identificadores personalizados. Seu desafio é criar uma estrutura que diferencie esses perfis.

Crie um programa que:

Defina uma classe Pessoa com os atributos Nome e Idade.
Crie uma classe ClienteVIP que herde de Pessoa, adicionando:
Um atributo nível de fidelidade (ex: Ouro, Diamante).
Um atributo código VIP (ex: VIP123A).
Instancie dois clientes VIP com dados fictícios.
Exiba no console uma mensagem formatada para cada cliente, incluindo:
Uma saudação personalizada (ex: "Bem-vindo, cliente VIP: [Nome]").
Idade, nível de fidelidade e código VIP em linhas separadas.
Exemplo de entrada:

ClienteVIP cliente1 = new ClienteVIP("Renata", 32, "Ouro", "VIP123A");  
ClienteVIP cliente2 = new ClienteVIP("Leonardo", 40, "Diamante", "VIP789X");  
Copiar código
Saída esperada:

Bem-vindo, cliente VIP: Renata
Idade: 32
Nível de Fidelidade: Ouro
Código VIP: VIP123A
 
Bem-vindo, cliente VIP: Leonardo
Idade: 40
Nível de Fidelidade: Diamante
Código VIP: VIP789X
*/