namespace ProgramacaoOrientadaObjeto.Interfaces;

public class AssuntoInterface(string titulo) : Assunto(titulo)
{
    public override void ExecutarDemo()
    {
        var cliente = new Cliente() { Descricao = "Instância de um cliente" };
        var funcionario = new Funcionario() { Descricao = "Instância de um funcionário" };

        Console.WriteLine("# Chamando membros a partir da instância da classe\n");

        Console.WriteLine(cliente.Descricao + ": " + cliente.Notificar() + " - " + cliente.MetodoCliente());
        Console.WriteLine(funcionario.Descricao + ": " + funcionario.Notificar() + " - " + funcionario.MetodoFuncionario());

        Console.WriteLine("\n# Chamando membros de um objeto definidos no contrato implementado (interface)\n");
        
        List<INotificacao> notificacoes = [];
        notificacoes.Add(cliente);
        notificacoes.Add(funcionario);

        foreach (var obj in notificacoes)
            Console.WriteLine(obj.Descricao + ": " + obj.Notificar());
    }
}
