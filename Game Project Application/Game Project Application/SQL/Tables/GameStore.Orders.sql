IF OBJECT_ID(N'GameStore.Orders') IS NULL
BEGIN
   CREATE TABLE GameStore.Orders
   (
      OrderId INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	  CustomerId INT FOREIGN KEY REFERENCES GameStore.Customers(CustomerId) NOT NULL,
	  DatePlaced DATETIMEOFFSET NOT NULL
   );
END;

