using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
	public class Contact
	{
		[Key]
		public int ContactId { get; set; }
		public string ContactName { get; set; }
		public string ContactMapsLınk { get; set; }
        public string ContactAddress { get; set; }
        public string ContactNumber { get; set; }
        public string ContactMaıl { get; set; }
        public bool ContactStatus { get; set; }
    }
}
