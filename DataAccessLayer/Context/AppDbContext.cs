using EntitiyLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Context
{
	public class AppDbContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=WIN-KMFO5JKEP0U;database=Core;integrated security=true;");
		}
		DbSet<About> Abouts { get; set; }
		DbSet<Article> Articles { get; set; }
		DbSet<Author> Authors { get; set; }
		DbSet<Category> Categories { get; set; }
		DbSet<Client> Clients { get; set; }
		DbSet<Comment> Comments { get; set; }
		DbSet<Contact> Contacts { get; set; }
		DbSet<ContactMessage> ContactMessages { get; set; }
		DbSet<Fact> Facts { get; set; }
		DbSet<Portfolio> Portfolios { get; set; }
		DbSet<Service> Services { get; set; }
		DbSet<Social> Socials { get; set; }
		DbSet<Tag> Tags { get; set; }
		DbSet<Testimonial> Testimonials { get; set; }
	}
}
