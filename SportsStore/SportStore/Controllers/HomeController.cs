using Microsoft.AspNetCore.Mvc;

namespace SportStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}
