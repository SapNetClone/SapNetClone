using SapNetClone.Entities.Classes.BaseClasses;

namespace SapNetClone.Entities.Classes.Product;

public class Product : BaseObject
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string Price { get; set; }
}