namespace ProgramacaoOrientadaObjeto.Classes;

public abstract class ModeloAbstrato
{
    public const string CHAVE_PADRAO = "TESTE";

    public int Id { get; set; }
    public int Codigo { get; protected set; }

    public string Metodo()
    {
        return "Metodo implementado na superclasse";
    }

    public virtual string Metodo2()
    {
        return "Metodo2 implementado na superclasse";
    }

    public virtual string ObterDados()
    {
        return "Id: " + Id +
            "\nCódigo: " + Codigo;
    }

    public abstract string Metodo3();

    protected ModeloAbstrato()
    {

    }

    protected ModeloAbstrato(int id) : this()
    {
        Id = id;
    }
}

public class ModeloEspecializado : ModeloAbstrato
{
    public string PropriedadeEspecializada { get; set; }

    public ModeloEspecializado()
    {
        Codigo = Random.Shared.Next();
    }

    public ModeloEspecializado(int id, string valor) : this()
    {
        Id = id;
        PropriedadeEspecializada = valor;
    }

    public string MetodoEspecializado()
    {
        return "Este método só existe na classe 'ModeloEspecializado'";
    }

    public override string Metodo2()
    {
        return "Método2 reimplementado na subclasse 'ModeloEspecializado'";
    }

    public override string Metodo3()
    {
        return "Método3 implementado na subclasse 'ModeloEspecializado'";
    }

    public override string ObterDados()
    {        
        return base.ObterDados() +
            "\nPropriedade Especializada: " + PropriedadeEspecializada
        ;
    }
}

public class ModeloEspecializado2 : ModeloAbstrato
{
    public string PropriedadeEspecializada2 { get; }

    public ModeloEspecializado2(int id, string valor) : base(id)
    {
        PropriedadeEspecializada2 = valor;
        Codigo = Random.Shared.Next();
    }

    public string MetodoEspecializado2()
    {
        return "Este método só existe na classe 'ModeloEspecializado2'";
    }

    public override string Metodo3()
    {
        return "Metodo3 implementado na subclasse 'ModeloEspecializado2'";
    }

    public override string ObterDados()
    {
        return base.ObterDados() +
            "\nPropriedade Especializada 2: " + PropriedadeEspecializada2
        ;
    }
}
