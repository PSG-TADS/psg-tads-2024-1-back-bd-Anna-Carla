# Relatório de Funcionamento

`Sistema de Locadora de Veículos utilizando C#, ASP.NET Core, Entity Framework, SQL Express e Swagger`  

`Análise e Desenvolvimento de Sistemas - PUC Minas` 

## Participantes

- Anna Carla Teixeira da Silva

# Introdução

O propósito deste relatório é oferecer uma análise detalhada do projeto concebido para estimular a assimilação de conceitos de backend pelos alunos, empregando tecnologias contemporâneas e funcionalidades práticas. O projeto aborda a criação de uma plataforma de locação de veículos, utilizando recursos como CSharp, ASP.NET Core 8.0, Entity Framework, SQL e Swagger para testes. Essa iniciativa busca não apenas familiarizar os alunos com tais ferramentas, mas também proporcionar-lhes uma compreensão mais aprofundada por meio da sua aplicação em um contexto realístico.

## Objetivos

O projeto visa desenvolver uma API utilizando ASP.NET Core para um sistema de locadora de veículos, permitindo que os clientes efetuem reservas de veículos de forma prática e eficiente. 

# Especificações do Projeto

## Principais funcionalidades

As funcionalidades centrais do sistema estão relacionadas aos seguintes aspectos:

Clientes:
- Cadastro e gerenciamento de clientes.
- Pesquisa de todos os clientes ou de um cliente específico.
- Pesquisa do cliente e suas reservas.

Veículos:
- Cadastro e gerenciamento de veículos.
- Pesquisa de todos os veículos ou de um veículo específico.
- Pesquisa de todos os veículos disponíveis.

Locações:
- Cadastro e gerenciamento de locações.
- Pesquisa de uma locação específica.
- Pesquisa de todas as locações disponíveis.

## Tecnologias Utilizadas

- IDE: Visual Studio Community
- Repositório: Github
- Versionamento: Git
- Ambiente SQL: SQL Server Management Studio
- Teste: Swagger

### Requisitos Funcionais

| ID  | Descrição                               | Prioridade |
|-----|-----------------------------------------|------------|
| RF01| O sistema deve permitir o cadastro de novos clientes, incluindo informações como nome, CPF, Telefone e Endereço. | Alta |
| RF02| O sistema deve permitir a edição e atualização dos dados dos clientes cadastrados. | Alta |
| RF03| O sistema deve permitir a exclusão de clientes cadastrados. | Alta |
| RF04| O sistema deve permitir a pesquisa de clientes pelo id. | Média |
| RF05| O sistema deve permitir o cadastro de novos veículos, incluindo informações como marca, modelo, ano, valor da diária e placa. | Alta |
| RF06| O sistema deve permitir a edição e atualização dos dados dos veículos cadastrados. | Alta |
| RF07| O sistema deve permitir a exclusão de veículos cadastrados. | Alta |
| RF08| O sistema deve permitir a pesquisa de veículos com base no id. | Média |
| RF09| O sistema deve permitir a realização de reservas de veículos por parte dos clientes cadastrados. | Alta |
| RF10| O sistema deve permitir a edição e cancelamento de reservas de veículos pelos clientes. | Alta |
| RF11| O sistema deve permitir a visualização do histórico de reservas dos clientes. | Baixa |
| RF12| O sistema não deve permitir que o cliente seja excluído com reservas ativas. | Alta |

## Arquitetura da solução

### Detalhamento

A estrutura utilizada para desenvolver o sistema segue o modelo MVC (Model, View, Controller), uma abordagem que divide a aplicação em três camadas distintas. A camada View é encarregada de apresentar os dados aos usuários finais. Neste projeto, não foram implementadas Views; em vez disso, essa funcionalidade foi integrada diretamente ao Swagger, que oferece uma interface interativa para testar e documentar as APIs desenvolvidas. A camada Controller, por sua vez, recebe as requisições HTTP, realiza validações e tratamentos de erros, garantindo a integridade e segurança das operações efetuadas. Por fim, a camada Model define as entidades da aplicação e cuida da manipulação dos dados.

### Principais Classes e suas Responsabilidades

- Cliente: Esta classe mantém informações dos clientes, como nome, CPF, telefone e endereço. Além disso, ela gerencia operações como cadastro, edição e exclusão de clientes.
- Veículo: Responsável por representar os veículos da locadora, esta classe armazena detalhes como marca, modelo, ano, valor da diária e placa. Ela também controla operações como cadastro, edição e exclusão de veículos.
- Reserva: Controla as reservas de veículos feitas pelos clientes. Esta classe registra informações como data de início, data de término, o id do cliente e o do veículo. Além disso, gerencia operações como realização, edição e cancelamento de reservas.

## Descrição do Banco de Dados

### Modelo Conceitual

![ModeloRelacionalAtualizado](https://github.com/PSG-TADS/psg-tads-2024-1-back-bd-Anna-Carla/assets/116588995/83c11a31-2df7-4bed-b323-cb52c7c36f0a)

### Tabelas e Relacionamentos 

Tabela Cliente:
- ID (PK): Identificador único do cliente
- Nome: Nome do cliente
- CPF: CPF do cliente
- Telefone: Telefone do cliente
- Endereço: Endereço do cliente

Tabela Veículo:
- ID (PK): Identificador único do veículo
- Marca: Marca do veículo
- Modelo: Modelo do veículo
- Ano: Ano do veículo
- Valor Diária: Valor da diária do veículo
- Placa: Placa do veículo

Tabela Reserva:
- ID (PK): Identificador único da reserva
- Data Início: Data de início da reserva
- Data Término: Data de término da reserva
- ID Cliente (FK): Identificador único do cliente associado à reserva
- ID Veículo (FK): Identificador único do veículo associado à reserva

## Registros de Testes e Resultados

Imagens de teste: [Testes](images/)

## Considerações Finais

### Reflexões sobre Experiências Adquiridas

Durante o processo, houve oportunidades que poderiam ter sido mais bem exploradas, contribuindo para uma experiência ainda mais enriquecedora.

### Sugestões para Melhorias Futuras

Acredita-se que o ensino presencial seria mais benéfico para esta disciplina, dada a sua importância e complexidade. O formato de Ensino a Distância (EAD) torna mais difícil obter suporte direto para esclarecer dúvidas, o que pode complicar o desenvolvimento técnico em cada tópico abordado. Seria vantajoso incluir mais exemplos práticos em diferentes níveis de dificuldade, evitando generalizações que possam dificultar o entendimento.

# Referências

1. Microsoft. (n.d.). Introdução ao Entity Framework Core no ASP.NET Core MVC. [link](https://learn.microsoft.com/pt-br/aspnet/core/data/ef-mvc/intro?view=aspnetcore-8.0)
2. Microsoft. (n.d.). Acessar SQL: Conceitos básicos, vocabulário e sintaxe. [link](https://support.microsoft.com/pt-br/topic/acessar-sql-conceitos-b%C3%A1sicos-vocabul%C3%A1rio-e-sintaxe-444d0303-cde1-424e-9a74-e8dc3e460671)
3. Universidade Federal de Santa Catarina. (n.d.). Como escrever textos em LaTeX. [link](https://www.inf.ufsc.br/~j.barreto/cca/tratexto/latex.htm)
4. Endeavor Brasil. (n.d.). Como elaborar um pitch quase perfeito. [link](https://endeavor.org.br/dinheiro/como-elaborar-um-pitch-quase-perfeito/)
