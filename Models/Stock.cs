namespace Entities.Models
{
  public class Stock
  {
    public int IdStock { get; set; }
    public string Date { get; set; }
    public decimal Quantity { get; set; }
    public decimal BuyPrice { get; set; }
    public int ProductIdProduct { get; set; }
    public int ProductCategoryIdCategory { get; set; }

  }
}