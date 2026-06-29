# DB1BankExpress

API ASP.NET Core com MySQL.

## Pré-requisitos

1. .NET SDK 10
2. WSL
3. Docker disponível dentro do WSL
4. `dotnet-ef` instalado globalmente apenas se você quiser rodar migrations manualmente

Se precisar instalar o `dotnet-ef`:

```powershell
dotnet tool install --global dotnet-ef
```

## Subida rápida

Na raiz do projeto, execute:

```bash
docker compose up -d
dotnet restore
dotnet run --launch-profile http
```

Observação: a aplicação aplica migrations pendentes automaticamente no startup. O comando `dotnet ef database update` continua útil como validação manual da conexão com o banco, mas não é obrigatório para toda execução local.

## Endereços locais

- API: `http://localhost:5073`
- Swagger: `http://localhost:5073/swagger`
- Endpoint base: `http://localhost:5073/api`

## Passo a passo curto

1. Abra o terminal da sua distro WSL.
2. Entre na pasta do projeto.
3. Suba o MySQL com `docker compose up -d`.
4. Rode `dotnet restore`.
5. Se quiser validar a migration manualmente antes de subir a API, rode `dotnet ef database update`.
6. Rode `dotnet run --launch-profile http`.
7. Abra o Swagger e siga o desenvolvimento.

## Se algo falhar

- `docker` não reconhecido: valide se o Docker está disponível dentro do WSL e reabra o terminal.
- falha ao aplicar migrations no startup: valide a conexão com o MySQL e rode `dotnet ef database update` manualmente para inspecionar o erro.
- porta 3306 ocupada: libere a porta ou ajuste compose e connection string.
- Swagger não abre: confirme que a aplicação está rodando em Development e acesse `http://localhost:5073/swagger`.

## Documentação complementar

Detalhes do projeto, configuração local no WSL e observações adicionais estão em [DETALHES-DO-PROJETO.md](DETALHES-DO-PROJETO.md).