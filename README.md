# DB1BankExpress

API ASP.NET Core com MySQL.

## Pré-requisitos

1. .NET SDK 10
2. WSL
3. `dotnet-ef` instalado globalmente
4. Docker disponível dentro do WSL

Se precisar instalar o `dotnet-ef`:

```powershell
dotnet tool install --global dotnet-ef
```

## Subida rápida

Na raiz do projeto, execute:

```bash
docker compose up -d
dotnet restore
dotnet ef database update
dotnet run --launch-profile http
```

## Endereços locais

- API: `http://localhost:5073`
- Swagger: `http://localhost:5073/swagger`
- Endpoint base: `http://localhost:5073/api`

## Passo a passo curto

1. Abra o terminal da sua distro WSL.
2. Entre na pasta do projeto.
3. Suba o MySQL com `docker compose up -d`.
4. Rode `dotnet restore`.
5. Rode `dotnet ef database update`.
6. Rode `dotnet run --launch-profile http`.
7. Abra o Swagger e siga o desenvolvimento.

## Se algo falhar

- `docker` não reconhecido: valide se o Docker está disponível dentro do WSL e reabra o terminal.
- banco sem tabela `Customers`: rode `dotnet ef database update` novamente.
- porta 3306 ocupada: libere a porta ou ajuste compose e connection string.

## Documentação complementar

Detalhes do projeto, configuração local no WSL e observações adicionais estão em [DETALHES-DO-PROJETO.md](DETALHES-DO-PROJETO.md).