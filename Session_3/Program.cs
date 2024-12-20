using System;
namespace TaskSession3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            // Console.WriteLine("Enter you number ");
            // int number = int.Parse(Console.ReadLine());
            // Console.WriteLine(number);
            #endregion
            #region Q2
            // string s = "adel";
            // int number =int.Parse(s);
            // Console.WriteLine(number);
            // // it will give me exeption because i can't convert string of words to a numeric int 
            #endregion
            #region Q3
            // Console.WriteLine("Enter the first number");
            // float num1 = float.Parse(Console.ReadLine());
            // Console.WriteLine("Enter the second number");
            // float num2 = float.Parse(Console.ReadLine());
            // float sum = num1 + num2;
            // Console.WriteLine($"The sum of {num1} and {num2} is: {sum}");
            #endregion
            #region Q4
            // Console.WriteLine("Enter the string");
            // string s = Console.ReadLine();
            // Console.WriteLine("Enter the start position");
            // int start = int.Parse(Console.ReadLine());
            // Console.WriteLine("Enter the length of substring");
            // int len = int.Parse(Console.ReadLine());
            // string sub = s.Substring(start, len);
            // Console.WriteLine($"The substring is: {sub}");
            #endregion
            #region Q5

            // int x = 6, y;
            // y = x;
            // Console.WriteLine(y);
            // y++;
            // Console.WriteLine(y);
            // Console.WriteLine(x);
            // // when i modifey on y the value of it increase by 1 and the value of is still const
            // // because every one has a different address in stack 

            #endregion
            #region Q6

           //  string s1 = "adel", s2;
           //  s2 = s1;
           //  Console.WriteLine(s2);
           //  s2 = "mohamed";
           //  Console.WriteLine(s2);
           //  Console.WriteLine(s1);
           // // because string is a reference type that mean the two string s1,s2 reference to the same
           // // hashcode in the heap and when i make update on s2, it mean that s1 already updated also 
            #endregion
            #region Q7
            // string s1=Console.ReadLine(),s2=Console.ReadLine();
            // Console.WriteLine(s1+" "+s2);
            #endregion
            #region Q8

            // Console.WriteLine("Enter the principal amount");
            // double principal_amount=double.Parse(Console.ReadLine());
            // Console.WriteLine("Enter the rate of interest");
            // double rate_of_interest = double.Parse(Console.ReadLine());
            // Console.WriteLine("Enter the time");
            // double time = double.Parse(Console.ReadLine());
            // Console.WriteLine($"The simple interest is: {(principal_amount*rate_of_interest*time)/100}");

            #endregion
            #region Q9
            // double Weight = double.Parse(Console.ReadLine());
            // double Height = double.Parse(Console.ReadLine());
            // double BMI = Weight / (Height*Height);
            // Console.WriteLine($"The Body Mass Index is: {BMI}");
            #endregion
            #region Q10
            // Console.WriteLine("Enter the temperature");
            // int temperature = int.Parse(Console.ReadLine());
            // string result;
            // if (temperature < 10) result = "Just Cold";
            // else if (temperature > 30)  result = "Just Hot";
            // else result = "Just Good";
            // Console.WriteLine($"The temperature is: {result}");
            #endregion
            #region Q11
            // Console.WriteLine("Enter the date");
            // string input = Console.ReadLine();
            // DateTime date = Convert.ToDateTime(input);
            // Console.WriteLine($"Today’s date: {date:dd, MM, yyyy}");
            // Console.WriteLine($"Today’s date: {date:dd / MM / yyyy}");
            // Console.WriteLine($"Today’s date: {date:dd – MM – yyyy}");
            #endregion
            #region Q12
             // the answer is 'c'
            #endregion
            #region Q13
            // the answer is 'f'
            #endregion
            #region Q14
             // the answer is 'd'
            #endregion
            #region Q15
             // the answer is 'd'
            #endregion
        }
    }
}