using ApiProject.DTO.ProductDTO;
using ApiProject.Entity;

namespace ApiProject.Services.Abstract
{
    public interface IProductService
    {

        Task<CreateProductDTO> CreateProduct(CreateProductDTO product);
        Task<EditProductDTO> UpdateProduct(EditProductDTO product);
        Task<bool> DeleteProduct(int id);
        Task<ServiceResponse<List<Product>>> GetAllProducts();
        Task<Product> GetProductById(int id);
    }
}
