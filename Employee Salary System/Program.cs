/* Employee Salary System
 * Define an abstract Employee class with fields like name & salary
 * Add an abstract method CalculateBonus()
 * Create subclasses for Manager and developer 
 * and implement the bonus calculation logic */

using System;
using System.Reflection.Emit;

// abstract Employee
public abstract class Employee
{

    public string Name { get; set; }
    public decimal Salary { get; set; }

    //constructor
    public Employee (string name, decimal salary)
    {
        Name = name;
        Salary = salary;
    }

    //abstract method to calculate bonus
    public abstract decimal CalculateBonus();
}

public class Manager : Employee
{
    //constructor to initialize manager specific details
    public Manager(string name, decimal salary) : base(name, salary) { }

    //implementing the calculatebonus method for manager
    public override decimal CalculateBonus()
    {
        //bonus calculation: 10% of the salary for manager
        return Salary * 0.10m;
    }
}

public class Developer : Employee
{
    //construcotr to initalize developer specific details
    public Developer(string name, decimal salary): base(name, salary) { }

    //implementing the calculatebonus method for developer
    public override decimal CalculateBonus()
    {
        // bonus calculation: 5% of the salary for developer
        return Salary * 0.05m;
    }
}

class Program
{
    static void Main()
    {
        //creating manager and developer objects
        Employee manager = new Manager("Peter", 100000);
        Employee developer = new Developer("Vele", 56000);

        //displaying the bonus for each employee
        Console.WriteLine($"{manager.Name}'s Bonus: {manager.CalculateBonus():C}");
        Console.WriteLine($"{developer.Name}'s Bonus: {developer.CalculateBonus():C}");
  

    }
}