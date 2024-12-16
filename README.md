# Projeto Estágio Vega

Sistema de Gestão de Fornecedores e Materiais

## Descrição

Esse Projeto Permite o Cadastro de fornecedores e seus respectivos materiais. O Projeto Permite cadastro de informações básicas de endereço, identificação e mantém as relações de quais Fornecedores fornecem quais materiais.

## Tecnologias Utilizadas

- Linguagem de programação: C#, JavaScript
- Frameworks e bibliotecas: ASP .Net, Bootstrap, Jquery, Entity Framework
- Banco de Dados: MySql
- Outros: Html5, CSS3, Git para versionamento do Projeto

## Funcionalidades

- Cadastro de fornecedores e materiais.
- Manutenção da relação entre fornecedores e materiais.
- Listagem e edição de informações cadastradas.
- [Adicione mais funcionalidades relevantes]

## Como Executar o Projeto

1. Clone o repositório:
   ```bash
   git clone https://github.com/zagdolly/Projeto-Est-gio-Vega
   ```

2. Instale as dependências:
   
   Entity.EntityFramework.Core 8.0.2  
   Entity.EntityFramework.Design 8.0.2  
   Entity.EntityFramework.Relational 8.0.2  
   Entity.EntityFramework.Tools 8.0.2  
   POMELO.EntityFrameworkCore.MySql 8.0.2

   Além das dependências acima, certifique-se de instalar, localmente, o Banco de Dados MySql, e o framework .NET.

3. Configure as variáveis de ambiente:
   
   No arquivo `appsettings.json`, no campo "DefaultConnection", substitua a string pelos dados do seu banco de dados local, instalado anteriormente.
   Exemplo:
   ```json
   "DefaultConnection": "Server=localhost;Database=MeuBanco;User=root;Password=teste123;Port=3306;"
   ```

4. Execute a aplicação:
   
   Após instalar as dependências e configurar as variáveis de ambiente, abra o projeto no Visual Studio e execute este comando para criar as tabelas no banco de dados:
   ```bash
   Update-Database
   ```

5. Acesse o site:

   Em sua IDE, após a instalação das dependências e criação do banco de dados e respectivas tabelas, execute a aplicação dentro da IDE (Depuração).

## Estrutura do Projeto

O Projeto foi dividido em 2 partes:

1ª) Src - Código fonte do projeto  
2ª) Readme - Explicações do Projeto.

```plaintext
/
|-- src/            # Código fonte
|-- README.md       # Documentação do projeto
```

## Melhorias Futuras

- Melhorar a identidade visual da aplicação.
- Tratar melhor os inputs do usuário (verificar se são pertinentes antes de adicioná-los ao banco de dados).
- Realizar autenticação do usuário antes de permitir manipulação dos dados cadastrados.
- [Adicione melhorias ou funcionalidades planejadas.]

## Autor(es)

- Nome: Arthur Martins Zagnoli Silva
- LinkedIn: [linkedin.com/in/arthur-zagnoli-81029723a/](https://linkedin.com/in/arthur-zagnoli-81029723a/)
- GitHub: [github.com/zagdolly](https://github.com/zagdolly)

