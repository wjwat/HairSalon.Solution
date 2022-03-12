using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Client
  {
    public Client()
    {
      this.Appointments = new HashSet<Appointment>();
    }

    public int ClientId { get; set; }
    public int StylistId { get; set; }
    public string Name { get; set; }
    public virtual Stylist Stylist { get; set; }
    public virtual ICollection<Appointment> Appointments { get; set; }
  }
}
