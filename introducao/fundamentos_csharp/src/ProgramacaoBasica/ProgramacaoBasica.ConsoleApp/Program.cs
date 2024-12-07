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