namespace ProgramacaoOrientadaObjeto.Records;

public record class ModeloRecord
{
    public int Id { get; }
    public string Titulo { get; private set; }
    public string Descricao { get; set; }

    public ModeloRecord(int id, string titulo)
    {
        Id = ValidarId(id) ? id : throw new ArgumentException("Id deve ser maior que 0");
        Titulo = titulo;
    }

    private bool ValidarId(int id) => id > 0;
}