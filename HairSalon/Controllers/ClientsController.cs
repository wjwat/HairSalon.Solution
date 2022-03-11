using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

using HairSalon.Models;

namespace HairSalon.Controllers
{
  public class ClientsController : Controller
  {
    private readonly HairSalonContext _db;

    public ClientsController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      // Display list of current clients
      return View();
    }

    public ActionResult Create()
    {
      // If we have no stylists just dump back out to the create Stylist page,
      // but a more ideal solution would be to add an intermediate page that
      // says why we're back at the create a stylist page.
      if (_db.Stylists.Count() == 0)
      {
        return RedirectToAction("Create", "Stylists");
      }
      else
      {
        ViewBag.StylistIds = new SelectList(_db.Stylists, "StylistId", "Name");
        return View();
      }
    }

    public ActionResult Edit(int id)
    {
      return View();
    }

    [HttpPost]
    public ActionResult Edit(Client client)
    {
      return View();
    }

    public ActionResult Delete(int id)
    {
      return View();
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeletePost(int id)
    {
      return View();
    }
  }
}
