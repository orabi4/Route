﻿namespace TaskSession_P3;

class Program
{
    static void Main(string[] args)
    {
        #region part 1
        // internal class Car
        // {
        //     public int Id { get; set; } 
        //     public double Speed { get; set; } 
        //     public string Model { get; set; } 
        //     public Car()
        //     {
        //     
        //     }
        //     //Constructor overloading
        //
        //     //Constructor Chaining 
        //     //Ctor 1
        //     public Car(int id, double speed, string model)
        //     {
        //         Console.WriteLine("Constructor 1 [id , speed , model]");
        //         Id = id;
        //         Speed = speed;
        //         Model = model;
        //     }
        //     //Ctor 2
        //     public Car(int id , double speed) : this(id , speed , "BMW")
        //     {
        //         Console.WriteLine("Constructor 2 [id , speed]");
        //     }
        //     //Ctor 3
        //     public Car(int id) : this(id,1000)
        //     {
        //         Console.WriteLine("Constructor 3 [id]");
        //     }
        //     public override string ToString()
        //     {
        //         return$"Id = {Id} , Model = {Model} , Speed = {Speed}";
        //     }
        //
        // }
        

        #endregion
        
        #region part 2
        #region Q1

        // Employee employee = new Employee(5, "adel", SecurityLevel.guest, 1000, new DateTime(2004, 6, 15), (Gender)3);
        // Console.WriteLine(employee.ToString());

        #endregion
        #region Q2

        // _Q2_HiringDate hiringDate = new _Q2_HiringDate(15, 6, 2004);
        // Console.WriteLine(hiringDate.ToString());

        #endregion
        #region Q3
        _Q3_Employee[]EmpArr = new _Q3_Employee[3];
        EmpArr[0]= new _Q3_Employee(2,"adel",_SecurityLevel.DBA,50000,new DateTime(2004,6,15),(_Gender)1);
        EmpArr[1] = new _Q3_Employee(2, "omar", _SecurityLevel.SecurityOfficer, 4000, new DateTime(2004, 6, 15), (_Gender)1);
        EmpArr[2] = new _Q3_Employee(3, "Mona", _SecurityLevel.Guest ,6000, new DateTime(2000, 10, 11), (_Gender)2);
        //  foreach (var emp in EmpArr)
        //  {
        //      Console.WriteLine(emp.ToString());
        //  }
        //  {
        //      
        //  }
        #endregion
        #region Q4
        
        // int boxingCount = 0;
        // int unboxingCount = 0;
        //
        // for (int i = 0; i < EmpArr.Length - 1; i++)
        // {
        //     for (int j = 0; j < EmpArr.Length - i - 1; j++)
        //     {
        //         boxingCount++;
        //         if (EmpArr[j].GetHireDate() > EmpArr[j + 1].GetHireDate())
        //         {
        //             _Q3_Employee temp = EmpArr[j];
        //             EmpArr[j] = EmpArr[j + 1];
        //             EmpArr[j + 1] = temp;
        //         }
        //     }
        // }
        //
        // Console.WriteLine("Employees sorted by Hire Date:");
        // foreach (var i in EmpArr)
        // {
        //     Console.WriteLine(i);
        //     Console.WriteLine();
        // }
        //
        // Console.WriteLine($"Number of Boxing operations: {boxingCount}");
        // Console.WriteLine($"Number of Unboxing operations: {unboxingCount}");

        #endregion
        #endregion
    
    }
}