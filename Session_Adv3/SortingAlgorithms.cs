namespace TaskSession_Adv3;

public class SortingAlgorithms<T>
{
    #region Example2
    // public static void Bubblesort(int[] array, CompareFuncDelegate compare)
    // {
    //     for (int i = 0; i < array.Length; i++)
    //     {
    //         for (int j = 0; j < array.Length - i - 1; j++)
    //         {
    //             if (compare.Invoke(array[j],array[j+1]))
    //                 swap(ref array[j],ref array[j + 1]);
    //         }
    //     }
    // }
    //
    // static void swap(ref int j1, ref int j2)
    // {
    //     int temp = j1;
    //     j1 = j2;
    //     j2 = temp;
    // }
    
    #endregion
    #region Example3
    public static void Bubblesort(T[] array, CompareFuncDelegateGenraic<T,bool> compare)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (compare.Invoke(array[j],array[j+1]))
                    swap(ref array[j],ref array[j + 1]);
            }
        }
    }

    static void swap(ref T j1, ref T j2)
    {
        T temp = j1;
        j1 = j2;
        j2 = temp;
    }

    public static bool CompareGreaterThan(int x,int y)
    {
        return x > y;
    }
    public static bool CompareLowerThan(int x,int y)
    {
        return x < y;
    }
    public static bool CompareStringGreater(string x, string y)
    {
        return x?.Length>y?.Length;
    }
    public static bool CompareStringLower(string x, string y)
    {
        return x?.Length<y?.Length;
    }
    #endregion
}