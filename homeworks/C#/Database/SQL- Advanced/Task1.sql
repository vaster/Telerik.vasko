/*
Write a SQL query to find the names and salaries of the employees that take the minimal salary in the company.
Use a nested SELECT statement.
*/

select FirstName + ' ' + LastName from Employees
	where Salary = 
		(select MIN(Salary) from Employees)