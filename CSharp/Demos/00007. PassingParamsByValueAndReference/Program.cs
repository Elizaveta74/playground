// This lesson demonstrates passing function/method parameters by value and reference.

using DataObjects;

namespace PassingParamsByValueAndReference
{
    internal class Program
    {
        static Employee employee = new("John Doe");

        static void Main(string[] args)
        {
            int someIntValue = 12345;

            Console.WriteLine("Let's see how passing by value and by reference works for a primitive type");
            Console.WriteLine($"Actual value for int variable is: {someIntValue}");
            Console.WriteLine("Passing this int variable by value to a function, that changes the parameter value");
            ProcessNumberByValue(someIntValue);
            Console.WriteLine($"After calling the method, the variable did not change and contains the same value: {someIntValue}");
            Console.WriteLine();

            Console.WriteLine("------- Now. let's pass the same variable by reference -------");
            Console.WriteLine($"Variable value before: {someIntValue}");
            ProcessNumberByReference(ref someIntValue);
            Console.WriteLine($"Variable changed its value, and function after call equals to: {someIntValue}");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("----------------------------------------------------------------------------------------");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Now, let's see how passing by value and by reference works for an object type");
            Console.WriteLine($"Value of FullName property of Employee class instance is: {employee.FullName}");
            Console.WriteLine("Calling ProcessEmployeeByValue(employee)");

            Employee actualReferenceToEmployeeObject = employee; // for comparison purposes later

            ProcessEmployeeByValue(employee);

            Console.WriteLine("After calling ProcessEmployeeByValue(employee), comparing the references");
            Console.WriteLine();

            if (actualReferenceToEmployeeObject == employee)
            {
                Console.WriteLine("Reference did not change, as expected");
            }
            else
            {
                Console.WriteLine("It is amazing, but reference did change! Call Anders Hejlsberg NOW!");
            }

            Console.WriteLine();

            Console.WriteLine($"Value of FullName property of Employee class after calling ProcessEmployeeByValue: {employee.FullName}");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Now, let's call ProcessEmployeeByReference()");
            ProcessEmployeeByReference(ref employee);

            Console.WriteLine("After calling ProcessEmployeeByReference(employee), comparing the references");
            Console.WriteLine();

            if (actualReferenceToEmployeeObject == employee)
            {
                Console.WriteLine("No way, references cannot be same! Call Anders Hejlsberg and computer repair team now!");
            }
            else
            {
                Console.WriteLine("As expected, reference has changed");
            }

            Console.WriteLine();

            Console.WriteLine($"Value of FullName property of Employee class after calling ProcessEmployeeByReference: {employee.FullName}");
        }


        static void ProcessNumberByValue(int numberParameter)
        {
            numberParameter = 777;
        }

        static void ProcessNumberByReference(ref int numberParameter)
        {
            numberParameter = 30004000;
        }

        static void ProcessEmployeeByValue(Employee employeeParameter)
        {
            // employeeParameter references the same object as employee,
            // declared on the class level above (line #9).
            // But reference to employeeParameter cannot be changed in this case
            // And while you can't change the reference to the object itself,
            // you can change the internal state of the object by calling
            // its methods and changing its properties.
            // To change reference to the passed object-type parameter, you should use ref keyword
            // as it is done in ProcessEmployeeByReference() method

            Employee anotherEmployee = new("Tom Sawyer");
            employeeParameter = anotherEmployee;
        }

        static void ProcessEmployeeByReference(ref Employee employeeParameter)
        {
            Employee anotherEmployee = new("Bilbo Baggins");
            employeeParameter = anotherEmployee;
        }
    }
}