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
      List<Client> model = _db.Clients.ToList();
      return View(model);
    }

    public ActionResult Create(int? id)
    {
      // If we have no stylists just dump back out to the create Stylist page,
      // but a more ideal solution would be to add an intermediate page that
      // says why we're back at the create a stylist page.
      if (_db.Stylists.Count() == 0 ||
          (_db.Stylists.All(s => s.StylistId != id) &&
          id != null))
      {
        return RedirectToAction("Create", "Stylists");
      }
      else
      {
        if (id != null)
        {
          var s = _db.Stylists.Where(s => s.StylistId == id).FirstOrDefault();

          ViewBag.Selected = s.StylistId;
          ViewBag.Attr = new { disabled = "", @class = "disabled", required = "" };
          ViewBag.StylistId = new SelectList(
              _db.Stylists,
              "StylistId",
              "Name",
              s.StylistId
          );
        }
        else
        {
          ViewBag.Selected = null;
          ViewBag.Attr = new {required = ""};
          ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
        }
        return View();
      }
    }

    [HttpPost]
    public ActionResult Create(Client client)
    {
      _db.Clients.Add(client);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Client client = _db.Clients.FirstOrDefault(s => s.ClientId == id);

      if (client == null)
      {
        return RedirectToAction("Index");
      }

      ViewBag.StylistName = (client.StylistId == 0) ?
          "Unknown" :
          _db.Stylists.FirstOrDefault(s => s.StylistId == client.StylistId).Name;
      return View(client);
    }

    public ActionResult Edit(int id)
    {
      Client client = _db.Clients.FirstOrDefault(s => s.ClientId == id);

      if (client == null || !_db.Stylists.Any())
      {
        return RedirectToAction("Index");
      }

      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
      return View(client);
    }

    [HttpPost]
    public ActionResult Edit(Client client)
    {
      _db.Entry(client).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      if (id == 0)
      {
        return RedirectToAction("Index");
      }

      var client = _db.Clients.FirstOrDefault(s => s.ClientId == id);
      return View(client);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var client = _db.Clients.FirstOrDefault(s => s.ClientId == id);
      _db.Clients.Remove(client);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}
