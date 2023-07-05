using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    public  class EmployeeDAL
    {
        private MySqlConnection connection;

        public EmployeeDAL(MySqlConnection connection)
        {
            this.connection = connection;
        }

        // TODO: Logic to update the employee's salary using the SP
        public void UpdateEmployeeSalary(int empID, int newSalary, out int oldSalary)
        {
            
            // Declare the output parameter
            var oldSalaryParameter = new MySqlParameter("@oldSalary", MySqlDbType.Int32);
            oldSalaryParameter.Direction = ParameterDirection.Output;

            // SQL command
            using (var command = new MySqlCommand("UpdateEmployeeSalary", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Add parameters
                command.Parameters.AddWithValue("@empID", empID);
                command.Parameters.AddWithValue("@newSalary", newSalary);
                command.Parameters.Add(oldSalaryParameter);

                // Execute the command
                command.ExecuteNonQuery();

                // Get the old salary value from the output parameter
                oldSalary = (int)oldSalaryParameter.Value;
            }
        }

        // TODO: Logic to get the employee by id
        public Employee? GetEmployeeByID(int empID)
        {
            // SQL command
            using (var command = new MySqlCommand("SELECT * FROM employees WHERE empID = @empID", connection))
            {
                command.Parameters.AddWithValue("@empID", empID);

                // Execute the command and read the data
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Instance of the Employee class and get its properties
                        var employee = new Employee();
                        employee.EmpID = reader.GetInt32("empID");
                        employee.Sal = reader.GetInt32("salary");

                        return employee;
                    }
                }
            }

            // If employee is not found
            return null; 
        }

    }
}
