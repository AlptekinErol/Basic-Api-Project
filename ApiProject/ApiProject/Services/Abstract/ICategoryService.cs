using ApiProject.DTO;
using ApiProject.Entity;

namespace ApiProject.Services.Abstract
{
    public interface ICategoryService
    {
        Task<CreateCategoryDTO> CreateCategory(CreateCategoryDTO category);
        Task<EditCategoryDTO> UpdateCategory(EditCategoryDTO category);
        Task<bool> DeleteCategory(int id);
        Task<ServiceResponse<List<Category>>> GetAllCategories();
        Task<Category> GetCategoryById(int id);
    }
}
