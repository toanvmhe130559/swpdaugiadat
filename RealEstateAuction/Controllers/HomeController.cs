using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using RealEstateAuction.DAL;
using RealEstateAuction.DataModel;
using RealEstateAuction.Enums;
using RealEstateAuction.Models;
using System.Data;
using System.Diagnostics;

namespace RealEstateAuction.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
      
        private readonly Pagination pagination;
        

        public HomeController(ILogger<HomeController> logger)
        {
            pagination = new Pagination();
           
            _logger = logger;
        }
        [Route("")]
        [Route("home")]
       

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