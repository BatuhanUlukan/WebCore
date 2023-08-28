using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
	public class ContactMessage
	{
		[Key]
		public int ContactMessageId { get; set; }
		public string ContactMessageUserName { get; set; }
		public string ContactMessageMail { get; set; }
		public string ContactMessageSubject { get; set; }
		public string ContactMessageContect { get; set; }
		public DateTime ContactMessageDate { get; set; }
		public bool ContactMessageStatus { get; set; }
    }
}
