--Write a SQL query to find the names of all employees whose first name starts with "SA".


select FirstName + ' ' + MiddleName + ' ' + LastName  from Employees
	where FirstName like 'SA%'