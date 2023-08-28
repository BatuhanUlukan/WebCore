using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
	public class Client
	{
		[Key]
		public int ClientId { get; set; }
        public string ClientTitle { get; set; }
        public string ClientImage { get; set; }
        public string ClientLink { get; set; }
        public bool ClientStatus { get; set; }
    }
}
