# 🔧 CRUD API com .NET 6, PostgreSQL e Swagger

[![.NET](https://img.shields.io/badge/.NET-6.0-purple)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/C%23-10.0-green)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![PostgreSQL](https://img.shields.io/badge/PostgreSQL-12%2B-blue)](https://www.postgresql.org/)
[![Entity Framework](https://img.shields.io/badge/EF%20Core-6.0-orange)](https://docs.microsoft.com/en-us/ef/core/)
[![Swagger](https://img.shields.io/badge/Swagger-UI-brightgreen)](https://swagger.io/)
[![License](https://img.shields.io/badge/License-MIT-lightgrey)](LICENSE)

API RESTful completa para gerenciamento de usuários, desenvolvida em **.NET 6** com **C#**, utilizando **PostgreSQL** como banco de dados e **Entity Framework Core** como ORM. A API é documentada automaticamente com **Swagger** e segue boas práticas de arquitetura, como o padrão Repository e injeção de dependência.

* * *

## ✨ Funcionalidades

* ✅ **CRUD completo** – Criação, leitura, atualização e remoção de usuários.
* ✅ **Validação de dados** – Modelos com Data Annotations e validações de entrada.
* ✅ **Arquitetura em camadas** – Separação entre Controllers, Repository e Data Context.
* ✅ **Documentação interativa** – Swagger UI para testar os endpoints.
* ✅ **Migrations automáticas** – Versionamento do esquema do banco de dados.
* ✅ **Injeção de dependência** – Nativa do .NET, promovendo desacoplamento.
* ✅ **Tratamento de exceções** – Respostas padronizadas para erros.

* * *

## 📂 Estrutura do Projeto

```bash
📁 CRUD_w_Csharp_.NET6.0_PostgreSQL_WEB_Swagger/
│
├── Controllers/ # Controladores da API (endpoints)
├── Data/ # Contexto do Entity Framework
├── Migrations/ # Histórico de migrações do banco
├── Model/ # Entidades do domínio (ex: Usuario)
├── Repository/ # Implementação do padrão Repository
├── Properties/ # Configurações de lauchSettings
├── appsettings.json # Configurações (string de conexão)
├── Program.cs # Ponto de entrada e configuração da API
└── usuario.csproj # Arquivo de projeto .NET
```

* * *

## 🚀 Como Executar

### Pré-requisitos

* [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
* [PostgreSQL](https://www.postgresql.org/download/) (12 ou superior)
* [Visual Studio Code](https://code.visualstudio.com/) (ou qualquer IDE)

### Passo a Passo

1. **Clone o repositório**

   ```bash
   git clone https://github.com/Gussnogue/CRUD_w_Csharp_.NET6.0_PostgreSQL_WEB_Swagger.git
   cd CRUD_w_Csharp_.NET6.0_PostgreSQL_WEB_Swagger

2. **Configure a string de conexão**

   ```bash
   {  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Database=usuariosdb;Username=postgres;Password=sua_senha"  }}

3. **Aplique as migrações**
   ```bash
   dotnet ef database update

4. **Execute a aplicação**
   ```bash
   dotnet run

## 🔗 Endpoints da API

| Método | Rota                | Descrição                         |
|--------|---------------------|-----------------------------------|
| GET    | `/api/usuarios`     | Retorna todos os usuários        |
| GET    | `/api/usuarios/{id}`| Retorna um usuário por ID        |
| POST   | `/api/usuarios`     | Cria um novo usuário             |
| PUT    | `/api/usuarios/{id}`| Atualiza um usuário existente    |
| DELETE | `/api/usuarios/{id}`| Remove um usuário                |

## Exemplo de corpo para POST/PUT:

```json
{
  "nome": "João Silva",
  "email": "joao@email.com",
  "dataCadastro": "2025-03-14T10:00:00"
}
```

## 🛠️ Tecnologias Utilizadas

.NET 6 – Framework principal

C# 10 – Linguagem de programação

Entity Framework Core 6 – ORM para acesso a dados

PostgreSQL – Banco de dados relacional

Swashbuckle (Swagger) – Documentação interativa

Injeção de Dependência Nativa – Desacoplamento de camadas

Repository Pattern – Abstração da camada de dados

## 📌 Boas Práticas Aplicadas

Separação em camadas (Controllers, Repository, Data)

Uso de Data Annotations para validação de modelos

Migrations para versionamento do banco

Configuração por ambiente (Development/Production)

Tratamento de exceções com respostas padronizadas

Código limpo e comentado seguindo convenções C#

## 📄 Licença

Este projeto está licenciado sob a MIT License – veja o arquivo LICENSE para mais detalhes.
