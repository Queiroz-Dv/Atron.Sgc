# Protótipo de Sistema de Gestão Comercial (SGC) - API

![Status](https://img.shields.io/badge/Status-Em%20Desenvolvimento-yellow)
![Tecnologia](https://img.shields.io/badge/.NET-8-blueviolet)

## 🎯 Sobre o Projeto

Este repositório contém o código-fonte do back-end de um **Sistema de Gestão Comercial (SGC)**. O projeto foi desenvolvido como um exercício prático para aprimorar e solidificar habilidades em desenvolvimento de APIs RESTful com C# e .NET.

O escopo foi desenhado para um nível de complexidade mediano, ideal para um desenvolvedor de nível pleno, com foco na correta implementação de regras de negócio, na estruturação de uma API coesa e na aplicação de boas práticas de desenvolvimento, como a separação de responsabilidades (SOLID), injeção de dependência e o padrão de repositório.

---

## ✨ Funcionalidades

O sistema é dividido em três módulos principais que cobrem o ciclo de vida de uma venda:

* **📦 Módulo de Cadastros:**
    * Gerenciamento completo (CRUD) de `Clientes`.
    * Gerenciamento completo (CRUD) de `Produtos`.

* **🛒 Módulo de Vendas:**
    * Criação de `Pedidos` associados a um cliente e compostos por um ou mais produtos.
    * Gerenciamento do ciclo de vida de um pedido através de `Status` (Pendente, Processando, Cancelado, etc.).

* **📊 Módulo de Controle de Estoque:**
    * Validação de estoque disponível antes de processar uma venda.
    * Baixa automática do estoque após a confirmação do pedido.
    * Estorno de estoque em caso de cancelamento de um pedido processado.

---

## 📜 Principais Regras de Negócio

A lógica do sistema é guiada pelas seguintes regras de negócio:

#### Clientes
- `RN01`: O **Email** deve ser único na base de dados.
- `RN02`: O **CPF** deve ser único e possuir um formato válido.
- `RN03`: Clientes **inativos** não podem realizar novos pedidos.
- `RN04`: A exclusão física de um cliente só é permitida se ele não possuir pedidos. Caso contrário, apenas a **inativação** (exclusão lógica) é permitida.

#### Produtos
- `RN05`: O **SKU** (código do produto) deve ser único.
- `RN06`: O **Preço** de um produto deve ser sempre maior que zero.
- `RN07`: A **Quantidade em Estoque** não pode ser negativa.
- `RN08`: Produtos **inativos** não podem ser adicionados a novos pedidos.

#### Pedidos e Estoque
- `RN12`: O **preço do produto** é "congelado" no item do pedido no momento da compra.
- `RN13`: O **valor total do pedido** é sempre calculado no back-end.
- `RN15`: O estoque de **todos os itens** de um pedido é verificado antes de seu processamento.
- `RN16`: A **baixa de estoque** é realizada de forma atômica quando o pedido é processado.
- `RN17`: O **estorno de estoque** é realizado se um pedido já processado for cancelado.

---

## 🛠️ Tecnologias Utilizadas

* **[C#](https://learn.microsoft.com/pt-br/dotnet/csharp/)**
* **[.NET 8](https://dotnet.microsoft.com/pt-br/download/dotnet/8.0)**
* **[ASP.NET Core Web API](https://learn.microsoft.com/pt-br/aspnet/core/web-api/)**
* **Repositório em Memória:** Para fins de prototipagem, o projeto utiliza uma lista em memória como banco de dados, com o ciclo de vida do repositório gerenciado como `Singleton` para persistir os dados durante a execução da aplicação.
* **Arquitetura em Camadas:** O projeto segue uma separação clara entre Domínio, Aplicação (Serviços), Infraestrutura (Repositórios) e Apresentação (API).

---

## Endpoints da API

### `api/cliente`
- `GET /` - Retorna todos os clientes.
- `GET /{id}` - Retorna um cliente por ID.
- `POST /` - Adiciona um novo cliente.
- `PUT /{id}` - Atualiza um cliente existente.
- `DELETE /{id}` - Inativa um cliente (exclusão lógica).

### `api/produto`
- `GET /` - Retorna todos os produtos.
- `GET /{id}` - Retorna um produto por ID.
- `POST /` - Adiciona um novo produto.
- `PUT /{id}` - Atualiza um produto existente.
- `DELETE /{id}` - Inativa um produto.

### `api/pedido`
- `POST /` - Cria um novo pedido com status `Pendente`.
- `GET /{id}` - Busca um pedido com seus itens.
- `PATCH /{id}/processar` - Altera o status para `Processando` e realiza a baixa de estoque.
- `PATCH /{id}/cancelar` - Altera o status para `Cancelado` e realiza o estorno de estoque, se necessário.

---

## 🚀 Como Executar o Projeto

1.  **Pré-requisitos:**
    * [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

2.  **Clone o repositório:**
    ```bash
    git clone https://github.com/Queiroz-Dv/Atron.Sgc.git
    ```

3.  **Navegue até a pasta do projeto:**
    ```bash
    cd Atron.Sgc
    ```

4.  **Restaure as dependências:**
    ```bash
    dotnet restore
    ```

5.  **Execute a aplicação:**
    ```bash
    dotnet run
    ```

A API estará disponível em `http://localhost:5000` ou `https://localhost:5001`. Verifique o console para a porta exata.

---

## 👨‍💻 Autor

**Eduardo Borges Custodio Queiroz**

* **GitHub:** [Queiroz-Dv](https://github.com/Queiroz-Dv)
* **LinkedIn:** [Eduardo Queiroz](https://www.linkedin.com/in/seu-perfil/)