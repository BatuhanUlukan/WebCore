using Microsoft.AspNetCore.Mvc;

namespace WebCore.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
