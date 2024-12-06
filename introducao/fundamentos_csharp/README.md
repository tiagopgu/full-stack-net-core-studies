# 🎯 Fundamentos do C\# <a id="topo"></a>

[![CSharp Badge](https://img.shields.io/badge/C%23-239120?logo=c-sharp&logoColor=white&style=for-the-badge)](https://dotnet.microsoft.com/pt-br/languages/csharp)
[![.Net Badge](https://img.shields.io/badge/--5C2D91?logo=.net&logoColor=white&style=for-the-badge)](https://dotnet.microsoft.com/pt-br/)
[![VS Code Badge](https://img.shields.io/badge/-VS%20Code-007ACC?style=for-the-badge&logo=data%3Aimage%2Fsvg%2Bxml%3Bbase64%2CPD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0iVVRGLTgiPz4KPHN2ZyB2ZXJzaW9uPSIxLjEiIHZpZXdCb3g9IjAgMCAxMDI0IDEwMjQiIHdpZHRoPSIyNTYiIGhlaWdodD0iMjU2IiB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciPgo8cGF0aCB0cmFuc2Zvcm09InRyYW5zbGF0ZSg3MzYpIiBkPSJtMCAwaDI2bDE1IDYgNTAgMjQgNjYgMzIgMjMgMTEgMzUgMTcgMjMgMTEgMjEgMTEgMTAgOCA3IDggOCAxNCA0IDExdjcxOGwtNyAxNi05IDE0LTkgOC0xNCA4LTMwIDE1LTIzIDExLTMzIDE2LTIzIDExLTM5IDE5LTMxIDE1LTIzIDExLTIxIDloLTI0bC0xMi00LTEzLTctMTQtMTItMTctMTYtMTMtMTItMTAtOS0zOS0zNi0xMi0xMS04LTctMTYtMTUtMTMtMTItMTItMTEtOC03LTE1LTE0LTEzLTEyLTEyLTExLTgtNy0xNS0xNC0xMy0xMi0xMi0xMS04LTctMTUtMTQtMTMtMTItMTItMTEtOC03LTE1LTE0LTEzLTEyLTEyLTExLTgtNy0xNS0xNC0xMy0xMi0xMi0xMS0xMC05LTctNi01IDEtMTIgOS0xMyAxMC0xNyAxMy0yMSAxNi0xNiAxMi0xMyAxMC0xOCAxNC0xMiA5LTQyIDMyLTEzIDktMTEgNS01IDFoLTlsLTEyLTMtOS01LTE0LTEyLTE3LTE2LTEzLTEyLTEwLTktNy02LTktMTItNC05di0yMmw3LTEzIDExLTEyIDEwLTkgMTctMTYgMjAtMTggMTUtMTQgMjQtMjIgOC03IDE2LTE1IDEyLTExIDEwLTkgMTItMTFoMmwxLTUtNC0yLTExLTExLTgtNy0xNi0xNS0xMi0xMS0xMC05LTE1LTE0LTEwLTktMTMtMTItMTAtOS0xNS0xNC0xMC05LTEyLTExLTExLTExLTctMTItMS0zdi0yMmw3LTEzIDktMTAgMTUtMTQgMTMtMTIgOC03IDEzLTEyIDExLTkgMTEtNSA0LTFoMTVsMTIgNCAxNCAxMCAxNyAxMyAxMyAxMCAxNiAxMiAxOCAxNCAyMCAxNSAxOCAxNCAxNiAxMiAxOCAxNCAxNiAxMiAxNSAxMSA0LTEgNy03IDgtNyAxNS0xNCAyNC0yMiAxMC05IDE1LTE0IDEwLTkgMTMtMTIgMTAtOSAxNS0xNCAxMC05IDEzLTEyIDEwLTkgMTUtMTQgMTItMTEgMTAtOSAxMi0xMSAyNi0yNCAxMC05IDEyLTExIDI2LTI0IDEwLTkgMTItMTEgMjYtMjQgMTAtOSAxMi0xMSAyNi0yNCAxMC05IDEzLTEyIDktNyAxNi04em0zMCAyNzktMTUgMTItMTYgMTItODQgNjQtMTMgMTAtMTYgMTItMTMgMTAtMzQgMjYtMjEgMTYtMTYgMTItMTMgMTAtNTEgMzktMTIgOSA1IDUgMTYgMTMgMTYgMTIgNjMgNDggNTkgNDUgMTMgMTAgMTYgMTIgMjYgMjAgMjAgMTUgMTggMTQgMjAgMTUgMzAgMjMgNCAydi00NjZ6IiBmaWxsPSIjRjNGM0YzIi8%2BCjwvc3ZnPgo%3D)](https://code.visualstudio.com/)

[![README Repositório Badge](https://img.shields.io/badge/README-Repositório-062019?style=for-the-badge&labelColor=%23139E65)](/README.md)

## Conceitos Básicos

Antes de iniciar o estudo da linguagem de programação **C#**, alguns conceitos são importantes serem entendidos:

### Lógica de programação

Sequência de passos definidos para que um programa de computador consiga executar algo.

### Linguagem de programação

- Define instruções que usamos para implementar a lógica de um programa
- Existem diversas linguagens disponíveis no mercado, como, por exemplo, o **C#**
- Cada linguagem possui sua sintaxe e semântica, semelhante a um idioma de um país
- Todo o conjunto de instruções usados no programa é chamado de **código fonte**.
- Para ser executado, o _código fonte_ passa por um dos seguintes passos, a depender da linguagem de programação em que foi escrito:
  - Interpretação: Cada instrução é lida e executada em sequência pelo computador. Exemplo de linguagem interpretada: _python_
  - Compilação: O _código fonte_ é compilado para gerar um arquivo binário. Exemplo de linguagem compilada: _C++_.
  
    <a id="compilacao-csharp"></a>
    - O _C#_ é uma linguagem compilada, porém passa por um processo diferente: na primeira etapa é gerada uma linguagem intermediária (IL). Esse código intermediário é passado por um compilador de tempo de execução (RyuJIT), que transformará o código IL nos binário nativo da máquina em que está sendo executado.

### .NET

- Plataforma de código aberto para desenvolvimento de várias aplicações: desktop, web, IoT, jogos, etc.
- Provê diversas bibliotecas otimizadas que acelera o desenvolvimento
- Permite usar diversas linguagens de programação, como, por exemplo, o **C#**.

#### Histórico

- .NET Framework
  - Criado em 2002
  - Última versão lançada foi a 4.8.1
  - Só pode ser executado no Windows (existe o projeto _Mono_ que permite a execução em outra plataforma, porém não é oficial da Microsoft)

- .NET Core
  - Criado em 2016
  - Reescrita completa da plataforma
  - Multiplaforma (não depende do Windows para funcionar)
  - Plataforma de código aberto

- .NET
  - Novo nome do .NET Core a partir da versão 5.
  - Não teve a versão 4 do .NET Core (provavelmente para não gerar confusão com a última versão do .NET Framework, que foi a 4.8.8).
  - Qualquer referência a .NET, estamos falando da versão 5 ou superior do .NET Core (por exemplo: .NET 9, que é a versão mais recente até a escrita desse documento)

#### CLR (Commom Language Runtime)

- Principal parte do .NET
- Responsável por executar a [linguagem intermediária (IL)](#compilacao-csharp)
- Conversa com o hardware
- Gerencia o uso de recursos e memória

[🔼 topo](#topo)

## Ambiente de desenvolvimento

### Configuração

- Baixe o [.NET](https://dotnet.microsoft.com/pt-br/download) e faça a instalação
  - Baixe o .NET Runtime caso queira somente executar aplicações desenvolvida em .NET
  - Baixe o .NET SDK caso queira desenvolver aplicações em .NET
- Confirme a instalação e outras informações de versões instaladas, executando no prompt de comandos: `dotnet --info`

  ![Informações do .NET instalado](/introducao/fundamentos_csharp/img/dotnet-info.png)

### IDE's de desenvolvimento

- [Visual Studio](https://visualstudio.microsoft.com/pt-br/)
  - Mais completa para desenvolvimento .NET
  - Roda somente no Windows
  - Possui versão gratuita e paga

- [Visual Studio Code](https://code.visualstudio.com/)
  - Versão mais simplicada e leve para desenvolvimento
  - Multiplataforma
  - Open Source
  - Possui diversos plugins, que podem ser instalados conforme a necessidade
  - Extensões para desenvolvimento C#:
    - C#
    - _(Opcional)_ C# Dev Kit

- [Jetbrains Rider](https://www.jetbrains.com/rider/)
  - Multiplataforma
  - Paga

### Estrutura

#### Projeto

- Organiza os _códigos fonte_, seja por pasta e/ou arquivos
- É um escrito em uma das linguagens suportadas pelo .NET
- Define a versão do .NET usada
- Define a tipo de binário de saída (.exe, .dll)

#### Solution

- Agrupa projetos de uma aplicação
- Permite que todos os projetos sejam compilados de uma vez

[🔼 topo](#topo)
