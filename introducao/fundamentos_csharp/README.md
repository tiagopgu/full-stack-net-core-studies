# 🎯 Fundamentos do C\# <a id="topo"></a>

[![CSharp Badge](https://img.shields.io/badge/C%23-239120?logo=c-sharp&logoColor=white&style=for-the-badge)](https://dotnet.microsoft.com/pt-br/languages/csharp)
[![.Net Badge](https://img.shields.io/badge/--5C2D91?logo=.net&logoColor=white&style=for-the-badge)](https://dotnet.microsoft.com/pt-br/)
[![VS Code Badge](https://img.shields.io/badge/-VS%20Code-007ACC?style=for-the-badge&logo=data%3Aimage%2Fsvg%2Bxml%3Bbase64%2CPD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0iVVRGLTgiPz4KPHN2ZyB2ZXJzaW9uPSIxLjEiIHZpZXdCb3g9IjAgMCAxMDI0IDEwMjQiIHdpZHRoPSIyNTYiIGhlaWdodD0iMjU2IiB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciPgo8cGF0aCB0cmFuc2Zvcm09InRyYW5zbGF0ZSg3MzYpIiBkPSJtMCAwaDI2bDE1IDYgNTAgMjQgNjYgMzIgMjMgMTEgMzUgMTcgMjMgMTEgMjEgMTEgMTAgOCA3IDggOCAxNCA0IDExdjcxOGwtNyAxNi05IDE0LTkgOC0xNCA4LTMwIDE1LTIzIDExLTMzIDE2LTIzIDExLTM5IDE5LTMxIDE1LTIzIDExLTIxIDloLTI0bC0xMi00LTEzLTctMTQtMTItMTctMTYtMTMtMTItMTAtOS0zOS0zNi0xMi0xMS04LTctMTYtMTUtMTMtMTItMTItMTEtOC03LTE1LTE0LTEzLTEyLTEyLTExLTgtNy0xNS0xNC0xMy0xMi0xMi0xMS04LTctMTUtMTQtMTMtMTItMTItMTEtOC03LTE1LTE0LTEzLTEyLTEyLTExLTgtNy0xNS0xNC0xMy0xMi0xMi0xMS0xMC05LTctNi01IDEtMTIgOS0xMyAxMC0xNyAxMy0yMSAxNi0xNiAxMi0xMyAxMC0xOCAxNC0xMiA5LTQyIDMyLTEzIDktMTEgNS01IDFoLTlsLTEyLTMtOS01LTE0LTEyLTE3LTE2LTEzLTEyLTEwLTktNy02LTktMTItNC05di0yMmw3LTEzIDExLTEyIDEwLTkgMTctMTYgMjAtMTggMTUtMTQgMjQtMjIgOC03IDE2LTE1IDEyLTExIDEwLTkgMTItMTFoMmwxLTUtNC0yLTExLTExLTgtNy0xNi0xNS0xMi0xMS0xMC05LTE1LTE0LTEwLTktMTMtMTItMTAtOS0xNS0xNC0xMC05LTEyLTExLTExLTExLTctMTItMS0zdi0yMmw3LTEzIDktMTAgMTUtMTQgMTMtMTIgOC03IDEzLTEyIDExLTkgMTEtNSA0LTFoMTVsMTIgNCAxNCAxMCAxNyAxMyAxMyAxMCAxNiAxMiAxOCAxNCAyMCAxNSAxOCAxNCAxNiAxMiAxOCAxNCAxNiAxMiAxNSAxMSA0LTEgNy03IDgtNyAxNS0xNCAyNC0yMiAxMC05IDE1LTE0IDEwLTkgMTMtMTIgMTAtOSAxNS0xNCAxMC05IDEzLTEyIDEwLTkgMTUtMTQgMTItMTEgMTAtOSAxMi0xMSAyNi0yNCAxMC05IDEyLTExIDI2LTI0IDEwLTkgMTItMTEgMjYtMjQgMTAtOSAxMi0xMSAyNi0yNCAxMC05IDEzLTEyIDktNyAxNi04em0zMCAyNzktMTUgMTItMTYgMTItODQgNjQtMTMgMTAtMTYgMTItMTMgMTAtMzQgMjYtMjEgMTYtMTYgMTItMTMgMTAtNTEgMzktMTIgOSA1IDUgMTYgMTMgMTYgMTIgNjMgNDggNTkgNDUgMTMgMTAgMTYgMTIgMjYgMjAgMjAgMTUgMTggMTQgMjAgMTUgMzAgMjMgNCAydi00NjZ6IiBmaWxsPSIjRjNGM0YzIi8%2BCjwvc3ZnPgo%3D)](https://code.visualstudio.com/)

[![README Repositório Badge](https://img.shields.io/badge/README-Repositório-062019?style=for-the-badge&labelColor=%23139E65)](/README.md)

<details>
  <summary style="font-size: 18px; font-weight: bold">📑Sumário</summary>

  1. [Conceitos Básicos](#conceitos)
      1. [Lógica de Programação](#logica)
      2. [Linguagem de Programação](#linguagem)
      3. [.NET](#net)
          1. [Histórico](#net-hystory)
          2. [CLR (Commom Language Runtime)](#clr)
  2. [Ambiente de desenvolvimento](#sdk)
      1. [Configuração](#sdk-conf)
      2. [IDE's de desenvolvimento](#sdk-ide)
      3. [Estrutura](#estrutura)
          1. [Projeto](#projeto)
          2. [Solution](#solution)
          3. [Namespace](#namespace)
          4. [Entrypoint da aplicação](#entrypoint)
              1. [Top-Level Statement](#top-level)
  3. [Programação Básica](#programacao)
      1. [Tipos de Dados Primitivos](#dados-primitivos)
          1. [Numéricos](#numericos)
          2. [Caractere](#caractere)
          3. [Booleando](#bool)
      2. [Variável](#variavel)
      3. [Constante](#constante)
      4. [Operadores](#operadores)
          1. [Atribuição](#atribuicao)
          2. [Aritméticos](#aritmetico)
          3. [Relacionais](#relacional)
          4. [Lógicos](#logico)
          5. [Ternário](#ternario)
      5. [Métodos (Funções)](#metodo)
      6. [Estruturas de dados](#estrutura-dados)
          1. [Array](#array)
          2. [ArrayList](#arrayList)
          3. [Lista Genérica](#lista)
          4. [Dicionário](#dicionario)
          5. [Queue (Fila)](#queue)
          6. [Stack (Pilha)](#stack)
      7. [Estruturas de Controle](#estrutura-controle)
          1. [Estrutura de decisão](#decisao)
          2. [Estrutura de seleção](#selecao)
          3. [Estruturas de Repetição](#repeticao)
              1. [For](#for)
              2. [Foreach](#foreach)
              3. [While](#while)
              4. [Do..While](#do-while)
              5. [Break](#break)
              6. [Continue](#continue)
  4. [Programação Orientada a Objeto](#poo)
      1. [Classe](#classe)
          1. [Classe estática](#class-static)
          2. [Classe Abstrata](#class-abstract)
          3. [Classe Sealed](#class-sealed)

</details>

## Conceitos Básicos <a id="conceitos"></a>

Antes de iniciar o estudo da linguagem de programação **C#**, alguns conceitos são importantes serem entendidos:

### Lógica de programação <a id="logica"></a>

Sequência de passos definidos para que um programa de computador consiga executar algo.

### Linguagem de programação <a id="linguagem"></a>

- Define instruções que usamos para implementar a lógica de um programa
- Existem diversas linguagens disponíveis no mercado, como, por exemplo, o **C#**
- Cada linguagem possui sua sintaxe e semântica, semelhante a um idioma de um país
  - Sintaxe no **C#**
    - Toda instrução deve terminar com `;`
    - Comentários não são executados
      - Comentário de uma linha: `// Comentário`
      - Cometário em bloco (pode ter várias linhas): `/* Comentário - quebra de linha - Comentário */`
- Todo o conjunto de instruções usados no programa é chamado de **código fonte**.
- Para ser executado, o _código fonte_ passa por um dos seguintes passos, a depender da linguagem de programação em que foi escrito:
  - Interpretação: Cada instrução é lida e executada em sequência pelo computador. Exemplo de linguagem interpretada: _python_
  - Compilação: O _código fonte_ é compilado para gerar um arquivo binário. Exemplo de linguagem compilada: _C++_.
  
    <a id="compilacao-csharp"></a>
    - O _C#_ é uma linguagem compilada, porém passa por um processo diferente: na primeira etapa é gerada uma linguagem intermediária (IL). Esse código intermediário é passado por um compilador de tempo de execução (RyuJIT), que transformará o código IL nos binário nativo da máquina em que está sendo executado.

[🔼 topo](#topo)

### .NET <a id="net"></a>

- Plataforma de código aberto para desenvolvimento de várias aplicações: desktop, web, IoT, jogos, etc.
- Provê diversas bibliotecas otimizadas que acelera o desenvolvimento
- Permite usar diversas linguagens de programação, como, por exemplo, o **C#**.

#### Histórico <a id="net-hystory"></a>

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

#### CLR (Commom Language Runtime) <a id="clr"></a>

- Principal parte do .NET
- Responsável por executar a [linguagem intermediária (IL)](#compilacao-csharp)
- Conversa com o hardware
- Gerencia o uso de recursos e memória

[🔼 topo](#topo)

## Ambiente de desenvolvimento <a id="sdk"></a>

### Configuração <a id="sdk-conf"></a>

- Baixe o [.NET](https://dotnet.microsoft.com/pt-br/download) e faça a instalação
  - Baixe o .NET Runtime caso queira somente executar aplicações desenvolvida em .NET
  - Baixe o .NET SDK caso queira desenvolver aplicações em .NET
- Confirme a instalação e outras informações de versões instaladas, executando no prompt de comandos: `dotnet --info`

  ![Informações do .NET instalado](/introducao/fundamentos_csharp/img/dotnet-info.png)

### IDE's de desenvolvimento <a id="sdk-ide"></a>

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

[🔼 topo](#topo)

### Estrutura <a id="estrutura"></a>

#### Projeto <a id="projeto"></a>

- Organiza os _códigos fonte_, seja por pasta e/ou arquivos
- É escrito em uma das linguagens suportadas pelo .NET
- Define a versão do .NET usada
- Define a tipo de binário de saída (.exe, .dll)
- Para criar um projeto via CLI:
  - Listar templates de projeto: `dotnet new list`
  - Criar um projeto: `dotnet new nome_curto_template [-n nome_projeto] [-o diretorio_saida] [-f versao_framework]`. Exemplo de uma aplicação console: `dotnet new console -n MinhaAplicacao -f new8.0`
    - Se não informado o nome do projeto, será usado o nome do diretório
    - Se não informado o framework, será usada a versão mais recente instalada na máquina (ver `dotnet --info`)
    - Dentre os itens criado para o projeto, está o arquivo de projeto _.csproj_
- Para executar um projeto:
  - Buildando o projeto: `dotnet build [caminho_arquivo_solution.sln | caminho_arquivo_projeto.csproj]`
    - Caso esteja no diretório da solution ou projeto, não é necessário informar o caminho
  - Limpando arquivos de build: `dotnet clean [caminho_arquivo_solution.sln | caminho_arquivo_projeto.csproj]`
    - Caso esteja no diretório da solution ou projeto, não é necessário informar o caminho
  - Executando um projeto: `dotnet run --project caminho_arquivo_projeto.csproj`
    - Caso esteja no diretório do projeto, não é necessário informar a opção _--project_
    - Automaticamente será gerado um _build_ do projeto
    - Desabilitando mensagens de compilação: `dotnet run --WarningLevel 0`

#### Solution <a id="solution"></a>

- Agrupa projetos de uma aplicação
- Permite que todos os projetos sejam compilados de uma vez
- Para criar uma solution via CLI:
  - Criando a solution: `dotnet new solution [-o diretorio_saida] [-n NomeSolution]`
    - Se não informado o diretório de saída, será criado somente o arquivo de solução (_.sln_)
    - Se não informado o nome da solução, será usado o do diretório de saída
  - Adicionar um projeto a uma solução: `dotnet sln nome_arquivo.sln add caminho_projeto.csproj`

[🔼 topo](#topo)

#### Namespace <a id="namespace"></a>

- Permite realizar agrupamento de classes
- Podem existir classes de mesmo nome, desde que em namespaces diferentes
- Sintaxe:

  ~~~csharp
  // Declaração de um namespace. Esta forma de declaração permite ter mais de um namespace no mesmo arquivo
  namespace Parte.Nome.NomeNamespace
  {
    public class NomeClass1
    {
      //
    }

    public class NomeClass2
    {
      //
    }
  }

  // Declaração simplificada. Esta forma de declaração permite somente uma definição de namespace no arquivo, e deve estar no início, antes da declaração dos membros
  namespace Parte.Nome.NomeNamespace2;

  public class NomeClass1
  {
    //
  }

  public class NomeClass3
  {
    //
  }

  // Para acessar membros do namespace em outro arquivo da aplicação
  // Usando o caminho completo da classe
  var class1 = new Parte.Nome.NomeNamespace.NomeClass1();
  var class2 = new Parte.Nome.NomeNamespace2.NomeClass1();

  // Usando using para simplificar caminho do membro
  using Parte.Nome.NomeNamespace;
  using Alternativa = Parte.Nome.NomeNamespace2; // Alias para um namespace

  var class1 = new NomeClass1(); // Pertence ao namespace 'Parte.Nome.NomeNamespace'
  var class2 = new Alternativa.NomeClass1(); // Pertence ao namespace 'Parte.Nome.NomeNamespace2'. Neste exemplo, para não causar conflito com a classe definida no namespace 'Parte.Nome.NomeNamespace', foi necessário criar um alias.
  ~~~

[🔼 topo](#topo)

#### Entrypoint da aplicação <a id="entrypoint"></a>

- Define o ponto de início de uma aplicação
- No C#, é iniciado no método estático `Main`
  - Só pode exitir um método estático `Main`
- Sintaxe:

  ~~~csharp
  namespace NomeNamespace;

  public class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Aqui inicia a execução da aplicação");

      MetodoInterno(5);

      Console.WriteLine(OutroMetodoInterno());
    }

    static void MetodoInterno(int param)
    {
      //
    }

    static string OutroMetodoInterno()
    {
      return "Alguma coisa";
    }
  }
  ~~~

[🔼 topo](#topo)

##### Top-Level Statement <a id="top-level"></a>

- Simplifica a escrita do ponto de entrada da aplicação
- Só pode existir um único arquivo de classe com esta forma
- Disponível a partir do **.Net 6.0**
- Se existir na aplicação um método `Main`, esta forma terá prioridade na execução
- Sintaxe:

  ~~~csharp
  // Simples assim: não precisa definir o namespace, a classe e o método Main
  Console.WriteLine("Aqui inicia a execução da aplicação");

  MetodoInterno(5);
  
  Console.WriteLine(OutroMetodoInterno());

  // Um método que não retorna valor
  void MetodoInterno(int param)
  {
    //
  }

  string OutroMetodoInterno()
  {
    return "Alguma Coisa"
  }
  ~~~

[🔼 topo](#topo)

## Programação Básica <a id="programacao"></a>

### Tipos de Dados Primitivos <a id="dados-primitivos"></a>

Cada categoria abaixo segue a ordem de capacidade de armazenamento, do menor para o maior. Isto significa que o tipo menor cabe no tipo maior, porém o contrário não é verdadeiro.

#### Numéricos <a id="numericos"></a>

- Inteiros
  - `byte`: 0 até 255
  - `short`: -32768 até 32767
  - `int`: -2174843648 até 2147483647
  - `long`: -9223372036854775808 até 9223372036854775807

  Obs.: Inclua `u` na frente dos tipos que aceitam valores negativos para não aceitar valores negativos aumentar o máximo dos positivos: Exemplo: `uint`
- Real (ponto flutuante)
  - `float`
    - Até 9 dígitos
    - O valor deve ter o sufixo `f`ou `F` no final. Exemplo: `35.54F`
  - `double`
    - Até 17 dígito
    - Não necessita de sufixo no valor, porém pode ser usado o `d`ou `D`
  - `decimal`
    - Até 29 dígitos
    - Usado quando necessita de uma precisão maior (por exemplo para trabalhar com valores monetários)
    - O valor deve ter o sufixo `m` ou `M`. Exemplo: `199.99M`

#### Caractere <a id="caractere"></a>

- `char`
  - Somente um caractere, podendo ser no formato hexadecimal ou unicode
  - Valor deve estar entre aspas simples. Exemplo: `'A'`
- `string`
  - Cadeia de caracteres
  - Valor deve estar entre aspas duplas. Exemplo: `"Teste"`
  - Não é um tipo primitivo, mas devido ao seu uso é praticamente considerado como sendo

#### Booleando <a id="bool"></a>

- `bool`: Somente os valoes `true`ou `false`

[🔼 topo](#topo)

### Variável <a id="variavel"></a>

- Define uma região de memória para armazenar dados
- Declaração: `tipo_dado nomeVariavel = valor`. Exemplo: `int idade = 35`
  - O compilador pode inferir o tipo pelo valor atribuído: `var nomeVariavel = valor`. Exemplo: `var idade = 35`
  - Não é possível usar uma variável sem inicializá-la
  - Para usar, basta chamar pelo nome definido. Exemplo: `Console.WriteLine(idade)`
  - Nome da variável
    - Não pode ter caracteres especiais, exceto undescore (_)
    - Não pode iniciar com número
    - Não pode ter espaço em palavras compostas
    - Não é indicado usar palavras com acentuação
    - É uma boa prática que o nome seja significativo

### Constante <a id="constante"></a>

- Define uma variável que uma vez inicializada, não pode ser alterada posteriormente
- Declaração: `const tipo_dado NOME_CONSTANTE = valor`. Exemplo: `const string NOME_CURSO = "CSHARP"`
- Segue basicamente as mesmas regras de variáveis
- No C# é convencionado que constantes sejam escritas em maiúscula e palavras compostas separadas por underscore (_).

[🔼 topo](#topo)

### Operadores <a id="operadores"></a>

#### Atribuição <a id="atribuicao"></a>

- Atribui o valor a direita à variável a esquerda
- Exemplo: `string variavel = "Valor Atribuído";`;

#### Aritméticos <a id="aritmetico"></a>

- Soma: `var resultado = valor1 + valor2;`
  - Soma da variável e reatribuição: `resultado += valor3; // resultado = resultado + valor3`
- Subtracao: `var resultado = valor1 - valor2;`
  - Subtração da variável e reatribuição: `resultado -= valor3; // resultado = resultado - valor3`
- Multiplicação: `var resultado = valor1 * valor2;`
  - Multiplicação da variável e reatribuição: `resultado *= valor3; // resultado = resultado * valor3`
- Divisão: `var resultado = valor1 / valor2;`
  - Divisão da variável e reatribuição: ``resultado /= valor3; // resultado = resultado / valor3`
  - Retorna resultado inteiro caso os dois operandos sejam de algum dos tipos inteiros
  - Retorna resultado real se ao menos um dos tipos for um dos tipos real
  - Retorna erro se `valor2` for 0

Obs1.: Os operandos podem ser valores literais ou uma variável que contenha valor\
Obs2.: O tipo de dados do resultado será com base no tipo de dado do operando com maior capacidade de armazenamento de valor. Exemplo: `valor_inteiro + valor_long = resultado_long;`
Obs3.: Prioridade segue a mesma regra da matemática
Obs4.: Em uma expressão, use parênteses para alterar a ordem de prioridade. Exemplo: `var resultado = (valor1 + valor2) * (valor3 / valor4)`

#### Relacionais <a id="relacional"></a>

- Igualdade: `var resultado = valor1 == valor2;`
  - `=` é chamado de _operador de atribuição_
- Diferença: `var resultado = valor1 != valor2;`
- Maior que: `var resultado = valor1 > valor2;`
- Menor que: `var resultado = valor1 < valor2;`
- Maior ou igual: `var resultado = valor1 >= valor2;`
- Menor ou igual: `var resultado = valor1 <= valor2`

Obs.: O resultado dos operadores relacionais é do tipo `bool;`

#### Lógicos <a id="logico"></a>

- And: `&&`. Exemplo: `var valido = valor > 5 && valor < 25;`
  - Todas as condições devem ser verdadeiras
- Or: `||`. Exemplo `var valido = valor > 5 || valor == 2;`;
  - Ao menos um das condições deve ser verdadeira
- Not: `!`. Exemplo: `var valido = !(valor > 10);`
  - Inverte o valor de um resultado lógico

#### Ternário <a id="ternario"></a>

- Analisa um expressão e retorna um valor se verdeiro, ou um valor diferente se o resultado for falso
- Sintaxe: `var mensagem = usuarioAtivo ? "Usuário ativo no sistema" : "Usuário inativo no sistema";`
- O resultado retornado nas duas situações devem ser do mesmo tipo

[🔼 topo](#topo)

### Métodos (Funções) <a id="metodo"></a>

- Bloco de código nomeado, executado sempre que chamado
- Pode receber parâmetro
- Pode retornar valor
  - `void` indica que a função não retorna valor
- Sintaxe:

  ~~~csharp

  int numero1 = 5, numero2 = 10;

  var soma = Soma(numero1, numero2); // Chamando função que retorna valor e recebe parâmetro

  Escrever("Resultado: " + soma); // Chamando função que não retorna valor e recebe parâmetro

  // Declarando uma função que retorna valor e recebe parâmetros
  int Soma(int valor1, int valor2)
  {
    var resultado = valor1 + valor2;

    return resultado;
  }

  // Declarando uma função que não retorna valor e recebe parâmetros
  void Escrever(string texto)
  {
    Console.WriteLine(texto);

    PularLinha(); // Chamando função que não retorna valor e não recebe parâmetro
  }

  // Declarando uma função que não retorna valor e não recebe parâmetros
  void PularLinha()
  {
    Console.WriteLine();
  }
  ~~~

[🔼 topo](#topo)

### Estruturas de dados <a id="estrutura-dados"></a>

#### Array <a id="array"></a>

- Deve ser tipado (aceita só um tipo de valor, conforme o tipo definido)
- Itens da coleção acessado por índice
- Sintaxe

  ~~~csharp
  // Declarando array vazio
  string[] array1 = new string[10]; // Indicar o tipo de dados do array e a quantidade de items (neste exemplo 10 itens, com índice de 0 a 9)
  var array2 = new int[5];

  // Declarando array inicializado
  string[] array3 = new string[] { "Item 1", "Item 2", "Item 3" };
  string[] array4 = new[] { "Item 1", "Item 2", "Item 3" };
  string[] array5 = [ "Item 1", "Item 2", "Item 3" ];
  var array6 = new string[] { "Item 1", "Item 2", "Item 3" };

  // Acessando item por um índice
  var item = array6[2];

  // Inserindo/Atualizando item por um índice
  array6[0] = "Novo Item";

  // Redimensionando array
  Array.Resize(ref array6, 5); // Novos espaços vazios
  array6 = [.. array6, "Item 4", "Item 5" ]; // Redimensionando com a inclusão de novos itens
  ~~~

[🔼 topo](#topo)

#### ArrayList <a id="arrayList"></a>

- Armazena itens de diversos tipos de dados
- Acessada por índice
- Sintaxe

  ~~~csharp
  using System.Collections; // Namespace onde está o ArrayList

  // Criando um array vazio
  var array1 = new ArrayList();
  ArrayList array2 = new ArrayList();
  ArrayList array3 = new();
  ArrayList array4 = [];

  // Criando um array com objetos
  var array5 = new()
  {
    "Item 1",
    'A',
    45,
    3.50M
  };

  var array6 =
  [
    "Item 1",
    'A',
    45,
    3.50M
  ];

  // Adicionar item
  array6.Add("Novo Item de Qualquer tipo");

  // Acessar um item pelo índice
  var item = array6[2];

  // Remover a primeira ocorrencia de um item
  array6.Remove(45);

  // Remover um item pelo índice
  array6.RemoveAt(1);

  // Quantidade de itens
  array6.Count;

  // Limpando um array
  array6.Clear();

  array6 = new(); // Atribuindo um novo objeto ArrayList
  ~~~

[🔼 topo](#topo)

#### Lista Genérica <a id="lista"></a>

- Deve ser tipada
- Pode ser acessado por índice
- Mais performática
- Possui mais funcionalidades para trabalhar com listas
- Sintaxe

  ~~~c#
  using System.Collections.Generic; // Namespace onde está a lista

  // Criando uma lista
  List<string> list1 = new List<string>(); // Pode ser passador no construtor o tamanho inicial
  List<int> list2 = new(); // Pode ser passador no construtor o tamanho inicial
  List<byte> list3 = [];

  var list4 = new List<string>();

  // Criando uma lista inializada
  List<string> list5 = new List<string>() { "Valor 1", "Valor 2" };
  List<int> list6 = new List<int> { 5, 10 };
  List<string> list7 = new() { "Valor 1", "Valor 2" };
  List<int> list8 = [ 15, 23 ];

  var lista9 = new List<string>() { "Valor 1", "Valor 2" };
  var list10 = new List<int> { 58, 26 };

  // Adicionando item
  lista10.Add(5);
  lista10.AddRange([9, 50, 13, 11]); // Pode ser adicionada qualquer outra coleção

  // Acessando por índice
  var item = list10[3];

  // Atualizando item
  list10[2] = 10;

  // Removendo item
  list10.Remove(item); // Remove primeira ocorrência do item
  list10.RemoveAt(0); // Remove item por indice

  // Limpando a lista
  list10.Clear();
  ~~~

[🔼 topo](#topo)

#### Dicionário <a id="dicionario"></a>

- Itens possuem chave/valor
- Tanto a chave quando o valor são tipados (podem ser diferentes entre si)
- Chaves não podem ser repetidas
- Valor de cada item acessado por chave
- Sintaxe:

  ~~~csharp
  using System.Collections.Generic; // Namespace onde está o dicionário

  // Inializando dicionário vazio
  Dictionary<string, string> dic1 = new Dicionary<string, string>();
  Dictionary<int, string> dic2 = new();
  Dictionary<string, string> dic3 = [];

  var dic4 = new Dictionary<int, string>();

  // Inicializando dicionário com itens
  Dictionary<string, string> dic5 = new Dictionary<string, string>() { { "chave1", "valor1" }, { "chave2" , "valor2" } }; // Se não tiver parâmetro, parênteses do construtor pode ser omitido
  Dictionary<int, string> dic6 = new Dictionary<int, string>() { ["chave1"] = "valor1", ["chave2"] = "valor2" }; // Se não tiver parâmetro, parênteses do construtor pode ser omitido
  Dictionary<string, string> dic7 = new() { { "chave1", "valor1" }, { "chave2", "valor2" } };
  Dictionary<int, string> dict8 = new() { [1] = "Valor 1", [2] = "Valor 2" };

  var dic9 = new Dictionary<string, string>() { { "chave1", "valor1" }, { "chave2", "valor2" } }; // Se não tiver parâmetro, parênteses do construtor pode ser omitido
  var dic10 = new Dictionary<int, string>() { [1] = "Valor 1", [2] = "Valor 2" }; // Se não tiver parâmetro, parênteses do construtor pode ser omitido

  // Obtendo um item
  var item = dic10.ElementAt(0); // item do tipo KeyValuePair<int, string>
  var keyItem = item.Key;
  var keyItem = item.Value;

  // Adicionar item
  dic10.Add(3) = "Valor 3";
  dic10[4] = "Valor 4";

  // Atualizar valor do item
  dic10[3] = "Novo valor";

  // Remover item
  dic10.Remove(0);

  // Limpar o dicionário
  dic10.Clear();
  ~~~

> Obs.: Índice inicia em `0`

[🔼 topo](#topo)

#### Queue (Fila) <a id="queue"></a>

- Lista do tipo FIFO (First In First Out)
- Não permite ordenação
- Acesso ao dado ocorre na ordem de inclusão
- Pode aceitar qualquer tipo de dado, ou pode ser tipado
- Ideal para quando a ordem de entrada na lista importa
- Sintaxe:

  ~~~csharp
  using System.Collections; // Namespace onde está a lista

  // Lista que aceita qualquer tipo
  Queue lista1 = new Queue();
  Queue lista2 = new();

  var lista3 = new Queue();

  // Lista tipada
  Queue<string> lista4 = new Queue<string>();
  Queue<int> lista5 = new();

  var lista6 = new Queue<string>();

  // Adicionando itens
  lista3.Enqueue("Item");
  lista3.Enqueue(5);

  lista6.Enqueue("Item 1");
  lista6.Enqueue("Item 2");

  // Verificar o próximo item da fila
  var item = lista6.Peek();

  // Obter o próximo item da fila (remove o item)
  var item2 = lista6.Dequeue();

  // Limpar fila
  lista6.Clear();
  ~~~

[🔼 topo](#topo)

#### Stack (Pilha) <a id="stack"></a>

- Implementa a lógica LIFO (Last In First Out)
- Não permite ordenação
- Acesso ao dado ocorre a partir do último incluído
- Pode aceitar qualquer tipo de dado, ou pode ser tipado
- Sintaxe:

  ~~~csharp
  using System.Collections; // Namespace onde está a coleção

  // Lista que aceita qualquer tipo
  Stack lista1 = new Stack();
  Stack lista2 = new();

  var lista3 = new Stack();

  // Lista tipada
  Stack<string> lista4 = new Stack<string>();
  Stack<int> lista5  = new();

  var lista6 = new Stack<string>();

  // Adicionar item à lista
  lista3.Push("Item");
  lista3.Push(5);

  lista6.Push("Item 1");
  lista6.Push("Item 2");

  // Ver último item da lista
  var item = lista6.Peek();

  // Obter o próximo item da fila (remove o item da lista)
  var item2 = lista6.Pop();

  // Limpar a fila
  lista6.Clear();
  ~~~

[🔼 topo](#topo)

### Estruturas de Controle <a id="estrutura-controle"></a>

#### Estrutura de decisão <a id="decisao"></a>

- Executa trecho de código com base em um resultado booleano
- Sintaxe:

  ~~~csharp
  // Executa um bloco de código se resultado booleano for true. Caso seja só um código executado, é possível omitir as chaves
  if (resultadoBooleano)
  {
    Console.WriteLine("Executa alguma coisa se true");
    Console.WriteLine("Executa outra coisa se true");
  }

  // Executa um bloco de código se true e outro se false.  Caso seja só um código executado, é possível omitir as chaves
  if (resultadoBooleano)
  {
    Console.WriteLine("Executa alguma coisa se true");
    Console.WriteLine("Executa outra coisa se true");
  }
  else
  {
    Console.WriteLine("Executa alguma coisa se false");
    Console.WriteLine("Executa outra coisa se false");
  }

  // Executa um bloco de código para diversos resultados booleano.  Caso seja só um código executado, é possível omitir as chaves
  if (resultadoBooleano)
  {
    Console.WriteLine("Executa alguma coisa se resultado 1 true");
    Console.WriteLine("Executa outra coisa se resultado 1 true");
  }
  else if (resultadoBooleano2)
  {
    Console.WriteLine("Executa alguma coisa se resultado 1 false e resultado 2 true");
    Console.WriteLine("Executa outra coisa se resultado 1 false  e resultado 2 true");
  }
  else
  {
    Console.WriteLine("Executa alguma coisa se resultados 1 e 2 forem false");
    Console.WriteLine("Executa outra coisa se resultados 1 e 2 forem false");
  }

  // Estruturas podem ser aninhadas
  if (resultadoBooleano)
  {
    Console.WriteLine("Executa alguma coisa se true");

    if (resultadoBooleano2)
    {
      Console.WriteLine("Executa alguma coisa se resultados 1 e 2 forem true");
      Console.WriteLine("Executa outra alguma coisa se resultados 1 e 2 forem true");
    }
    else
    {
      Console.WriteLine("Executa alguma coisa se resultado 1 for true e resultado 2 for false");
      Console.WriteLine("Executa outra alguma coisa se resultado 1 for true e resultado 2 for false");
    }
  }
  ~~~

[🔼 topo](#topo)

#### Estrutura de seleção <a id="selecao"></a>

- Executa um bloco de instrução com base em um valor
- Sintaxe:

  ~~~csharp
  var resultado = "Valor 3";

  // Testa o valor da variável resultado e executa um bloco de código quando encontrado
  switch (resultado)
  {
    case "Valor":
      Console.WriteLine("Executa uma instrução para 'Valor'");
      Console.WriteLine("Executa outra instrução  para 'Valor'");
      break; // Indica onde para as instruções desse case
    case "Valor 1":
    case "Valor 2": // As intruções são executadas se resultado for "Valor 1" ou "Valor 2"
      Console.WriteLine("Executa uma instrução para 'Valor 1' ou 'Valor 2'");
      Console.WriteLine("Executa outra instrução para 'Valor 1' ou 'Valor 2'");
      break; // Indica onde para as instruções desse case
    case "Valor 3":
      Console.WriteLine("Executa uma instrução para 'Valor 3'");
      Console.WriteLine("Executa outra instrução para 'Valor 3'");
      break; // Indica onde para as instruções desse case
    default:
      Console.WriteLine("Executa uma instrução para valores não encontrados");
      Console.WriteLine("Executa outra instrução para valores não encontrados");
      break; // Indica onde para as instruções desse case
  }

  // Retorna um resultado com base em um valor. Resultados retornados devem ser do mesmo tipo.
  var retorno = resultado switch
  {
    "Valor" => "Retorno se 'Valor'",
    "Valor 1" => "Retorno se 'Valor 1'",
    "Valor 2" => "Retorno se 'Valor 2'",
    "Valor 3" => "Retorno se 'Valor 3'",
    _ => "Resultado se nenhum valor encontrado"
  };
  ~~~

[🔼 topo](#topo)

#### Estruturas de Repetição <a id="repeticao"></a>

- Repete um trecho de código

##### For <a id="for"></a>

- Usado quando se sabe exatamente a quantidade de vezes que o código será repetido.
- Sintaxe:

  ~~~csharp
  // for (valor inicial; condição de parada; incremento do valor inicial após cada execução do bloco)

  // Exemplo percorrendo uma lista
  var lista = new string[] { "Valor 1", "Valor 2", "Valor 3" };

  for (var i = 0; lista.Length; i++)
  {
    var valor = lista[i]; // A cada execução, valor de i acessar um item da lista
    Console.WriteLine(valor);
  }
  ~~~~

##### Foreach <a id="foreach"></a>

- Itera sobre uma coleção, retornando cada valor na mesma
- Não é possível acessar o índice do item corrente, caso a coleção permita ser acessada por índice
- Sintaxe:

  ~~~csharp
  string[] lista = [ "Valor 1", "Valor 2", "Valor 3" ];

  // Percorrendo a coleção
  foreach (var item in lista)
  {
    // Executa qualquer coisa sobre o item
    Console.WriteLine(item);
  }

  ~~~

[🔼 topo](#topo)

##### While <a id="while"></a>

- Testa uma condição no início
- Trecho de código executado enquanto uma condição for verdadeira
- Sintaxe

  ~~~csharp
  var i = 0;
  
  // Executa o laço enquanto a condição for verdadeira
  while (i < 5)
  {
    Console.WriteLine("i = " + i);
    i++;
  }
  ~~~

##### Do..While <a id="do-while"></a>

- Testa uma condição no fim do laço
- Executa o bloco de código ao menos uma vez, e depois enquanto a condição for verdadeira
- Sintaxe:

  ~~~csharp
  var i = 0;

  do
  {
    Console.WriteLine("i = " + i);
    i++;
  } while(i < 5)
  ~~~

[🔼 topo](#topo)

##### Break <a id="break"></a>

- Encerra imediatamente a execução do laço de repetição
- Exemplo:

  ~~~csharp
  // Escreve de 0 a 6
  for (var i = 0 ; i < 10; i++)
  {
    Console.WriteLine(i);

    if (i > 3 && i % 3 == 0) break; // Encerra o laço se a condição for atendida
  }
  ~~~

##### Continue <a id="continue"></a>

- Avança imediatamente para a próxima iteração do laço de repetição
- Exemplo:

  ~~~csharp
  // Não escreve os números divisiveis por 3
  for (var i = 0; i <= 10; i++)
  {
    if (i % 3 == 0)
      continue;

    Console.WriteLine(i);
  }
  ~~~

[🔼 topo](#topo)

## Programação Orientada a Objeto <a id="poo"></a>

- Paradigma de programação, difundido por volta dos anos 90
- Programação mais próxima do mundo real
  - Conceitos dos mundo real são tratados como objeto
- Pilares
  - Abstração
    - Consiste em "abstrair" somente características essencial do objeto
    - Torna o objeto mais genérico
    - Características estendidas e melhor definida por objetos especializados
  - Encapsulamento
    - Protege atributos e propriedades do objeto
    - Esconde complexidade das implementações de um objeto
    - Alterações em atributos e propriedades do objeto somente feito por métodos expostos
  - Herança
    - Capacidade de um objeto herdar atributos e comportamentos de outro
    - Conceito do "é um": objeto que herda "é um" tipo do objeto herdado
  - Polimorfismo
    - Um comportamento pode ser diferente dependendo do objeto que o invoca
    - Um objeto genérico pode aplicar um comportamento padrão, e objetos especializados sobreescrever esse comportamento conforme suas necessidades.

[🔼 topo](#topo)

### Classe <a id="classe"></a>

- Implementa os conceitos do mundo real
- Modelo para a criação dos objetos
- Define atributos e comportamentos dos objetos
- Unidade mínima na linguagem C#
- Todo método e atributo só podem ser definidos dentro de uma classe
- **Instância** é o processo de criação de um objeto a partir de uma classe
- Sintaxe:

  ~~~csharp
  using System; // Definição dos usings usados na classe

  namespace ProgramacaoOrientadaObjeto.Classes; // Namespace ao qual pertence a classe

  // Modificador de acesso 'public' indica que a classe pode ser instânciada (criação de um objeto) em qualquer lugar da aplicação
  public class ModeloClasse
  {
      // Este é um campo da classe. Convenções da linguagem dita que campos privados devem iniciar com '_'.
      // O modificador de acesso 'private', indica que o campo só pode ser acessado diretamente dentro da classe
      private int _idPrivado;

      // Os métodos a seguir são chamados de acessores do campo privado acima, permitindo atualizar e acessar o valor.
      // O modificador de acesso 'public', indica que o método pode ser acessado de fora da classe
      public void SetIdPrivado(int id)
      {
          if (id > 0)
              throw new ArgumentException("Id deve ser maior que 0");

          _idPrivado = id;
      }

      public int GetIdPrivado()
      {
          return _idPrivado;
      }

      // Esta é uma propriedade auto-implementada: substitui a escrita de campo acima e seus acessores. Os métodos acessores estão intrísecos na propriedade.
      public int PropriedadeAutoImplementadaDescricao { get; set; }

      // A seguir é uma propriedade implementada. Métodos acessores estão intríseco na propriedade. Ideal quando precisa de lógica de tratamento do valor a ser inserido na propriedade e/ou tratamento do retorno
      // É uma boa prática que o nome da propriedade implementada seja igual ao do campo ao qual referencia. No exemplo, seria "Valor". O nome abaixo é para didaticamente indicar que é uma propriedade implementada.
      private decimal _valor;
      
      public decimal PropriedadeImplementadaValor
      {
          get
          {
              // Talvez algum tratamento do retorno
              return _valor;
          }
          set
          {
              if (value < 0M)
                  throw new ArgumentException("Valor não pode ser menor que 0");

              _valor = value;
          }
      }

      // A seguir dois membros de classe somente leitura: atualização somente pode ser feita pelo construtor da classe
      public string PropriedadeSomenteLeitura { get; }
      public readonly string CampoSomenteLeitura;

      // A propriedade implementada abaixo, embora seja somente leitura fora da classe, internamente pode ser atualizada
      private int _estoque;
      public int PropriedadeEstoque {
          // Chaves nos acessores e métodos pode ser substituída por '=>', caso o membro retorne somente o valor sem tratamento, ou caso execute somente uma lógica, mesmo não retornando nada.
          get => _estoque;

          // O modificador de acesso 'private' indica que o método acessor só pode ser chamado internamente.
          private set
          {
              if (ValidarValorEstoque(value))
                  _estoque = value;
          } 
      }

      // Essa é a definição de uma constante. Diferente dos outros membros, que devem ser chamados a partir de uma instância, este é chamado pela própria classe, sem instância
      public const int CONST_ESTOQUE_MINIMO = 10;

      // Esse é um construtor, que possui o mesmo nome da classe e não tem retorno.
      // Construtores inicializam propriedades e campos da classe
      // O construtor sem parâmetro estará disponível automaticamente, caso nenhum outro com parâmetro tenha sido implementado.
      // Se existir construtor com parâmetro, para diponibilizar o construtor sem parâmetro deve ser implementado explicitamente
      public ModeloClasse()
      {
          // Campos somente leitura somente podem ser inicializados em contrutores
          PropriedadeSomenteLeitura = "Esta propriedade é somente leitura";
          CampoSomenteLeitura = "Este campo é somente leitura";
      }

      // Os construtores abaixo aceitam parâmetros.
      // Caso não tenha sido declarado explicitamente o construtor sem parâmetros, essa classe só pode ser instânciada mediante a passagem de valor definida em um desses construtores.
      // this se refere à propria classe. Neste caso, após execução desse construtor, chama o construtor sem parâmetros, caso seja definido
      public ModeloClasse(int id) : this()
      {
          SetIdPrivado(id);
      }

      // this se refere à propria classe. Neste caso, após execução desse construtor, chama o construtor com um parâmetro, caso seja definido
      public ModeloClasse(int id, decimal valor) : this(id)
      {
          PropriedadeImplementadaValor = valor;
      }

      // Este é um método da classe acessível externamente e que não retorna valor
      public void ChecarEstoque()
      {
          if (PropriedadeEstoque < CONST_ESTOQUE_MINIMO)
              throw new ApplicationException("Estoque muito baixo");
      }

      // Este é um método da classe acessível externamente e que não retorna valor
      public void AtualizarEstoque(int qtd)
      {
          if (ValidarValorEstoque(qtd))
              _estoque += qtd;
      }

      // Este é um método da classe acessível externamente e que retorna valor
      public string RetornarDados()
      {
          return 
              "Id: " + GetIdPrivado() +
              "\nDescrição: " + PropriedadeAutoImplementadaDescricao +
              "\nValor: " + PropriedadeImplementadaValor +
              "\nEstoque: " + PropriedadeEstoque +
              "\nObservação 1: " + PropriedadeSomenteLeitura +
              "\nObservação 2: " + CampoSomenteLeitura;
      }

      // Método static é acessado sem uma instância da classe. Esses métodos não podem acessar membros não estáticos da classe
      public static decimal CalcularDesconto(decimal valor, decimal percentual) => valor - (valor * (percentual / 100));

      // O método abaixo só pode ser acessado pela classe
      private bool ValidarValorEstoque(int qtd)
      {
          if (qtd <= 0)
              throw new ArgumentException("Valor para atualização do estoque deve ser maior que 0");

          return true;
      }
  }

  // Usando classe. Será necessário o using com o namespace da classe em outros arquivos

  // Instânciando usando construtor padrão
  var instanciaValoresPadrao = new ModeloClasse();

  // Instânciando usando construtor com um parâmetro
  var instanciaConstrutorUmParam = new ModeloClasse(5);

  // Instânciando usando construtor com dois parâmetros
  var intanciaConstrutorDoisParam = new ModeloClasse(3, 19.99M);

  // Instanciando e inicializando propriedades
  var modelo = new ModeloClasse()
  {
      PropriedadeAutoImplementadaDescricao = "Atualizando valor de uma propriedade",
      PropriedadeImplementadaValor = 39.99M,

      // Tentivas abaixo produzirá erros, por serem somente leitura externamente
      //PropriedadeSomenteLeitura = "Atualizado internamente via construtor";
      //PropriedadeEstoque = 5 // Não pode ser atualizado
      //CampoSomenteLeitura = "Atualizando internamente via construtor";
  };

  // Chamando métodos
  Console.WriteLine(modelo.RetornarDados() + "\n");

  // Usando acessores de campos
  modelo.SetIdPrivado(10);
  Console.WriteLine("Atualizando Id para " + modelo.GetIdPrivado() +"\n" + modelo.RetornarDados() + "\n");

  // Acessando propriedades
  Console.WriteLine("Observação: " + modelo.PropriedadeSomenteLeitura + "\n");

  // Acessando constatnes
  Console.WriteLine("Estoque mínimo: " + ModeloClasse.CONST_ESTOQUE_MINIMO + "\n");

  // Chamando método
  modelo.AtualizarEstoque(5);
  
  // Chamando método estático
  var valorTotal = ModeloClasse.CalcularDesconto(modelo.PropriedadeImplementadaValor, 10M);

  // Usando construtor primário
  // Disponível a partir do C# 12.0
  // Parâmetros estão disponíveis somente dentro da classe
  public class ModeloClasse2(int id, int seed, string descricao)
  {
    // Para tratar o valor entrado, deve ser criada uma propriedade implementada e o método de validação deve ser estático
    // Inicialização de um campo
    private int _id = ValidarId(id) ? id : throw new ArgumentException("Id deve ser maior que 0");

    public int Id
    {
      get => _id;
      set => _id = ValidarId(value) ? value : throw new ArgumentException("Id deve ser maior que 0");
    }

    // Inicialização de uma propriedade auto-implementada
    public string Descricao { get; set; } = descricao;

    public int ObterCodigo()
    {
      return Random.Shared.Next(10000000) * Math.Abs(seed);
    }

    private static bool ValidarId(int id) => id > 0;
  }

  // Herança de classes com construtor primário
  public class ModeloClasse3 : ModeloClasse2
  {
    public ModeloClasse3(int id, int seed, string descricao) : base(id, seed, descricao)
    {
      //
    }
  }

  public class ModeloClasse4(int id, int seed, string descricao) : ModeloClasse2(id, seed, descricao)
  {
    //
  }
  
  // Usando classes com construtor primário
  var modelo2 = new ModeloClasse2(5, 2, "Teste");

  Console.WriteLine("Id: " + modelo2.Id);
  Console.WriteLine("Descrição: " + modelo2.Descricao);
  Console.WriteLine("Código: " + modelo2.ObterCodigo());
  ~~~

[🔼 topo](#topo)

#### Classe estática <a id="class-static"></a>

- Não podem ser instanciada
- Não possui construtor
- Não pode ser herdado
- Só podem ter membros estáticos
- Sintaxe

  ~~~csharp
  public static class ClassStatic
  {
    // Constantes são automaticamente estáticas
    public const int VALOR_CONSTANTE = 3;

    public static int PropriedadeStatic { get; set; }

    public static void MetodoStatic(int a, int b)
    {
      PropriedadeStatic = a + b + VALOR_CONSTANTE;
    }

    public static string OutroMetodoStatic()
    {
      return "Alguma coisa";
    }
  }

  // Usando uma classe estática. Using necessário em outras namespace

  // Isso produz erro
  //var modelo = new ClassStatic();

  // Acessando membros de uma classe estática
  ClassStatic.PropriedadeStatic = 11;

  Console.WriteLine(ClassStatic.PropriedadeStatic);

  Console.WriteLine(ClassStatic.VALOR_CONSTANTE);

  ClassStatic.MetodoStatic(5, 2);

  Console.WriteLine(ClassStatic.OutroMetodoStatic());
  ~~~

[🔼 topo](#topo)

#### Classe Abstrata <a id="class-abstract"></a>

- Não pode ser instânciada
- Deve ser herdada por outras classes especializadas
- Acesso aos membros que não sejam de classe somente através de objetos especializados
- Sintaxe:

  ~~~csharp
  public abstract class ModeloAbstrato
  {
    // Constantes e membros estáticos podem ser acessador pelo nome da superclasse
    public const string CHAVE_PADRAO = "TESTE";

    public int Id { get; set; }

    // O modificador de acesso 'protected' indica que o membro somente pode ser acessado pelas subclasses, ou classes filhas
    public int Codigo { get; protected set; }

    // Método não pode ser sobrescrito nas subclasses
    public string Metodo()
    {
        return "Metodo implementado na superclasse";
    }

    // A keyword 'virtual' indica que o método pode ser sobrescrito pelas subclasses
    public virtual string Metodo2()
    {
        return "Metodo2 implementado na superclasse";
    }

    // Método abstratos obriga a implementação nas subclasses
    // Métodos abstratos não possuem implementação
    // Só pode existir em classes abstratas
    public abstract string Metodo3();

    public virtual string ObterDados()
    {
        return "Id: " + Id +
            "\nCódigo: " + Codigo;
    }

    // É uma boa prática manter os construtores 'protected', já que somente serão acessados pelas subclasses
    protected ModeloAbstrato()
    {

    }

    protected ModeloAbstrato(int id) : this()
    {
        Id = id;
    }
  }

  // Classe herda de 'ModeloAbstrato' (Neste contexto ':' significa que herda, ou seja, aplica o conceito 'é um')
  // A classe herdada é chamada de 'superclasse', e a que herda é chamada de 'subclasse'
  public class ModeloEspecializado : ModeloAbstrato
  {
    // Membro só pode ser acessado pelo objeto especializado
    public string PropriedadeEspecializada { get; set; }

    public ModeloEspecializado()
    {
        // Membro definido na superclasse pode ser acessado na subclasse, desde que não seja privado
        Codigo = Random.Shared.Next();
    }

    public ModeloEspecializado(int id, string valor) : this()
    {
        Id = id;
        PropriedadeEspecializada = valor;
    }

    // Membro só pode ser acessado pelo objeto especializado
    public string MetodoEspecializado()
    {
        return "Este método só existe na classe 'ModeloEspecializado'";
    }

    // A keyword 'override' significa que o método está sendo sobrescrito
    public override string Metodo2()
    {
        return "Método2 reimplementado na subclasse 'ModeloEspecializado'";
    }

    public override string Metodo3()
    {
        return "Método3 implementado na subclasse 'ModeloEspecializado'";
    }

    // A keyword 'base', significa que está sendo acessado membros da superclasse e não da subclasse
    public override string ObterDados()
    {        
        return base.ObterDados() +
            "\nPropriedade Especializada: " + PropriedadeEspecializada
        ;
    }
  }

  public class ModeloEspecializado2 : ModeloAbstrato
  {
    public string PropriedadeEspecializada2 { get; }

    // 'base(id)' indica que está sendo usado o construtor da base que aceita um argumento do tipo passado
    public ModeloEspecializado2(int id, string valor) : base(id)
    {
        PropriedadeEspecializada2 = valor;
        Codigo = Random.Shared.Next();
    }

    public string MetodoEspecializado2()
    {
        return "Este método só existe na classe 'ModeloEspecializado2'";
    }

    public override string Metodo3()
    {
        return "Metodo3 implementado na subclasse 'ModeloEspecializado2'";
    }

    public override string ObterDados()
    {
        return base.ObterDados() +
            "\nPropriedade Especializada 2: " + PropriedadeEspecializada2
        ;
    }
  }

  // Usando classes herdadas

  // Erro: classe abstrata não pode ser instanciada
  //var modeloAbstrato = new ModeloAbstrato();
  var modeloEspecializado = new ModeloEspecializado()
  {
      Id = 3,
      PropriedadeEspecializada = "Valor 1"
      //Codigo = 5; // Erro: Propriedade somente leitura externamente
  };
  var modeloEspecializado2 = new ModeloEspecializado2(5, "Valor 2");

  // Membro estático na superclasse
  Console.WriteLine(ModeloAbstrato.CHAVE_PADRAO);

  // Membros existente somente nas especializações
  Console.WriteLine(modeloEspecializado.PropriedadeEspecializada);
  Console.WriteLine(modeloEspecializado.MetodoEspecializado());

  Console.WriteLine(modeloEspecializado2.PropriedadeEspecializada2);
  Console.WriteLine(modeloEspecializado2.MetodoEspecializado2());

  // Abstração e herança permite a aplicação do polimorfismo
  // Embora de tipos diferentes, as duas classes especializadas puderam ser alocadas na lista de tipo diferente, devido ao conceito do "é um"
  List<ModeloAbstrato> especializacoes = [modeloEspecializado, modeloEspecializado2];

  // Chamadas aos métodos abaixo podem ter comportamentos diferentes dependendo do objeto em que está sendo chamado
  // Somente podem ser chamados membros definidos no tipo da lista 'especializacoes'
  foreach (var obj in especializacoes)
  {
      Console.WriteLine("Id: " + obj.Id);
      Console.WriteLine("Método 1: " + obj.Metodo());
      Console.WriteLine("Método 2: " + obj.Metodo2());
      Console.WriteLine("Método 3: " + obj.Metodo3());
      Console.WriteLine();
  }
  ~~~

[🔼 topo](#topo)

#### Classe Sealed <a id="class-sealed"></a>

- Indica que a classe não pode ser herdada
- A keyword **sealed** também pode ser aplicada a método, que indica que heranças posteriores não podem sobrescrever o método
- Sintaxe:

  ~~~csharp
  // Keyword 'sealed' impede a classe de ser herdada
  public sealed class ModeloSealed(int id) : ModeloAbstrato(id)
  {
      public override string Metodo3()
      {
          return "Esta classe está selada: não pode ser herdada";
      }
  }

  // Erro: Não é possível herar de classes seladas
  /*public class ModeloTesteSealed : ModeloSealed
  {
      //
  }*/

  public class ModeloMetodoSeald (int id) : ModeloAbstrato(id)
  {
      // Keyword no método impede de ser sobrescrito em heranças posteriores
      public sealed override string Metodo3()
      {
          return "Este método foi implementado na classe 'ModeloMetodoSeald' e está selado para implementação em herança posterior";
      }
  }

  public class ModeloTesteMetodoSeald(int id) : ModeloMetodoSeald(id)
  {
      // Erro: método selado não pode ser sobrescrito
      /*public override string Metodo3()
      {
          return "";
      }*/
  }
  ~~~

[🔼 topo](#topo)
