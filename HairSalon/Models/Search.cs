using System;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Models
{
  public class Search
  {
    public string SearchString { get; set; }
    public List<Stylist> Stylists { get; set; }
    public List<Client> Clients { get; set; }
  }
}
