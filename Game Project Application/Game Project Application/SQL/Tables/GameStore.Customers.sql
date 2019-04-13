IF OBJECT_ID(N'GameStore.Customers') IS NULL
BEGIN
   CREATE TABLE GameStore.Customers
   (
      CustomerId INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	  FirstName NVARCHAR(20) NOT NULL,
	  LastName NVARCHAR(20) NOT NULL,
	  Email NVARCHAR(64) UNIQUE NOT NULL,
	  Address NVARCHAR(64),
	  City NVARCHAR(64),
	  State NVARCHAR(20)
   );
END;