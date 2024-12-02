namespace DemoBlazorLezione2.Core.Northwind;

public interface ICategoryData
{
    Task<List<CategoriaDTO>?> EstraiCategorieAsync();
}
