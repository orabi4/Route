namespace Library_Management_System;

class Program
{
    static void Main(string[] args)
    {
        St_Book book=new St_Book("cleancode","adel","978-0-306-40615-7");
        BorrowedBook borrowedBook=new BorrowedBook("cleancode",new DateTime(2025,1,1),book);
        if(borrowedBook.IsAvailable)borrowedBook.CheckOut();
        else borrowedBook.ReturnItem();
        Console.WriteLine(borrowedBook.CalculateBorrowDuration());
    }
}