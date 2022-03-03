using GenericMethodsConsoleApp.Entities;
using GenericMethodsConsoleApp.Entities.IRepositories;
using GenericMethodsConsoleApp.Repositories.Base;

namespace GenericMethodsConsoleApp.Repositories.SQLServer;

public class ProductSQLRepository : SQLRepository<Product>, IProductRepository
{
}

