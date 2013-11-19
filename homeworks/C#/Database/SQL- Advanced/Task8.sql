--Write a SQL query to find the number of all employees that have no manager.

select
	COUNT(*) 
	from Employees
where ManagerID IS NULL