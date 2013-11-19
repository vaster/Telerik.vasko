--Write a SQL query to find all employees along with their address. Use inner join with ON clause.


select e.FirstName + ' ' + e.LastName as [Name], a.AddressText as [Address] from Employees e
	inner join Addresses a
	on a.AddressID = e.AddressID