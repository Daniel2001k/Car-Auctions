namespace CarAuctions.Shared;

public class Car
{
    public string Make { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public int Year { get; set; }
    public string Color { get; set; } = string.Empty;
    public int Mileage { get; set; }
    public decimal Price { get; set; }
    public string FuelType { get; set; } = string.Empty;
    public string[] Features { get; set; } = [];
}