using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntitiyLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
	public class EfAboutRepository:GenericRepository<About>,IAboutDal
	{

	}
}
