using System.Collections;

namespace TaskSession_Adv2;

class Program
{
    static void Main(string[] args)
    {
        #region Q1
        // int Size=int.Parse(Console.ReadLine());
        // int Queries=int.Parse(Console.ReadLine());
        // int []arr=new int[Size];
        // for (int i = 0; i < Size; i++)
        // {
        //     arr[i] = int.Parse(Console.ReadLine());
        // }
        //  Array.Sort(arr);
        // while (Queries>0)
        // {
        //     int counter = 0;
        //     int Number=int.Parse(Console.ReadLine());
        //     int Index = Array.BinarySearch(arr, Number);
        //     if(Index>=0) Console.WriteLine(Size-(Index+1));
        //     else Console.WriteLine(0);
        //     Queries--;
        // }

        #endregion
        #region Q2
        // int Size=int.Parse(Console.ReadLine());
        // int []arr=new int[Size];
        // for (int i = 0; i < Size; i++)
        // {
        //     arr[i] = int.Parse(Console.ReadLine());
        // }
        // bool flag=false;
        // for (int i = 0, j = Size - 1; i < j; i++, j--)
        // {
        //     if (arr[i] != arr[j])
        //     {
        //         flag = true;
        //         break;
        //     }
        // }
        // if(flag) Console.WriteLine("NO");
        // else Console.WriteLine("YES");
        
        #endregion
        #region Q3
        // int Size=int.Parse(Console.ReadLine());
        // Queue<int> q1 = new Queue<int>();
        // for (int i = 0; i < Size; i++)
        // {
        //     q1.Enqueue(int.Parse(Console.ReadLine()));
        // }
        //
        // Stack<int> Reverse(Queue<int> q)
        // {
        //     Stack<int> stack = new Stack<int>();
        //     while(q.Count > 0)
        //     {
        //         stack.Push(q.Dequeue());
        //     }
        //
        //     return stack;
        // }
        //
        // Stack<int> stack=Reverse(q1);
        // while (stack.Count > 0)
        // {
        //     Console.WriteLine(stack.Pop());
        // }
        

        #endregion
        #region Q4
        //  string s=Console.ReadLine();
        // bool CheckBarenthesesIsBalanced(string s)
        // {
        //     Stack<char> stack = new Stack<char>();
        //     foreach (char c in s)
        //     {
        //         if(c=='('||c=='{'||c=='[')stack.Push(c);
        //         else
        //         {
        //             if(stack.Count==0 ||stack.Peek()=='('&&c!=')'||stack.Peek()=='['&&c!=']'||stack.Peek()=='{'&&c!='}') return false;
        //             stack.Pop();
        //         }
        //     }
        //     if(stack.Count>0) return false;
        //     return true;
        // }
        // Console.WriteLine(CheckBarenthesesIsBalanced(s));
        #endregion
        #region Q5
        // int Size=int.Parse(Console.ReadLine());
        // HashSet<int> Numbers = new HashSet<int>();
        // for (int i = 0; i < Size; i++)
        // {
        //     Numbers.Add(int.Parse(Console.ReadLine()));
        // }
        //
        // foreach (int number in Numbers)
        // {
        //     Console.WriteLine(number);
        // }
        
        #endregion
        #region Q6
        // int Size=int.Parse(Console.ReadLine());
        // List<int> List=new List<int>();
        // for (int i = 0; i < Size; i++)
        // {
        //     List.Add(int.Parse(Console.ReadLine()));
        // }
        //
        // void RemoveOddNumbers(ref List<int> list)
        // {
        //     for (int i = list.Count-1; i>=0; i--)
        //     {
        //         if (list[i] % 2 != 0) list.Remove (list[i]);
        //     }
        // }
        // RemoveOddNumbers(ref List);
        // foreach(int i in List) Console.WriteLine(i);
        #endregion
        #region Q7
        // Queue q = new Queue();
        // q.Enqueue(1);
        // q.Enqueue("Apple");
        // q.Enqueue(5.28);
        #endregion
        #region Q8
        // int Size=int.Parse(Console.ReadLine());
        // int []SeriesOfIntegers=new int[Size];
        // for (int i = 0; i < Size; i++)
        // {
        //     SeriesOfIntegers[i] = int.Parse(Console.ReadLine());
        // }
        //
        // Console.WriteLine("Enter The Target Please");
        // int Target=int.Parse(Console.ReadLine());
        //
        // void SearchForTarget(int[] arr)
        // {
        //     Stack<int> stack=new Stack<int>();
        //     foreach (int i in arr)
        //     {
        //         stack.Push(i);
        //     }
        //
        //     int counter = 0;
        //     bool flag = false;
        //     while (stack.Count > 0)
        //     {
        //         if (stack.Pop() == Target)
        //         {
        //             flag=true;
        //             break;
        //         }
        //
        //         counter++;
        //     }
        //
        //     if (flag) Console.WriteLine($"Target was found successfully and the count ={counter}");
        //     else Console.WriteLine("Target was not found");
        // }
        // SearchForTarget(SeriesOfIntegers);

        #endregion
        #region Q9
        // int Size1=int.Parse(Console.ReadLine());
        // int Size2=int.Parse(Console.ReadLine());
        // List<int> numbers1 = new List<int>();
        // for (int i = 0; i < Size1; i++)
        // {
        //     numbers1.Add(int.Parse(Console.ReadLine()));
        // }
        // List<int> numbers2 = new List<int>();
        // for (int i = 0; i < Size2; i++)
        // {
        //     numbers2.Add(int.Parse(Console.ReadLine()));
        // }
        //
        // Console.WriteLine($"[{string.Join(", ",numbers1.Intersect(numbers2))}]");
        
        
        #endregion
        #region Q10

        // int Size=int.Parse(Console.ReadLine());
        // List<int> list=new List<int>();
        // for (int i = 0; i < Size; i++)
        // {
        //     list.Add(int.Parse(Console.ReadLine()));
        // }
        // int target=int.Parse(Console.ReadLine());
        // int sum = 0, l = 0;
        // bool flag = false;
        // for (int r = 0; r < list.Count; r++)
        // {
        //     sum += list[r];
        //     while (sum > target && l <= r)
        //     {
        //         sum -= list[l];
        //         l++;
        //     }
        //
        //     if (sum == target)
        //     {
        //         flag = true;
        //         break;
        //     }
        // }
        // if(flag) Console.WriteLine("YES");
        // else Console.WriteLine("NO");

        #endregion
        #region Q11
        // int Size=int.Parse(Console.ReadLine());
        // Queue<int> q1 = new Queue<int>();
        // for (int i = 0; i < Size; i++)
        // {
        //     q1.Enqueue(int.Parse(Console.ReadLine()));
        // }
        // int K=int.Parse(Console.ReadLine());
        // Stack<int> stack=new Stack<int>();
        // for(int i=0;i<K;i++)stack.Push(q1.Dequeue());
        // foreach(int i in stack) Console.WriteLine(i);
        // foreach (int i in q1) Console.WriteLine(i);
        #endregion
    }
}