using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
	public class Tag
	{
		[Key]
		public int TagId { get; set; }
		public string TagName { get; set; }
		public bool TagStatus { get; set; }
	}
}
