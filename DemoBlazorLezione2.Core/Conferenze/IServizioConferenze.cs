namespace DemoBlazorLezione2.Core.Conferenze;

public interface IServizioConferenze
{
    List<Conferenza>? EstraiConferenzeFuture();
    List<Conferenza>? EstraiConferenzePassate();
    void CancellaConferenzaPassata(int id);
    void CancellaConferenzaFutura(int id);

}