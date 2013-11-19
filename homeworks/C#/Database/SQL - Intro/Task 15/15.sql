-- Write a SQL query to find all employees that do not have manager.


select FirstName from Employees
	where ManagerID is NULL