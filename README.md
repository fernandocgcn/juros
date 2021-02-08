# Juros

Duas Web APIs RESTful implementadas em C# (.NET Core), com troca de informações entre si, documentadas com Swagger.

![](/misc/ComponentDiagram.png)

## Tecnologias Utilizadas

### C# - .NET Core

* src/Juros.Api.Calculo - Web API RESTful contendo os controllers (endpoints) para o cálculo dos juros compostos, utilizando Injeção de Dependência para Inversão de Controle dos serviços utilizados.  

* src/Juros.Api.Taxa - Web API RESTful contendo os controllers (endpoints) para a consulta da taxa de juros, sem dependências de outros projetos.  

* src/Juros.Shared - Biblioteca compartilhada entre as APIs que realiza a comunicação entre ambas.  

* src/Juros.Test - Testes (NUnit) de unidade e integração dos controllers. Fundamental para a utilização de TDD no desenvolvimento do projeto, ajudando a manter um baixo acoplamento e a detectar critérios dos requisitos ainda não considerados.  

## Screenshots da Aplicação

![](/misc/screenshots/01.png)
![](/misc/screenshots/02.png)
![](/misc/screenshots/03.png)
![](/misc/screenshots/04.png)
![](/misc/screenshots/05.png)

## Autor

* **Fernando Cordeiro Gondim Cavalcante Neto** - [fernandocgcn@GitHub](https://github.com/fernandocgcn) e [fernandocgcn@LinkedIn](https://www.linkedin.com/in/fernandocgcn)
