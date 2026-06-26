# Detalhes do Projeto

## Stack

- .NET 10
- ASP.NET Core Web API
- Entity Framework Core
- Pomelo EntityFrameworkCore MySQL
- MySQL 8 via Docker
- Swagger / OpenAPI em Development

## Estrutura principal

- `Program.cs`: configuração da API, Swagger e DbContext
- `Context/AppDbContext.cs`: contexto do Entity Framework
- `Models/Customer.cs`: modelo de cliente
- `Controllers/CustomerController.cs`: CRUD de clientes
- `Migrations/`: histórico de migrations
- `docker-compose.yml`: container do MySQL

## Configuração atual do banco

Connection string configurada:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Port=3306;Database=banking;User=root;Password=1234;"
}
```

Container MySQL esperado pelo projeto:

- porta `3306`
- banco `banking`
- usuário `root`
- senha `1234`

## Fluxo de execução local

A aplicação não aplica migrations automaticamente no startup. Por isso, o fluxo correto é:

1. Subir o MySQL.
2. Restaurar pacotes.
3. Aplicar migration com `dotnet ef database update`.
4. Subir a API com `dotnet run --launch-profile http`.

## WSL

Se você estiver rodando pelo WSL:

1. Use uma distro Linux com o projeto acessível pelo terminal.
2. Garanta que o comando `docker` funcione dentro do WSL.
3. Valide no terminal Linux:

```bash
docker --version
docker compose version
docker ps
```

Exemplo de caminho do projeto dentro do WSL:

```bash
cd /mnt/c/Users/renan.silva/Documents/cursos/DB1BankExpress
```

## Endpoints

- `GET /api/customer`
- `POST /api/customer`
- `PUT /api/customer`
- `DELETE /api/customer?Id={guid}`

Exemplo para criar cliente:

```json
{
  "name": "Maria Silva"
}
```

Exemplo para atualizar cliente:

```json
{
  "id": "00000000-0000-0000-0000-000000000000",
  "name": "Maria Souza"
}
```

## Problemas comuns

### `docker compose` não funciona

- confirme que o comando `docker` funciona dentro da distro WSL
- reabra o terminal para atualizar o ambiente
- se necessário, revise a integração do Docker com a distro usada

### `dotnet ef` não funciona

Instale ou atualize a ferramenta:

```powershell
dotnet tool install --global dotnet-ef
dotnet tool update --global dotnet-ef
```

### Aviso de `pending changes` no EF Core

Este repositório pode exibir esse aviso durante `dotnet ef database update`. Para execução local, o mais importante é confirmar se o comando concluiu e se o banco ficou acessível com a tabela `Customers`.

### Porta 3306 em uso

Se houver outro MySQL local ocupando a porta, ajuste a porta do container e a connection string do projeto.

## Observações

- Swagger fica disponível apenas em ambiente Development.
- O profile `http` usa a porta `5073`.
- O projeto compilou com sucesso com o SDK `10.0.101`.