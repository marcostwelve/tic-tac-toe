<h1 align="center">Jogo da Velha</h1>


<img width="886" height="425" alt="image" src="https://github.com/user-attachments/assets/9cd7bd74-e063-421e-9f1a-9f08dd7bc9b1" />


 ## Jogo da velha (tic tac toe) é um projeto full-stack para o clássico jogo da velha.

## 🔥 Introdução

APP foi criação com .net versão 8 e React versão 19

### ⚙️ Pré-requisitos
* .Net Core versão 8.0 [.Net Core 8.0 Download](https://dotnet.microsoft.com/pt-br/download/dotnet/8.0)
* Entity Framework Core versão 8.0 [Documentação](https://learn.microsoft.com/pt-br/ef/)
* Visual studio 2022, ou IDE que tenha suporte ao .Net 8.0 [Visual Studio 2022 Download](https://visualstudio.microsoft.com/pt-br/downloads/)
* PostgeSQL versão 16 [PostgreSQL Download](https://www.postgresql.org/download/windows/)
* React v19 [Documentação] ([Learn React](https://react.dev/learn))
  


### 🔨 Guia de instalação

Para utilizar este projeto, necessário instalar o Entity Framework, e configurar o banco de dados no arquivo appsettings.Development.json, e instalar as migrations para conexão com o banco de dados

Etapas para instalar:

```bash
dotnet tool install --global dotnet-ef
```
Passo 2:
```bash
dotnet add package Microsoft.EntityFrameworkCore.Npgsql
```
Passo 3:
```bash
Install-Package Microsoft.EntityFrameworkCore.Design
```
Passo 4:
```bash
dotnet-ef migrations add (Nome da migration do projeto)
```

Passo 5:
```bash
dotnet-ef database update
```

# Executando a Aplicação 🌐

Para executar a aplicação App, digite o seguinte comando

```bash
npm run dev
```
Acessar o link http://localhost:5173 (Caso o navegador não abra automaticamente)

Para executar a aplicação back-end, digite o seguinte comando

```bash
dotnet run
```

# Criação de Autor e genero via back-end 🚨

Foram criados dois end-points
Um para criar partidas e outro para buscar partidas e mostrar no histórico
Existe um terceiro, para buscar partida, mas o mesmo não foi utilizado neste projeto

<img width="1441" height="173" alt="image" src="https://github.com/user-attachments/assets/6bbdedfa-1160-4d5d-889d-0b113cb4b2cb" />

# Páginas 📝

Existem duas páginas no projeto
- Página principal (Jogo)
- Página de histórico (Verificar partidas anteriores)


<img width="886" height="425" alt="image" src="https://github.com/user-attachments/assets/7962c529-f8a1-4aae-86cf-1660812a2dda" />

<img width="886" height="422" alt="image" src="https://github.com/user-attachments/assets/796f4043-3019-40e5-a386-fa96d7cbb35c" />


