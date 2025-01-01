namespace TaskSession_P2;

public struct St_Person
{
    #region Attributes
    private string name;
    private int age;
    #endregion
    #region Methods
    
    public St_Person(string Name, int Age)
    {
        name = Name;
        age = Age;
    }

    public int Age
    {
        get { return age; }
    }
    public string DisplayData
    {
        get { return $"Name: {name}, Age: {age}"; }
    }
    
    #endregion
    
    
    
}