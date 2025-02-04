using System.Text.Json.Serialization;

namespace CarAuctions.Shared.Models;

[method: JsonConstructor]
public class Car(string make, string model, int year, string color, int mileage, decimal price, string fuelType, string[] features)
{
    public string Make { get; set; } = make;
    public string Model { get; set; } = model;
    public int Year { get; set; } = year;
    public string Color { get; set; } = color;
    public int Mileage { get; set; } = mileage;
    public decimal Price { get; set; } = price;
    public string FuelType { get; set; } = fuelType;
    public string[] Features { get; set; } = features;
}
