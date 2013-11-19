--Write a SQL query to find the full name, 
 --salary and department of the employees that take the minimal salary in their department. 
 --Use a nested SELECT statement.


select 
	e.FirstName + ' ' + e.LastName as [Full Name],
	e.Salary as [Salary],
	e.DepartmentID
		from Employees e
where 
	Salary = 
		(select MIN(Salary) from Employees em
			where em.DepartmentID = e.DepartmentID)
	order by DepartmentID