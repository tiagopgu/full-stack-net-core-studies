namespace ProgramacaoOrientadaObjeto;

public abstract class Assunto
{
    public string Titulo { get; set; }

    protected Assunto(string titulo)
    {
        if (string.IsNullOrWhiteSpace(titulo))
            throw new ArgumentException("Título não pode ser vazio");

        Titulo = titulo;
    }

    public abstract void ExecutarDemo();
}
