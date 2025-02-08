namespace TaskSession_Adv3;

public class LibraryEngine
{
    public static void Processboks<T>(List<T> books, FuncDelegetGenaric<T,string> fptr)
    {
        foreach (T i in books)
        {
            Console.WriteLine(fptr(i));
        }
    }
}