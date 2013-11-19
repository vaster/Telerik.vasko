--Write a SQL query to find the names of all employees whose last name is exactly 5 characters long.
-- Use the built-in LEN(str) function.


select LastName from Employees
	where LEN(LastName) = 5