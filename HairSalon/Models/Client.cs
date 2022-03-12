using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
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
    public virtual Stylist Stylist { get; set; }
  }
}
