using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
	public class Article
	{
		[Key]
		public int ArticleId { get; set; }
		public string ArticleTitle { get; set; }
		public string ArticleContent { get; set; }	
        public int ArticleViewCount { get; set; }
        public int ArticleCategoryCount { get; set; }
        public bool ArticleStatus { get; set; }
		public DateTime ArticlePublıshDate { get; set; }
        public string ArticleMaınImage { get; set; }
		public int CategoryId { get; set; }
		public Category Category { get; set; }
		public int TagId { get; set; }
		public Tag Tag { get; set; }
		public List<Comment> Comments { get; set; }

    }
}
