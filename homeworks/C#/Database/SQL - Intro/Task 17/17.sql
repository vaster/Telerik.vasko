--Write a SQL query to find the top 5 best paid employees.


select top 5 FirstName from Employees
	order by Salary