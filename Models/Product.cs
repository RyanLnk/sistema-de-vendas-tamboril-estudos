namespace Entities.Models
{
  public class Product
  {
    public int IdProduct { get; set; }
    public string Name { get; set; }
    public decimal SalePrice { get; set; }
    public string Description { get; set; }
    public int CategoryIdCategory { get; set; }
  }
}