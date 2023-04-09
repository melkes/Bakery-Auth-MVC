namespace BakeryTreats.Models
{
  public class FlavorTreat
    {       
        public int TreatFlavorId { get; set; }
        public int TreatId { get; set; }
        public Treat Treat { get; set; }
        public int FlavorId { get; set; }
        public Flavor Flavor { get; set; }
    }
}