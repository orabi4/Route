namespace TaskSession_P3;

    public enum Gender
    {
        M,
        F
    }
    public enum SecurityLevel
    {
        guest,
        Developer,
        secretary,
        DBA
    }

    public class Employee
    {
        private int Id { get; set; }
        private string Name { get; set; }
        SecurityLevel SecurityLevel { get; set; }
        private decimal Salary { get; set; }
        DateTime HireDate { get; set; }
        Gender Gender { get; set; }

        public Employee(int id, string name, SecurityLevel securityLevel, decimal salary, DateTime hireDate,
            Gender gender)
        {
            Id = id;
            Name = name;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate;
            if (gender == (Gender)1 || gender == (Gender)2) Gender = gender;
            else Console.WriteLine("Please Enter an invalid gender M or F");
        }

        public override string ToString()
        {
            return
                $"ID: {Id}\n Name: {Name}\n SecruityLevel: {SecurityLevel}\n Salary: {Salary}\n HireDate: {HireDate}\n Gender: {Gender}";
        }
    }

