--Write a SQL query to find the average salary in the department #1.


select 
	AVG(Salary) as [Avg. Salary In Depart. 1]
		from Employees
	where DepartmentID = 1