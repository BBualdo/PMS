using API.Services.DTOs;
using Data.Models;

namespace API.Services;

public interface IProductsService
{
    Task<PaginatedProducts> GetProducts(int page, int pageSize);
    Task AddProduct(Product product);
    Task UpdateProduct(Product product);
    Task DeleteProduct(int id);
}