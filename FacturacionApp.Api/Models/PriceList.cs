using System;

namespace FacturacionApp.Api.Models;

public class PriceList : BaseEntity
{
    public string Name { get; private set; } = string.Empty;
    public bool IsActive { get; private set; } = true;

    private PriceList(){}

    public static PriceList Create(string name)
    {
        return new PriceList
        {
            Name = name,
            IsActive = true
        };
    }

    public void Update(string name)
    {
        if(string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Name cannot be empty");
        }
        Name = name;
    }

    public void Deactivate()
    {
        IsActive = false;
    }

    public void Activate()
    {
        IsActive = true;
    }


}