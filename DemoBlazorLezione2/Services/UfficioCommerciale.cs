using Demo.Core.Conferenze;

namespace BlazorAppCorretta.Services;

public class UfficioCommerciale : IUfficioCommerciale
{
    public double EstraiPrezzoConferenza(int id)
    {
        return id * 1000;
    }
}
