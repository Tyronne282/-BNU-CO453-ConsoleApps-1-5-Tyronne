﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ConsoleAppProject.App02;
using WebApps.Models;

namespace WebApps.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DistanceConverter()
        {
            return View();
        }

        [HttpGet]
        public IActionResult BmiCalculator()
        {
            return View();
        }

        [HttpPost]
        public IActionResult BmiCalculator(BmiCalculator bmi)
        {
            if (bmi.Centimetres > 140 && bmi.Kilograms > 10)
            {
                bmi.CalculateMetricBMI();
            }
            else if (bmi.Feet > 4 && bmi.Stones > 6)
            {
                bmi.CalculateImperialBMI();
            }
            else
            {
                ViewBag.Error = "You have entered values too small for any adult";
                return View();
            }

            double bmiIndex = bmi.Index;

            return RedirectToAction("HealthMessage", new { bmiIndex });
        }

        public IActionResult HealthMessage(double bmiIndex)
        {
            return View(bmiIndex);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
