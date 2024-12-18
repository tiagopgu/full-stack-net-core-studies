using System.Collections;
/*
VariaveisTiposDados();

Console.WriteLine();

Constantes();

Console.WriteLine();

OperadoresAritmeticos();

Console.WriteLine();

OperadoresRelacionais();

Console.WriteLine();

OperadoresLogicos();

Console.WriteLine();

OperadorTernario();

Console.WriteLine();

EstruturaDados_Array();

Console.WriteLine();

EstruturaDados_ArrayList();

Console.WriteLine();

EstruturasDados_List();

Console.WriteLine();

EstruturaDados_Dictionary();

Console.WriteLine();

EstruturaDados_Queue();

Console.WriteLine();

EstruturaDados_Stack();

Console.WriteLine();

EstruturaControle_Decisao();

Console.WriteLine();

EstruturaControle_Selecao();

Console.WriteLine();

EstruturaRepeticao_For();

Console.WriteLine();

EstruturaRepeticao_Foreach();

Console.WriteLine();

EstruturaRepeticao_While();

Console.WriteLine();

EstruturaRepeticao_Do_While();

Console.WriteLine();

EstruturaRepeticao_Break();

Console.WriteLine();
*/
EstruturaRepeticao_Continue();

Console.WriteLine();


// ******************************************************************************************* //

void VariaveisTiposDados()
{
    string nomeUsuario = "Eliane Fátima Gonçalves";
    string cpfUsuario = "501.961.101-81";
    char sexoUsuario = 'F';
    long rgUsuario = 144743516;
    byte idadeUsuario = 35;
    var emailUsuario = "eliane-goncalves78@gmail.com";
    float alturaUsuario = 1.84F; 
    short pesoUsuario = 64;
    decimal salarioUsuario = 4986.35M;
    double percentualDesconto = 2.359;
    int contaCorrenteUsuario = 1109162;
    int digitoContaCorrenteUsuario = 2;
    int agenciaContaUsuario = 58106082;
    string bancoContaCorrenteUsuario = "Banco do Brasil";
    bool usuarioAtivo = true;
    var numeroOrdemUsuario =  40;

    Console.WriteLine("\n** Dados Pessoais do Usuário **\n");
    Console.WriteLine("\tNome: " + nomeUsuario);
    Console.WriteLine("\tE-mail: " + emailUsuario);
    Console.WriteLine("\tRG: " + rgUsuario);
    Console.WriteLine("\tCPF: " + cpfUsuario);
    Console.WriteLine("\tSexo: " + sexoUsuario);
    Console.WriteLine("\tIdade: " + idadeUsuario);
    Console.WriteLine("\tAltura: " + alturaUsuario);
    Console.WriteLine("\tPeso: " + pesoUsuario);

    Console.WriteLine("\n** Dados de Salário **\n");
    Console.WriteLine("\tSalário: " + salarioUsuario);
    Console.WriteLine("\tPercentual Desconto: " + percentualDesconto);

    Console.WriteLine("\n** Dados Bancário **\n");
    Console.WriteLine("\tConta Corrente: " + contaCorrenteUsuario + "-" + digitoContaCorrenteUsuario);
    Console.WriteLine("\tAgência: " + agenciaContaUsuario);
    Console.WriteLine("\tBanco: " + bancoContaCorrenteUsuario);

    Console.WriteLine("\n** Outros Dados **\n");
    Console.WriteLine("\tAtivo: " + usuarioAtivo);
    Console.WriteLine("\tNúmero da Ordem: " + numeroOrdemUsuario);
}

void Constantes()
{
    const string CHAVE_ACESSO = "TESTE";
    const decimal PERCENTUAL_DESCONTO_PADRAO = 1.5M;

    Console.WriteLine("\n** Valores Padrão **\n");
    Console.WriteLine("Chave de Acesso: " + CHAVE_ACESSO);
    Console.WriteLine("Percentual Desconto Padrão: " + PERCENTUAL_DESCONTO_PADRAO);

    // Essa instrução produz um erro de compilação
    // CHAVE_ACESSO = "NOVA";
}

