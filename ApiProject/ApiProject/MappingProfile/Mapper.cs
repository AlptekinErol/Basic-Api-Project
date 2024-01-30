using ApiProject.DTO.ProductDTO;
using ApiProject.DTO;
using ApiProject.Entity;
using AutoMapper;

namespace ApiProject.MappingProfile
{
    public class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<Category, CreateCategoryDTO>().ReverseMap();
            CreateMap<Category, EditCategoryDTO>().ReverseMap();
            CreateMap<Product, EditProductDTO>().ReverseMap();
            CreateMap<Product, CreateProductDTO>().ReverseMap();
        }
    }
}
