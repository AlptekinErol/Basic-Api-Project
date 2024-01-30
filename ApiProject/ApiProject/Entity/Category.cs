using ApiProject.Entity.Base;
using System.ComponentModel.DataAnnotations;

namespace ApiProject.Entity
{
    public class Category : BaseEntity
    {

        [Key]
        public int Id { get; set; }
        public string? CategoryName { get; set; }
        public string? CategoryDescription { get; set; }
        public virtual List<Product>? Products { get; set; }

    }
}
