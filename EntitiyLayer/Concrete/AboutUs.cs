using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
	public class AboutUs
	{
		[Key]
		public int AboutId { get; set; }
        public string AboutTitle { get; set; }
        public string AboutSubTitle { get; set; }
        public string AboutImage { get; set; }
        public string AboutContent { get; set; }
        public bool AboutStatus { get; set; }
    }
}
