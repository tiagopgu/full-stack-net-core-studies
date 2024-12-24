namespace ProgramacaoOrientadaObjeto.Interfaces;

public class Funcionario : INotificacao
{
    public string Descricao { get; set; }

    public string Notificar() => "Esta é uma notificação do funcionário.";

    public string MetodoFuncionario() => "Este é um método do funcionario";
}
