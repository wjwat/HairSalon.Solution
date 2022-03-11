using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

using HairSalon.Models;

namespace HairSalon.Controllers
{
    public class HomeController : Controller
    {

      public ActionResult Index()
      {
        return View();
      }

    }
}
