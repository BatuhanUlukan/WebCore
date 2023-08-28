using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
	public class Testimonial
	{
		[Key]
		public int TestimonialId { get; set; }
		public string TestimonialRefrer { get; set; }
		public string TestimonialImage { get; set; }
		public string TestimonialContent { get; set; }
		public bool TestimonialStatus { get; set; }
	}
}
