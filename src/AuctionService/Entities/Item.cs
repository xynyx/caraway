using System.ComponentModel.DataAnnotations.Schema;
using AuctionService.Entities;

namespace AuctionService;

[Table("Items")] // DB table that this class maps to
public class Item
{
    public Guid Id { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }
    public int Mileage { get; set; }
    public string ImageUrl { get; set; }
    // "Nav properties" - Define relationship to Auction entity; configures schema/relationship for the DB
    public Auction Auction { get; set; }
    public Guid AuctionId { get; set; }
}
