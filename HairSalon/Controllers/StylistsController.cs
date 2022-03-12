using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

using HairSalon.Models;

namespace HairSalon.Controllers
{
  public class StylistsController : Controller
  {
    private readonly HairSalonContext _db;

    public StylistsController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Stylist> model = _db.Stylists.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Stylist stylist)
    {
      // Should we be doing input validation here? And if not here then where?
      _db.Stylists.Add(stylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Stylist stylist = _db.Stylists.FirstOrDefault(s => s.StylistId == id);

      if (stylist != null)
      {
        ViewBag.clients = _db.Clients.Where(c => c.StylistId == id).ToList();
        return View(stylist);
      }
      else
      {
        return RedirectToAction("Index");
      }
    }

    public ActionResult Edit(int id)
    {
      Stylist stylist = _db.Stylists.FirstOrDefault(s => s.StylistId == id);

      if (stylist == null)
      {
        RedirectToAction("Index");
      }

      return View(stylist);
    }

    [HttpPost]
    public ActionResult Edit(Stylist stylist)
    {
      _db.Entry(stylist).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      if (id == 0)
      {
        RedirectToAction("Index");
      }

      var stylist = _db.Stylists.FirstOrDefault(s => s.StylistId == id);
      return View(stylist);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var stylist = _db.Stylists.FirstOrDefault(s => s.StylistId == id);
      var clients = _db.Clients.Where(c => c.StylistId == id).ToList();

      clients.ForEach(c =>
        c.StylistId = 0
      );

      _db.Stylists.Remove(stylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}