void OperadoresAritmeticos()
{
    long numero1 = 35;
    int numero2 = 3;
    float numero3 = 6.5F;
    double numero4 = 1.3;

    var resultadoSoma = numero1 + numero2;
    var resultadoSoma2 = numero1 + numero3;
    var resultadoSoma3 = numero3 + numero4;

    var resultadoSubtracao = numero1 - numero2;
    var resultadoSubtracao2 = numero1 - numero3;
    var resultadoSubtracao3 = numero3 - numero4;

    var resultadoMultiplicacao = numero1 * numero2;
    var resultadoMultiplicacao2 = numero1 * numero3;
    var resultadoMultiplicacao3 = numero3 * numero4;

    var resultadoDivisao = numero1 / numero2;
    var resultadoDivisao2 = numero1 / numero3;
    var resultadoDivisao3 = numero3 / numero4;

    // Cálculo da equação do segundo grau: 35x² + 3x - 25 = 0
    var numero5 = -25;
    var resultadoSolucao1 = CalcularSolucaoFormulaBaskara(numero1, numero2, numero5);
    var resultadoSolucao2 = CalcularSolucaoFormulaBaskara(numero1, numero2, numero5, primeiraSolucao: false);

    Console.WriteLine ("\n** Operações Matemáticas **\n");

    Console.WriteLine("- Soma\n");
    Console.WriteLine("\t" + numero1 + " + " + numero2 + " = " + resultadoSoma);
    Console.WriteLine("\t" + numero1 + " + " + numero3 + " = " + resultadoSoma2);
    Console.WriteLine("\t" + numero3 + " + " + numero4 + " = " + resultadoSoma3);

    Console.WriteLine("\n- Subtracao\n");
    Console.WriteLine("\t" + numero1 + " - " + numero2 + " = " + resultadoSubtracao);
    Console.WriteLine("\t" + numero1 + " - " + numero3 + " = " + resultadoSubtracao2);
    Console.WriteLine("\t" + numero3 + " - " + numero4 + " = " + resultadoSubtracao3);

    Console.WriteLine("\n- Multiplicação\n");
    Console.WriteLine("\t" + numero1 + " * " + numero2 + " = " + resultadoMultiplicacao);
    Console.WriteLine("\t" + numero1 + " * " + numero3 + " = " + resultadoMultiplicacao2);
    Console.WriteLine("\t" + numero3 + " * " + numero4 + " = " + resultadoMultiplicacao3);

    Console.WriteLine("\n- Divisão\n");
    Console.WriteLine("\t" + numero1 + " / " + numero2 + " = " + resultadoDivisao);
    Console.WriteLine("\t" + numero1 + " / " + numero3 + " = " + resultadoDivisao2);
    Console.WriteLine("\t" + numero3 + " / " + numero4 + " = " + resultadoDivisao3);

    Console.WriteLine("\nCalculo da equação: " + numero1 + "x² + " + numero2 + "x - " + (numero5 * -1) + " = 0\n");
    Console.WriteLine("\tResultado delta: " + CalcularDiscriminanteFormulaBaskara(numero1, numero2, numero5));
    Console.WriteLine("\tResultado solução 1: " + resultadoSolucao1);
    Console.WriteLine("\tResultado solução 2: " + resultadoSolucao2);
}

