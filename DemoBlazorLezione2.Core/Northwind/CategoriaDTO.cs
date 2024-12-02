using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBlazorLezione2.Core.Northwind
{
    public class ProdottoDTO
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public decimal Prezzo { get; set; }
        
    }


    public class CategoriaDTO
    {
        public int Id { get; set; }

        public required string Nome { get; set; }

        public string? Descrizione { get; set; }

        public int NumeroProdotti { get; set; }

        public List<ProdottoDTO> Prodotti { get; set; } = new List<ProdottoDTO>();
    }
}
