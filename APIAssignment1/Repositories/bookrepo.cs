using APIAssignment1.Models;
using APIAssignment1.Repositories;
using System.Collections.Generic;
namespace APIAssignment1.Repositories
{
    public class bookrepo : Ibookrepo
    {
        private static List<Books> book = new List<Books>()
        {
            new Books(){bookId = 1234, bookName="Dev", author="rajesh",price=99999, lang="hindi", ReleaseDate=2000}
        };
        public List<Books> GetAllBooks()
        {
            return book;
        }
        public void Addbook(Books books)
        {
            book.Add(books);
        }
        public List<Books> GetBookbyAuthor(string author)
        {
            List<Books> be = new List<Books>();
            foreach(var books in book)
            {
                if(books.author == author)
                {
                    be.Add(books);
                }
            }
            return be;
        }
        public List<Books> GetBookbyLang(string Lang)
        {
            List<Books> be = new List<Books>();
            foreach (var books in book)
            {
                if (books.lang == Lang)
                {
                    be.Add(books);
                }
            }
            return be;
        }
        public void Editbook()
        {

        }
        public void Deletebook(int bookID)
        {
            Books be = null;
            foreach(var b in book)
            {
                if(b.bookId==bookID)
                {
                    be = b;
                }
            }
            book.Remove(be);
        }

    }
}
 