using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace TaskSessionAdv_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //optimization: in any path that no happen swap in it this mean all element in the correct places
            //              so you will make return and end the  For loop 
            int[] arr = { 1,2,4,3 };
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    bool flag = false;
            //    for(int j = 0; j <arr.Length-i - 1; j++)
            //    {
            //        if (arr[j].CompareTo(arr[j+1])==1)
            //        {
            //            Helper.swap<int>(ref arr[j],ref arr[j+1]);
            //            flag = true;
            //        }
            //    }
            //    if (!flag) return; // this for optimization 
            //}

            #endregion
            #region Q2
            //Range<int> range = new Range<int>(100,50);
            //Console.WriteLine(range.IsRange(30));
            //Console.WriteLine(range.Lenth());
            #endregion
            #region Q3
            //int[]Arr = { 1,2,4,5 };
            //Helper.ArrList(ref Arr);

            #endregion
            #region Q4
            //int[]Arr= {1,2,3,4};
            //List<int> ArrList = Helper.EvenList(ref Arr);
            //foreach(var i in ArrList)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #region Q5
            //FixedSizeList<int> fixedSizeList = new FixedSizeList<int>(5);
            //fixedSizeList.Add(1);
            //fixedSizeList.Add(2);
            //Console.WriteLine(fixedSizeList.Get(1));
            #endregion
            #region Q6
            string s = Console.ReadLine();
            Dictionary<char,int> dic = new Dictionary<char,int>();
            foreach (char i in s)
            {
                if(dic.ContainsKey(i)) dic[i]++;
                else dic[i] = 1;
            }
            bool flag = false;
            foreach(char i in s)
            {
                if (dic[i] == 1) {
                    Console.WriteLine(s.IndexOf(i));
                    flag = true;
                    break;
                }
            }
            if (!flag) Console.WriteLine(-1);

            #endregion
        }
    }
}
