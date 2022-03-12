using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    public Stylist()
    {
      this.Clients = new HashSet<Client>();
      this.Appointments = new HashSet<Appointment>();
    }

    // Is there a specific need to have this column named 'StylistId' instead of
    // 'Id'?
    public int StylistId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Name
    {
      get
      {
        return FirstName + " " + LastName;
      }
    }

    public virtual ICollection<Client> Clients { get; set; }
    public virtual ICollection<Appointment> Appointments { get; set; }
  }
}
