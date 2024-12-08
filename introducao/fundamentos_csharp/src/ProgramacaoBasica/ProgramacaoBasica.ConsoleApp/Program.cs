using System.Collections;

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

EstruturaDados_ArrayList();

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