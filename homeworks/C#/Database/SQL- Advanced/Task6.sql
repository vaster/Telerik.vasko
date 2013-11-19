--Write a SQL query to find the number of employees in the "Sales" department.


select 
	COUNT(*) as [Number Of Empl. in Sales Depart.]
	from Employees
where DepartmentID = 
		(select DepartmentID from Departments
			where Name = 'Sales')