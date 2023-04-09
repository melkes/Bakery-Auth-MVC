using System.Collections.Generic;

namespace BakeryTreats.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }
    public string Name { get; set; }
    public List<Treat> Treats { get; set; }
  }
}