void OperadoresRelacionais()
{
    var valor1 = 15;
    var valor2 = 42;

    var resultadoIgualdade = valor1 == valor2;
    var resultadoDiferenca = valor1 != valor2;
    var resultadoMaiorQue = valor1 > valor2;
    var resultadoMenorQue = valor1 < valor2;
    var resultadoMaiorIgualA = valor1 >= valor2;
    var resultadoMenorIgualA = valor1 <= valor2;

    var senha = "atL5590!";
    var senhaConfirmacao = "atL559o!";
    var confirmacaoSenhaValida = senha == senhaConfirmacao;

    Console.WriteLine("\n** Comparações Relacionais **\n");
    Console.WriteLine("\t" + valor1 + " == " + valor2 + " = " + resultadoIgualdade);
    Console.WriteLine("\t" + valor1 + " != " + valor2 + " = " + resultadoDiferenca);
    Console.WriteLine("\t" + valor1 + " > " + valor2 + " = " + resultadoMaiorQue);
    Console.WriteLine("\t" + valor1 + " < " + valor2 + " = " + resultadoMenorQue);
    Console.WriteLine("\t" + valor1 + " >= " + valor2 + " = " + resultadoMaiorIgualA);
    Console.WriteLine("\t" + valor1 + " <= " + valor2 + " = " + resultadoMenorIgualA);
    Console.WriteLine("\n\tCofirmação Senha válida: " + confirmacaoSenhaValida);
}

void OperadoresLogicos()
{
    const int IDADE_MINIMA = 18;
    var idade = 14;
    var cadastroLiberado = false;
    var senhaCadastrada = "123456";
    var senhaInformada = "1234567";

    var podeCadastrar = idade > IDADE_MINIMA || cadastroLiberado;
    var acessoLiberado = senhaCadastrada == senhaInformada && podeCadastrar;

    Console.WriteLine("\n** Operadores Lógicos **\n");
    Console.WriteLine("\tPode Cadastrar: " + podeCadastrar);
    Console.WriteLine("\tAcesso liberado: " + acessoLiberado);
    Console.WriteLine("\n\tNão é possível realizar o cadastro: " + !podeCadastrar);
}

void OperadorTernario()
{
    var logado = false;

    Console.WriteLine("\n** Operador Ternário **\n");
    Console.WriteLine("\t" + (logado ? "Você está logado no sistema" : "Você está deslogado do sistema"));
}

double CalcularDiscriminanteFormulaBaskara(double a, double b, double c)
{
    var resultadoDelta = Math.Pow(b, 2) - 4 * a * c;

    return resultadoDelta;
}

double CalcularSolucaoFormulaBaskara(double a, double b, double c, bool primeiraSolucao = true)
{
    var resultadoDelta = CalcularDiscriminanteFormulaBaskara(a, b, c);
    var resultadoSolucao = (-b + (primeiraSolucao ? +Math.Sqrt(resultadoDelta) : -Math.Sqrt(resultadoDelta))) / (2 * a);


    return resultadoSolucao;
}

void EstruturaDados_Array()
{
    string[] nomesSorteio =
    [
        "Caroline Heloisa da Silva",
        "Ian Heitor Danilo Martins",
        "Andrea Isadora Aurora Ferreira"
    ];

    Console.WriteLine("** Nomes para sorteio **\n");

    foreach (var nome in nomesSorteio) Console.WriteLine(nome);

    Array.Resize(ref nomesSorteio, 5);

    nomesSorteio[3] = "Pedro Henrique Cláudio Calebe da Costa";
    nomesSorteio[4] = "Andrea Tânia Eduarda Nunes";

    Console.WriteLine("\n--");
    foreach (var nome in nomesSorteio) Console.WriteLine(nome);

    nomesSorteio = [.. nomesSorteio, "Mirella Emily Mariane Dias", "Davi Thomas Farias"];

    Console.WriteLine("\n--");
    foreach(var nome in nomesSorteio) Console.WriteLine(nome);

    nomesSorteio[0] = "Caroline Heloisa Silva";

    Console.WriteLine("\n--");
    foreach(var nome in nomesSorteio) Console.WriteLine(nome);
}

