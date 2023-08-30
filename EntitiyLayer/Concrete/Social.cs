using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
	public class Social
	{
		[Key]
		public int SocialId { get; set; }
        public string SocialName { get; set; }
        public string SocialLink { get; set; }
        public string SocialIcon { get; set; }
        public bool SocialStatus { get; set; }
		public List<Author> Authors { get; set; }

	}
}
