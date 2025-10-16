// See https://aka.ms/new-console-template for more information

using Exercicio2;

Console.WriteLine("Hello, World!");

/*
 Você está desenvolvendo um sistema interno para uma empresa que deseja organizar as informações de seus colaboradores. A empresa possui funcionários fixos, que recebem salário mensal, e freelancers, que trabalham por projetos com valores específicos. Seu desafio é criar uma estrutura que represente esses dois tipos de colaboradores, aproveitando os conceitos de herança para evitar repetição de código.

Crie um programa que:

Defina uma classe base Funcionario com os atributos Nome e Cargo.
Crie uma classe filha Freelancer que herde de Funcionario e adicione o atributo ValorProjeto.
Crie uma classe filha Interno que herde de Funcionario e adicione o atributo Salario.
Instancie pelo menos um objeto de cada classe filha, atribuindo valores a cada atributo.
Exiba as informações no terminal.
Exemplo de entrada:

Interno f1 = new Interno("Luciana", "Desenvolvedora", 7000.00m);  
Freelancer f2 = new Freelancer("Carlos", "Designer", 3500.00m);  
Copiar código
Saída esperada:

Funcionária Luciana – Cargo: Desenvolvedora – Salário: R$ 7000,00
Freelancer Carlos – Cargo: Designer – Projeto atual: R$ 3500,00
*/

// Criando Freelancers:
Freelancer freela1 = new Freelancer("Dondo", "Designer", 5500.00m);
Freelancer freela2 = new Freelancer("Carlos", "Designer", 4500.00m);
Console.WriteLine(freela1);
Console.WriteLine(freela2);

// Criando Internos:
Interno interno1 = new Interno("Patricia", "Desenvolvedora", 7000.00m);
Interno interno2 = new Interno("Mano Deyvin", "Desenvolvedor", 8000.00m);
Interno interno3 = new Interno("Jovem Tranquilao", "Desenvolvedor", 9000.00m);
Console.WriteLine(interno1);
Console.WriteLine(interno2);
Console.WriteLine(interno3);