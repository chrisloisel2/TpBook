using Microsoft.EntityFrameworkCore;

namespace Library
{

	public class BookContext : DbContext
	{
		public DbSet<Book> Books { get; set; }// <- nom de la table = nom du DbSet

		public BookContext()
		{
			Database.EnsureCreated();
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseMySQL("Server=localhost;Database=Library;User=root;Password=0000");
		}
	}
}
