namespace TaskSession_Adv3;

public static class FunctionForPart03
{
    public static bool CheckExistElementInt(int num1,int num2) => num1 == num2;
    public static bool CheckExistElementString(string num1,string num2) => num1 == num2;
    public static bool CompareElementIntGreater(int num1,int num2) => num1 > num2;
    public static bool CompareElementStringGreater(string num1,string num2) => num1.Length > num2.Length;
    public static bool TrueForAll(int num1,int num2) => num1==num2;
    public static bool TrueForAll(string num1,string num2) => num1==num2;
}