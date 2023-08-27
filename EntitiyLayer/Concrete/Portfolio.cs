using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
	public class Portfolio
	{
		public int PortfolioId { get; set; }
		public string PortfolioTitle { get; set; }
		public string PortfolioContent { get; set; }
		public string PortfolioLınk { get; set; }
		public int PortfolioViewCount { get; set; }
        public bool PortfolioStatus { get; set; }
		public DateTime PortfolioPublıshDate { get; set; }
        public string PortfolioMaınImage { get; set; }

    }
}
