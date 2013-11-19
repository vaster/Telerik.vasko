--Write a SQL query to find the count of all employees in each department and for each town.



/* In  Each departament */
select 
	COUNT(*) as [Employees Count],
	DepartmentID
	from Employees
group by DepartmentID


/* In Each Town */
select 
	COUNT(*) as [Employess Count],
	 t.TownID
	from Employees e
	join Addresses a
	on e.AddressID = a.AddressID
	join Towns t
	on t.TownID = a.TownID
group by t.TownID