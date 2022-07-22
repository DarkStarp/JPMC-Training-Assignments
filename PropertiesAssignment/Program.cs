namespace PropertiesAssignment
{
    internal class Program
    {

    }
    class book
    {
        private int isbn, quantity;
        private string book_name, author;
        private string book_title;
        private double price;

        //public book(int isbn, int quantity, string book_name, string author, string book_title, double price)
        //{
        //    this.isbn = isbn;
        //    this.quantity = quantity;
        //    this.book_name = book_name;
        //    this.author = author;
        //    this.book_title = book_title;
        //    this.price = price;
        //}
        public int ISBN
        {
            get { return isbn; }
            set {
                isbn = value;
            }
        }
        public int Quant
        {
            get { return quantity; }
            set
            {
                quantity = value;
            }
        }
        public string Name
        {
            get { return book_name; }
            set
            {
                book_name = value;
            }
        }
        public string title
        {
            get { return book_title; }
            set { book_title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public void display()
        {
            Console.WriteLine("Amount is {0}", (double)(quantity) * price);
        }
    }
}