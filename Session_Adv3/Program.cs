namespace TaskSession_Adv3;

    #region Part1Delegates
public delegate int StringFuncDelegate(string s);
public delegate bool CompareFuncDelegate(int x,int y);
public delegate TResult CompareFuncDelegateGenraic<in TE,out TResult>(TE x, TE y);
#endregion
    #region Part2Delegates
    public delegate TResult FuncDelegetGenaric<in T,out TResult>(T book); 
    #endregion
class Program
{
    static void Main(string[] args)
    {
        #region Part1
        #region Example1
        // StringFuncDelegate stringFuncDelegate = new StringFuncDelegate(StringFunctions.CountUpperChar);
        // //Syntax Sugare
        // StringFuncDelegate stringFuncDelegate2 = StringFunctions.CountUpperChar;
        // // Console.WriteLine(stringFuncDelegate.Invoke("AdEl"));
        // stringFuncDelegate2 += StringFunctions.CountLowerChar;
        // //stringFuncDelegate-=StringFunctions.CountLowerChar;  
        // Console.WriteLine(stringFuncDelegate("ADEL"));
        // Console.WriteLine(stringFuncDelegate2("AdeeL")); 
        //

        #endregion
        #region Example2

        // int[] arr = { 5, 1, 3, 2, 4 };
        // SortingAlgorithms.Bubblesort(arr,SortingAlgorithms.CompareLowerThan);
        // foreach (var i in arr) Console.WriteLine(i);

        #endregion
        #region Example3

        string[] arr = { "adel", "ad", "ome", "adfsadfsd" };
        // SortingAlgorithms<string>.Bubblesort(arr,SortingAlgorithms<string>.CompareStringGreater);
        // SortingAlgorithms<string>.Bubblesort(arr,SortingAlgorithms<string>.CompareStringLower);
        //foreach (string  i in arr) Console.WriteLine(i);
        CompareFuncDelegateGenraic<string, bool> compareFuncDelegateGenraic = SortingAlgorithms<string>.CompareStringGreater;
        SortingAlgorithms<string>.Bubblesort(arr, compareFuncDelegateGenraic);
        //foreach (string  i in arr) Console.WriteLine(i);
        int[] arr2 = { 2, 5, 1, 3 };
        SortingAlgorithms<int>.Bubblesort(arr2,SortingAlgorithms<int>.CompareGreaterThan);
        //foreach (int  i in arr2) Console.WriteLine(i);
        #endregion
        

        #endregion
        
        #region Part2
        #region Q1
         // two classes was created successfully
        #endregion
        
        #region Q2
     
        List<Book> books = new List<Book>()
        {
            new("10","Harry Potter",new string[]{"adel","mohamed","kassem"},new DateTime(2004,6,15),1000m),
            new("20","marvin",new string[]{"kassem","adel","mohamed"},new DateTime(2004,6,15),12000m)
        };
        // LibraryEngine.Processboks(books,BookFunctions.GetTitle);
        // LibraryEngine.Processboks(books,BookFunctions.GetAuthors);
        // LibraryEngine.Processboks(books,BookFunctions.GetPrice);
        // Func<Book,string> funcdelegate= delegate ( Book book){return book.ISBN;};
        // Console.WriteLine(funcdelegate(books[0]));
        // Func<Book,DateTime> funcdelegate2 = book=> book.PublicationDate;
        // Console.WriteLine(funcdelegate2(books[0]));
        #endregion

        #region Q3
        List<int>list = new List<int>(){1,2,3,4,5,5,5,8,9,10};
        List<string> list2 = new List<string>() { "adel", "mohamed", "kassem","mohamed" };
        Console.WriteLine(Exist(FunctionForPart03.CheckExistElementInt,5,list));
        Console.WriteLine(Exist(FunctionForPart03.CheckExistElementString,"adel",list2));
        Console.WriteLine(Find(FunctionForPart03.CheckExistElementInt,4,list));
        Console.WriteLine(string.Join(", ",FindAll(FunctionForPart03.CheckExistElementString,"mohamed",list2)));
        Console.WriteLine(FindIndex(FunctionForPart03.CheckExistElementString,"kassem",list2));
        Console.WriteLine(FindLast(FunctionForPart03.CompareElementIntGreater,5,list));
        Console.WriteLine(FindLast(FunctionForPart03.CompareElementStringGreater,"adel",list2));
        Console.WriteLine(FindLastIndex(FunctionForPart03.CheckExistElementInt,5,list));
        
        Console.WriteLine(TrueForAll(FunctionForPart03.TrueForAll,2,list));
        Console.WriteLine(TrueForAll(FunctionForPart03.TrueForAll,"adel",list2));
        #region Exist

         bool Exist<T>(Func<T,T,bool> predelegate,T num,List<T>list)
         {
            for (int i = 0; i < list.Count; i++) 
                if (predelegate(list[i],num)) return true;
            return false;
        }
        #endregion
        
        #region Find
        T Find<T>(Func<T,T,bool>funcdelegate,T num,List<T>list)
        {
            for (int i = 0; i < list.Count; i++)
                if (funcdelegate(list[i],num)) return list[i];
            return default;
        }

        #endregion
        
        #region FindAll
         
        List<T> FindAll<T>(Func<T,T,bool>funcdelegate,T num,List<T>list)
        {
            List<T> List = new List<T>(); 
            for (int i = 0; i < list.Count; i++)
                if (funcdelegate(list[i],num))List.Add(list[i]);
            return List;
        }

        #endregion
        
        #region FindIndex
        int FindIndex<T>(Func<T,T,bool>funcdelegate,T num,List<T>list)
        {
            for (int i = 0; i < list.Count; i++)
                if (funcdelegate(list[i],num)) return i;
            return -1;
        }
        

        #endregion
        
        #region FindLast
        T FindLast<T>(Func<T,T,bool>funcdelegate,T num,List<T>list)
        {
            T last=default;
            for (int i = 0; i < list.Count; i++)
                if (funcdelegate(list[i],num)) last=list[i];
            return last;
        }
        #endregion

        #region FindLastIndex
        
            int FindLastIndex<T>(Func<T,T,bool>funcdelegate,T num,List<T>list)
            {
                int lastindex=-1;
                for (int i = 0; i < list.Count; i++)
                    if (funcdelegate(list[i],num)) lastindex=i;
                return lastindex;
            }

        #endregion

        #region Foreach
        // my information about foreach that you should be implement interface IEnumerable to deal with it 
        // and i will wait for the workshop to see how can i handle it 

        #endregion

        #region TrueForAll

        bool TrueForAll<T>(Func<T,T,bool>funcedelegate,T num,List<T>list)
        {
            bool lastindex = true;
            for (int i = 0; i < list.Count; i++)
                if (!funcedelegate(list[i],num))
                {
                    lastindex = false;
                    break;
                }
            return lastindex;
        }

        #endregion
        #endregion
        #endregion
    }
}