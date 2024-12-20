using ProgramacaoOrientadaObjeto._2_Classes;
using ProgramacaoOrientadaObjeto.Classes;
using ProgramacaoOrientadaObjeto.Namespaces;
using Entidades = ProgramacaoOrientadaObjeto.Namespaces.Entidades;

Console.WriteLine("\n** Namespace **\n");

Console.WriteLine(Pessoa.Descricao());
Console.WriteLine(Entidades.Pessoa.Descricao());
Console.WriteLine();

Console.WriteLine("** Classes **\n");

var instanciaValoresPadrao = new ModeloClasse(); // Instânciando usando construtor padrão
var instanciaConstrutorUmParam = new ModeloClasse(5); // Instânciando usando construtor com um parâmetro
var intanciaConstrutorDoisParam = new ModeloClasse(3, 19.99M); // Instânciando usando construtor com dois parâmetros

Console.WriteLine("# Instância padrão\n" + instanciaValoresPadrao.RetornarDados() + "\n");
Console.WriteLine("# Instância usando construtor com 1 parâmetro\n" + instanciaConstrutorUmParam.RetornarDados() + "\n");
Console.WriteLine("Instância usando construtor com 2 parâmetros\n" + intanciaConstrutorDoisParam.RetornarDados() + "\n");

var modelo = new ModeloClasse()
{
    PropriedadeAutoImplementadaDescricao = "Atualizando valor de uma propriedade",
    PropriedadeImplementadaValor = 39.99M,
    //PropriedadeSomenteLeitura = "Atualizado internamente via construtor";
    //PropriedadeEstoque = 5 // Não pode ser atualizado
    //CampoSomenteLeitura = "Atualizando internamente via construtor";
};

Console.WriteLine("Instância com atualização das propriedades\n" + modelo.RetornarDados() + "\n");

modelo.SetIdPrivado(10);

Console.WriteLine("Atualizando Id para " + modelo.GetIdPrivado() +"\n" + modelo.RetornarDados() + "\n");

Console.WriteLine("\nAcessando uma propriedade\n" + "Observação: " + modelo.PropriedadeSomenteLeitura + "\n");

Console.WriteLine("Usando constante definida na classe:\n" + "Estoque mínimo: " + ModeloClasse.CONST_ESTOQUE_MINIMO + "\n");

modelo.AtualizarEstoque(5);

Console.WriteLine("Alterando atributo da via método\n" + modelo.RetornarDados() + "\n");

var valorTotal = ModeloClasse.CalcularDesconto(modelo.PropriedadeImplementadaValor, 10M);

Console.WriteLine("Usando método estático da classe\n" + "Valor com desconto de 10%: " + valorTotal + "\n");

Console.WriteLine("** Classe estática **\n");

// Erro: classes estáticas não podem ser instancias
//var modeloStatic = new ModeloStatic();

ModeloStatic.Chave = 11;

Console.WriteLine("Acessando propriedade estática\n" + "Chave: " + ModeloStatic.Chave + "\n");

Console.WriteLine("Acessando constante em classe estática\n" + "Valor Padrão: " + ModeloStatic.VALOR_PADRAO + "\n");

ModeloStatic.SetId(5);

Console.WriteLine("Chamando um método estático\n" + ModeloStatic.RetornarValores() + "\n");

Console.WriteLine("Usando um método estático\n" + "2 + 5 = " + ModeloStatic.Somar(2, 5) + "\n");
