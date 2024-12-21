namespace ProgramacaoOrientadaObjeto.Classes;

public sealed class ModeloSealed(int id) : ModeloAbstrato(id)
{
    public override string Metodo3()
    {
        return "Esta classe está selada: não pode ser herdada";
    }
}

// Erro: Não é possível herar de classes seladas
/*public class ModeloTesteSealed : ModeloSealed
{
    //
}*/

public class ModeloMetodoSeald (int id) : ModeloAbstrato(id)
{
    public sealed override string Metodo3()
    {
        return "Este método foi implementado na classe 'ModeloMetodoSeald' e está selado para implementação em herança posterior";
    }
}

public class ModeloTesteMetodoSeald(int id) : ModeloMetodoSeald(id)
{
    // Erro: método selado não pode ser sobrescrito
    /*public override string Metodo3()
    {
        return "";
    }*/
}
