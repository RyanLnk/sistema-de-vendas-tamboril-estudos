namespace Entities.Models
{
  public class SalesHasProduct
  {
    public int IdSalesProduct { get; set; }
    public decimal Price { get; set; }
    public decimal Quantity { get; set; }
    public decimal SubTotal { get; set; }
    public int SalesIdSales { get; set; }
    public int SalesCustomerIdCustomer { get; set; }
    public int SalesSellerIdSeller { get; set; }
    public int ProductIdProduct { get; set; }
    public int ProductCategoryIdCategory { get; set; }
  }
}