void EstruturaDados_ArrayList()
{
    ArrayList dadosPessoais =
    [
        "Vera Tânia Assis",
        45,
        'F'
    ];

    Console.WriteLine("\n** Dados Cadastrados do(a) " + dadosPessoais[0] + " **\n");
    
    dadosPessoais.Add("432.575.783-00");
    dadosPessoais.Add(1.60);

    EscreverArrayList(dadosPessoais);

    dadosPessoais.Remove('F');

    Console.WriteLine("--");

    EscreverArrayList(dadosPessoais);

    dadosPessoais.Add("(85) 98991-6148");

    dadosPessoais.RemoveAt(3);

    Console.WriteLine("\n--");

    EscreverArrayList(dadosPessoais);

    dadosPessoais.Clear();

    Console.WriteLine("\n--");

    EscreverArrayList(dadosPessoais);

    dadosPessoais = [];
}

void EscreverArrayList(ArrayList array)
{
    foreach(var item in array)
    {
        Console.WriteLine(item);
    }
}

void EstruturasDados_List()
{
   var alunos = new List<string>
   {
        "Caleb José Porto",
        "Cristiane Lara Galvão",
        "Carla Rafaela Natália Assis",
        "Mário Renan da Luz"
   };

    Console.WriteLine("** Lista de alunos **\n");

    foreach (var aluno in alunos) Console.WriteLine(aluno);

    alunos.Add("Cauã André Augusto da Mata");
    alunos.Add("Matheus Bento Assunção");

    Console.WriteLine("\n--");
    foreach (var aluno in alunos) Console.WriteLine(aluno);

    alunos.AddRange(["Yago Eduardo Benjamin Baptista", "Agatha Carolina da Rosa", "Bruna Stella Caroline Almada"]);

    Console.WriteLine("\n--");
    foreach (var aluno in alunos) Console.WriteLine(aluno);

    var alunoAux = alunos[5];

    Console.WriteLine("\n--\n" + alunoAux);

    alunos[3] = "Mário Renan Luz";

    Console.WriteLine("\n--");
    foreach (var aluno in alunos) Console.WriteLine(aluno);

    alunos.Remove(alunoAux);
    alunos.RemoveAt(0);

    Console.WriteLine("\n--");
    foreach (var aluno in alunos) Console.WriteLine(aluno);

    alunos.Clear();

    Console.WriteLine("\n--");
    foreach (var aluno in alunos) Console.WriteLine(aluno);
}

void EstruturaDados_Dictionary()
{
    var clientes = new Dictionary<string, string>
    {
        { "608.250.820-30", "Caleb José Porto" },
        { "095.181.566-03", "Cristiane Lara Galvão" },
        { "785.472.946-86", "Carla Rafaela Natália Assis" }
    };

    Console.WriteLine("** Dados Clientes **");

    foreach (var item in clientes) Console.WriteLine("\nCPF: " + item.Key + "\nNome: " + item.Value);

    var clienteAux = clientes.ElementAt(1);

    Console.WriteLine("\n--\nCPF: " + clienteAux.Key + "\nNome: " + clienteAux.Value);

    clientes.Add("451.870.462-25", "Mário Renan da Luz");
    clientes["756.543.484-18"] = "Cauã André Augusto da Mata";

    Console.Write("\n--");
    foreach (var item in clientes) Console.WriteLine("\nCPF: " + item.Key + "\nNome: " + item.Value);

    clientes["451.870.462-25"] = "Mário Renan Luz";

    Console.Write("\n--");
    foreach (var item in clientes) Console.WriteLine("\nCPF: " + item.Key + "\nNome: " + item.Value);

    clientes.Remove("756.543.484-18");

    Console.Write("\n--");
    foreach (var item in clientes) Console.WriteLine("\nCPF: " + item.Key + "\nNome: " + item.Value);

    clientes.Clear();

    Console.Write("\n--");
    foreach (var item in clientes) Console.WriteLine("\nCPF: " + item.Key + "\nNome: " + item.Value);
}

