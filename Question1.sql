
CREATE PROCEDURE UpdateEmployeeSalary ( 
 IN empID INT, 
 IN newSalary INT,
 OUT oldSalary INT
 ) 
BEGIN 
 -- TODO: Implement the UpdateEmployeeSalary stored procedure 
  DECLARE oldSalaryOutput INT;
  
  SELECT salary INTO oldSalaryOutput FROM employees WHERE employee_id = empID;
  
  UPDATE employees SET salary = newSalary WHERE employee_id = empID;
  
   SET oldSalary = oldSalaryOutput;
END

--exec UpdateEmployeeSalary 2, 100,000