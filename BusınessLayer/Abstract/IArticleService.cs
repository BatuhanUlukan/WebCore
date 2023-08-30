using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusınessLayer.Abstract
{
	public interface IArticleService
	{
		void ArticleAdd(Article article);
		void ArticleUpdate(Article article);
		void ArticleDelete(Article article);
		List<Article> GetAllArticles();
		Article GetById(int id);
	}
}
