--Write SQL statements to insert in the Users table the names of all employees from the Employees table.
-- Combine the first and last names as a full name. 
--For username use the first letter of the first name + the last name (in lowercase).
-- Use the same for the password, and NULL for last login time.


insert into TelerikUsers(UserID,Username,UserPassword,FullName)
	select EmployeeID + 5,
	SUBSTRING(FirstName,1,1) + LastName,
	SUBSTRING(FirstName,1,1) + LastName + 'aa',
	FirstName + ' ' + LastName
from Employees