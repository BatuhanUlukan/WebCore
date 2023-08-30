using BusınessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusınessLayer.Concrete
{
	public class CategoryManager : ICategoryService
	{

		ICategoryDal categoryDal;

  
		public CategoryManager(ICategoryDal categoryDal)
		{
			this.categoryDal = categoryDal;
		}

		public void CategoryAdd(Category category)
		{
			categoryDal.Insert(category);
		}

		public void CategoryDelete(Category category)
		{
			categoryDal.Delete(category);
		}

		public void CategoryUpdate(Category category)
		{
			categoryDal.Update(category);
		}

		public List<Category> GetAllCategories()
		{
			return categoryDal.GetListAll();
		}

		public Category GetById(int id)
		{
			return categoryDal.GetById(id);
		}
	}
}
