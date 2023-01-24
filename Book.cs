using System.ComponentModel.DataAnnotations;

namespace Library
{
	public class Book
	{
		// ID
		public int ID { set; get; }
		// Title
		public string Title { set; get; }
		// Author
		public string Author { set; get; }
		// Price
		public float Price { set; get; }

		public Book()
		{
			this.Title = new string("");
			this.Author = new string("");
			this.ID = 0;
		}

		public Book(string Title, string Author, float Price)
		{
			this.ID = 0;
			this.Title = Title;
			this.Author = Author;
			this.Price = Price;
		}
	}
}
