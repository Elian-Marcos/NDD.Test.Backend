Web API .NET 8 CRUD Client
==========================

Esta é uma aplicação de exemplo que demonstra como implementar um CRUD de clientes em uma Web API .NET 8 utilizando os princípios de CQRS (Command Query Responsibility Segregation) com Mediator e Entity Framework.

Funcionalidades
---------------

*   Cadastrar um novo cliente
*   Listar todos os clientes
*   Buscar um cliente por ID
*   Atualizar os dados de um cliente existente
*   Excluir um cliente

Configuração
------------

### Pré-requisitos

*   Visual Studio
*   .NET SDK 8 (ou superior)
*   SQL Server

### Passos para configurar o ambiente de desenvolvimento

1.  Clone este repositório em sua máquina local:
    
    bashCopy code
    
    `[git clone https://github.com/seu-usuario/nome-do-repositorio.git](https://github.com/Elian-Marcos/ndd-test.git)`
    
2.  Abra a solução `NDD.Test.sln` no Visual Studio.
    
3.  Verifique e, se necessário, atualize a connection string no arquivo `appsettings.json` para apontar para o seu banco de dados local.
 
4.  Pressione F5 para iniciar a aplicação. A API estará disponível em `https://localhost:7168`.
    
Uso
---

Você pode usar qualquer cliente HTTP para interagir com a API. Aqui estão alguns exemplos usando o `curl`:

*   Listar todos os clientes:
    
    bashCopy code
    
    `curl -X GET https://localhost:7168/api/v1/clients/getAll`
    
*   Buscar um cliente por ID:
    
    bashCopy code
    
    `curl -X GET https://localhost:7168/api/v1/clients/getById`
    
*   Cadastrar um novo cliente:
    
    bashCopy code
    
    `curl -X POST https://localhost:7168/api/v1/clients/create -d '{ "name": "string", "cpf": "string", "gender": "string", "phoneNumber": "string"  "email": "string", "birthDate": "2024-04-13T21:33:50.187Z", "observation": "string"}' -H 'Content-Type: application/json'`
    
*   Atualizar os dados de um cliente:
    
    bashCopy code
    
    `curl -X PUT https://localhost:7168/api/v1/clients/update -d '{"phoneNumber": "string"  "email": "string", "observation": "string"}' -H 'Content-Type: application/json'`
    
*   Excluir um cliente:
    
    bashCopy code
    
    `curl -X DELETE https://localhost:5001/api/v1/clients/delete`
    

Contribuição
------------

Contribuições são bem-vindas! Sinta-se à vontade para enviar pull requests ou abrir issues com sugestões e melhorias.

Licença
-------

Este projeto está licenciado sob a Licença MIT.
