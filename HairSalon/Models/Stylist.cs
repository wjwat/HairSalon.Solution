using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    public Stylist()
    {
      this.Clients = new HashSet<Client>();
    }

    // Is there a specific need to have this column named 'StylistId' instead of
    // 'Id'?
    public int StylistId { get; set; }
    public string Name { get; set; }

    public virtual ICollection<Client> Clients { get; set; }
  }
}
