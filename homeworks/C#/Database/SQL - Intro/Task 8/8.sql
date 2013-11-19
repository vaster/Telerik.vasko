/*
	Write a SQL query to find the email addresses of each employee (by his first and last name).
	Consider that the mail domain is telerik.com. Emails should look like “John.Doe@telerik.com".
	The produced column should be named "Full Email Addresses".

*/

select FirstName + '.' + LastName + '@telerik.com' as [Full Email Addresses] from Employees