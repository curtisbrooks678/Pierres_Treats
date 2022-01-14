using System;
using System.Collections.Generic;

namespace PierresTreats.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }
    public string Name { get; set; }
    public virtual ApplicationUser User { get; set; }
    public virtual ICollection<FlavorTreat> JoinEntities { get; }
    public Flavor()
    {
      this.JoinEntities = new HashSet<FlavorTreat>(); 
    }
  }
}