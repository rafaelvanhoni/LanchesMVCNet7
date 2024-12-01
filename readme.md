# Lanches Rafael

![.NET](https://img.shields.io/badge/.NET-Core_7.0-blue)

Bem-vindo ao **Lanches Rafael**, um sistema em desenvolvimento baseado no curso *"Curso de ASP .NET Core MVC - Criando um Site do Zero"* de Macoratti. Este projeto está sendo desenvolvido com fins educacionais para aprendizado e prática de ASP.NET Core MVC e conceitos de desenvolvimento web.

## 🚀 Status do Projeto

🔨 **Em desenvolvimento**: funcionalidades estão sendo implementadas gradualmente, e o código está em constante evolução.  

---

## 📚 Tabela de Conteúdo

1. [Descrição do Projeto](#-descrição-do-projeto)
2. [Tecnologias Utilizadas](#-tecnologias-utilizadas)
3. [Funcionalidades](#-funcionalidades)
4. [Configuração do Projeto](#-configuração-do-projeto)
5. [Links Úteis](#-links-úteis)
6. [Contribuição](#-contribuição)
7. [Licença](#-licença)

---

## 📝 Descrição do Projeto

O **Lanches Rafael** é um sistema de e-commerce que visa a listagem e compra de lanches. Apesar de estar em desenvolvimento, já possui algumas funcionalidades, como:

- Listagem de lanches categorizados.
- Exibição de detalhes do lanche.
- Adição de lanches ao carrinho de compras.

---

## 🛠️ Tecnologias Utilizadas

- **Linguagem:** C#  
- **Framework:** .NET Core 7.0  
- **ORM:** Entity Framework Core  
- **Banco de Dados:** SQL Server  
- **IDE:** Visual Studio Community (MacOS)  

---

## 📌 Funcionalidades (em progresso)

- [x] Listagem de lanches por categoria.
- [x] Exibição de detalhes do produto.
- [ ] Carrinho de compras.
- [ ] Cadastro de usuários.
- [ ] Sistema de checkout com integração a métodos de pagamento.

---

## ⚙️ Configuração do Projeto

Para executar este projeto localmente, siga as etapas:

1. Clone este repositório:
   ```bash
   git clone https://github.com/rafaelvanhoni/LanchesMVCNet7.git

2. **Instale as dependências**  
   Certifique-se de ter o SDK do .NET Core 7.0 instalado. Acesse a [documentação oficial](https://dotnet.microsoft.com/download/dotnet/7.0) para baixar e instalar a versão necessária.

3. **Configure o banco de dados**  
   - O projeto utiliza o Entity Framework Core para gerenciamento do banco de dados.
   - Verifique o arquivo `appsettings.json` para ajustar as configurações de conexão com o banco de dados.
   - Para criar e aplicar as migrações, execute os comandos:
     ```bash
     dotnet ef migrations add InitialMigration
     dotnet ef database update
     ```

4. **Execute o projeto**  
   Na raiz do projeto, utilize o comando:
   ```bash
   dotnet run

O sistema estará disponível no endereço padrão: `http://localhost:5000`.

5. **Acesse a aplicação**  
   Abra seu navegador e vá até `http://localhost:5000` para visualizar a aplicação em execução.

## Links Úteis

Aqui estão alguns links importantes relacionados ao projeto e ao curso:

- [Curso ASP.NET Core MVC - Macoratti](https://www.udemy.com/course/curso-de-asp-net-core-mvc-criando-um-site-do-zero/)
- [Documentação oficial do ASP.NET Core](https://learn.microsoft.com/aspnet/core/)
- [Documentação oficial do Entity Framework Core](https://learn.microsoft.com/ef/core/)
