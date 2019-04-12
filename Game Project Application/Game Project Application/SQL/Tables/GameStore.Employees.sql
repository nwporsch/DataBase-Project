IF OBJECT_ID(N'GameStore.Employees') IS NULL
BEGIN
   CREATE TABLE GameStore.Employees
   (
      EmployeeId INT IDENTITY(1,1) NOT NULL,
	  StoreId INT NOT NULL,
	  FirstName NVARCHAR(20) NOT NULL,
	  LastName NVARCHAR(20) NOT NULL,
   );
END;