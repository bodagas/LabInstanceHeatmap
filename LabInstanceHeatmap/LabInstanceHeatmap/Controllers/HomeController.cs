using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LabInstanceHeatmap.Infrastructure;

namespace LabInstanceHeatmap.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var labInstances = App.Cache.GetPoints();
            return View(labInstances);
        }
    }
}