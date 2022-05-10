using System;

public class Employee
{
	public float Salary { get; set; }
	public Address? address { get; set; }

}

public class Address
{
	public string State { get; set; }
}

public static class AccessClassProps
{

    public static void Shortened()
    {
        float? empSalary;
        string? empState;
        Employee employee = new Employee();

        employee.Salary = 25000;
        employee.address = new Address() { State = "TN" };

        //if (employee != null)
        //{
        //    empSalary = employee.Salary;

        //    if (employee.address != null)
        //    {
        //        empState = employee?.address?.State;

        //        Console.WriteLine(empSalary);
        //        Console.WriteLine(empState);
        //    }
        //}
        
        //Shortened Way
        empSalary = employee?.Salary;
        empState = employee?.address?.State;
        Console.WriteLine(empSalary);
        Console.WriteLine(empState);

        Console.WriteLine("ShortEnd");

    }

}