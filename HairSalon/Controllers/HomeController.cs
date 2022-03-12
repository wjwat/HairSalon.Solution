using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

using HairSalon.Models;

namespace HairSalon.Controllers
{
    public class HomeController : Controller
    {

      private readonly HairSalonContext _db;

      public HomeController(HairSalonContext db)
      {
        _db = db;
      }

      public ActionResult Index()
      {
        var clients = _db.Clients.Where(c => c.StylistId == 0).ToList();
        ViewBag.stylists = _db.Stylists.ToList();
        return View(clients);
      }

    }
}
