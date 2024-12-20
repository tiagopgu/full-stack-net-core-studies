namespace ProgramacaoOrientadaObjeto.Classes;

public class AssuntoClasse(string titulo) : Assunto(titulo)
{
    public override void ExecutarDemo()
    {
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

        Console.WriteLine("Classe com construtor primário\n");
        var modelo2 = new ModeloClasse2(1, "Teste");
        
        Console.WriteLine(modelo2.RetornarDados() + "\n");

        modelo2.Titulo = "Teste Atualizado";
        modelo2.Descricao = "Esta é um descrição";

        Console.WriteLine(modelo2.RetornarDados());
    }
}
