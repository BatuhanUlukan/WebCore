using BusınessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebCore.Controllers
{
	public class Category : Controller
	{
		CategoryManager cm = new CategoryManager(new EfCategoryRepository());
		public IActionResult Index()
		{
			var values = cm.GetAllCategories();
			return View(values);
		}
	}
}
