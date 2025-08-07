using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CarWorkshop.MVC.Models;

namespace CarWorkshop.MVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Shop()
    {
        var model = new List<Product>()
        {
            new Product()
            {
                Name="Creatine 500g",
                Price=34,
                Stock=10
            },
            new Product()
            {
                Name="Collagen 500g",
                Price=45,
                Stock=0
            }
        };
        return View(model);

    }

    public IActionResult Home()
    {
  
        return View();
    }

    public IActionResult Privacy()
    {
        var model = new List<Person>()
        {
            new Person()
            {
                FirstName="Jan",
                LastName="Kowalski"
            },
            new Person()
            {
                FirstName="Magdalena",
                LastName="Wachowska"
            }
        };

        return View(model);         //przekazalismy model do widoku
    }

    public IActionResult About()
    {
        var model = new About()
        {
          
                Title="CarWorkShop application",
                Description="Internet service with car workshops.",
                Tags=new List<string>() {"Instagram","Facebook", "LinkedIn" }
        };
        return View(model);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
