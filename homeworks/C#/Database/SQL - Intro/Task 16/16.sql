--Write a SQL query to find all employees that have salary more than 50000. Order them in decreasing order by salary.


select FirstName as Name, Salary as Salary from Employees
	where Salary > 50000
		order by Salary