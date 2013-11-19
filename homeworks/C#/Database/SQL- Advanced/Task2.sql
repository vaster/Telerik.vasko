--Write a SQL query to find the names and salaries of the employees that have a salary that is up to 10% higher than the minimal salary for the company.


select FirstName + ' ' + LastName from Employees
	where Salary <
		(select (MIN(Salary) * 0.1 + MIN(Salary)) from Employees)