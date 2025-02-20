public class Book
{
    private string author = "None";
    private string title = "None";
    private string publisher = "None";
    private int pages = 0;
    private int year = 0;
    private static double price = 9;

    public Book(String author, String title, String publisher, int pages, int year)
    {
    this.author = author;
    this.title = title;
    this.publisher = publisher;
    this.pages = pages;
    this.year = year;
    }

    public Book(string author, string title) 
    {
        this.author = author;
        this.title = title;
    }

    public Book() {}

    static Book() {price = 10;}
    
    public string GetTitle()
    {
        return this.title;
    }

    public static void SetPrice(double price)
    {
        Book.price = price; 
    }

    public void SetBook(String author, String title, String publisher, int pages, int year)
    {
    this.author = author;
    this.title = title;
    this.publisher = publisher;
    this.pages = pages;
    this.year = year;
    }

    public void Show()
    {
        Console.WriteLine($"\nBook info:\nAuthor: {author}    Title: {title}\nPublisher: {publisher}    Pages: {pages}\nYear: {year}    Rent for day: {Book.price}");
    }

    public double PriceBook(int day)
    {
        return day * price;
    }
}
