IF OBJECT_ID(N'GameStore.Orders') IS NULL
BEGIN
   CREATE TABLE GameStore.Orders
   (
      OrderId INT NOT NULL IDENTITY(1,1) PRIMARY KEY 
   );
END;

