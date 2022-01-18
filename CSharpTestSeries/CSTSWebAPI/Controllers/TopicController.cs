using Microsoft.AspNetCore.Mvc;

namespace CSTSWebAPI.Controllers
{
    public class TopicController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
