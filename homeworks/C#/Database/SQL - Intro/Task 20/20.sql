--Write a SQL query to find all employees along with their manager.


select e.FirstName as [Manager], m.FirstName as [Employee] from Employees e
	join Employees m
	on e.EmployeeID = m.ManagerID

