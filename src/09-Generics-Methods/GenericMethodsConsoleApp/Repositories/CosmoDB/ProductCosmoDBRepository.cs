using GenericMethodsConsoleApp.Entities;
using GenericMethodsConsoleApp.Entities.IRepositories;
using GenericMethodsConsoleApp.Repositories.Base;

namespace GenericMethodsConsoleApp.Repositories.CosmoDB;

public class ProductCosmoDBRepository:   CosmoDBRepository<Product>, IProductRepository
{

}

