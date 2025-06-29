# 🚀 InsightFlow

**InsightFlow** é uma plataforma de gestão de incidentes com integração de Inteligência Artificial Generativa, desenvolvida em .NET, utilizando **arquitetura limpa (DDD + Hexagonal)** e práticas modernas de desenvolvimento.

> **Objetivo:** Automatizar o processo de categorização, resposta e priorização de incidentes técnicos em ambientes corporativos.

---

## 📚 Sumário

- [📖 Sobre o Projeto](#-sobre-o-projeto)
- [⚙️ Arquitetura](#-arquitetura)
- [🗂️ Estrutura de Pastas](#️-estrutura-de-pastas)
- [🚀 Tecnologias Utilizadas](#-tecnologias-utilizadas)
- [💻 Instalação e Execução](#-instalação-e-execução)
- [🧪 Testes](#-testes)
- [📌 Próximos Passos](#-próximos-passos)

---

## 📖 Sobre o Projeto

**InsightFlow** foi criado com foco em inovação e aplicabilidade no ambiente corporativo. Utilizando **Inteligência Artificial Generativa (via OpenAI ou Azure OpenAI)**, o sistema analisa descrições de incidentes e sugere automaticamente possíveis soluções, otimizando o trabalho da equipe de suporte.

**Casos de uso iniciais:**

- Cadastro e gerenciamento de incidentes
- Sugestão automática de soluções via IA
- Priorização automática com base em análise semântica
- Histórico completo de interações
- Integração futura com sistemas terceiros via API

---

## ⚙️ Arquitetura

O projeto adota:

- **Domain-Driven Design (DDD)**
- **Clean Architecture** com separação de responsabilidades em camadas
- **Hexagonal Architecture (Ports & Adapters)** para facilitar testes e integrações

---

## ⚙️ Como rodar localmente

- dotnet restore
- dotnet build
- dotnet run --project ./InsightFlow.Api

## 🗂️ Estrutura de Pastas

- `InsightFlow.Api/`: Camada de apresentação (Controllers, Program.cs)
- `InsightFlow.Application/`: Casos de uso, comandos, handlers, serviços de aplicação
- `InsightFlow.Domain/`: Entidades, ValueObjects, Enums (modelo de negócio puro)
- `InsightFlow.Infrastructure/`: EF Core, DbContext, repositórios, configurações
- `InsightFlow.Tests/`: Testes unitários e de integração

## 🚀 Tecnologias Utilizadas

- [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
- ASP.NET Core 9
- MediatR + CQRS
- FluentValidation
- Entity Framework Core + PostgreSQL
- AutoMapper
- Serilog
- OpenAI API
- xUnit + Moq + FluentAssertions

---

### 🧪 Testes

### ✅ Pré-requisitos

- [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
- VS Code (ou outro editor)
- PostgreSQL (em breve docker)

### ▶️ Rodando via terminal

### Install make

```powershell
choco install make
```
### Makefile commands

```bash
make restore
make build
make run
make test
make migrate
make update
make up
make down
```
