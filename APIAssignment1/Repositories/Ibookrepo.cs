using APIAssignment1.Models;
namespace APIAssignment1.Repositories
{
    public interface Ibookrepo
    {
        public void Addbook(Books book);
        public List<Books> GetAllBooks();
        public List<Books> GetBookbyAuthor(string author);
        public List<Books> GetBookbyLang(string Lang);
        public void Editbook();
        public void Deletebook(int bookID);
    }
}
