using CarAuctions.Shared.Models;

namespace CarAuctions.Server.Data;

public static class ExampleCars
{
    public static List<Car> GetAllCars()
    {
        return
        [
            new("Toyota", "Corolla", 2022,  "Silver", 20000, 25000m, "Gasoline", ["Bluetooth", "Backup Camera", "Keyless Entry"]),
            new("Honda", "Civic", 2021,  "White", 18000, 22000m, "Gasoline", ["Apple CarPlay", "Android Auto", "Lane Departure Warning"]),
            new("Ford", "Mustang", 2020,  "Red", 15000, 35000m, "Gasoline", ["Leather Seats", "Navigation System", "Heated Seats"]),
            new("Chevrolet", "Equinox", 2019,  "Blue", 30000, 20000m, "Gasoline", ["Rearview Camera", "Blind-Spot Monitoring", "Wi-Fi Hotspot"]),
            new("Nissan", "Altima", 2020,  "Black", 22000, 21000m, "Gasoline", ["Remote Start", "Automatic Emergency Braking", "Lane Keeping Assist"]),
            new("BMW", "3 Series", 2021,  "White", 12000, 40000m, "Diesel", ["Sunroof", "Adaptive Cruise Control", "Parking Assistance"]),
            new("Tesla", "Model 3", 2022,  "Red", 8000, 45000m, "Electric", ["Autopilot", "Full Self-Driving Capability", "Premium Audio System"]),
            new("Audi", "Q5", 2021,  "Gray", 15000, 38000m, "Gasoline", ["Virtual Cockpit", "Panoramic Sunroof", "Apple CarPlay"]),
            new("Mercedes-Benz", "E-Class", 2020,  "Silver", 18000, 42000m, "Gasoline", ["MBUX Infotainment", "Heated Steering Wheel", "Air Suspension"]),
            new("Chevrolet", "Tahoe", 2020,  "Black", 25000, 45000m, "Gasoline", ["Leather Seats", "Third-Row Seating", "Power Liftgate"]),
            new("Subaru", "Outback", 2021,  "Green", 12000, 32000m, "Gasoline", ["All-Wheel Drive", "Roof Rails", "Adaptive Cruise Control"]),
            new("Lexus", "RX 350", 2022,  "White", 8000, 48000m, "Gasoline", ["Premium Leather Seats", "Panoramic Sunroof", "Mark Levinson Audio"]),
            new("Ford", "F-150", 2020,  "Blue", 18000, 38000m, "Gasoline", ["Towing Package", "Off-Road Package", "Sync 3 Infotainment"]),
            new("BMW", "X5", 2021,  "Black", 14000, 55000m, "Diesel", ["Heated Seats", "Wireless Charging", "Gesture Control"]),
            new("Honda", "CR-V", 2019,  "Silver", 25000, 26000m, "Gasoline", ["Adaptive Cruise Control", "Lane Keeping Assist", "Apple CarPlay"]),
            new("Toyota", "RAV4", 2020,  "White", 18000, 29000m, "Gasoline", ["Blind-Spot Monitoring", "Rear Cross-Traffic Alert", "Apple CarPlay"]),
            new("Tesla", "Model Y", 2022,  "Red", 8000, 52000m, "Electric", ["Autopilot", "Premium Interior", "Panoramic Roof"]),
            new("Chevrolet", "Silverado", 2019,  "Black", 25000, 35000m, "Gasoline", ["Towing Package", "Trailer Brake Controller", "Apple CarPlay"]),
            new("Ford", "Escape", 2021,  "Gray", 12000, 28000m, "Gasoline", ["Apple CarPlay", "Android Auto", "Blind-Spot Monitoring"]),
            new("Mercedes-Benz", "GLE 350", 2020,  "Silver", 18000, 46000m, "Gasoline", ["MBUX Infotainment", "Panoramic Sunroof", "Adaptive Cruise Control"]),
            new("BMW", "4 Series", 2021,  "Blue", 10000, 48000m, "Gasoline", ["Head-Up Display", "Wireless Charging", "Parking Assistance"]),
            new("Honda", "Accord", 2022,  "Black", 8000, 31000m, "Gasoline", ["Honda Sensing Suite", "Remote Engine Start", "Wireless Phone Charger"]),
            new("Jeep", "Grand Cherokee", 2021,  "White", 10000, 38000m, "Gasoline", ["4WD", "Uconnect Infotainment", "Heated Seats"]),
            new("Toyota", "Highlander", 2020,  "Silver", 20000, 36000m, "Gasoline", ["Lane Departure Alert", "Third-Row Seating", "Smart Key System"]),
            new("Ford", "Explorer", 2022,  "Blue", 6000, 42000m, "Gasoline", ["SYNC 4 Infotainment", "Tri-Zone Climate Control", "Power Liftgate"]),
            new("Chevrolet", "Camaro", 2021,  "Red", 8000, 40000m, "Gasoline", ["RS Package", "Wireless Apple CarPlay", "Bose Premium Audio"]),
            new("Audi", "A4", 2020,  "White", 15000, 36000m, "Gasoline", ["Virtual Cockpit", "Panoramic Sunroof", "Audi Pre Sense City"])
        ];
    }
}
