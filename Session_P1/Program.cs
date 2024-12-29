namespace TaskSession_P1;
#region Example for part 1
enum Permissions:byte
{
    Read=1, 
    write=2, 
    Delete=4, 
    Execute=8
}
#endregion
#region part2
  #region Q1

enum WeekDays
{
    monday,
    tuesday,
    wednesday,
    thursday,
    friday,
    saturday,
    sunday
}
#endregion
  #region Q2
  enum Seas_on
  {
      Spring, 
      Summer, 
      Autumn, 
      Winter
  }
  #endregion
  #region Q3
 [Flags]
  enum permissions:byte
  {
      Read=1, 
      write=2, 
      Delete=4, 
      Execute=8
  }
  #endregion
  #region Q4

  enum Colors
  {
      Red, 
      Green, 
      Blue
  }
  #endregion

#endregion
class Program
{
    static void Main(string[] args)
    {
      #region part1
      //   Permissions p = new Permissions();
      //   p = (Permissions)15;
      //   Console.WriteLine(p);
      // p ^= Permissions.Delete; // will delete 'permission delete' from variable 'p' using 'xor'
      // Console.WriteLine(p);
      // p |= Permissions.Delete; // will add permission delete using 'or' 
      // Console.WriteLine(p);
      // if((p & Permissions.Delete)==Permissions.Delete) Console.WriteLine("the permission is already exist"); // to check if the permission is exist or not 
      // else p^= Permissions.Delete;
      #endregion
      #region executed part2
      #region Q1
      // WeekDays w = new WeekDays();
      // Console.WriteLine(w);
      // foreach (var i in Enum.GetValues(typeof(WeekDays)))
      // {
      //     Console.WriteLine(i);
      // }
      #endregion
      #region Q2
      // Seas_on s = new Seas_on();
      // s=(Seas_on)Enum.Parse(typeof(Seas_on), Console.ReadLine());
      // if(s==(Seas_on)1)Console.WriteLine("march to may");
      // else if(s==(Seas_on)2)Console.WriteLine("june to august");
      // else if(s==(Seas_on)3)Console.WriteLine("September to November");
      // else if(s==(Seas_on)4) Console.WriteLine("December to February");
      #endregion
      #region Q3
    //   permissions p = new permissions();
    //   p = (permissions)15;
    //   Console.WriteLine(p);
    // p ^= permissions.Delete; // will delete 'permission delete' from variable 'p' using 'xor'
    // Console.WriteLine(p);
    // p |= permissions.Delete; // will add permission delete using 'or' 
    // Console.WriteLine(p);
    // if((p & permissions.Delete)==permissions.Delete) Console.WriteLine("the permission is already exist"); // to check if the permission is exist or not 
    // else p^= permissions.Delete;
    


    #endregion
      #region Q4

    // Colors c = new Colors();
    // c = (Colors)Enum.Parse(typeof(Colors), Console.ReadLine());
    // if(c==(Colors)1||c==(Colors)2||c==(Colors)3)Console.WriteLine("Yes, it's primary color");
    // else Console.WriteLine("No, it not a primary color");

    #endregion


    #endregion.
    }
}