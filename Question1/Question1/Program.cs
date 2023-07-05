using System;

namespace EmployeeDALTest
{
    public class Program
    {
       public static void Main(string[] args)
        {
            // Run the tests
            EmployeeDALTests employeeDALTests = new EmployeeDALTests();
            employeeDALTests.Setup();
            employeeDALTests.TestUpdateEmployeeSalary();
            employeeDALTests.TearDown();

            Console.WriteLine("Tests have been completed. Press any key to exit.");
            Console.ReadKey();
        }
    }
}



