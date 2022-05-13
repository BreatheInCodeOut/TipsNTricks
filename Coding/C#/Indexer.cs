using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* C# : Indexers - Allows instances of class or struct to be indexed just like arrays. 
The indexed value can be set or retrieved without explicitly specifying a type or instance member */
class Employee
{
    public int EmployeeId { get; set; }
    public string EmployeeName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public DateTime DateOfJoin { get; set; }
}

class Employer
{
    public int EmployerId { get; set; }
    public string EmployerName { get; set; }
    public List<Employee> Employees { get; set; }
    //Indexer {Syntax AccessModifier ReturnType this[type variableName]}
    //Indexers resemble properties except accessors take parameters
    public Employee this[int employeeId]
    {
        get => this.Employees.FirstOrDefault(e => e.EmployeeId == employeeId);
        set 
        {
            Employee emp = this.Employees.FirstOrDefault(e => e.EmployeeId == employeeId);
            int index = this.Employees.IndexOf(emp);
            this.Employees[index] = value;
        }//value assigned through indexer
    }
}

class Consumer
{
    Employer _employer;
    public Consumer()
    {
            _employer = new Employer()
            {
                EmployerId = 1,
                EmployerName = "XYZ",
                Employees = new List<Employee>
                {
                    new Employee() {EmployeeId = 10, EmployeeName = "Steve", DateOfJoin = new DateTime(2009, 12 ,1 ), DateOfBirth = new DateTime(1984, 12, 1)},
                    new Employee() {EmployeeId = 20, EmployeeName = "Michele", DateOfJoin = new DateTime(2019, 1 ,12 ), DateOfBirth = new DateTime(2000, 2, 2)}
                }
            };
    }

    public void ShowEmployeeDetails(int employeeId)
    {
        Employee employee = _employer[employeeId];//Get
        Console.WriteLine(String.Format("{0} - {1}", employee.EmployeeId, employee.EmployeeName));
        //Set
        _employer[20] = new Employee() { EmployeeId = 20, EmployeeName = "Mitch", DateOfJoin = new DateTime(2019, 2, 12), DateOfBirth = new DateTime(2000, 2, 2) };
        Employee employee1 = _employer[20];
        Console.WriteLine(String.Format("{0} - {1}", employee1.EmployeeId, employee1.EmployeeName));
    }
}

/*
Consumer objConsumer = new Consumer();
objConsumer.ShowEmployeeDetails(10);

OUTPUT:
10 - Steve
20 - Mitch
*/