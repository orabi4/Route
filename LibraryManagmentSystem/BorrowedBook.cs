namespace Library_Management_System;

public class BorrowedBook:LibraryItem
{
    string BorrowerName {get; set;}
    DateTime BorrowedDate {get; set;} 
    St_Book BookDetails;

    public BorrowedBook(string borrowerName,DateTime borrowedDate,St_Book bookDetails)
    {
        BorrowerName = borrowerName;
        BorrowedDate = borrowedDate;
        BookDetails = bookDetails;
    }
    public int CalculateBorrowDuration()
    {
        return (DateTime.Now - BorrowedDate).Days;
    }
    
   
}