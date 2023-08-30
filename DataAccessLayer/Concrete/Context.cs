using EntitiyLayer.Concrete;
using Microsoft.EntityFrameworkCore;


namespace DataAccessLayer.Concrete
{
	public class Context : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=WIN-KMFO5JKEP0U;database=Core;integrated security=true;");

		}
		public DbSet<About> Abouts { get; set; }
		public DbSet<Article> Articles { get; set; }
		public DbSet<Author> Authors { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Client> Clients { get; set; }
		public DbSet<Comment> Comments { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<ContactMessage> ContactMessages { get; set; }
		public DbSet<Fact> Facts { get; set; }
		public DbSet<Portfolio> Portfolios { get; set; }
		public DbSet<Service> Services { get; set; }
		public DbSet<Social> Socials { get; set; }
		public DbSet<Tag> Tags { get; set; }
		public DbSet<Testimonial> Testimonials { get; set; }

	}

}
