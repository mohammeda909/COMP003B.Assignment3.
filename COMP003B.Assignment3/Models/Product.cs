using System.ComponentModel.DataAnnotations;

public class Product
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Please enter the product name.")]
    public required string Name { get; set; }

    [Required(ErrorMessage = "Please enter the product description.")]
    public required string Description { get; set; }

    [Range(0, double.MaxValue, ErrorMessage = "Please enter a valid price.")]
    public double Price { get; set; }
}
