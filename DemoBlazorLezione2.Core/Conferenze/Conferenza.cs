namespace DemoBlazorLezione2.Core.Conferenze;

public class Conferenza
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Luogo { get; set; }
    public DateTime DataInizio { get; set; }
    public bool Completata { get; set; }
    public double Prezzo { get; set; }
}
