using System;

namespace FacturacionApp.Api.Models;

public class Product : BaseEntity
{
    public string Name { get; private set; } = string.Empty;
    public string Description { get; private set; } = string.Empty;
    public bool IsActive { get; private set; } = true;

    private Product(){}

    public static Product Create(string name, string description)
    {
        return new Product
        {
            Name = name,
            Description = description,
            IsActive = true
        };
    }    

    public void Update(string name, string description)
    {
      if(string.IsNullOrWhiteSpace(name))
      {
        throw new ArgumentException("Name cannot be empty");
      }

      Name = name;
      Description = description ?? string.Empty;
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