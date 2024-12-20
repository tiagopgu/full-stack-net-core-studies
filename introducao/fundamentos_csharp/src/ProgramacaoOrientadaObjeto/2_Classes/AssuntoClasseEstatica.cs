namespace ProgramacaoOrientadaObjeto.Classes;

public class AssuntoClasseEstatica(string titulo) : Assunto(titulo)
{
    public override void ExecutarDemo()
    {
        // Erro: classes estáticas não podem ser instancias
        //var modeloStatic = new ModeloStatic();

        ModeloStatic.Chave = 11;

        Console.WriteLine("Acessando propriedade estática\n" + "Chave: " + ModeloStatic.Chave + "\n");

        Console.WriteLine("Acessando constante em classe estática\n" + "Valor Padrão: " + ModeloStatic.VALOR_PADRAO + "\n");

        ModeloStatic.SetId(5);

        Console.WriteLine("Chamando um método estático\n" + ModeloStatic.RetornarValores() + "\n");

        Console.WriteLine("Usando um método estático\n" + "2 + 5 = " + ModeloStatic.Somar(2, 5));
    }
}
