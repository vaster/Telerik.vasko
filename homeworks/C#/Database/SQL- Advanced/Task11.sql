--Write a SQL query to find all managers that have exactly 5 employees. Display their first name and last name.


select FirstName + ' ' + LastName from Employees
	where ManagerID is null