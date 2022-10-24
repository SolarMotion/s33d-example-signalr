using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Web.Models;

namespace Web.Controllers
{
    public class WindowPopupController : Controller
    {
        public ActionResult Index(string floor, string unit, string cssID)
        {
            if (floor != null && unit != null && cssID != null)
            {
                ViewBag.Message = $"Floor {floor} {unit} clicked.";
            }
            else
            {
                ViewBag.Message = "Opps, something goes wrong.";
            }

            var viewModel = new WindowPopupViewModel() { Floor = floor, CssID = cssID };

            return View(viewModel);
        }
    }
}