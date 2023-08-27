﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
	public class Article
	{
		public int ArticleId { get; set; }
		public string ArticleTitle { get; set; }
		public string ArticleContent { get; set; }	
        public int ArticleViewCount { get; set; }
        public int ArticleCategoryCount { get; set; }
        public bool ArticleStatus { get; set; }
		public DateTime ArticlePublıshDate { get; set; }
        public string ArticleMaınImage { get; set; }

    }
}