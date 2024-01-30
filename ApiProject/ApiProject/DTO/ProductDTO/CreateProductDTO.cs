namespace ApiProject.DTO.ProductDTO
{
    public class CreateProductDTO
    {
        public string? ProductName { get; set; }
        public decimal? ProductPrice { get; set; }
        public string? ProductDescription { get; set; }
        public int? CategoryId { get; set; }
    }
}
