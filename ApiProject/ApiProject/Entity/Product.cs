using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ApiProject.Entity.Base;

namespace ApiProject.Entity
{
    public class Product:BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string? ProductName { get; set; }
        [Column(TypeName = "Decimal(18.2)")]
        public decimal? ProductPrice { get; set; }
        public string? ProductDescription { get; set; }
        public int? CategoryId { get; set; }
        [JsonIgnore]
        public virtual Category? Category { get; set; }
    }
}
