--Write a SQL query to display the average employee salary by department and job title.


select AVG(Salary) as [Avg. Salary],e.JobTitle, d.Name
  from Employees e
	join Departments d
	on e.DepartmentID = d.DepartmentID
group by e.JobTitle,d.Name