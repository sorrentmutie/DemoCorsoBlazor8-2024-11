using DemoBlazorLezione2.Core.Northwind;
using DemoBlazorLezione2.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoBlazorLezione2.Services
{
    public class CategorieSQLServer : ICategoryData
    {
        private readonly NorthwindContext northwindContext;

        public CategorieSQLServer(NorthwindContext northwindContext)
        {
            this.northwindContext = northwindContext;
        }

        public async Task<List<CategoriaDTO>?> EstraiCategorieAsync()
        {
            return await northwindContext.Categories
                .Select( c => new CategoriaDTO { 
                    Descrizione = c.Description,
                    Id = c.CategoryId,
                    Nome = c.CategoryName,
                    NumeroProdotti = c.Products.Count,
                    Prodotti = c.Products.Select(p => new ProdottoDTO
                    {
                        Id = p.ProductId,
                        Nome = p.ProductName,
                        Prezzo = p.UnitPrice ?? 0
                    }).ToList()
                })
                .ToListAsync();
        }
    }
}
