using System;

namespace FacturacionApp.Api.Models;

public class ProductPrice : BaseEntity
{
    public int ProductId { get; private set; }
    public int PriceListId { get; private set; }
    public decimal Price { get; private set; }

    private ProductPrice(){}

    public static ProductPrice Create(int ProductId, int PriceListId, decimal Price)
    {
        if(Price < 0)
        {
            throw new ArgumentException("Price cannot be negative");
        }

        // TODO: Verify product and priceList exist

        return new ProductPrice 
        {
            ProductId = ProductId,
            PriceListId = PriceListId,
            Price = Price
        };
    }

    public void UpdatePrice(Guid ProductId, Guid PriceListId, decimal Price)
    {
      if(Price < 0)
        {
            throw new ArgumentException("Price cannot be negative");
        }
        RegisterUpdate();
        //TODO: Search priceList and productId to update price
    }
}