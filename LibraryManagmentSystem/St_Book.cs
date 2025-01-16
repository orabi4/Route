namespace Library_Management_System;

public class St_Book
{
     string Title{get; set;}
     string Author{get; set;}
     string ISBN{get; set;}

     public St_Book(string title, string author, string isbn)
     {
          Title = title;
          Author = author;
          ISBN = isbn;
          
     }
}