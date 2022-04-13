namespace Entities.Models
{
  public class SalesHasPayment
  {
    public int IdSalesPayment { get; set; }
    public decimal Value { get; set; }
    public string Status { get; set; }
    public string Date { get; set; }
    public int SalesIdSales { get; set; }
    public int SalesCustomerIdCustomer { get; set; }
    public int SalesSellerIdSeller { get; set; }
    public int PaymentIdPayment { get; set; }

  }
}