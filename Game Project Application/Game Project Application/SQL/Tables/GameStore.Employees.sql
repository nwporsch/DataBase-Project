IF OBJECT_ID(N'GameStore.Employees') IS NULL
BEGIN
   CREATE TABLE GameStore.Employees
   (
      EmployeeId INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	  StoreId INT FOREIGN KEY REFERENCES GameStore.Stores(StoreId) NOT NULL,
	  FirstName NVARCHAR(20) NOT NULL,
	  LastName NVARCHAR(20) NOT NULL,
   );
END;