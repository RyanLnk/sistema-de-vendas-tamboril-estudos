namespace Entities.Models
{
  public class Sales
  {
    public int IdSales { get; set; }
    public string Date { get; set; }
    public int CustomerIdCustomer { get; set; }
    public int SellerIdSeller { get; set; }
  }
}