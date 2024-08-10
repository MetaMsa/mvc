using System.ComponentModel.DataAnnotations;

namespace Entities.Models;
public class Product
{
    public int ProductId { get; set; }
    [Required(ErrorMessage = "Product name is required")]
    public String? ProductName { get; set; } = String.Empty;
    [Required(ErrorMessage = "Product price is required")]
    public decimal Price { get; set; }
    [Required(ErrorMessage = "Product image is required")]
    public String? ProductImage { get; set; } = String.Empty;
}
