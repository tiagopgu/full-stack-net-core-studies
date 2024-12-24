using ProgramacaoOrientadaObjeto.Classes;

namespace ProgramacaoOrientadaObjeto.Interfaces;

public class Cliente : INotificacao
{
    public string Descricao { get; set; }

    public string Notificar() => "Esta é um notificação do cliente";

    public string MetodoCliente() => "Este é um método só do cliente";
}
