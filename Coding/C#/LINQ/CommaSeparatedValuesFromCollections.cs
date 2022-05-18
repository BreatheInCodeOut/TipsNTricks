using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}

class Consumer
{
    Employer _employer;
    List<Employer> _employers;
    public Consumer()
    {

        _employers = new List<Employer>() {
            new Employer()
            {
                EmployerId = 1,
                EmployerName = "XYZ",
                Employees = new List<Employee>
                {
                    new Employee() {EmployeeId = 10, EmployeeName = "Steve", DateOfJoin = new DateTime(2009, 12 ,1 ), DateOfBirth = new DateTime(1984, 12, 1)},
                    new Employee() {EmployeeId = 20, EmployeeName = "Michele", DateOfJoin = new DateTime(2019, 1 ,12 ), DateOfBirth = new DateTime(2000, 2, 2)}
                }
            },
            new Employer()
            {
                EmployerId = 2,
                EmployerName = "ABC",
                Employees = new List<Employee>
                {
                    new Employee() {EmployeeId = 2010, EmployeeName = "Christina", DateOfJoin = new DateTime(2020, 03 , 20 ), DateOfBirth = new DateTime(1999, 12, 31)},
                    new Employee() {EmployeeId = 1020, EmployeeName = "Jackson", DateOfJoin = new DateTime(2010, 2 ,15 ), DateOfBirth = new DateTime(1980, 5, 25)}
                }
            }
        };

        _employer = _employers[0];
        //Comma Separated using LINQ
        Console.WriteLine(string.Join(", ", _employer.Employees.Select(e => e.EmployeeId + "-" + e.EmployeeName)));
        Console.WriteLine(string.Join(", ", _employers.SelectMany(er => er.Employees.Select(e => er.EmployerName + "::" + e.EmployeeId + "_" + e.EmployeeName))));

        /*
        10-Steve, 20-Michele
        XYZ::10_Steve, XYZ::20_Michele, ABC::2010_Christina, ABC::1020_Jackson
        */
    }
}