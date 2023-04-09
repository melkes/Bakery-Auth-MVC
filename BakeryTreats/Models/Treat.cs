using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BakeryTreats.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    [Required(ErrorMessage = "The treat's description can't be empty!")]
    public string Description { get; set; }
    [Range(1, int.MaxValue, ErrorMessage = "You must add your treat to a flavor. Have you created a flavor yet?")]
    public int FlavorId { get; set; }
    public Flavor Flavor { get; set; }
    public List<TreatFlavor> JoinEntities { get;}
  }
}