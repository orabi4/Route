using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSessionAdv_1
{
    internal class Helper
    {
        public static void swap<T>(ref T x,ref T y )
        {
            T temp = y;
            x = y;
            y = temp;
        }
        public static void ArrList(ref int []arr )
        {
            for(int i=arr.Length-1;i>=0;i--) Console.WriteLine(arr[i]);
        }
        public static List<int> EvenList(ref int[] arr)
        {
            List<int> ReturnedList = new List<int>();
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i]%2==0 )ReturnedList.Add(arr[i]);
            }
            return ReturnedList;
        }
      
    }
}
