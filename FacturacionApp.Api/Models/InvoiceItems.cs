using System;

namespace FacturacionApp.Api.Models;

public class InvoiceItem : BaseEntity
{
    public Guid InvoiceId { get; private set; }
    public Guid ProductId { get; private set; }
    public int Quantity { get; private set; }
    public decimal SubTotal { get; private set; }
    public decimal Total { get; private set; }

    private InvoiceItem(){}

    public static InvoiceItem Create(Guid InvoiceId, Guid ProductId, int Quantity, decimal SubTotal, decimal Total)
    {
        if(InvoiceId == Guid.Empty)
        {
            throw new ArgumentException("InvoiceId cannot be empty");
        }

        if(ProductId == Guid.Empty)
        {
            throw new ArgumentException("ProductId cannot be empty");
        }

        if(Quantity <= 0)
        {
            throw new ArgumentException("Quantity must be positive");
        }

        if(SubTotal <= 0)
        {
            throw new ArgumentException("SubTotal must be positive");
        }

        if(Total <= 0)
        {
            throw new ArgumentException("Total must be positive");
        }

        return new InvoiceItem
        {
            InvoiceId = InvoiceId,
            ProductId = ProductId,
            Quantity = Quantity,
            SubTotal = SubTotal,
            Total = Total
        };
    }
}