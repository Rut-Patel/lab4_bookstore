using lab4_bookstore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace lab4_bookstore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Appraise()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Appraise(textbook model)
        {
            string message = "";

            if(ModelState.IsValid)
            {
                ViewData["Message"] = "Your textbook: " + model.title + " ,version: " + model.version;
                ViewData["Appraise"] = "was appraised at: $" + model.appraisalPrice(model.price,model.condition);

                return View("Appraised", model);
            }
            else
            {
                //message = "Failed to appraise the price. Please try again.";
                return View("Error");
            }

           
        }
    }
}
