using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebCore.ViewComponents
{

	public class CSSViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			// ViewComponent'in görselleştirileceği görünümü döndürün
			return View();
		}
	}

}
