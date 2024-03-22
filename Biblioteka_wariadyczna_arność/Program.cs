using System;
using System.Collections.Generic;

namespace Biblioteka_wariadyczna_arność
{
    public enum BookCategory
    {
        Fantasy,
        Thriller,
        Horror
    }

    public class Book
    {
        public string Title { get; }
        public BookCategory Category { get; } 
        public string Author { get; }

        public Book(string title, BookCategory category, string author)
        {
            Title = title;
            Category = category;
            Author = author;
        }
    }

    public class LibrarySystem
    {
        private List<Book> books = new List<Book>();

        public void AddBooks(params Book[] newBooks)
        {
            foreach (var book in newBooks)
            {
                books.Add(book);
                Console.WriteLine($"Dodano książkę: {book.Author} {book.Title} ({book.Category})");
            }
        }

        public void DisplayBooks()
        {
            Console.WriteLine("Lista książek w bibliotece:");
            foreach (var book in books)
            {
                Console.WriteLine($"- {book.Author} {book.Title} ({book.Category})");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            LibrarySystem library = new LibrarySystem();

            library.AddBooks(
                new FantasyBook("„Harry Potter i Kamień Filozoficzny”", "J.K. Rowling"),
                new ThrillerBook("„Przyjaciółka”", "B.A Paris"),
                new HorrorBook("„Ezgorcysta”", "Blatty William Peter"),
                new FantasyBook("„Harry Potter i Książe Półkrwi”", "J.K. Rowling"),
                new HorrorBook("„Dom po drugiej stronie jeziora”", "Sager Riley"),
                new ThrillerBook("„Za zamkniętymi drzwiami”", "B.A Paris")
            );

            library.DisplayBooks();
        }
    }

    public class FantasyBook : Book
    {
        public FantasyBook(string title, string author) : base(title, BookCategory.Fantasy, author) { }
    }

    public class ThrillerBook : Book
    {
        public ThrillerBook(string title, string author) : base(title, BookCategory.Thriller, author) { }

    }
    public class HorrorBook : Book
    {
        public HorrorBook(string title, string author) : base(title, BookCategory.Horror, author) { }

    }
}
