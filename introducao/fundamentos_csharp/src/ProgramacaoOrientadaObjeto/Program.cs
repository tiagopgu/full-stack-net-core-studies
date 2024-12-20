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

Console.WriteLine("** Classe abstrata **\n");

// Erro: classe abstrata não pode ser instanciada
//var modeloAbstrato = new ModeloAbstrato();
var modeloEspecializado = new ModeloEspecializado()
{
    Id = 3,
    PropriedadeEspecializada = "Valor 1"
    //Codigo = 5; // Erro. Propriedade somente leitura externamente
};
var modeloEspecializado2 = new ModeloEspecializado2(5, "Valor 2");

Console.WriteLine("Dados Especializados 1\n" + modeloEspecializado.ObterDados() + "\n");
Console.WriteLine("Dados Especializados 2\n" + modeloEspecializado2.ObterDados() + "\n");

Console.WriteLine("Membro estático na superclasse\n" + "Valor Padrão: " + ModeloAbstrato.CHAVE_PADRAO + "\n");

Console.WriteLine("Membros existente somente nas especializações");
Console.WriteLine("Propriedade Especializada 1: " + modeloEspecializado.PropriedadeEspecializada);
Console.WriteLine("Método Especializado 1: " + modeloEspecializado.MetodoEspecializado());
Console.WriteLine("Propriedade Especializada 2: " + modeloEspecializado2.PropriedadeEspecializada2);
Console.WriteLine("Método Especializado 2: " + modeloEspecializado2.MetodoEspecializado2() + "\n");

Console.WriteLine("Membro somente na superclasse");
Console.WriteLine("Objeto especializado 1: " + modeloEspecializado.Metodo());
Console.WriteLine("Objeto especializado 2: " + modeloEspecializado2.Metodo() + "\n");

Console.WriteLine("Membro implementado somente em um objeto especializado");
Console.WriteLine("Objeto especializado 1: " + modeloEspecializado.Metodo2());
Console.WriteLine("Objeto especializado 2: " + modeloEspecializado2.Metodo2() + "\n");

Console.WriteLine("Membro de implementação obrigatória pelos objetos especializados");
Console.WriteLine("Objeto especializado 1: " + modeloEspecializado.Metodo3());
Console.WriteLine("Objeto especializado 2: " + modeloEspecializado2.Metodo3() + "\n");

// Abstração permite a aplicação do polimorfismo
List<ModeloAbstrato> especializacoes = [modeloEspecializado, modeloEspecializado2];

Console.WriteLine("Usando abstração para aplicação do polimorfismo\n");

foreach (var obj in especializacoes)
{
    Console.WriteLine("Id: " + obj.Id);
    Console.WriteLine("Método 1: " + obj.Metodo());
    Console.WriteLine("Método 2: " + obj.Metodo2());
    Console.WriteLine("Método 3: " + obj.Metodo3());
    Console.WriteLine();
}
