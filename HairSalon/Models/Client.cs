using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
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
    public virtual Stylist Stylist { get; set; }
  }
}
