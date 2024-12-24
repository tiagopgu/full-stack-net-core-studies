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
        Console.WriteLine("# Instância usando construtor com 2 parâmetros\n" + intanciaConstrutorDoisParam.RetornarDados() + "\n");

        var modelo = new ModeloClasse()
        {
            PropriedadeAutoImplementadaDescricao = "Atualizando valor de uma propriedade",
            PropriedadeImplementadaValor = 39.99M,
            //PropriedadeSomenteLeitura = "Atualizado internamente via construtor";
            //PropriedadeEstoque = 5 // Não pode ser atualizado
            //CampoSomenteLeitura = "Atualizando internamente via construtor";
        };

        Console.WriteLine("# Instância com atualização das propriedades\n" + modelo.RetornarDados() + "\n");

        modelo.SetIdPrivado(10);

        Console.WriteLine("# Atualizando Id para " + modelo.GetIdPrivado() +"\n" + modelo.RetornarDados() + "\n");

        Console.WriteLine("\n# Acessando uma propriedade\n" + "Observação: " + modelo.PropriedadeSomenteLeitura + "\n");

        Console.WriteLine("# Usando constante definida na classe:\n" + "Estoque mínimo: " + ModeloClasse.CONST_ESTOQUE_MINIMO + "\n");

        modelo.AtualizarEstoque(5);

        Console.WriteLine("# Alterando atributo da via método\n" + modelo.RetornarDados() + "\n");

        var valorTotal = ModeloClasse.CalcularDesconto(modelo.PropriedadeImplementadaValor, 10M);

        Console.WriteLine("# Usando método estático da classe\n" + "Valor com desconto de 10%: " + valorTotal + "\n");

        Console.WriteLine("# Classe com construtor primário\n");
        var modelo2 = new ModeloClasse2(1, "Teste");
        
        Console.WriteLine(modelo2.RetornarDados() + "\n");

        modelo2.Titulo = "Teste Atualizado";
        modelo2.Descricao = "Esta é um descrição";

        Console.WriteLine(modelo2.RetornarDados());

        Console.WriteLine("\n# Teste de cópia de entre objetos\n");

        var objTesteCopia1 = new ModeloClasse2(1, "Teste Igualdade", "Este é o objeto 1");
        var objTesteCopia2 = objTesteCopia1; // Isso não clona o objeto.

        Console.WriteLine("Objeto 1\n" + objTesteCopia1.RetornarDados() + "\n");
        Console.WriteLine("Objeto 2\n" + objTesteCopia2.RetornarDados() + "\n");

        objTesteCopia2.Descricao = "Este é o objeto 2";

        Console.WriteLine("Atualizando objeto 2\n");

        Console.WriteLine("Objeto 1\n" + objTesteCopia1.RetornarDados() + "\n");
        Console.WriteLine("Objeto 2\n" + objTesteCopia2.RetornarDados() + "\n");

        Console.WriteLine("Fazendo a cópia de um objeto\n");

        objTesteCopia1.Descricao = "Este é o objeto 1";

        objTesteCopia2 = new ModeloClasse2(2, objTesteCopia1.Titulo, "Este é o objeto 2");

        Console.WriteLine("Objeto 1\n" + objTesteCopia1.RetornarDados() + "\n");
        Console.WriteLine("Objeto 2\n" + objTesteCopia2.RetornarDados() + "\n");

        Console.WriteLine("\n# Teste de igualdade entre objetos\n");

        var objTesteIgualdade1 = new ModeloClasse2(2, objTesteCopia1.Titulo, objTesteCopia1.Descricao);

        Console.WriteLine("Objeto 1\n" + objTesteCopia1.RetornarDados() + "\n");
        Console.WriteLine("Objeto 2\n" + objTesteIgualdade1.RetornarDados() + "\n");
        Console.WriteLine("Objeto1 == Objeto2: " + (objTesteIgualdade1 == objTesteCopia1));
        Console.WriteLine("Objeto1.Equals(objeto2): " + objTesteIgualdade1.Equals(objTesteCopia1));
        Console.WriteLine("Objeto1 != Objeto2: " + (objTesteIgualdade1 != objTesteCopia1));
        Console.WriteLine("\t* Validação falha, mesmo objetos com as mesmas informações, pois foi validada a referência, que são diferentes\n");

        var objTesteIgualdade2 = new ModeloClasse(1, 16.49M)
        {
            PropriedadeAutoImplementadaDescricao = "Objeto de Teste"
        };
        var objTesteIgualdade3 = new ModeloClasse(objTesteIgualdade2); // Fazendo uma cópia

        Console.WriteLine("Objeto 1\n" + objTesteIgualdade2.RetornarDados() + "\n");
        Console.WriteLine("Objeto 2\n" + objTesteIgualdade3.RetornarDados() + "\n");
        Console.WriteLine("Objeto1 == Objeto2: " + (objTesteIgualdade2 == objTesteIgualdade3));
        Console.WriteLine("Objeto1.Equals(objeto2): " + objTesteIgualdade2.Equals(objTesteIgualdade3));
        Console.WriteLine("Objeto1 != Objeto2: " + (objTesteIgualdade2 != objTesteIgualdade3));
    }
}
