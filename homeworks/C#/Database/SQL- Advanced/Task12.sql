--Write a SQL query to find all employees along with their managers. For employees that do not have manager display the value "(no manager)".


SELECT e.LastName as Employee, CASE WHEN e.ManagerId IS NULL THEN '(no manager)' ELSE m.LastName END as Manager
	from Employees e
	left join Employees m
	on e.ManagerID= m.EmployeeID