--Write a SQL query to find all departments and the average salary for each of them.

select AVG(Salary) as [AVG Salary], DepartmentID 
	from Employees
Group by DepartmentID
	