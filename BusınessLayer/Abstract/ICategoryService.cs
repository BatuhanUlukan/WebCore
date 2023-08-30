using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusınessLayer.Abstract
{
	public interface ICategoryService
	{
		void CategoryAdd(Category category);
		void CategoryUpdate(Category category);
		void CategoryDelete(Category category);
		List<Category> GetAllCategories();
		Category GetById(int id);
	}
}
