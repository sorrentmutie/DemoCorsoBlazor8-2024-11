using System.ComponentModel.DataAnnotations;

namespace DemoBlazorLezione2.Core.Conferenze;

public class Conferenza
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Il nome è obbligatorio")]
    [StringLength(20, ErrorMessage = "Il nome non può superare i {1} caratteri")]
    public string Nome { get; set; } = "";
    [Required(ErrorMessage = "La località è obbligatoria")]
    [StringLength(30, ErrorMessage = "La località non può superare i {1} caratteri")]
    public string Luogo { get; set; } = "";
    public DateTime DataInizio { get; set; } = DateTime.Today;
    public bool Completata { get; set; }
    public double Prezzo { get; set; }
}
