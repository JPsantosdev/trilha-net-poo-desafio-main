# DIO - Trilha .NET - Programação orientada a objetos
www.dio.me

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de orientação a objetos, da trilha .NET da DIO.

## Contexto
Você é responsável por modelar um sistema que trabalha com celulares. Para isso, foi solicitado que você faça uma abstração de um celular e disponibilize maneiras de diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos.

## Proposta
Você precisa criar um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone. 
Você deve criar as suas classes de acordo com o diagrama abaixo:

![Diagrama classes](Imagens/diagrama.png)

## Regras e validações
1. A classe **Smartphone** deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** devem ser classes filhas de Smartphone.
3. O método **InstalarAplicativo** deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.

## Solução
O código foi implementado e resolvido conforme a solicitação do professor Buca. Com ele foi possível abstrair melhor os conhecimentos de POO, assim como aprender quais parâmetros devem ou não ser passados dentro de uma classe abstrata, assim como atribuir os conceitos de herança e interface. Foi possível perceber que alguns parâmetros devem ser passados dentro da interface, e que foi necessário passar os parâmetros de uma classe filha para uma classe pai, pois os constructors não são herdados, e muitas as vezes o terminal alertava que não existiam parâmetros sendo passados. Foi necessário inicializar os construtores dentro das classes filhas.
