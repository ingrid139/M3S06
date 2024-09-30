# Diagram

## Overview
Solução direcionada para exemplo de código durante a aula da turma FullStack Educacional módulo 3 semana 6!

Abordagem dos temas:
- Codificação Profissional (Clean Code)
- Nome de variáveis e funções, e escrita de funções
- Comentários
- Formatação
- Gerenciamento de erros
- Introdução de princípios de projeto de software
- Testabilidade
- Refatoração
- Princípios de projeto SOLID
- Design Patterns

A solução foi separada por projetos que representam os assuntos abordados nas aulas

# Aula 1
- Clean Code
- Nome de variáveis e funções, e escrita de funções
- Comentários
- Formatação
- Gerenciamento de erros

# Aula 2
- Clean Code
- Introdução de princípios de projeto de software
- Refatoração
- Exercício de refatoração 1
- Exercício de refatoração 2
- Exercício de refatoração 3


## Aula 2.1 e Aula2.1.UnitTests
- Clean Code
- Testabilidade

# Aula 3
- SOLID
- Principios e violações
- Exercício de refatoração SOLID LSP
- Exercício de refatoração SOLID OCP
- Exercício de refatoração SOLID SRP

# Aula 4
## Criacional
- Abstract Factory
Abstract Factory é um padrão de design criacional que resolve o problema de criar famílias inteiras de produtos sem especificar suas classes concretas.

Abstract Factory define uma interface para criar todos os produtos distintos, mas deixa a criação real do produto para classes de fábrica concretas. Cada tipo de fábrica corresponde a uma certa variedade de produto.

O código do cliente chama os métodos de criação de um objeto factory em vez de criar produtos diretamente com uma chamada de construtor ( newoperador). Como um factory corresponde a uma única variante de produto, todos os seus produtos serão compatíveis.

O código do cliente trabalha com fábricas e produtos somente por meio de suas interfaces abstratas. Isso permite que o código do cliente trabalhe com quaisquer variantes de produto, criadas pelo objeto de fábrica. Você apenas cria uma nova classe de fábrica concreta e a passa para o código do cliente.

## Estrutural
- Adaptor
Adaptador é um padrão de design estrutural que permite que objetos incompatíveis colaborem.

O Adapter atua como um wrapper entre dois objetos. Ele captura chamadas para um objeto e as transforma em formato e interface reconhecíveis pelo segundo objeto.

## Comportamental
- Strategy
Estratégia é um padrão de design comportamental que transforma um conjunto de comportamentos em objetos e os torna intercambiáveis ​​dentro do objeto de contexto original.

O objeto original, chamado contexto, contém uma referência a um objeto de estratégia. O contexto delega a execução do comportamento ao objeto de estratégia vinculado. Para alterar a maneira como o contexto realiza seu trabalho, outros objetos podem substituir o objeto de estratégia vinculado atualmente por outro.

# References
- https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/exceptions/creating-and-throwing-exceptions
- https://docs.microsoft.com/pt-br/dotnet/standard/exceptions/best-practices-for-exceptions
- https://www.webdevtutor.net/blog/c-sharp-variable-conventions
- https://dotnettutorials.net/lesson/variables-in-csharp/#google_vignette
- https://www.w3schools.com/CS/cs_variables_identifiers.php
- https://www.programiz.com/csharp-programming/variables-primitive-data-types
- https://fernando-machado.medium.com/refatora%C3%A7%C3%A3o-5550f00c327d
- https://medium.com/@brunobandev/os-princ%C3%ADpios-s-o-l-i-d-em-imagens-1b5233479c21
- http://www.macoratti.net/vb_pd1.htm https://medium.com/@text2dipak/design-patterns-using-c-bc905885f797 
- https://en.wikipedia.org/wiki/Software_design_pattern 
- https://www.fabiosilvalima.net/design-patterns-no-mundo-real/ 
- http://www.macoratti.net/13/09/net_dp1.htm
- https://refactoring.guru/design-patterns/abstract-factory
- https://refactoring.guru/design-patterns/adapter
- https://refactoring.guru/design-patterns/strategy