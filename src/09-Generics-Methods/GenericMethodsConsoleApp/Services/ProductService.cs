using GenericMethodsConsoleApp.Entities;
using GenericMethodsConsoleApp.Entities.Base;
using GenericMethodsConsoleApp.Entities.IRepositories;

namespace GenericMethodsConsoleApp.Services;

public class ProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        this._productRepository = productRepository;
    }

    public void Run()
    {
          _productRepository.Add(new Product() { Id = 1, Name = "Camera" });
        _productRepository.Add(new Product() { Id = 2, Name = "Camera 2" });
        _productRepository.Save();
        _productRepository.GetById(1);
       // _productRepository.Delete()
    }
}


public static class ProductServiceExtensions
{
    //public static List<Product> CustomSorting(List<Product> product)
    //{
    //    return product.OrderBy(x => x.Id).ToList();
    //}

    public static List<T> CustomSorting<T>(List<T> list) where T : IEntityBase
    {
        return list.OrderBy(x => x.Id).ToList();
    }
}


