--Write a SQL query to find the names of all employees whose last name contains "ei".


select FirstName + ' ' + MiddleName + ' ' + LastName  from Employees
	where LastName like '%ei%'