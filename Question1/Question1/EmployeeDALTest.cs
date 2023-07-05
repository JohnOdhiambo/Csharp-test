using MySql.Data.MySqlClient;
using NUnit.Framework;
using Question1;

[TestFixture]
public class EmployeeDALTests
{
    private MySqlConnection connection;
    private EmployeeDAL dal;

    [SetUp]
    public void Setup()
    {
        // TODO: Setup code to create a connection to the test database
        // and initialize the data access layer

        //string connectionString = "Server=DESKTOP-PIVUJ82;Database=Latest_Test;user=sa;password=2208;";// Mysql management studio server
        string connectionString = "Server=localhost;Port=3306;Database=employeedb;Uid=root;Pwd=mypassword;";
        connection = new MySqlConnection(connectionString);
        dal = new EmployeeDAL(connection);
        connection.Open();
    }

    [TearDown]
    public void TearDown()
    {
        // TODO: Teardown code to clean up the test database
        connection.Close();
    }

    [Test]
    public void TestUpdateEmployeeSalary()
    {
        // TODO: Write test cases to ensure that the UpdateEmployeeSalary
        // stored procedure is working correctly

        // Prepare test data
        int empID = 1; 
        int newSalary = 5000; 

        // Call the stored procedure and retrieve the old salary value
        int oldSalary = 0;
        dal.UpdateEmployeeSalary(empID, newSalary, out oldSalary);

        // Assert the old salary value is correct (based on your test data)
        Assert.AreEqual(4000, oldSalary);

        // Retrieve the updated employee's record from the database
        Employee employee = dal.GetEmployeeByID(empID);

        // Assert the employee's salary has been updated correctly
        Assert.AreEqual(newSalary, employee.Sal);
    }

}