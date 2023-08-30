﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
	public class Category
	{
		[Key]
		public int CategoryId { get; set; }
		public string CategoryDescription { get; set; }
		public string CategoryName { get; set; }
		public bool CategoryStatus { get; set; }
		public List<Article> Articles { get; set; }
		public List<Portfolio> Portfolios { get; set; }
	}
}
