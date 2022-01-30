using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Temperature.Models;
using Temperature.Services;


namespace Temperature.Controllers
{
 
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        TemperatureCalculatorService temperatureCalculator = new TemperatureCalculatorService();

        TemperatureModel temperatureModel = new TemperatureModel();



        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return RedirectToAction("TemperatureCalculator"); 
        }

        public IActionResult TemperatureCalculator(double result=110,String type="")
        {
            ViewBag.result =result;
            ViewBag.type = type;
            return View();
        }

        [HttpPost]
        public IActionResult calculate(TemperatureModel model)
        {
            dynamic result = 0;
            dynamic type = "";
            if (model.fahrenheit.Equals(0) && model.celsius.Equals(0))

            {
              
                TempData["errMsg"] = true;
                TempData["success"] = false;
            }
            else
            {
             

                if (model.fahrenheit.Equals(0))
                {

                    type = "Fehrenheit";
                    result = temperatureCalculator.celsius_to_fahrenheit(model.celsius);

                }
                else if (model.celsius.Equals(0))
                {
                    type = "Celsius";
                    result = temperatureCalculator.fahrenheit_to_celsius(model.fahrenheit);
                }

                TempData["errMsg"] = false;
                TempData["success"] = true;

            }

            return RedirectToAction("TemperatureCalculator",new { result=result,type=type});
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
