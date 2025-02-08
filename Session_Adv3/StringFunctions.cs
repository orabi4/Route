using System.Diagnostics.Metrics;

namespace TaskSession_Adv3;

public class StringFunctions
{
    public static int CountUpperChar(string s)
    {
        int counter = 0;
        if (s is not null)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsUpper(s[i])) counter++;
            }
            
        }

        return counter;
    }
    public static int CountLowerChar(string s)
    {
        int counter = 0;
        if (s is not null)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLower(s[i])) counter++;
            }
            
        }

        return counter;
    }
}