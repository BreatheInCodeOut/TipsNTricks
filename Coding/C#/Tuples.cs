    /*
    C#: Tuple types, provides concise syntax to group multiple data elements of same/different types in a 
    lightweight data structure to avoid creation of classes or struct.
    Tuples can be used as Parameter & Return types.
    */
    class clsTuple
    {
        private static Employee employee = new Employee()
        {
            EmployeeId = 2,
            EmployeeName = "Jay",
            DateOfJoin = new DateTime(2011, 5, 1),
            DateOfBirth = new DateTime(1988, 5, 6)
        };

        public void ShowEmployee()
        {
            Console.WriteLine(employee.EmployeeName);
            //Tuple Field Names
            (int Age, int ProfessionalExperience) derivedInfo = GetDerivedDetails(employee);
            //Access named tuples
            Console.WriteLine("Age: {0} Experience: {1}", derivedInfo.Age, derivedInfo.ProfessionalExperience);
        }

        //Tuple as return type
        private static (int, int) GetDerivedDetails(Employee emp)
        {
            int age = DateTime.Today.Year - emp.DateOfBirth.Year;
            int exp = DateTime.Today.Year - emp.DateOfJoin.Year;
            if (emp.DateOfBirth.Date > DateTime.Today.AddYears(-age)) age--;
            if (emp.DateOfJoin.Date > DateTime.Today.AddYears(-exp)) exp--;
            return (age, exp);
        }
    }

    /*
    clsTuple objTuple = new clsTuple();
    objTuple.ShowEmployee();
    OUTPUT:
    Jay
    Age: 34 Experience: 11 //Differs based on execution date
    */