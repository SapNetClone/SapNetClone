using System.ComponentModel.DataAnnotations;
using SapNetClone.DataAccess.Helpers;

namespace SapNetClone.Application.ViewModels.Product;

public class CreateProductVM
{
    [Required] 
    public string Name { get; set; }
    [Required] 
    public string Description { get; set; }
    [RequiredGreaterThanZero]
    public double Price { get; set; }
}