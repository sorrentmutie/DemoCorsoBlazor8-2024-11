using Demo.Core.Conferenze;
using DemoBlazorLezione2.Core.Conferenze;

namespace DemoBlazorLezione2.Services;

public class ServizioConferenze : IServizioConferenze
{

    private readonly IUfficioCommerciale ufficioCommerciale;

    public ServizioConferenze(IUfficioCommerciale ufficioCommerciale)
    {
        this.ufficioCommerciale = ufficioCommerciale;
    }


    private static List<Conferenza> conferenzeFuture = new()
        {
             new Conferenza { Id = 1, Nome = "Build 2026", 
                 DataInizio = new DateTime(2026, 5, 25), 
                 Completata = false,
                 Luogo ="Napoli"},
             new Conferenza { Id = 2, Nome = "Build 2025", DataInizio = new DateTime(2025, 5, 25), Completata = false, Luogo = "Roma"},
             new Conferenza { Id = 3, Nome = "Build 2027", DataInizio = new DateTime(2027, 5, 25), Completata = false, Luogo = "Milano"}
        };
        
       
    private static List<Conferenza> conferenzePassate = new() {
         new Conferenza { Id = 4, Nome = "Build 2021", DataInizio = new DateTime(2021, 5, 25), Completata = true, Luogo ="Napoli"},
         new Conferenza { Id = 5, Nome = "Build 2022", DataInizio = new DateTime(2022, 5, 25), Completata = true, Luogo = "Roma"},
         new Conferenza { Id = 6, Nome = "Build 2023", DataInizio = new DateTime(2023, 5, 25), Completata = true, Luogo = "Milano"}
        };

    public void CancellaConferenzaFutura(int id)
    {
        conferenzeFuture.RemoveAll(c => c.Id == id);
    }

    public void CancellaConferenzaPassata(int id)
    {
        if(id % 2 == 0)
        {
            conferenzePassate.RemoveAll(c => c.Id == id);
        }
    } 

    public List<Conferenza>? EstraiConferenzeFuture()
    {
        foreach (var conferenza in conferenzeFuture)
        {
            conferenza.Prezzo = ufficioCommerciale.EstraiPrezzoConferenza(conferenza.Id);
        }

        return conferenzeFuture;
    }

    public List<Conferenza>? EstraiConferenzePassate()
    {
        return conferenzePassate;
    }

    public async Task AggiungiConferenzaAsync(Conferenza conferenzaNuova)
    {
        await Task.Delay(1000);
        conferenzaNuova.Id = conferenzeFuture.Max(c => c.Id) + 1;
        conferenzeFuture.Add(conferenzaNuova);
    }

    public async Task ModificaConferenzaAsync(Conferenza conferenzaModificata)
    {
        await Task.Delay(1000);
        var conferenzaDaModificare = conferenzeFuture.FirstOrDefault(c => c.Id == conferenzaModificata.Id);
        if(conferenzaDaModificare != null)
        {
            conferenzaDaModificare.Nome = conferenzaModificata.Nome;
            conferenzaDaModificare.Luogo = conferenzaModificata.Luogo;
            conferenzaDaModificare.DataInizio = conferenzaModificata.DataInizio;
            conferenzaDaModificare.Completata = conferenzaModificata.Completata;
        }
    }

    public async Task<List<Conferenza>?> EstraiConferenzeFutureAsync()
    {
        await Task.Delay(1000);
        return conferenzeFuture;
    }
}
