using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
	public class Fact
	{
		[Key]
		public int FactId { get; set; }
        public string FactTitle { get; set; }
        public string FactIcon { get; set; }
        public int FactCount { get; set; }
        public bool FactStatus { get; set; }
    }
}
