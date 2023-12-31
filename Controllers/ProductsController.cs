﻿using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Core_Web_Development_Activity2.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // IActionResult = Interface das diverse Dinge wieder geben kann, bevorzugt aber Views()
        public IActionResult Message()
        {
            // auto gen: add view/razor view
            return View("message");
        }

        // /products ist hier der controller und /messagestring die action
        public string MessageString()
        {
            return "This is a important message about a product thing.";
        }

        // (string name, int secretNumber=13) sind parameter die in die address-bar müssen
        // =13 ist der default wert, bei nicht-eingabe
        // aufruf url: /products/welcome?name=Name&secretnumber=Number
        public IActionResult Welcome(string name, int secretNumber = 13)
        {
            // ViewBag is a property – considered a dynamic object – that enables you to share values dynamically
            // between the controller and view within ASP.NET MVC applications. 
            ViewBag.Name = name;
            ViewBag.SecretNumber = secretNumber;
            // added Razor View "Welcome"
            return View();
            // wenn ein string statt IActionResult die Methode wäre:
            // return "Hello." + name + "the secret number of today is:" + secretNumber;
        }
    }
}
