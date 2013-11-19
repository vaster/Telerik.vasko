--Write a SQL query to display the number of managers from each town.


select COUNT(*), t.Name
from Employees e
join Addresses a
on a.AddressID = e.AddressID
join Towns t
on t.TownID = a.TownID
where e.ManagerID is null
group by t.Name

