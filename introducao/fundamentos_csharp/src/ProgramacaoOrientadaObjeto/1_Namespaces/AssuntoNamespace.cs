namespace ProgramacaoOrientadaObjeto.Namespaces;

public class AssuntoNamespace(string titulo) : Assunto(titulo)
{
    public override void ExecutarDemo()
    {
        Console.WriteLine(Pessoa.Descricao());
        Console.WriteLine(Entidades.Pessoa.Descricao());
    }
}
