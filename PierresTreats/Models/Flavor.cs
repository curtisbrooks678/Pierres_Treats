using System;
using System.Collections.Generic;

namespace PierresTreats.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    public string Name { get; set; }
    public virtual ApplicationUser User { get; set; }
    public virtual ICollection<FlavorTreat> JoinEntities { get; }
    public Treat()
    {
      this.JoinEntities = new HashSet<FlavorTreat>(); 
    }
  }
}