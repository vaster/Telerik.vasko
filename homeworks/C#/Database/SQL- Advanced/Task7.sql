--Write a SQL query to find the number of all employees that have manager.


select 
	COUNT(*)
		from Employees
	where ManagerID IS NOT NULL