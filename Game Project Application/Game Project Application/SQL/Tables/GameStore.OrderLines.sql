IF OBJECT_ID(N'GameStore.OrderLines') IS NULL
BEGIN
   CREATE TABLE GameStore.OrderLines
   (
      OrderId INT NOT NULL,
	  GameId INT NOT NULL,
	  Quantity INT NOT NULL,
	  UnitPrice DECIMAL(4,2) NOT NULL
   );
END;