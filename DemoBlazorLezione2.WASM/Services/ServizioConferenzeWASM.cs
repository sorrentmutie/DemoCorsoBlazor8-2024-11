using DemoBlazorLezione2.Core.Conferenze;

namespace DemoBlazorLezione2.WASM.Services;

public class ServizioConferenzeWASM : IServizioConferenze
{

    private static List<Conferenza> conferenzePassate = new() {
         new Conferenza { Id = 4, Nome = "Build 2021", DataInizio = new DateTime(2021, 5, 25), Completata = true, Luogo ="Napoli"},
         new Conferenza { Id = 5, Nome = "Build 2022", DataInizio = new DateTime(2022, 5, 25), Completata = true, Luogo = "Roma"},
         new Conferenza { Id = 6, Nome = "Build 2023", DataInizio = new DateTime(2023, 5, 25), Completata = true, Luogo = "Milano"}
        };



    public Task AggiungiConferenzaAsync(Conferenza conferenzaNuova)
    {
        throw new NotImplementedException();
    }

    public void CancellaConferenzaFutura(int id)
    {
        throw new NotImplementedException();
    }

    public void CancellaConferenzaPassata(int id)
    {
        throw new NotImplementedException();
    }

    public List<Conferenza>? EstraiConferenzeFuture()
    {
        throw new NotImplementedException();
    }

    public Task<List<Conferenza>?> EstraiConferenzeFutureAsync()
    {
        throw new NotImplementedException();
    }

    public List<Conferenza>? EstraiConferenzePassate()
    {
        return conferenzePassate;
    }

    public Task ModificaConferenzaAsync(Conferenza conferenzaModificata)
    {
        throw new NotImplementedException();
    }
}
