--Write a SQL query to display the town where maximal number of employees work.


select t.Name, COUNT(*) as [Empl. count]
	from Employees e
	join Addresses a
	on e.AddressID = a.AddressID
	join Towns t
	on t.TownID = a.TownID
group by t.Name
having COUNT(*) = 
	(select Max(countt) as [Count] from 
		(select tw.Name, COUNT(*) as countt
		from Employees em
		join Addresses ad
		on em.AddressID = ad.AddressID
		join Towns tw
		on tw.TownID = ad.TownID
		group by tw.Name) t1 -- source stackoverflow
	)