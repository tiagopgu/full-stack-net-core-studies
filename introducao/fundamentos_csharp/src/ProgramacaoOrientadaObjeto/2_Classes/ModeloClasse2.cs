namespace ProgramacaoOrientadaObjeto.Classes;

public class ModeloClasse2(int id, string titulo, string descricao = null)
{
    public int Id { get; } = ValidarId(id) ? id : throw new ArgumentException("Id deve ser maior que 0");

    private string _titulo = ValidarTitulo(titulo) ? titulo : throw new ArgumentException("Título deve ser informado e ter no mínimo 2 caracteres");

    public string Titulo
    {
        get => _titulo;
        set => _titulo = ValidarTitulo(value) ? value : throw new ArgumentException("Título deve ser informado e ter no mínimo 2 caracteres");
    }

    public string Descricao { get; set; } = descricao;

    public string RetornarDados()
    {
        return "Id: " + Id +
            "\nTítulo: " + Titulo +
            "\nDescrição: " + Descricao;
    }

    private static bool ValidarId(int id) => id > 0;

    private static bool ValidarTitulo(string titulo) => !string.IsNullOrWhiteSpace(titulo) && titulo.Length >= 2;
}
