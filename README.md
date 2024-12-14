# Projeto Estágio Vega

Sistema de Gestão de Foprnecedores e Materiais

## Descrição

Esse Projeto Permite o Cadastro de fornecedores e seus respectivos materiais. O Projeto Permite cadastro de informações básicas de endereço, identificação e mantem as relações de quais Fornecedores fornecem quais materiais.

## Tecnologias Utilizadas

- Linguagem de programação: C#, JavaScript
- Frameworks e bibliotecas: ASP .Net, Bootstrap, Jquery, Entity Framework
- Banco de Dados: MySql
- Outros: Html5, CSS3, Git para versionamento do Projeto

## Funcionalidades

- [Descreva funcionalidade 1, ex.: Cadastro de usuários com autenticação]
- [Descreva funcionalidade 2, ex.: Listagem de dados com filtros]
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

   Além das dependências acima, certifique-se de instalar, localmente, o Banco de Dados MySql.
   
   

3. Configure as variáveis de ambiente (se aplicável):
   
   No Arquivo "appsettings.json", no campo "DefaultConnection", substitua a String pelos dados de seu banco de dados local, instalado anteriormente.
   Ex:
   ```bash
   "DefaultConnection": "Server=localhost;Database=MeuBanco;User=root;Password=teste123;Port=3306;"
   ```

5. Execute a aplicação:

   Após instalação das dependências e configurar as variaveis de ambiente, execute esse comando para criação das tabelas no banco de dados.
   ```bash
   Update-Database
   ```

7. Acesse no Site:

  Em sua IDE, após a instalação das dependencias e criação do Banco de dados e respectivas tabelas, inicie a depuração.

## Estrutura do Projeto


O Projeto Foi dividido em 2 Partes.
1ª) Src -  Codigo fonte do projeto
2ª) Readme -  Explicações do Projeto.
```plaintext
/
|-- src/            # Código fonte
|-- README.md       # Documentação do projeto
```

## Melhorias Futuras

- Melhorar a Identidade Visual da Aplicação.
- Tratar melhor os Inputs do usuário (Verificar se são pertinentes antes de adicioná-los ao Banco de Dados).
- Realizar autenticação do Usuário antes de permitir manipulação dos dados cadastrados.
- 


## Autor(es)

- Nome: Arthur Martins Zagnoli Silva
- LinkedIn: linkedin.com/in/arthur-zagnoli-81029723a/
- GitHub: github.com/zagdolly
