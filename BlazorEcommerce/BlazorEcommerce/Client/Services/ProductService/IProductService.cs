using BlazorEcommerce.Shared;

namespace BlazorEcommerce.Client.Services.ProductService
{
    public interface IProductService
    {
        event Action ProductsChanged;
        List<Product> Products { get; set; }
        Task GetProducts(string? catogoryURl = null);
        Task<ServiceResponse<Product>> GetProduct(int productId);
    }
}
