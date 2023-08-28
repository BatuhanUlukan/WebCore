using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
	public class Author
	{
		[Key]
		public int AuthorId { get; set; }
		public string AuthorName { get; set; }
		public string AuthorMail { get; set; }
		public int AuthorNumber { get; set; }
		public string AuthorPassword { get; set; }
		public string AuthorContent { get; set; }
		public string AuthorAvatar { get; set; }
		public string AuthorJob { get; set; }
		public string AuthorImage { get; set; }
		public bool AuthorStatus { get; set; }
	}
}
