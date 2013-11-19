--Write a SQL query to find all employees and their address. Use equijoins (conditions in the WHERE clause).


select e.FirstName + ' ' + e.LastName as [Name], a.AddressText as [Address] from Employees e, Addresses a
	where e.AddressID = a.AddressID