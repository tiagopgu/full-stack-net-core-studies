// Variáveis e tipos de dados
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
Console.WriteLine();

// Constantes
const string CHAVE_ACESSO = "TESTE";
const decimal PERCENTUAL_DESCONTO_PADRAO = 1.5M;

Console.WriteLine("\n** Valores Padrão **\n");
Console.WriteLine("Chave de Acesso: " + CHAVE_ACESSO);
Console.WriteLine("Percentual Desconto Padrão: " + PERCENTUAL_DESCONTO_PADRAO);
Console.WriteLine();

// Essa instrução produz um erro de compilação
// CHAVE_ACESSO = "NOVA";

// Operadores Aritméticos

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
var resultadoDelta = Math.Pow(numero2, 2) - 4 * numero1 * numero5;
var resultadoSolucao1 = (-numero2 + Math.Sqrt(resultadoDelta)) / (2 * numero1);
var resultadoSolucao2 = (-numero2 - Math.Sqrt(resultadoDelta)) / (2 * numero1);

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
Console.WriteLine("\tResultado delta: " + resultadoDelta);
Console.WriteLine("\tResultado solução 1: " + resultadoSolucao1);
Console.WriteLine("\tResultado solução 2: " + resultadoSolucao2);
Console.WriteLine();