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

[🔼 topo](#topo)

### Estrutura

#### Projeto

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

#### Solution

- Agrupa projetos de uma aplicação
- Permite que todos os projetos sejam compilados de uma vez
- Para criar uma solution via CLI:
  - Criando a solution: `dotnet new solution [-o diretorio_saida] [-n NomeSolution]`
    - Se não informado o diretório de saída, será criado somente o arquivo de solução (_.sln_)
    - Se não informado o nome da solução, será usado o do diretório de saída
  - Adicionar um projeto a uma solução: `dotnet sln nome_arquivo.sln add caminho_projeto.csproj`

[🔼 topo](#topo)

## Programação Básica

### Tipos de Dados Primitivos

Cada categoria abaixo segue a ordem de capacidade de armazenamento, do menor para o maior. Isto significa que o tipo menor cabe no tipo maior, porém o contrário não é verdadeiro.

#### Numéricos

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

#### Caractere

- `char`
  - Somente um caractere, podendo ser no formato hexadecimal ou unicode
  - Valor deve estar entre aspas simples. Exemplo: `'A'`
- `string`
  - Cadeia de caracteres
  - Valor deve estar entre aspas duplas. Exemplo: `"Teste"`
  - Não é um tipo primitivo, mas devido ao seu uso é praticamente considerado como sendo

#### Booleando

- `bool`: Somente os valoes `true`ou `false`

[🔼 topo](#topo)

### Variável

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

### Constante

- Define uma variável que uma vez inicializada, não pode ser alterada posteriormente
- Declaração: `const tipo_dado NOME_CONSTANTE = valor`. Exemplo: `const string NOME_CURSO = "CSHARP"`
- Segue basicamente as mesmas regras de variáveis
- No C# é convencionado que constantes sejam escritas em maiúscula e palavras compostas separadas por underscore (_).

[🔼 topo](#topo)

### Operadores

#### Aritméticos

- Soma: `var resultado = valor1 + valor2;`
- Subtracao: `var resultado = valor1 - valor2;`
- Multiplicação: `var resultado = valor1 * valor2;`
- Divisão: `var resultado = valor1 / valor2;`
  - Retorna resultado inteiro caso os dois operandos sejam de algum dos tipos inteiros
  - Retorna resultado real se ao menos um dos tipos for um dos tipos real
  - Retorna erro se `valor2` for 0

Obs1.: Os operandos podem ser valores literais ou uma variável que contenha valor\
Obs2.: O tipo de dados do resultado será com base no tipo de dado do operando com maior capacidade de armazenamento de valor. Exemplo: `valor_inteiro + valor_long = resultado_long;`
Obs3.: Prioridade segue a mesma regra da matemática
Obs4.: Em uma expressão, use parênteses para alterar a ordem de prioridade. Exemplo: `var resultado = (valor1 + valor2) * (valor3 / valor4)`

#### Relacionais

- Igualdade: `var resultado = valor1 == valor2;`
  - `=` é chamado de _operador de atribuição_
- Diferença: `var resultado = valor1 != valor2;`
- Maior que: `var resultado = valor1 > valor2;`
- Menor que: `var resultado = valor1 < valor2;`
- Maior ou igual: `var resultado = valor1 >= valor2;`
- Menor ou igual: `var resultado = valor1 <= valor2`

Obs.: O resultado dos operadores relacionais é do tipo `bool;`

#### Lógicos

- And: `&&`. Exemplo: `var valido = valor > 5 && valor < 25;`
  - Todas as condições devem ser verdadeiras
- Or: `||`. Exemplo `var valido = valor > 5 || valor == 2;`;
  - Ao menos um das condições deve ser verdadeira
- Not: `!`. Exemplo: `var valido = !(valor > 10);`
  - Inverte o valor de um resultado lógico

#### Ternário

- Analisa um expressão e retorna um valor se verdeiro, ou um valor diferente se o resultado for falso
- Sintaxe: `var mensagem = usuarioAtivo ? "Usuário ativo no sistema" : "Usuário inativo no sistema";`
- O resultado retornado nas duas situações devem ser do mesmo tipo

[🔼 topo](#topo)

### Métodos (Funções)

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

### Estruturas de dados

#### Array

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

#### ArrayList

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

#### Lista Genérica

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
  
#### Dicionário

- Itens possuem chave/valor
- Tanto a chave quando o valor são tipados (podem ser diferentes entre si)
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

#### Queue (Fila)

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

#### Stack (Pilha)

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
