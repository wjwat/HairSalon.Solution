using System;
using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Appointment
  {
    public int AppointmentId { get; set; }
    public int ClientId { get; set; }
    public int StylistId { get; set; }
    public string Description { get; set; }
    public decimal Cost { get; set; }
    public DateTime StartTime { get; set; }
    public double Duration { get; set; }
    public virtual Stylist Stylist { get; set; }
    public virtual Client Client { get; set; }
  }
}
