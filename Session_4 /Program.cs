using System;
namespace TaskSession3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 
            //int number = int.Parse(Console.ReadLine());
            //if (number % 3 == 0 && number % 4 == 0) Console.WriteLine("Yes");
            //else Console.WriteLine("No");
            #endregion
            #region Q2 
            //int number = int.Parse(Console.ReadLine());
            //if (number < 0) Console.WriteLine("negative");
            //else if (number > 0) Console.WriteLine("positive");    
            #endregion
            #region Q3
               // int number1,number2,number3;
               // number1 = int.Parse(Console.ReadLine());
               // number2 = int.Parse(Console.ReadLine());
               // number3 = int.Parse(Console.ReadLine());
               // Console.WriteLine($"The Max Number is: {Math.Max(number1, Math.Max(number2, number3))}");
               // Console.WriteLine($"The Min Number is: {Math.Min(number1, Math.Min(number2, number3))}");
               #endregion
            #region Q4
            // int number=int.Parse(Console.ReadLine());
            // if(number%2==0)Console.WriteLine("even");
            // else Console.WriteLine("odd");
            #endregion
            #region Q5
            // char c=char.Parse(Console.ReadLine());
            // if(c=='a'||c=='e'||c=='i'||c=='o'||c=='u')Console.WriteLine("vowel");
            // else Console.WriteLine("consonant");
            #endregion
            #region Q6
            // int number=int.Parse(Console.ReadLine());
            // for(int i=1;i<=number;i++)Console.WriteLine(i);
            #endregion
            #region Q7
            // int number=int.Parse(Console.ReadLine());
            // int counter = 0;
            // int i = number;
            // while (counter != 12)
            // {
            //     if (i % number == 0)
            //     {
            //         counter++;
            //         Console.WriteLine($"{i} ");
            //     }
            //     i++;
            // }

            #endregion
            #region Q8
            // int number=int.Parse(Console.ReadLine());
            // for (int i = 1; i <= number; i++)
            // {
            //     if(i%2==0)Console.WriteLine(i);
            // }
            #endregion
            #region Q9

            // int number1, number2;
            // number1=int.Parse(Console.ReadLine());
            // number2=int.Parse(Console.ReadLine());
            // Console.WriteLine(Math.Pow(number1,number2));

            #endregion
            #region Q10
            // int []arr=new int[5];
            // int TotalMarks = 0;
            // for (int i = 0; i < 5; i++)
            // {
            //     arr[i]=int.Parse(Console.ReadLine());
            //     TotalMarks+=arr[i];
            // }
            // double AverageMarks = (double)TotalMarks/5;
            // double Percentage = (double)TotalMarks / (5 * 100) * 100;
            // Console.WriteLine($"Total Marks: {TotalMarks}");
            // Console.WriteLine($"Average Marks: {AverageMarks}");
            // Console.WriteLine($"Percentage: {Percentage}");
            #endregion
            #region Q11
            // int month=int.Parse(Console.ReadLine());
            // if(month==1||month==3||month==5||month==7||month==8||month==10||month==12)
            //     Console.WriteLine(31);
            // else if (month==4 || month==6 || month==9 || month==11)
            //     Console.WriteLine(30);
            // else Console.WriteLine(29); // in month 2 the days can be 28 or 29
            #endregion
            #region Q12

            // int number1, number2;
            // Console.Write("Enter the first number: ");
            // number1 =int.Parse(Console.ReadLine());
            // Console.Write("Enter the second number: ");
            // number2 = int.Parse(Console.ReadLine());
            // Console.Write("Enter the operation you want to perform: (+,-,*,/) ");
            // char c=char.Parse(Console.ReadLine());
            // if (c=='+')Console.WriteLine($"the sum of two numbers is: {number1 + number2}");
            // else if(c=='-')Console.WriteLine($"the substract of two numbers is: {number1 - number2}");
            // else if(c=='*')Console.WriteLine($"the multiply of two numbers is: {number1 * number2}");
            // else if(c=='/')Console.WriteLine($"the divide two numbers is: {number1 / number2}");

            #endregion
            #region Q13

            // string s = Console.ReadLine();
            // for(int i=s.Length-1;i>=0;i--)Console.Write(s[i]);

            #endregion
            #region Q14

            // string s=Console.ReadLine();
            // for(int i=s.Length-1;i>=0;i--)Console.Write(s[i]);

            #endregion
            #region Q15

            // bool PrimeNumber(int number)
            // {
            //     if(number < 2)return false;
            //     for (int i = 2; i<=Math.Sqrt(number) ; i++)
            //     {
            //         if (number % i == 0)
            //         {
            //             return false;
            //         }
            //     }
            //     return true;
            // }
            //
            // int start = int.Parse(Console.ReadLine());
            // int end = int.Parse(Console.ReadLine());
            // for (int i = start; i <= end; i++)
            // {
            //     if(PrimeNumber(i))Console.WriteLine(i);
            // }
            #endregion
            #region Q16
            // int number=int.Parse(Console.ReadLine());
            // string s=Convert.ToString(number,2);
            // Console.WriteLine($"binary is: {s}");
            #endregion
            #region Q17
            //
            // int x1, y1, x2, y2, x3, y3;
            // x1=int.Parse(Console.ReadLine());
            // y1=int.Parse(Console.ReadLine());
            // x2=int.Parse(Console.ReadLine());
            // y2=int.Parse(Console.ReadLine());
            // x3=int.Parse(Console.ReadLine());
            // y3=int.Parse(Console.ReadLine());
            // double area = 0.5 * Math.Abs( ( x1 * (y2 - y3) ) + ( x2 * (y3 - y1) ) + ( x3 * (y1 - y2) ) );
            // if (area == 0) Console.WriteLine("yes, the points on the straight line");
            // else Console.WriteLine("no");
            #endregion
            #region Q18
            // double time =int.Parse(Console.ReadLine());
            // if (time>=2&&time<=3)Console.WriteLine("highly efficient");
            // else if(time>3&&time<=4)Console.WriteLine("increase your speed");
            // else if(time>4&&time<=5)Console.WriteLine("provided with training to enhance your speed");
            // else if(time>5)Console.WriteLine(" required to leave the company");
            #endregion
            #region Q19

            // int n=int.Parse(Console.ReadLine());
            // for (int i = 0; i < n; i++)
            // {
            //     for (int j = 0; j < n; j++)
            //     {
            //         if (i == j)
            //             Console.Write("1 ");
            //         else
            //             Console.Write("0 ");
            //     }
            //     Console.WriteLine(); 
            // }

            #endregion
            #region Q20
            // int []arr=new int[]{1,2,3,4,5,6};
            // Console.WriteLine(arr.Sum());
            #endregion
            #region Q21
            // int []arr=new int[]{1,2,3};
            // int []arr2=new int[]{4,5,6};
            // int[] mer_arr = new int[6];
            // for (int i = 0; i < 3; i++)
            // {
            //     mer_arr[i] = arr[i];
            //     mer_arr[i+3]=arr2[i];
            // }
            //
            // for (int i = 0; i < mer_arr.Length; i++)
            // {
            //     Console.Write($"{mer_arr[i]} ");
            // }

            #endregion
            #region Q22 
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //for (int i = 0; i < n; i++) arr[i] = int.Parse(Console.ReadLine());
            //bool[] flag = new bool[n];
            //Console.WriteLine("Frequency of each element:");
            //for (int i = 0; i < n; i++)
            //{
            //    if (!flag[i])
            //    {
            //        int counter = 1;
            //        for (int j = i + 1; j < n; j++)
            //        {
            //            if (arr[i] == arr[j])
            //            {
            //                counter++;
            //                flag[j] = true;
            //            }
            //        }
            //        Console.WriteLine($"Element {arr[i]} appears {counter} time(s).");
            //    }
            //}
            #endregion
            #region Q23 
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //for (int i = 0; i < n; i++) arr[i] = int.Parse(Console.ReadLine());

            //int maxx = arr.Max();
            //int minn = arr.Min();
            //Console.WriteLine($"Maximum element in the array is : {maxx}");
            //Console.WriteLine($"Minimum element in the array is : {minn}");
            #endregion
            #region Q24 
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //for (int i = 0; i < n; i++) arr[i] = int.Parse(Console.ReadLine());
            //Array.Sort(arr);
            //int SecondMax = arr[arr.Length - 2];
            //Console.WriteLine(SecondMax);
            #endregion
            #region Q25 
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //for (int i=0; i<n; i++) arr[i] = int.Parse(Console.ReadLine());
            //int maxx = 0;
            //for (int i=0; i<n; i++)
            //{
            //    for (int j=0; j<n; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            int x = j - i; // distance 
            //            maxx = Math.Max(maxx, x);
            //        }
            //    }
            //}
            //Console.WriteLine($"The longest distance is : {maxx}");
            #endregion
            #region Q26 
            //string s = Console.ReadLine();
            //string[] arr = s.Split(' ');
            //Array.Reverse(arr);
            //string s2 = string.Join(" ", arr);
            //Console.WriteLine($"the reversed string is ({s2})");
            #endregion
            #region Q27 
            //int row = int.Parse(Console.ReadLine());
            //int col = int.Parse(Console.ReadLine());

            //int[,] arr1 = new int[row, col];
            //int[,] arr2 = new int[row, col];

            //for (int i = 0; i< row; i++)
            //{
            //    for (int j = 0; j<col; j++)
            //    {
            //        arr1[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < row; i++)
            //{
            //    for (int j = 0; j < col; j++)
            //    {
            //        arr2[i, j] = arr1[i, j];
            //    }
            //}
            //for (int i = 0; i < row; i++)
            //{
            //    for (int j = 0; j < col; j++)
            //    {
            //        Console.WriteLine($"{arr1[i, j]} ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region Q28 
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //for (int i = 0; i < n; i++) arr[i] = int.Parse(Console.ReadLine());
            //Array.Reverse(arr);
            //for (int i = 0; i < n; i++) Console.Write($"{arr[i]} ");
            #endregion
        }
    }
}
