using ApiProject.DatabaseContext;
using ApiProject.DTO.ProductDTO;
using ApiProject.Entity;
using ApiProject.Services.Abstract;
using AutoMapper;

namespace ApiProject.Services.Concrete
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ProductService(ApplicationDbContext context
                                                     , IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<CreateProductDTO> CreateProduct(CreateProductDTO product)
        {
            var map = _mapper.Map<CreateProductDTO, Product>(product);
            map.CreatedDate = DateTime.Now;
            map.UpdateDate = DateTime.Now;
            var addedObj = _context.Products.Add(map);
            var respone = _mapper.Map<Product, CreateProductDTO>(addedObj.Entity);
            _context.SaveChanges();
            return respone;

        }

        public async Task<bool> DeleteProduct(int id)
        {
            var result = _context.Products.Find(id);
            if (result != null)
            {
                _context.Products.Remove(result);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public async Task<ServiceResponse<List<Product>>> GetAllProducts()
        {
            var result = _context.Products.ToList();
            ServiceResponse<List<Product>> _product = new ServiceResponse<List<Product>>();
            if (result != null)
            {
                _product.Data = result;
                _product.Success = true;
                _product.Message = "Products Listed";
                return _product;
            }
            return _product;


        }

        public async Task<Product> GetProductById(int id)
        {
            var result = _context.Products.FirstOrDefault(c => c.Id == id);
            return result;
        }

        public async Task<EditProductDTO> UpdateProduct(EditProductDTO product)
        {
            var result = _context.Products.Find(product.Id);
            if (result != null)
            {
                var map = _mapper.Map<EditProductDTO, Product>(product);
                result.ProductName = map.ProductName;
                result.ProductDescription = map.ProductDescription;
                result.ProductPrice = map.ProductPrice;
                result.CategoryId = map.CategoryId;
                result.UpdateDate = DateTime.Now;
                result.CreatedDate = DateTime.UtcNow;
                var response = _mapper.Map<Product, EditProductDTO>(map);
                _context.SaveChanges();
                return response;
            }
            return null;
        }
    }

}
