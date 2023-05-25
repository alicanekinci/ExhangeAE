using ExchangeAE.Entities;

namespace ExchangeAE.Assetss;

public class Assets : Entity<int>
{
    public string Title { get; set; }
    public int RoomCount { get; set; }
    public int HomeAge { get; set; }
    public int SquareMeter { get; set; }
}