void EstruturaDados_Queue()
{
    Queue dados = new();
    
    dados.Enqueue(45);
    dados.Enqueue("Elza Alice Araújo");

    dados.Enqueue(29);
    dados.Enqueue("Aparecida Andrea Vitória Drumond");

    Console.WriteLine("** Dados Diversos **\n");

    Console.WriteLine(dados.Peek());
    Console.WriteLine(dados.Peek());

    Console.WriteLine("\n--");

    Console.WriteLine(dados.Dequeue());
    Console.WriteLine(dados.Dequeue());

    Console.WriteLine("\n--");

    Console.WriteLine(dados.Peek());

    dados.Enqueue(35);
    dados.Enqueue("Sônia Laís Isabella Rocha");

    Console.WriteLine("\n--");
    foreach (var dado in dados) Console.WriteLine(dado);

    Console.WriteLine("\n--");
    Console.WriteLine(dados.Peek());

    var nomes = new Queue<string>();

    nomes.Enqueue("Oliver Diogo Bruno das Neves");
    nomes.Enqueue("Francisco Diogo Bryan Martins");
    nomes.Enqueue("Giovana Rayssa Alícia Gomes");

    Console.WriteLine("\n--");
    foreach (var nome in nomes) Console.WriteLine(nome);

    nomes.Clear();

    Console.WriteLine("\n--");
    foreach (var nome in nomes) Console.WriteLine(nome);
}

void EstruturaDados_Stack()
{
    Stack s1 = new Stack();
    Stack s2 = new();

    Stack<string> s3 = new Stack<string>();
    Stack<int> s4 = new();

    var s5 = new Stack();
    var items = new Stack();

    items.Push("Alícia Daiane da Paz");
    items.Push(68);

    items.Push("Severino Bento Assunção");
    items.Push(26);

    Console.WriteLine("** Dados Diversos Empilhados **\n");

    Console.WriteLine(items.Peek());
    Console.WriteLine(items.Peek());

    Console.WriteLine("\n--");
    Console.WriteLine(items.Pop());
    Console.WriteLine(items.Pop());

    Console.WriteLine("\n--");
    Console.WriteLine(items.Peek());

    Console.WriteLine("\n--");
    foreach (var item in items) Console.WriteLine(item);

    Stack<string> nomes = new();

    nomes.Push("Vera Aline Carvalho");
    nomes.Push("Lavínia Marli Rezende");
    nomes.Push("Anthony Hugo Pietro Castro");

    Console.WriteLine("\n--");
    foreach (var nome in nomes) Console.WriteLine(nome);

    Console.WriteLine("\n--");
    Console.WriteLine(nomes.Peek());

    nomes.Clear();

    Console.WriteLine("\n--");
    foreach (var nome in nomes) Console.WriteLine(nome);
}

