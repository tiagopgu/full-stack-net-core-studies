namespace ProgramacaoOrientadaObjeto.Records;

public class AssuntoRecord(string titulo) : Assunto(titulo)
{
    public record class ModeloImutavel(int Id, string Titulo, decimal Valor);

    public override void ExecutarDemo()
    {
        var modeloRecord = new ModeloRecord(1, "Teste") { Descricao = "Este é um record de Teste" };
        var modeloRecord2 = new ModeloRecord(1, "Teste") { Descricao = "Este é um record de Teste" };

        Console.WriteLine("Escrita padrão de um record:");

        Console.WriteLine("Modelo 1: " + modeloRecord);
        Console.WriteLine("Modelo 2: " + modeloRecord2);

        Console.WriteLine("\nTeste de igualdade:");
        Console.WriteLine("modeloRecord == modeloRecord2: " + (modeloRecord == modeloRecord2));
        Console.WriteLine("modeloRecord.Equals(modeloRecord2): " + modeloRecord.Equals(modeloRecord2));

        var modeloRecord3 = modeloRecord with { Descricao = "Este é um teste de cópia" };

        Console.WriteLine("\nTeste de cópia:");
        Console.WriteLine("Modelo 1: " + modeloRecord);
        Console.WriteLine("Modelo 3: " + modeloRecord3);
        Console.WriteLine("modeloRecord == modeloRecord3: " + (modeloRecord == modeloRecord3));
        Console.WriteLine("modeloRecord.Equals(modeloRecord3): " + modeloRecord.Equals(modeloRecord3));
        
        Console.WriteLine("\nTeste de objeto imutável:");

        var modeloImutavel = new ModeloImutavel(1, "Teste", 10.99M);

        // Códigos abaixo geram falha
        //modeloImutavel.Id = 2;
        //modeloImutavel.Titulo = "Novo Teste";
        //modeloImutavel.Valor = 15.99;

        Console.WriteLine("Modelo imutável: " + modeloImutavel);
    }
}
