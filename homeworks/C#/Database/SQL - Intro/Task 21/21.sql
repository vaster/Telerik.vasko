--Write a SQL query to find all employees, along with their manager and their address. Join the 3 tables: Employees e, Employees m and Addresses a.


select e.FirstName as [Manager], m.FirstName as [Employee], a.AddressText as [Mang. Address]  from Employees e
	join Employees m
	on m.ManagerID = e.EmployeeID
	join Addresses a
	on m.AddressID = a.AddressID