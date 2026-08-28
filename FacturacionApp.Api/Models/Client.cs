using System;

namespace FacturacionApp.Api.Models;

public class Client : BaseEntity
{

    public string Name { get; private set; } = string.Empty;
    public string LastName { get; private set; } = string.Empty;
    public string Email { get; private set; } = string.Empty;
    public string Phone { get; private set; } = string.Empty;
    public string Address { get; private set; } = string.Empty;
    public string City { get; private set; } = string.Empty;
    public string State { get; private set; } = string.Empty;
    public string ZipCode { get; private set; } = string.Empty;
    public string Country { get; private set; } = string.Empty;
    public string TaxId { get; private set; } = string.Empty;
    

    private Client(){}

    public static Client Create(string name, string lastName, string email, string phone, string address, string city, string state, string zipCode, string country, string taxId)
    {

        if(string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Name cannot be empty");
        }

        if(string.IsNullOrWhiteSpace(TaxId))
        {
            throw new ArgumentException("TaxId cannot be empty");
        }

        return new Client
        {
            Name = name,
            LastName = lastName,
            Email = email,
            Phone = phone,
            Address = address,
            City = city,
            State = state,
            ZipCode = zipCode,
            Country = country,
            TaxId = taxId
        };
    }

}