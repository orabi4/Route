namespace TaskSession_P3;

    public enum _Gender
    {
        M,
        F
    }
    public enum _SecurityLevel
    {
        Guest,
        SecurityOfficer,
        DBA
    }

    public class _Q3_Employee
    {
        private int Id { get; set; }
        private string Name { get; set; }
        _SecurityLevel SecurityLevel { get; set; }
        private decimal Salary { get; set; }
        DateTime HireDate { get; set; }
        _Gender Gender { get; set; }

        public _Q3_Employee(int id, string name, _SecurityLevel securityLevel, decimal salary, DateTime hireDate,_Gender gender)
        {
            Id = id;
            Name = name;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate;
            if (gender == (_Gender)1 || gender == (_Gender)2) Gender = gender;
            else Console.WriteLine("Please Enter an invalid gender M or F");
        }

        public override string ToString()
        {
            return
                $"ID: {Id}\n Name: {Name}\n SecruityLevel: {SecurityLevel}\n Salary: {Salary}\n HireDate: {HireDate}\n Gender: {Gender}";
        }

        public DateTime GetHireDate()
        {
            return HireDate;
        }
    }