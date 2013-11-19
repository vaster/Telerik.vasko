--Write a SQL query to display the minimal employee salary by department and job title along with the name of some of the employees that take it.


select MIN(Salary) as [Min. Salary],e.JobTitle,d.Name, e.LastName
	from Employees e
	join Departments d
	on e.DepartmentID = d.DepartmentID
group by e.JobTitle,d.Name, e.LastName