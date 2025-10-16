﻿/*
 Você está desenvolvendo um sistema para monitoramento de sensores inteligentes em diferentes dispositivos eletrônicos. 
Cada dispositivo pode ativar ou desativar sensores, mas os tipos de sensores variam conforme o modelo.

Seu desafio é criar uma estrutura que garanta que todos os dispositivos implementem um comportamento padrão. Para isso, vamos usar interfaces.

Crie um programa que:

Defina uma interface ISensor com os métodos Ativar() e Desativar().
Crie uma classe SensorTemperatura que implemente a interface ISensor.
Crie uma classe SensorPresenca que também implemente a interface ISensor.
Para cada tipo de sensor, exiba no console uma mensagem personalizada ao ativar e desativar.
No Program.cs, instancie cada sensor e chame os métodos Ativar() e Desativar().
Exemplo de entrada:

SensorTemperatura temp = new SensorTemperatura();
SensorPresenca presenca = new SensorPresenca();

temp.Ativar();
temp.Desativar();

presenca.Ativar();
presenca.Desativar();
Copiar código
Saída esperada:

Sensor de temperatura ativado.
Sensor de temperatura desativado.
Sensor de presença ativado.
Sensor de presença desativado.
*/

using Exercicio6;

SensorTemperatura temp = new SensorTemperatura();
SensorPresenca presenca = new SensorPresenca();

temp.Ativar();
temp.Desativar();

presenca.Ativar();
presenca.Desativar();
