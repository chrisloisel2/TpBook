using Library;
using Microsoft.EntityFrameworkCore;

// Crud -> Create, Read, Update, Delete

namespace ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			// Create
			// Commente le code suivant pour ne pas créer de doublons dans la base de données
			Book book = new Book("The Lord of the Rings", "J.R.R. Tolkien", 20.0f); // <- nom de la table = nom du DbSet
			BookContext context = new BookContext();
			context.Books.Add(book);// ajoute le livre dans la base de données
			context.SaveChanges();// sauvegarde les changements dans la base de données

			// Read
			foreach (Book b in context.Books)
			{
				System.Console.WriteLine(b.Title); // affiche le titre du livre
			}

			// Update
			book.Price = 25.0f;// modifie le prix du livre
			context.SaveChanges(); // sauvegarde les changements dans la base de données

			// Delete
			context.Books.Remove(book); // supprime le livre de la base de données
			context.SaveChanges(); // sauvegarde les changements dans la base de données
		}
	}
}
