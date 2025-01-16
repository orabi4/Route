namespace Library_Management_System;

public class LibraryItem
{
    int ItemId{get; set;}
    public bool IsAvailable;

    public LibraryItem()
    {
        ItemId = 0;
        IsAvailable = true;
    }

    public LibraryItem(int itemId,bool isAvailable)
    {
        ItemId = itemId;
        IsAvailable = isAvailable;
    }
    public void CheckOut()
    {
        IsAvailable = false;
         Console.WriteLine("Book is unavailable");
    }
    public void ReturnItem()
    {
        IsAvailable = true;
       Console.WriteLine("Book is Available");
    }
    
}