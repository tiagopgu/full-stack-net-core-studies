namespace ProgramacaoOrientadaObjeto.Classes;

public class AssuntoClasseSelada(string titulo) : Assunto(titulo)
{
    public override void ExecutarDemo()
    {
        var modeloSelado = new ModeloSealed(1);
        var modeloMetodoSealed = new ModeloMetodoSeald(2);
        var modeloTesteMetodoSealed = new ModeloTesteMetodoSeald(3);

        List<ModeloAbstrato> testesSealed = [modeloSelado, modeloMetodoSealed, modeloTesteMetodoSealed];

        Console.WriteLine("Teste da keyword 'sealed'\n");

        foreach (var teste in testesSealed)
        {
            Console.WriteLine("Id: " + teste.Id);
            Console.WriteLine("Método: " + teste.Metodo());
            Console.WriteLine("Método2: " + teste.Metodo2());
            Console.WriteLine("Método3: " + teste.Metodo3());
            Console.WriteLine();
        }
    }
}
