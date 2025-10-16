﻿/*
 Imagine que você está desenvolvendo um sistema de gerenciamento para uma biblioteca digital. 
Esse sistema precisa organizar diferentes tipos de mídias, como documentos de texto e imagens, 
cada um com suas próprias características, mas compartilhando propriedades básicas.

Sua tarefa é criar uma estrutura que permita catalogar esses itens, garantindo que cada tipo de mídia possa exibir suas informações específicas.

Crie um programa que:

Defina uma classe base chamada ItemDigital com um atributo para armazenar o título do item.
Crie uma classe Pergaminho que herde de ItemDigital, adicionando um atributo para armazenar o conteúdo textual.
Implemente o método MostrarDetalhes() para exibir o título e o conteúdo no console.
Instancie um objeto da classe Pergaminho, atribuindo um título e um conteúdo.
Chame o método MostrarDetalhes()
Exemplo de entrada:

Pergaminho pergaminhoAntigo = new Pergaminho("Segredos_Antigos.txt", "A chave para a sabedoria reside na observação...");
Copiar código
Saída esperada:

Detalhes do Pergaminho:
Título: Segredos_Antigos.txt
Descrição: A chave para a sabedoria reside na observação...
*/

using Exercicio5;

Pergaminho pergaminhoAntigo = new Pergaminho("Segredos_Antigos.txt", "A chave para a sabedoria reside na observação...");
pergaminhoAntigo.MostrarDetalhes();