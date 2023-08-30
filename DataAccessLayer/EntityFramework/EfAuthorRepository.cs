using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntitiyLayer.Concrete;


namespace DataAccessLayer.EntityFramework
{
	public class EfAuthorRepository	: GenericRepository<Author>,IAuthorDal
	{

	}
}
