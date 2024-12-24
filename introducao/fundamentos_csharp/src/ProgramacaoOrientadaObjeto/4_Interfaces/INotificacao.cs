namespace ProgramacaoOrientadaObjeto.Interfaces;

public interface INotificacao
{
    public string Descricao { get; set; }

    public string Notificar();
}
