IF OBJECT_ID(N'GameStore.OrderLines') IS NULL
BEGIN
   CREATE TABLE GameStore.OrderLines
   (
	  OrderLineId INT IDENTITY(1,1) NOT NULL,
      OrderId INT FOREIGN KEY REFERENCES GameStore.Orders(OrderId )NOT NULL,
	  GameId INT FOREIGN KEY REFERENCES GameStore.Games(GameId) NOT NULL,
	  Quantity INT CHECK(Quantity >= 0) NOT NULL,
	  UnitPrice DECIMAL(4,2) CHECK(UnitPrice > 0) NOT NULL

	  PRIMARY KEY(OrderId, OrderLineId)
   );
END;