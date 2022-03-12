using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

using HairSalon.Models;

namespace HairSalon.Controllers
{
    public class SearchController : Controller
    {

      private readonly HairSalonContext _db;

      public SearchController(HairSalonContext db)
      {
        _db = db;
      }

      public ActionResult Index(string id)
      {
        if (id == null)
        {
          return View(null);
        }

        var clients = from c in _db.Clients select c;
        var stylists = from s in _db.Stylists select s;

        if (!string.IsNullOrEmpty(id))
        {
          clients = clients.Where(c => c.FirstName!.Contains(id) ||
                                       c.LastName!.Contains(id));
          stylists = stylists.Where(s => s.FirstName!.Contains(id) ||
                                         s.LastName!.Contains(id));
        }

        var searchView = new Search
        {
          SearchString = id,
          Clients = clients.ToList(),
          Stylists = stylists.ToList()
        };

        return View(searchView);
      }

    }
}
