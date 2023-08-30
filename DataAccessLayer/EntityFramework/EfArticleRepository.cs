using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntitiyLayer.Concrete;


namespace DataAccessLayer.EntityFramework
{
	public class EfArticleRepository : GenericRepository<Article>, IArticleDal
	{

	}
}