void EstruturaControle_Decisao()
{
    var cepEstado = new Dictionary<string, string>
    {
        { "65633599", "MA" },
        { "29143669", "ES" },
        { "58038320", "PB" },
        { "06700519", "SP" },
        { "30610550", "MG" },
        { "74893804", "GO" },
        { "68770971", "PA" },
        { "29217210", "ES" },
        { "65058080", "MA" },
        { "58069299", "PB" },
        { "65058229", "MA" },
        { "64005260", "PI" },
        { "52070230", "PE" },
        { "40220265", "BA" },
        { "79303080", "MS" },
        { "42835971", "BA" },
        { "95050190", "RS" },
        { "82720290", "PR" },
        { "88309080", "SC" },
        { "76822200", "RO" },
        { "68904281", "AP" },
        { "27340490", "RJ" },
        { "76964232", "RO" },
        { "89253774", "SC" },
        { "69900064", "AC" },
        { "69316715", "RR" },
        { "79620211", "MS" },
        { "69315054", "RR" },
        { "69900379", "AC" },
        { "64212120", "PI" }
    };

    Console.WriteLine("** Dados dos Estados **\n");

    var totalCepEstado = new Dictionary<string, int>();

    foreach (var item in cepEstado)
    {
        if (!totalCepEstado.ContainsKey(item.Value))
            totalCepEstado.Add(item.Value, 1);
        else
            totalCepEstado[item.Value]++;
    }

    Console.WriteLine("- Total de CEP cadastrados por estado\n");

    foreach (var estado in totalCepEstado)
    {
        Console.WriteLine("\tEstado: " + estado.Key);
        Console.WriteLine("\tTotal CEP: " + estado.Value);
        Console.WriteLine();
    }

    int menorTotalCep = int.MaxValue;
    int maiorTotalCep = 0;

    foreach (var estado in totalCepEstado)
    {
        if (estado.Value < menorTotalCep) menorTotalCep = estado.Value;
        
        if (estado.Value > maiorTotalCep) maiorTotalCep = estado.Value;
    }

    var ufMenorQtdCep = "";
    var separadorUfMenor = "";
    var ufMaiorQtdCep = "";
    var separadorUfMaior = "";

    foreach (var estado in totalCepEstado)
    {
        if (estado.Value == menorTotalCep)
        {
            ufMenorQtdCep += separadorUfMenor + estado.Key;
            separadorUfMenor = ", ";
        }
        else if (estado.Value == maiorTotalCep)
        {
            ufMaiorQtdCep += separadorUfMaior + estado.Key;
            separadorUfMaior = ", ";
        }
    }

    Console.WriteLine("- Contagens de CEP\n");
    Console.WriteLine("\tMenor quantidade total: " + menorTotalCep);
    Console.WriteLine("\tUF's menor quantidade: " + ufMenorQtdCep);

    Console.WriteLine("\n\tMaior quantidade total: " + maiorTotalCep);
    Console.WriteLine("\tUF'a maior quantidade: " + ufMaiorQtdCep);
}

