using System;

namespace FacturacionApp.Api.Models;

public class Invoice : BaseEntity
{
    public Guid ClientId { get; private set; }
    public Guid PriceListId { get; private set; }
    public decimal Total { get; private set; }
    public DateTime Date { get; private set; }
    public string Status { get; private set; } = string.Empty;
    public const string LegalDisclaimer = "SIN VALOR FISCAL - NO VÁLIDO COMO COMPROBANTE";

    
    private Invoice(){}   

    public static Invoice Create(Guid ClientId, Guid PriceListId, decimal Total, DateTime Date, string Status)
    {
        if(ClientId == Guid.Empty)
        {
            throw new ArgumentException("ClientId cannot be empty");
        }

        if(PriceListId == Guid.Empty)
        {
            throw new ArgumentException("PriceListId cannot be empty");
        }

        if(Total < 0)
        {
            throw new ArgumentException("Total cannot be negative");
        }

        if(Date == default(DateTime))
        {
            throw new ArgumentException("Date cannot be empty");
        }
        if(string.IsNullOrWhiteSpace(Status))
        {
            throw new ArgumentException("Status cannot be empty");
        }

        return new Invoice
        {
            ClientId = ClientId,
            PriceListId = PriceListId,
            Total = Total,
            Date = Date,
            Status = Status
        };
    }
}