using Microsoft.AspNetCore.Routing.Constraints;

namespace CarWorkshop.MVC.Models
{
    public class Product
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Ean { get; set; }
        public decimal? Price { get; set; }
        public int? Stock { get; set; } = 0;
        public DateTime? Created_at { get; set; } = DateTime.Now;
    }
}
