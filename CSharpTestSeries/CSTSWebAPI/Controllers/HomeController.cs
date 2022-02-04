using CSTSWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Topic = CSTSWebAPI.Models.Topic;

namespace CSTSWebAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
    [HttpGet]
    public IActionResult Index()
        {
          ViewData["Message"] = "Neelima!"; //adding this to learn razor 
      ViewData["Object"] = new Topic { Id=1, TopicName="test", VideoName="test", VideoURL="test"};     
      return View();
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
