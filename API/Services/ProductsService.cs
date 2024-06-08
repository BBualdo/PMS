using API.Services.DTOs;
using Data.Models;
using Data.Repositories;

namespace API.Services;

public class ProductsService(IRepository<Product> productsRepository) : IProductsService
{
    private readonly IRepository<Product> _productsRepository = productsRepository;

    public async Task<PaginatedProducts> GetProducts(int page, int pageSize)
    {
        var products = await _productsRepository.GetAsync();
        var totalPages = (int)Math.Ceiling((double)products.Count() / pageSize);
        var paginatedProducts = products
            .Skip((page - 1) * pageSize);

        return new PaginatedProducts
        {
            Total = totalPages,
            Products = paginatedProducts
        };
    }

    public async Task AddProduct(Product product)
    {
        await _productsRepository.AddAsync(product);
    }

    public async Task UpdateProduct(Product product)
    {
        await _productsRepository.UpdateAsync(product);
    }

    public async Task DeleteProduct(int id)
    {
        var product = await _productsRepository.GetByIdAsync(id);
        await _productsRepository.DeleteAsync(product);
    }
}