void EstruturaControle_Selecao()
{
    char[] sexo = [ 'M', 'F' ];

    var codigoItem = 1;
    var separadorItem = "";

    Console.WriteLine("** Informações Tratamento Pessoa **\n");

    foreach (var s in sexo)
    {
        Console.Write(separadorItem + codigoItem++ + ". " + s);
        separadorItem = " - ";
    }

    Console.Write("\n\nSelecione o código referente ao sexo da pessoa: ");
    codigoItem = int.Parse(Console.ReadLine() ?? "");

    Console.WriteLine();

    if (codigoItem <= 0 || codigoItem > sexo.Length)
        Console.WriteLine("Código Inválido");
    else
        EscreverInformacoesTratamentoPessoa(sexo[--codigoItem]);

    Console.WriteLine();
    EscreverInformacoesTratamentoPessoa('A');

    string[] estados = ["AC", "AL", "AP", "AM", "BA", "CE", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"];

    Console.WriteLine("\n\n** Estados do Brasil **\n");

    codigoItem = 1;
    separadorItem = "";

    foreach (var estado in estados)
    {
        Console.Write(separadorItem + codigoItem++ + ". " + estado);
        separadorItem = " - ";
    }

    Console.Write("\n\nSelecione o código do estado para obter a descrição: ");
    codigoItem = int.Parse(Console.ReadLine() ?? "");

    if (codigoItem > 0 && codigoItem <= estados.Length)
    {
        var estadoSelecionado = estados[codigoItem - 1];

        Console.WriteLine("\n" + estadoSelecionado + ": " + RetornarDescricaoEstado(estadoSelecionado));
    }
    else
    {
        Console.WriteLine("\nCódigo inválido");;
    }

    Console.WriteLine("\nTE: " + RetornarDescricaoEstado("TE"));
}

void EscreverInformacoesTratamentoPessoa(char sexo)
{
    Console.WriteLine("O sexo escolhido foi '" + sexo + "'");

    switch (sexo)
    {
        case 'M':
            Console.WriteLine("A pessoa é do sexo masculino.");
            Console.WriteLine("O tratamento adequado é 'Sr.'");
            Console.WriteLine("Pessoa deve ser direcioanda para a ala masculina.");
            break;
        case 'F':
            Console.WriteLine("A pessoa é do sexo feminino.");
            Console.WriteLine("O tratamento adequado é 'Srta.'");
            Console.WriteLine("Pessoa deve ser direcionada para ala feminina.");
            break;
        default:
            Console.WriteLine("Não foi possível identificar informações de tratamento para o sexo informado");
            break;
    }
}

string RetornarDescricaoEstado(string estado)
{
   return estado switch
   {
        "AC" => "Acre",
        "AL" => "Alagoas",
        "AP" => "Amapá",
        "AM" => "Amazonas",
        "BA" => "Bahia",
        "CE" => "Ceará",
        "ES" => "Espírito Santo",
        "GO" => "Goiás",
        "MA" => "Maranhão",
        "MT" => "Mato Grosso",
        "MS" => "Mato Grosso do Sul",
        "MG" => "Minas Gerais",
        "PA" => "Pará",
        "PB" => "Paraíba",
        "PR" => "Paraná",
        "PE" => "Pernambuco",
        "PI" => "Piauí",
        "RJ" => "Rio de Janeiro",
        "RN" => "Rio Grande do Norte",
        "RS" => "Rio Grande do Sul",
        "RO" => "Rondônia",
        "RR" => "Roraima",
        "SC" => "Santa Catarina",
        "SP" => "São Paulo",
        "SE" => "Sergipe",
        "TO" => "Tocantins",
        _ => "Estado inválido"
   };
}

void EstruturaRepeticao_For()
{
    string[] nomes =
    [
        "Clara Maitê Valentina Moraes",
        "Eliane Adriana Caldeira",
        "Andreia Carla Bárbara Duarte",
        "Jorge Paulo Erick Baptista",
        "Benício Ruan Thales Dias"
    ];

    Console.WriteLine("** Nomes Sorteados **\n");

    for (var i = 0; i < nomes.Length; i++)
    {
        Console.Write((i + 1) + ". ");
        Console.WriteLine(nomes[i]);
    }
}

void EstruturaRepeticao_Foreach()
{
    string[] nomes =
    [
        "Clara Maitê Valentina Moraes",
        "Eliane Adriana Caldeira",
        "Andreia Carla Bárbara Duarte",
        "Jorge Paulo Erick Baptista",
        "Benício Ruan Thales Dias"
    ];

    Console.WriteLine("** Nomes Candidatos **\n");

    foreach (var nome in nomes)
        Console.WriteLine(nome);
}

void EstruturaRepeticao_While()
{
    Console.WriteLine("** Processamento 1 **\n");

    var processando = Random.Shared.Next(20) % 3 == 0;

    while(processando)
    {
        Console.WriteLine("Em processamento: " + processando);

        processando = Random.Shared.Next(20) % 3 == 0;
    }
}

void EstruturaRepeticao_Do_While()
{
    Console.WriteLine("** Processamento 2 **\n");

    var processando = Random.Shared.Next(20) % 3 == 0;

    do
    {
        Console.WriteLine("Em processamento: " + processando);
        processando = Random.Shared.Next(20) % 3 == 0;
    } while(processando);
}

void EstruturaRepeticao_Break()
{
    Dictionary<string, int> candidatosIdade = new()
    {
        { "Erick Noah Alves", 41 },
        { "Luan Severino Costa", 27 },
        { "Arthur Tiago Henrique Campos", 60 },
        { "Renan Theo Levi Almada", 60 },
        { "Mateus Caleb Roberto de Paula", 49 },
        { "Isabelly Flávia Dias", 68 },
        { "Bruno Giovanni Ricardo Corte Real", 27 },
        { "Bento Geraldo Rafael Ramos", 68 },
        { "Antônia Sônia Figueiredo", 64 },
        { "Sérgio Roberto Galvão", 74 },
        { "Hadassa Alícia Simone Cavalcanti", 73 },
        { "Tiago Roberto Pietro Santos", 24 },
        { "Amanda Maria Melissa Aragão", 24 },
        { "Regina Milena Bárbara Silveira", 76 },
        { "Regina Louise Fogaça", 48 },
        { "Hadassa Jennifer Nogueira", 40 },
        { "Danilo Manuel Moura", 36 },
        { "Juliana Sarah Souza", 56 },
        { "Enrico Iago Luiz Caldeira", 25 },
        { "Edson Eduardo Brito", 43 },
        { "Josefa Sophia Vera Assis", 60 },
        { "Milena Luna Lopes", 34 },
        { "Miguel Gabriel Pinto", 24 },
        { "Clara Elaine da Cruz", 27 },
        { "Aparecida Catarina Duarte", 21 },
        { "Laura Rita Bruna dos Santos", 32 },
        { "Roberto Caleb Ribeiro", 50 },
        { "Cauã Bento Emanuel Araújo", 18 },
        { "Kauê Oliver Nathan Novaes", 53 },
        { "Daniela Laura Jesus", 18 }
    };

    Console.WriteLine("** Lista de Candidatos e Idade **\n");

    foreach (var candidato in candidatosIdade)
    {
        if (candidato.Value < 25)
        {
            Console.WriteLine("\nATENÇÃO: Encontrado candidato com idade inferior a 25");
            break;
        }

        Console.WriteLine("\t" + candidato.Key + " (" + candidato.Value + ")");
    }
}

void EstruturaRepeticao_Continue()
{
    Dictionary<string, string> candidatosEstado = new()
    {
        { "Erick Noah Alves", "PE" },
        { "Luan Severino Costa", "GO" },
        { "Arthur Tiago Henrique Campos", "SP" },
        { "Renan Theo Levi Almada", "MA" },
        { "Mateus Caleb Roberto de Paula", "PE" },
        { "Isabelly Flávia Dias", "SC" },
        { "Bruno Giovanni Ricardo Corte Real", "RO" },
        { "Bento Geraldo Rafael Ramos", "TO" },
        { "Antônia Sônia Figueiredo", "RJ" },
        { "Sérgio Roberto Galvão", "AM" },
        { "Hadassa Alícia Simone Cavalcanti", "AM" },
        { "Tiago Roberto Pietro Santos", "TO" },
        { "Amanda Maria Melissa Aragão", "SC" },
        { "Regina Milena Bárbara Silveira", "SE" },
        { "Regina Louise Fogaça", "RS" },
        { "Hadassa Jennifer Nogueira", "PR" },
        { "Danilo Manuel Moura", "PI" },
        { "Juliana Sarah Souza", "BA" },
        { "Enrico Iago Luiz Caldeira", "PB" },
        { "Edson Eduardo Brito", "CE" },
        { "Josefa Sophia Vera Assis", "RO" },
        { "Milena Luna Lopes", "PI" },
        { "Miguel Gabriel Pinto", "SC" },
        { "Clara Elaine da Cruz", "CE" },
        { "Aparecida Catarina Duarte", "PB" },
        { "Laura Rita Bruna dos Santos", "AP" },
        { "Roberto Caleb Ribeiro", "MS" },
        { "Cauã Bento Emanuel Araújo", "RS" },
        { "Kauê Oliver Nathan Novaes", "PB" },
        { "Daniela Laura Jesus", "AL" }
    };

    Console.WriteLine("** Lista de Candidatos por UF (exceto SC) **\n");

    foreach (var candidato in candidatosEstado)
    {
        if (candidato.Value == "SC") continue;

        Console.WriteLine("\t" + candidato.Key + " (" + candidato.Value + ")");
    }
}
