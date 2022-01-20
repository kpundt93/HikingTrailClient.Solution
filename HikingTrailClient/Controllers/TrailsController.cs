using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HikingTrailClient.Models;

namespace HikingTrailClient.Controllers
{
  public class TrailsController : Controller
  {
    public IActionResult Index()
    {
      var allTrails = Trail.GetTrails();
      return View(allTrails);
    }

    public IActionResult Details(int id)
    {
      var trail = Trail.GetDetails(id);
      return View(trail);
    }
  }
}