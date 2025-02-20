using System;

namespace Pr1;

class Program
{
    static void Main() 
    {
     Tringle t1 = new Tringle(12.4, 5.1, 12.4);
     Tringle t2 = new Tringle(12.4, 12.4, 12.4);
     Tringle t3 = new Tringle(12.4, 100.1, 12.4);
     Tringle t4 = new Tringle(0, 5.1, 12.4);
     Tringle t5 = new Tringle(52.1, 53.1, 52.4);

     t1.ShowAll();   
     t2.ShowAll();   
     t3.ShowAll();   
     t4.ShowAll();   
     t5.ShowAll();   
    }

    // static void TestClassBook(Book book)
    // {
    //     book.Show();
    //     Console.WriteLine($"\nNumber of rental days for {book.GetTitle()}");
    //     int rentDays = Convert.ToInt32(Console.ReadLine());
    //     Console.WriteLine($"\nRent {book.GetTitle()} for {rentDays} days will cost: {book.PriceBook(rentDays)}");
    // }
}