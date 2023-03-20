using BulkyBookWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBookWeb.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index([Bind("WeightInKg,HeightInCm,BMI")] Category obj)
        {
            obj.BMI = Convert.ToString(((obj.WeightInKg) / (obj.HeightInCm * obj.HeightInCm)) * 10000);
            
            return View(obj);
        }
    }
}
