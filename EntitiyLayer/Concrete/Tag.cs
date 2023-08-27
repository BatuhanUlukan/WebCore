using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
	public class Tag
	{
		public int TagId { get; set; }
		public string TagDescription { get; set; }
		public string TagName { get; set; }
		public bool TagStatus { get; set; }
	}
}
