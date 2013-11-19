--Write a SQL query to find the average salary  in the "Sales" department.


select 
	AVG(Salary) as [Avg. Salery in Sales Depart.]
		from Employees e
	where e.DepartmentID = 
		(select DepartmentID from Departments
			where Name = 'Sales')
		