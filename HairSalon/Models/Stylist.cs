using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
    [Required, StringLength(60, MinimumLength = 1)]
    public string FirstName { get; set; }
    [Required, StringLength(60, MinimumLength = 1)]
    public string LastName { get; set; }
    public string Name
    {
      get
      {
        return FirstName + " " + LastName;
      }
    }

    public virtual ICollection<Client> Clients { get; set; }
  }
}
