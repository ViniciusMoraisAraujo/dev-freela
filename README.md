# 🚀 DevFreela API

![Build Status](https://img.shields.io/badge/Build-Success-brightgreen)
![Platform](https://img.shields.io/badge/Platform-.NET%208-blue)
![Language](https://img.shields.io/badge/Language-C%23-red)
![Docker](https://img.shields.io/badge/Docker-Ready-blue)

## 📖 Sobre o Projeto

O **DevFreela** é uma API RESTful robusta desenvolvida para gerenciar o ecossistema de freelancers. A aplicação atua como uma ponte entre clientes (que cadastram projetos) e freelancers (que se candidatam a eles).

Este projeto é o resultado de um estudo aprofundado sobre desenvolvimento backend moderno, seguindo as diretrizes da **Formação ASP.NET Core** do [Luis Dev](https://github.com/luisdev).

---

## 🛠 Tecnologias e Práticas Utilizadas

O projeto foi construído utilizando o que há de mais moderno no ecossistema Microsoft:

* **Runtime:** .NET 8 SDK (ASP.NET Core)
* **Linguagem:** C#
* **Acesso a Dados:** Entity Framework Core (ORM)
* **Banco de Dados:** SQL Server
* **Documentação:** Swagger / OpenAPI

### 🏗 Arquitetura e Padrões de Projeto
Para garantir escalabilidade e fácil manutenção, foram aplicados conceitos avançados de engenharia de software:

* **Clean Architecture:** Separação clara de responsabilidades entre as camadas *Core, Application, Infrastructure e API*.
* **DDD (Domain-Driven Design):** Modelagem focada no negócio com Entidades e Objetos de Valor ricos.
* **CQRS:** Separação de leitura e escrita utilizando a biblioteca **MediatR**.
* **Repository Pattern:** Abstração completa da camada de dados.
* **Injeção de Dependência:** Para garantir o desacoplamento de componentes.

---

## ✨ Funcionalidades

### 👤 Gerenciamento de Usuários
* **Criação:** Registro de novos perfis (Freelancers ou Clientes).
* **Consulta:** Visualização de detalhes de perfis específicos.
* **Atualização:** Edição de informações cadastrais.
* **Remoção:** Fluxo de desativação ou exclusão de usuários.

### 💻 Gestão de Projetos
* **Cadastro:** Clientes podem criar novas oportunidades de trabalho.
* **Listagem:** Busca dinâmica de todos os projetos disponíveis.
* **Detalhes:** Consulta profunda de um projeto (incluindo dados do cliente e status).
* **Atualização:** Alteração de título, descrição ou orçamento.
* **Cancelamento:** Fluxo para exclusão ou interrupção de projetos.

